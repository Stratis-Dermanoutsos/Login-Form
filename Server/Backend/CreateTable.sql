CREATE TABLE [dbo].[Account] (
    [Id]       INT            IDENTITY (1, 1) NOT NULL,
    [Email]    NVARCHAR (320) NOT NULL,
    [Password] NVARCHAR (128) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);