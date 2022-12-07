CREATE PROCEDURE [dbo].[P_Fonction_Delete]
	@Id_Fonction INT
AS
BEGIN 
	DELETE FROM Fonction
	WHERE Id_Fonction = @Id_Fonction
END