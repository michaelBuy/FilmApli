CREATE PROCEDURE [dbo].[P_Saison_Delete]
	@Id_Saison INT
AS
BEGIN
	DELETE FROM Saison
	WHERE Id_Saison = @Id_Saison
END
