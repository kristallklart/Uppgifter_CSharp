
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/21/2017 13:36:48
-- Generated from EDMX file: C:\Users\Kalle\git\Uppgifter_CSharp\Uppgifter_CSharp\Uppgift2_WS\App_Code\Model.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [FriendlyDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_FieldOfProfessionUser]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Users] DROP CONSTRAINT [FK_FieldOfProfessionUser];
GO
IF OBJECT_ID(N'[dbo].[FK_User_Location_Location]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[User_Location_Purpose] DROP CONSTRAINT [FK_User_Location_Location];
GO
IF OBJECT_ID(N'[dbo].[FK_User_Location_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[User_Location_Purpose] DROP CONSTRAINT [FK_User_Location_User];
GO
IF OBJECT_ID(N'[dbo].[FK_User_LocationPurpose]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[User_Location_Purpose] DROP CONSTRAINT [FK_User_LocationPurpose];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FieldOfProfessions]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FieldOfProfessions];
GO
IF OBJECT_ID(N'[dbo].[Locations]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Locations];
GO
IF OBJECT_ID(N'[dbo].[Purposes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Purposes];
GO
IF OBJECT_ID(N'[dbo].[User_Location_Purpose]', 'U') IS NOT NULL
    DROP TABLE [dbo].[User_Location_Purpose];
GO
IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'FieldOfProfessions'
CREATE TABLE [dbo].[FieldOfProfessions] (
    [Industry] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'Locations'
CREATE TABLE [dbo].[Locations] (
    [City] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'Purposes'
CREATE TABLE [dbo].[Purposes] (
    [Purposetype] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'User_Location_Purpose'
CREATE TABLE [dbo].[User_Location_Purpose] (
    [City] nvarchar(50)  NOT NULL,
    [Username] nvarchar(50)  NOT NULL,
    [Purposetype] nvarchar(50)  NOT NULL,
    [FromDate] datetime  NULL,
    [ToDate] datetime  NULL
);
GO

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [Username] nvarchar(50)  NOT NULL,
    [FirstName] nvarchar(50)  NOT NULL,
    [LastName] nvarchar(50)  NOT NULL,
    [Birthdate] datetime  NULL,
    [Picture] varbinary(max)  NULL,
    [Profession] nvarchar(50)  NULL,
    [Password] nvarchar(max)  NOT NULL,
    [About] nvarchar(max)  NULL,
    [FieldOfProfession_Industry] nvarchar(50)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Industry] in table 'FieldOfProfessions'
ALTER TABLE [dbo].[FieldOfProfessions]
ADD CONSTRAINT [PK_FieldOfProfessions]
    PRIMARY KEY CLUSTERED ([Industry] ASC);
GO

-- Creating primary key on [City] in table 'Locations'
ALTER TABLE [dbo].[Locations]
ADD CONSTRAINT [PK_Locations]
    PRIMARY KEY CLUSTERED ([City] ASC);
GO

-- Creating primary key on [Purposetype] in table 'Purposes'
ALTER TABLE [dbo].[Purposes]
ADD CONSTRAINT [PK_Purposes]
    PRIMARY KEY CLUSTERED ([Purposetype] ASC);
GO

-- Creating primary key on [City], [Username], [Purposetype] in table 'User_Location_Purpose'
ALTER TABLE [dbo].[User_Location_Purpose]
ADD CONSTRAINT [PK_User_Location_Purpose]
    PRIMARY KEY CLUSTERED ([City], [Username], [Purposetype] ASC);
GO

-- Creating primary key on [Username] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([Username] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [FieldOfProfession_Industry] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [FK_FieldOfProfessionUser]
    FOREIGN KEY ([FieldOfProfession_Industry])
    REFERENCES [dbo].[FieldOfProfessions]
        ([Industry])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FieldOfProfessionUser'
CREATE INDEX [IX_FK_FieldOfProfessionUser]
ON [dbo].[Users]
    ([FieldOfProfession_Industry]);
GO

-- Creating foreign key on [City] in table 'User_Location_Purpose'
ALTER TABLE [dbo].[User_Location_Purpose]
ADD CONSTRAINT [FK_User_Location_Location]
    FOREIGN KEY ([City])
    REFERENCES [dbo].[Locations]
        ([City])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Purposetype] in table 'User_Location_Purpose'
ALTER TABLE [dbo].[User_Location_Purpose]
ADD CONSTRAINT [FK_User_LocationPurpose]
    FOREIGN KEY ([Purposetype])
    REFERENCES [dbo].[Purposes]
        ([Purposetype])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_User_LocationPurpose'
CREATE INDEX [IX_FK_User_LocationPurpose]
ON [dbo].[User_Location_Purpose]
    ([Purposetype]);
GO

-- Creating foreign key on [Username] in table 'User_Location_Purpose'
ALTER TABLE [dbo].[User_Location_Purpose]
ADD CONSTRAINT [FK_User_Location_User]
    FOREIGN KEY ([Username])
    REFERENCES [dbo].[Users]
        ([Username])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_User_Location_User'
CREATE INDEX [IX_FK_User_Location_User]
ON [dbo].[User_Location_Purpose]
    ([Username]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------