CREATE PROCEDURE [dbo].[P_imgApi_Update]
	@Id INT,
	@Id_Film INT,
	@Id_Beta INT
AS
BEGIN
	UPDATE imgApi
	SET Id_Film = @Id_Film,
		Id_Beta = @Id_Beta
	WHERE Id = @Id
END
