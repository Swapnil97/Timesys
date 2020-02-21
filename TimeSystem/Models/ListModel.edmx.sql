
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 12/16/2019 14:25:22
-- Generated from EDMX file: C:\Users\v7112231\source\repos\TimeSystem\Models\ListModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [TimeSys];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Entries'
Create TABLE [dbo].[Entries] (
    [WeekStart] nvarchar(max),
    [Team] nvarchar(max),
    [Shift] nvarchar(max),
    [Name] nvarchar(max),
    [Application] nvarchar(max),
    [TaskType] nvarchar(max),
    [Activity] nvarchar(max),
    [Release] nvarchar(max),
    [Description] nvarchar(max),
    [StartDate] nvarchar(max),
    [HoursSpent] nvarchar(max),
    [Id] int NOT NULL 
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Entries'
ALTER TABLE [dbo].[Entries]
ADD CONSTRAINT [PK_Entries]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------