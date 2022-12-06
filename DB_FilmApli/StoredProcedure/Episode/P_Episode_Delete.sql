CREATE PROCEDURE [dbo].[P_Episode_Delete]
	@Id_Episode INT
AS
BEGIN
	DELETE FROM Episode
	WHERE Id_Episode = @Id_Episode
END