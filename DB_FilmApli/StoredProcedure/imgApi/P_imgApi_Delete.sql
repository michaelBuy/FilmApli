﻿CREATE PROCEDURE [dbo].[P_imgApi_Delete]
	@Id INT
AS
BEGIN
	DELETE FROM imgApi
	WHERE Id = @Id
END
