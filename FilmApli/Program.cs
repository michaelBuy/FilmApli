
using FilmApli_BLL.Interfaces;
using FilmApli_BLL.Services;

var MyAllowSpecificOrigins = "_MyAllowSubdomainPolicy";

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
        policy =>
        {
            policy.WithOrigins("http://localhost:4200", "https://localhost:4200").AllowAnyHeader().AllowAnyMethod();
        });
});

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IFilmService, Film_Service>();
builder.Services.AddScoped<IPersonneService, Personne_Service>();
builder.Services.AddScoped<ISerieService, Serie_Service>();
builder.Services.AddScoped<IEpisodeService, Episode_Service>();
builder.Services.AddScoped<ISaisonService, Saison_Service>();
builder.Services.AddScoped<IFonctionService, Fonction_Service>();
builder.Services.AddScoped<IGenreService, Genre_Service>();

int[] c = new int[] { };
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(MyAllowSpecificOrigins);

app.UseAuthorization();

app.MapControllers();

app.Run();
