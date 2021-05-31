USE Sandbox.Test;
GO

CREATE SCHEMA HRAppDB
GO

CREATE TABLE [HRAppDB].[Employees] (
	ID int NOT NULL,
	Photo nvarchar(255),
	FirstName nvarchar(255) NOT NULL,
	LastName nvarchar(255) NOT NULL,
	RegistationDate datetime NOT NULL,
	StatusID int NOT NULL,
	LocationID int NOT NULL,
	IsActual bit NOT NULL,
  CONSTRAINT [PK_EMPLOYEES] PRIMARY KEY CLUSTERED
  (
  [ID] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [HRAppDB].[Employees_Skills] (
	ID int NOT NULL,
	EmployeeID int NOT NULL,
	SkillID int NOT NULL,
	LevelSkillID int NOT NULL,
	[Date] datetime NOT NULL,
	IsActual bit NOT NULL,
	UserID int NOT NULL,
  CONSTRAINT [PK_EMPLOYEES_SKILLS] PRIMARY KEY CLUSTERED
  (
  [ID] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [HRAppDB].[Skills] (
	ID int NOT NULL,
	Title nvarchar(255) NOT NULL,
	[Description] nvarchar(255) NOT NULL,
  CONSTRAINT [PK_SKILLS] PRIMARY KEY CLUSTERED
  (
  [ID] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [HRAppDB].[LevelSkills] (
	ID int NOT NULL,
	Title nvarchar(255) NOT NULL,
  CONSTRAINT [PK_LEVELSKILLS] PRIMARY KEY CLUSTERED
  (
  [ID] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [HRAppDB].[Projects] (
	ID int NOT NULL,
	Title nvarchar(255) NOT NULL,
	[Description] nvarchar(255) NOT NULL,
	DirectionID int NOT NULL,
  CONSTRAINT [PK_PROJECTS] PRIMARY KEY CLUSTERED
  (
  [ID] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [HRAppDB].[Requirements] (
	ID int NOT NULL,
	SkillID int NOT NULL,
	LevelSkillID int NOT NULL,
	AmountOfEmployees int NOT NULL,
  CONSTRAINT [PK_REQUIREMENTS] PRIMARY KEY CLUSTERED
  (
  [ID] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [HRAppDB].[Projects_Requirements] (
	ID int NOT NULL,
	ProjectID int NOT NULL,
	RequirementsID int NOT NULL,
	IsActual bit NOT NULL,
  CONSTRAINT [PK_PROJECTS_REQUIREMENTS] PRIMARY KEY CLUSTERED
  (
  [ID] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [HRAppDB].[GeneralInformation] (
	ID int NOT NULL,
	EmployeeID int NOT NULL,
	Sex nvarchar(255) NOT NULL,
	Education nvarchar(255),
	FamilyStatusID int NOT NULL,
	Phone nvarchar(15) NOT NULL UNIQUE,
	Email nvarchar(255) NOT NULL UNIQUE,
	BirthDate datetime NOT NULL,
	Hobby nvarchar(255),
	AmountChildren int,
  CONSTRAINT [PK_GENERALINFORMATION] PRIMARY KEY CLUSTERED
  (
  [ID] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [HRAppDB].[Comments] (
	ID int NOT NULL,
	EmployeeID int NOT NULL,
	Information nvarchar(255) NOT NULL,
	[Date] datetime NOT NULL,
  CONSTRAINT [PK_COMMENTS] PRIMARY KEY CLUSTERED
  (
  [ID] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [HRAppDB].[Positions] (
	ID int NOT NULL,
	Title nvarchar(255) NOT NULL UNIQUE,
	[Description] nvarchar(255) NOT NULL,
  CONSTRAINT [PK_POSITIONS] PRIMARY KEY CLUSTERED
  (
  [ID] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [HRAppDB].[Positions_Employees] (
	ID int NOT NULL,
	EmployeeID int NOT NULL,
	PositionID int NOT NULL,
	HiredDate nvarchar(255) NOT NULL,
	FiredDate nvarchar(255) NOT NULL,
	IsActual bit NOT NULL,
	LevelPosition int NOT NULL,
  CONSTRAINT [PK_POSITIONS_EMPLOYEES] PRIMARY KEY CLUSTERED
  (
  [ID] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [HRAppDB].[Companies] (
	ID int NOT NULL,
	Title nvarchar(255) NOT NULL,
	LocationID int NOT NULL,
	[Description] nvarchar(255) NOT NULL,
	IsActual bit NOT NULL,
  CONSTRAINT [PK_COMPANIES] PRIMARY KEY CLUSTERED
  (
  [ID] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [HRAppDB].[Locations] (
	ID int NOT NULL,
	CityID int NOT NULL,
	Street nvarchar(255) NOT NULL,
	HouseNumber int,
	[Block] nvarchar(255) NOT NULL,
	ApartmentNumber int,
	PostIndex int NOT NULL,
  CONSTRAINT [PK_LOCATIONS] PRIMARY KEY CLUSTERED
  (
  [ID] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [HRAppDB].[Companies_Locations] (
	ID int NOT NULL,
	CompanyID int NOT NULL,
	LocationID int NOT NULL,
	IsActual bit NOT NULL,
  CONSTRAINT [PK_COMPANIES_LOCATIONS] PRIMARY KEY CLUSTERED
  (
  [ID] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [HRAppDB].[Departments] (
	ID int NOT NULL,
	Title nvarchar(255) NOT NULL,
	[Description] nvarchar(255) NOT NULL,
  CONSTRAINT [PK_DEPARTMENTS] PRIMARY KEY CLUSTERED
  (
  [ID] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [HRAppDB].[Companies_Depatments] (
	ID int NOT NULL,
	CompanyID int NOT NULL,
	DepartmentID int NOT NULL,
	IsActual bit NOT NULL,
  CONSTRAINT [PK_COMPANIES_DEPATMENTS] PRIMARY KEY CLUSTERED
  (
  [ID] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [HRAppDB].[Directions] (
	ID int NOT NULL,
	Title nvarchar(255) NOT NULL,
	[Description] nvarchar(255) NOT NULL,
  CONSTRAINT [PK_DIRECTIONS] PRIMARY KEY CLUSTERED
  (
  [ID] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [HRAppDB].[Departments_Projects] (
	ID int NOT NULL,
	ProjectID int NOT NULL,
	DepartmentID int NOT NULL,
	IsActual bit NOT NULL,
  CONSTRAINT [PK_DEPARTMENTS_PROJECTS] PRIMARY KEY CLUSTERED
  (
  [ID] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [HRAppDB].[Employees_Projects] (
	ID int NOT NULL,
	EmployeeID int NOT NULL,
	ProjectID int NOT NULL,
	StartDate nvarchar(255) NOT NULL,
	EndDate nvarchar(255) NOT NULL,
	IsActual bit NOT NULL,
  CONSTRAINT [PK_EMPLOYEES_PROJECTS] PRIMARY KEY CLUSTERED
  (
  [ID] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [HRAppDB].[Departments_Positions] (
	ID int NOT NULL,
	DepartmentID int NOT NULL,
	PositionID int NOT NULL,
	IsActual bit NOT NULL,
  CONSTRAINT [PK_DEPARTMENTS_POSITIONS] PRIMARY KEY CLUSTERED
  (
  [ID] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [HRAppDB].[Countries] (
	ID int NOT NULL,
	[Name] nvarchar(255) NOT NULL,
  CONSTRAINT [PK_COUNTRIES] PRIMARY KEY CLUSTERED
  (
  [ID] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [HRAppDB].[Cities] (
	ID int NOT NULL,
	[Name] nvarchar(255) NOT NULL,
	CountryID int NOT NULL,
  CONSTRAINT [PK_CITIES] PRIMARY KEY CLUSTERED
  (
  [ID] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [HRAppDB].[FamilyStatuses] (
	ID int NOT NULL,
	[Status] nvarchar(30) NOT NULL,
  CONSTRAINT [PK_FAMILYSTATUSES] PRIMARY KEY CLUSTERED
  (
  [ID] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [HRAppDB].[Users] (
	ID int NOT NULL,
	FisrtName nvarchar(255) NOT NULL,
	LastName nvarchar(255) NOT NULL,
	CompanyID int NOT NULL,
	Email nvarchar(255) NOT NULL UNIQUE,
	[Password] nvarchar(255) NOT NULL,
	IsActual bit NOT NULL,
  CONSTRAINT [PK_USERS] PRIMARY KEY CLUSTERED
  (
  [ID] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [HRAppDB].[Histories] (
	ID int NOT NULL,
	[Table] nvarchar(255) NOT NULL,
	CollumnName nvarchar(255) NOT NULL,
	OldValue nvarchar(255),
	NewValue nvarchar(255) NOT NULL,
	UpdatedBy int NOT NULL,
	Updated datetime NOT NULL,
  CONSTRAINT [PK_HISTORIES] PRIMARY KEY CLUSTERED
  (
  [ID] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [HRAppDB].[LevelsPositions] (
	ID int NOT NULL,
	Title nvarchar(255) NOT NULL,
	[Description] nvarchar(255) NOT NULL,
  CONSTRAINT [PK_LEVELSPOSITIONS] PRIMARY KEY CLUSTERED
  (
  [ID] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO
CREATE TABLE [HRAppDB].[Statuses] (
	ID int NOT NULL,
	[Name] nvarchar(255) NOT NULL UNIQUE,
  CONSTRAINT [PK_STATUSES] PRIMARY KEY CLUSTERED
  (
  [ID] ASC
  ) WITH (IGNORE_DUP_KEY = OFF)

)
GO

ALTER TABLE [HRAppDB].[Employees] WITH CHECK ADD CONSTRAINT [Employees_fk0] FOREIGN KEY ([StatusID]) REFERENCES [HRAppDB].[Statuses]([ID])
GO
ALTER TABLE [HRAppDB].[Employees] CHECK CONSTRAINT [Employees_fk0]
GO
ALTER TABLE [HRAppDB].[Employees] WITH CHECK ADD CONSTRAINT [Employees_fk1] FOREIGN KEY ([LocationID]) REFERENCES [HRAppDB].[Locations]([ID])
GO
ALTER TABLE [HRAppDB].[Employees] CHECK CONSTRAINT [Employees_fk1]
GO

ALTER TABLE [HRAppDB].[Employees_Skills] WITH CHECK ADD CONSTRAINT [Employees_Skills_fk0] FOREIGN KEY ([EmployeeID]) REFERENCES [HRAppDB].[Employees]([ID])
GO
ALTER TABLE [HRAppDB].[Employees_Skills] CHECK CONSTRAINT [Employees_Skills_fk0]
GO
ALTER TABLE [HRAppDB].[Employees_Skills] WITH CHECK ADD CONSTRAINT [Employees_Skills_fk1] FOREIGN KEY ([SkillID]) REFERENCES [HRAppDB].[Skills]([ID])
GO
ALTER TABLE [HRAppDB].[Employees_Skills] CHECK CONSTRAINT [Employees_Skills_fk1]
GO
ALTER TABLE [HRAppDB].[Employees_Skills] WITH CHECK ADD CONSTRAINT [Employees_Skills_fk2] FOREIGN KEY ([LevelSkillID]) REFERENCES [HRAppDB].[LevelSkills]([ID])
GO
ALTER TABLE [HRAppDB].[Employees_Skills] CHECK CONSTRAINT [Employees_Skills_fk2]
GO

ALTER TABLE [HRAppDB].[Projects] WITH CHECK ADD CONSTRAINT [Projects_fk0] FOREIGN KEY ([DirectionID]) REFERENCES [HRAppDB].[Directions]([ID])
GO
ALTER TABLE [HRAppDB].[Projects] CHECK CONSTRAINT [Projects_fk0]
GO

ALTER TABLE [HRAppDB].[Requirements] WITH CHECK ADD CONSTRAINT [Requirements_fk0] FOREIGN KEY ([SkillID]) REFERENCES [HRAppDB].[Skills]([ID])
GO
ALTER TABLE [HRAppDB].[Requirements] CHECK CONSTRAINT [Requirements_fk0]
GO
ALTER TABLE [HRAppDB].[Requirements] WITH CHECK ADD CONSTRAINT [Requirements_fk1] FOREIGN KEY ([LevelSkillID]) REFERENCES [HRAppDB].[LevelSkills]([ID])
GO
ALTER TABLE [HRAppDB].[Requirements] CHECK CONSTRAINT [Requirements_fk1]
GO

ALTER TABLE [HRAppDB].[Projects_Requirements] WITH CHECK ADD CONSTRAINT [Projects_Requirements_fk0] FOREIGN KEY ([ProjectID]) REFERENCES [HRAppDB].[Projects]([ID])
GO
ALTER TABLE [HRAppDB].[Projects_Requirements] CHECK CONSTRAINT [Projects_Requirements_fk0]
GO
ALTER TABLE [HRAppDB].[Projects_Requirements] WITH CHECK ADD CONSTRAINT [Projects_Requirements_fk1] FOREIGN KEY ([RequirementsID]) REFERENCES [HRAppDB].[Requirements]([ID])
GO
ALTER TABLE [HRAppDB].[Projects_Requirements] CHECK CONSTRAINT [Projects_Requirements_fk1]
GO

ALTER TABLE [HRAppDB].[GeneralInformation] WITH CHECK ADD CONSTRAINT [GeneralInformation_fk0] FOREIGN KEY ([EmployeeID]) REFERENCES [HRAppDB].[Employees]([ID])
GO
ALTER TABLE [HRAppDB].[GeneralInformation] CHECK CONSTRAINT [GeneralInformation_fk0]
GO
ALTER TABLE [HRAppDB].[GeneralInformation] WITH CHECK ADD CONSTRAINT [GeneralInformation_fk1] FOREIGN KEY ([FamilyStatusID]) REFERENCES [HRAppDB].[FamilyStatuses]([ID])
GO
ALTER TABLE [HRAppDB].[GeneralInformation] CHECK CONSTRAINT [GeneralInformation_fk1]
GO

ALTER TABLE [HRAppDB].[Comments] WITH CHECK ADD CONSTRAINT [Comments_fk0] FOREIGN KEY ([EmployeeID]) REFERENCES [HRAppDB].[Employees]([ID])
GO
ALTER TABLE [HRAppDB].[Comments] CHECK CONSTRAINT [Comments_fk0]
GO

ALTER TABLE [HRAppDB].[Positions_Employees] WITH CHECK ADD CONSTRAINT [Positions_Employees_fk0] FOREIGN KEY ([EmployeeID]) REFERENCES [HRAppDB].[Employees]([ID])
GO
ALTER TABLE [HRAppDB].[Positions_Employees] CHECK CONSTRAINT [Positions_Employees_fk0]
GO
ALTER TABLE [HRAppDB].[Positions_Employees] WITH CHECK ADD CONSTRAINT [Positions_Employees_fk1] FOREIGN KEY ([PositionID]) REFERENCES [HRAppDB].[Positions]([ID])
GO
ALTER TABLE [HRAppDB].[Positions_Employees] CHECK CONSTRAINT [Positions_Employees_fk1]
GO
ALTER TABLE [HRAppDB].[Positions_Employees] WITH CHECK ADD CONSTRAINT [Positions_Employees_fk2] FOREIGN KEY ([LevelPosition]) REFERENCES [HRAppDB].[LevelsPositions]([ID])
GO
ALTER TABLE [HRAppDB].[Positions_Employees] CHECK CONSTRAINT [Positions_Employees_fk2]
GO

ALTER TABLE [HRAppDB].[Locations] WITH CHECK ADD CONSTRAINT [Locations_fk0] FOREIGN KEY ([CityID]) REFERENCES [HRAppDB].[Cities]([ID])
GO
ALTER TABLE [HRAppDB].[Locations] CHECK CONSTRAINT [Locations_fk0]
GO

ALTER TABLE [HRAppDB].[Companies_Locations] WITH CHECK ADD CONSTRAINT [Companies_Locations_fk0] FOREIGN KEY ([CompanyID]) REFERENCES [HRAppDB].[Companies]([ID])
GO
ALTER TABLE [HRAppDB].[Companies_Locations] CHECK CONSTRAINT [Companies_Locations_fk0]
GO
ALTER TABLE [HRAppDB].[Companies_Locations] WITH CHECK ADD CONSTRAINT [Companies_Locations_fk1] FOREIGN KEY ([LocationID]) REFERENCES [HRAppDB].[Locations]([ID])
GO
ALTER TABLE [HRAppDB].[Companies_Locations] CHECK CONSTRAINT [Companies_Locations_fk1]
GO

ALTER TABLE [HRAppDB].[Companies_Depatments] WITH CHECK ADD CONSTRAINT [Companies_Depatments_fk0] FOREIGN KEY ([CompanyID]) REFERENCES [HRAppDB].[Companies]([ID])
GO
ALTER TABLE [HRAppDB].[Companies_Depatments] CHECK CONSTRAINT [Companies_Depatments_fk0]
GO
ALTER TABLE [HRAppDB].[Companies_Depatments] WITH CHECK ADD CONSTRAINT [Companies_Depatments_fk1] FOREIGN KEY ([DepartmentID]) REFERENCES [HRAppDB].[Departments]([ID])
GO
ALTER TABLE [HRAppDB].[Companies_Depatments] CHECK CONSTRAINT [Companies_Depatments_fk1]
GO

ALTER TABLE [HRAppDB].[Departments_Projects] WITH CHECK ADD CONSTRAINT [Departments_Projects_fk0] FOREIGN KEY ([ProjectID]) REFERENCES [HRAppDB].[Projects]([ID])
GO
ALTER TABLE [HRAppDB].[Departments_Projects] CHECK CONSTRAINT [Departments_Projects_fk0]
GO
ALTER TABLE [HRAppDB].[Departments_Projects] WITH CHECK ADD CONSTRAINT [Departments_Projects_fk1] FOREIGN KEY ([DepartmentID]) REFERENCES [HRAppDB].[Departments]([ID])
GO
ALTER TABLE [HRAppDB].[Departments_Projects] CHECK CONSTRAINT [Departments_Projects_fk1]
GO

ALTER TABLE [HRAppDB].[Employees_Projects] WITH CHECK ADD CONSTRAINT [Employees_Projects_fk0] FOREIGN KEY ([EmployeeID]) REFERENCES [HRAppDB].[Employees]([ID])
GO
ALTER TABLE [HRAppDB].[Employees_Projects] CHECK CONSTRAINT [Employees_Projects_fk0]
GO
ALTER TABLE [HRAppDB].[Employees_Projects] WITH CHECK ADD CONSTRAINT [Employees_Projects_fk1] FOREIGN KEY ([ProjectID]) REFERENCES [HRAppDB].[Projects]([ID])
GO
ALTER TABLE [HRAppDB].[Employees_Projects] CHECK CONSTRAINT [Employees_Projects_fk1]
GO

ALTER TABLE [HRAppDB].[Departments_Positions] WITH CHECK ADD CONSTRAINT [Departments_Positions_fk0] FOREIGN KEY ([DepartmentID]) REFERENCES [HRAppDB].[Departments]([ID])
GO
ALTER TABLE [HRAppDB].[Departments_Positions] CHECK CONSTRAINT [Departments_Positions_fk0]
GO
ALTER TABLE [HRAppDB].[Departments_Positions] WITH CHECK ADD CONSTRAINT [Departments_Positions_fk1] FOREIGN KEY ([PositionID]) REFERENCES [HRAppDB].[Positions]([ID])
GO
ALTER TABLE [HRAppDB].[Departments_Positions] CHECK CONSTRAINT [Departments_Positions_fk1]
GO

ALTER TABLE [HRAppDB].[Cities] WITH CHECK ADD CONSTRAINT [Cities_fk0] FOREIGN KEY ([CountryID]) REFERENCES [HRAppDB].[Countries]([ID])
GO
ALTER TABLE [HRAppDB].[Cities] CHECK CONSTRAINT [Cities_fk0]
GO

ALTER TABLE [HRAppDB].[Users] WITH CHECK ADD CONSTRAINT [Users_fk0] FOREIGN KEY ([CompanyID]) REFERENCES [HRAppDB].[Companies]([ID])
GO
ALTER TABLE [HRAppDB].[Users] CHECK CONSTRAINT [Users_fk0]
GO

ALTER TABLE [HRAppDB].[Histories] WITH CHECK ADD CONSTRAINT [Histories_fk0] FOREIGN KEY ([UpdatedBy]) REFERENCES [HRAppDB].[Users]([ID])
GO
ALTER TABLE [HRAppDB].[Histories] CHECK CONSTRAINT [Histories_fk0]
GO