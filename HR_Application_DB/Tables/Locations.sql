CREATE TABLE [dbo].[Locations] (
    [ID]              INT            IDENTITY (1, 1) NOT NULL,
    [CityID]          INT            NOT NULL,
    [Street]          NVARCHAR (255) NOT NULL,
    [HouseNumber]     INT            NULL,
    [Block]           NVARCHAR (255) NOT NULL,
    [ApartmentNumber] INT            NULL,
    [PostIndex]       INT            NOT NULL,
    CONSTRAINT [PK_LOCATIONS] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [Locations_fk0] FOREIGN KEY ([CityID]) REFERENCES [dbo].[Cities] ([ID])
);

