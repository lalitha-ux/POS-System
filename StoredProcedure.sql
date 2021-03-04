CREATE PROCEDURE usp_Login_VerifyLoginDetails
(
	@UserName NVARCHAR(50),
	@Password NVARCHAR(50)
)
AS
	BEGIN
		SELECT '*' FROM [dbo].[loginUsers]
		WHERE [UserName] = @UserName
		AND   [Password] = @Password
	END