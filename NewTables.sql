CREATE TABLE [User](
IDUser int IDENTITY(1,1) NOT NULL CONSTRAINT PK_User PRIMARY KEY,
FullName nvarchar(100) NOT NULL,
DateOfBirth date NOT NULL,
Age smallint NOT NULL
)
CREATE TABLE Award(
IDAward int IDENTITY(1,1) NOT NULL CONSTRAINT PK_Award PRIMARY KEY,
Title nvarchar(60) NOT NULL,
)
CREATE TABLE awardByUser(
IDUser int NOT NULL,
IDAward int NOT NULL,
)

ALTER TABLE awardByUser ADD
CONSTRAINT FK_awardByUser_IDUser
FOREIGN KEY(IDUser) REFERENCES [User](IDUser)

ALTER TABLE awardByUser ADD
CONSTRAINT FK_awardByUser_IDAward
FOREIGN KEY(IDAward) REFERENCES Award(IDAward)


INSERT into [User]( FullName, DateOfBirth, Age)  
VALUES  ('Davydova Victoria Vyacheslavovna', '2000-04-05', 20), 
('Ivanova Natalia Alexandrovna','2005-05-05', 15),
('Volokhina Julia Alexeevna', '1999-01-12', 21),
('Tselovalnikov Artem Dmitrievich', '1995-08-11', 24),
('Iskalieva Lunara Esbulatovna', '1999-03-05', 21);

INSERT into Award(Title)  
VALUES  ('Apple Design Awards'), 
('Best mobile App Awards'),
('Clio Awards'),
('CNews Awards'),
('Crunchies');

INSERT into awardByUser (IDUser,  IDAward)  
VALUES  (1,  2),
(2, 5),
(3, 1),
(4,  3),
(5, 4);