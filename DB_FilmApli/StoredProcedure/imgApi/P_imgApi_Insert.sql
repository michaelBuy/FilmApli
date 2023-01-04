CREATE PROCEDURE [dbo].[P_imgApi_Insert]
	@Id_Film INT,
	@Id_Beta INT
AS
BEGIN
	INSERT INTO imgApi(Id_Film, Id_Beta)
	VALUES(@Id_Film, @Id_Beta)
END
