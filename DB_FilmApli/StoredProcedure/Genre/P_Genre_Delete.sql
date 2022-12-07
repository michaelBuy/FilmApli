CREATE PROCEDURE [dbo].[P_Genre_Delete]
	@Id_Genre INT
AS
BEGIN 
	DELETE FROM Genre
	WHERE Id_Genre = @Id_Genre
END
