USE [UsersAwards]
GO

CREATE PROCEDURE AddUser
	@FullName nvarchar(100),
	@DateOfBirth date,
	@Age smallint
AS
BEGIN
		INSERT INTO [User](FullName, DateOfBirth, Age)
		VALUES(@FullName, @DateOfBirth, @Age)
END

CREATE PROCEDURE FindUserByID
	@IDUser int
AS
	SELECT FullName, DateOfBirth, Age FROM [User]
	WHERE IDUser = @IDUser
GO

CREATE PROCEDURE FindAwardByID
	@IDAward int
AS
	SELECT Title FROM Award
	WHERE IDAward = @IDAward
GO

CREATE PROCEDURE DeleteUser
	@IDUser int
AS
	DELETE FROM [User]
	WHERE IDUser = @IDUser
GO


CREATE PROCEDURE AddAward
	@Title varchar(255)
AS
BEGIN
		INSERT INTO Award(Title)
		VALUES(@Title)
END


CREATE PROCEDURE DeleteAward
	@IDAward int
AS
	DELETE FROM Award
	WHERE IDAward = @IDAward
GO


CREATE PROCEDURE AddAwardForUser
	@IDUser int,
	@IDAward int
AS
BEGIN
		INSERT INTO awardByUser(IDUser, IDAward)
		VALUES(@IDUser, @IDAward)
END

CREATE PROCEDURE DeleteAwardForUser
	@IDUser int,
	@IDAward int
AS
	DELETE FROM awardByUser
	WHERE IDUser = @IDUser AND IDAward = @IDAward
GO

CREATE PROCEDURE GetAllUsers
AS
BEGIN
		SELECT * FROM [User]
END


CREATE PROCEDURE GetAllAwards
AS
BEGIN
		SELECT * FROM Award
END

CREATE PROCEDURE GetAllUsersWithAwards
AS
BEGIN
		SELECT * FROM awardByUser
END