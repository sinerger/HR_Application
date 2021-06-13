CREATE TABLE [HRAppDB].[Locations] (
    [ID]              INT            IDENTITY (1, 1) NOT NULL,
    [CityID]          INT            NOT NULL,
    [Street]          NVARCHAR (255) NULL,
    [HouseNumber]     INT            NULL,
    [Block]           NVARCHAR (255) NULL,
    [ApartmentNumber] INT            NULL,
    [PostIndex]       INT            NULL,
    CONSTRAINT [PK_LOCATIONS] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [Locations_fk0] FOREIGN KEY ([CityID]) REFERENCES [HRAppDB].[Cities] ([ID])
);

