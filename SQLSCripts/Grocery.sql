USE master
GO
IF NOT EXISTS(
    SELECT name 
    FROM sys.databases
    WHERE name = N'BuyWithMe'
)
CREATE DATABASE [BuyWithMe]
GO

USE [BuyWithMe]

IF NOT EXISTS(
    SELECT TABLE_NAME
    FROM INFORMATION_SCHEMA.TABLES
    WHERE TABLE_NAME = N'ShoppingLists')
BEGIN
    CREATE TABLE [dbo].[ShoppingLists]
    (
        uUniqueID UNIQUEIDENTIFIER PRIMARY KEY DEFAULT NEWID(),
        sItemName VARCHAR(40) NOT NULL,
        dItemPrice DECIMAL NOT NULL,
        iItemQuantity INT NOT NULL,
        sAddedBy VARCHAR(30) NOT NULL,
        tAddedDate DATE NOT NULL,
        sUpdatedBy VARCHAR(30)  NULL,
        tUpdatedDate DATE  NULL,
        bDeletedIndicator bit NOT NULL DEFAULT 0
    )
END
GO

IF EXISTS(SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[usp_InsertNewRows]') AND type in(N'P', N'PC'))
    DROP PROCEDURE [dbo].[usp_InsertNewRows]
    PRINT 'DROPPING [dbo].[usp_InsertNewRows]'
GO
CREATE PROCEDURE [dbo].[usp_InsertNewRows]
    @itemName VARCHAR(40),
    @itemPrice DECIMAL,   
    @itemQuantity INT,
    @addedBy VARCHAR(30),
    @addedDate DATE,
    @deletedIndicator bit
AS 
BEGIN
    SET NOCOUNT ON

    DECLARE @sName VARCHAR(40);
    DECLARE @dPrice DECIMAL;
    DECLARE @iQuantity INT;
    DECLARE @sAddedBy VARCHAR(30);
    DECLARE @tAddedDate DATE;
    DECLARE @bDeletedIndicator bit;
    DECLARE @iInserted INT;
    BEGIN TRY
        SET @sName = @itemName
        SET @dPrice = @itemPrice;
        SET @iQuantity = @itemQuantity;
        SET @sAddedBy = @addedBy;
        SET @tAddedDate = @addedDate;

        PRINT 'INSERTING INTO  [dbo].[usp_InsertNewRows]'

        INSERT INTO [dbo].[ShoppingLists]
            (sItemName, dItemPrice, iItemQuantity, sAddedBy, tAddedDate, bDeletedIndicator)
        VALUES( @sName ,@dPrice,@iQuantity,@sAddedBy,@tAddedDate,0) 


        SET @iInserted = @@ROWCOUNT
        PRINT 'Records Inserted'

    END TRY 
    BEGIN CATCH
        PRINT 'Problem inserting rows into table'
    END CATCH

    SELECT @iInserted 
END
GO



IF EXISTS(SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[SelectExistingLists]') AND type in(N'P', N'PC'))
    DROP PROCEDURE [dbo].[SelectExistingLists]
    PRINT 'DROPPING [dbo].[SelectExistingLists]'
GO
CREATE PROCEDURE [dbo].[SelectExistingLists]
AS 
BEGIN
    SET NOCOUNT ON

    SELECT COUNT(uUniqueID) uniqueCount, tAddedDate 
    FROM [dbo].[ShoppingLists]  WITH (NOLOCK)
    GROUP BY tAddedDate
    ORDER BY tAddedDate DESC
END