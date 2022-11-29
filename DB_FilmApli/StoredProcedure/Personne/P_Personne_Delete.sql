CREATE PROCEDURE [dbo].[P_Personne_Delete]
	@Id_Personne INT
AS
BEGIN 
	DELETE FROM Personne
	WHERE Id_Personne = @Id_Personne
END
