CREATE TABLE [Employees] (
	ID int NOT NULL IDENTITY,
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

);
GO
ALTER TABLE [Employees] WITH CHECK ADD CONSTRAINT [Employees_fk0] FOREIGN KEY ([LocationID]) REFERENCES [Locations]([ID])

GO
ALTER TABLE [Employees] CHECK CONSTRAINT [Employees_fk0]
GO
GO
ALTER TABLE [Employees] WITH CHECK ADD CONSTRAINT [Employees_fk1] FOREIGN KEY ([StatusID]) REFERENCES [Statuses]([ID])

GO
ALTER TABLE [Employees] CHECK CONSTRAINT [Employees_fk1]
GO

