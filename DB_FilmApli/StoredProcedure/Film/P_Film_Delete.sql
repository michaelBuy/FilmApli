CREATE PROCEDURE [dbo].[P_Film_Delete]
	@Id_Film INT
AS
BEGIN
	DELETE FROM Film
	WHERE Id_Film = @Id_Film
END
