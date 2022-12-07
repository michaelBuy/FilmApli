
using FilmApli_BLL.Interfaces;
using FilmApli_BLL.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IFilmService, Film_Service>();
builder.Services.AddScoped<IPersonneService, Personne_Service>();
builder.Services.AddScoped<ISerieService, Serie_Service>();
builder.Services.AddScoped<IEpisodeService, Episode_Service>();

int[] c = new int[] { };
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
