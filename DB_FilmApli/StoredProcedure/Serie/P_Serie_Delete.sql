CREATE PROCEDURE [dbo].[P_Serie_Delete]
	@Id_Serie INT
AS

BEGIN
	DELETE FROM Serie
	WHERE Id_Serie = @Id_Serie
END