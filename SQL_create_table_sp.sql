USE [VehicleHub]
GO
/****** Object:  Table [dbo].[Manufacturers] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Manufacturers](
  [ID] [int] IDENTITY(1,1) NOT NULL,
  [Name] [nvarchar](250) NOT NULL,
 CONSTRAINT [PK_Manufacturers] PRIMARY KEY CLUSTERED 
(
  [ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Add_Manufacturer]    
    @Name NVARCHAR(250)   
    
      
AS    
    BEGIN    
 DECLARE @Id as BIGINT  
        INSERT  INTO [Manufacturers]    
                (Name
             )    
        VALUES  ( @Name       
             );   
    SET @Id = SCOPE_IDENTITY();   
        SELECT  @Id AS ManufacturerID;    
    END;    
  
 
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Update_Manufacturer] 
  @Id INT,   
    @Name NVARCHAR(250)   
AS    
    BEGIN    

  UPDATE [Manufacturers] SET Name = @Name WHERE ID = @Id 
             
    END;    
  

/****** Object:  Table [dbo].[Categories] ******/

  SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
  [ID] [int] IDENTITY(1,1) NOT NULL,
  [Name] [nvarchar](250) NOT NULL,
  [WeightMin] [int] NOT NULL,
  [WeightMax] [int] NULL,
  [IconPath] [nvarchar](250) NOT NULL
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
  [ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Add_Category]    
    @Name NVARCHAR(250),
	@WeightMin int,
	@WeightMax int = null,
	@IconPath NVARCHAR(250)
AS    
    BEGIN    
 DECLARE @Id as BIGINT  
        INSERT  INTO [Categories]    
                (Name, WeightMin, WeightMax, IconPath 
             )    
        VALUES  ( @Name, @WeightMin, @WeightMax, @IconPath       
             );   
    SET @Id = SCOPE_IDENTITY();   
        SELECT  @Id AS CategoryID;    
    END;      
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Update_Category] 
  @Id INT,   
    @Name NVARCHAR(250),
	@WeightMin int,
	@WeightMax int = null  ,
@IconPath NVARCHAR(250)	
AS    
    BEGIN    

  UPDATE [Categories] SET Name = @Name, WeightMin = @WeightMin, WeightMax=@WeightMax, IconPath=@IconPath WHERE ID = @Id 
             
    END;    


/****** Object:  Table [dbo].[Vehicles] ******/

  SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vehicles](
  [ID] [int] IDENTITY(1,1) NOT NULL,
  [OwnerName] [nvarchar](250) NOT NULL,
  [ManufacturerId] [int] NOT NULL,
  [YearOfManufactue] [int] NULL,
  [WeightInKilo] decimal(10,2) NOT NULL
 CONSTRAINT [PK_Vehicles] PRIMARY KEY CLUSTERED 
(
  [ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Add_Vehicle]    
  @OwnerName nvarchar(250),
  @ManufacturerId int,
  @YearOfManufactue int,
  @WeightInKilo decimal(10,2)
AS    
    BEGIN    
 DECLARE @Id as BIGINT  
        INSERT  INTO [Vehicles]    
                (OwnerName, ManufacturerId, YearOfManufactue, WeightInKilo 
             )    
        VALUES  ( @OwnerName, @ManufacturerId, @YearOfManufactue, @WeightInKilo       
             );   
    SET @Id = SCOPE_IDENTITY();   
        SELECT  @Id AS CategoryID;    
    END;      
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Update_Vehicle] 
  @Id INT,
  @OwnerName nvarchar(250),   
  @ManufacturerId int,
  @YearOfManufactue int,
  @WeightInKilo decimal(10,2)
AS    
    BEGIN    

  UPDATE [Vehicles] SET OwnerName=@OwnerName, ManufacturerId=@ManufacturerId, YearOfManufactue=@YearOfManufactue, WeightInKilo=@WeightInKilo  WHERE ID = @Id 
             
    END;    

 
INSERT  INTO [Vehicles] (OwnerName, ManufacturerId, YearOfManufactue, WeightInKilo)    
		VALUES  ( 'John', 1, 2010,100 ),( 'Andrew', 2, 2019,300 ), ( 'joe', 5, 2015,200 )
		
INSERT  INTO [Categories](Name, WeightMin, WeightMax, IconPath)    
        VALUES  ('Light', 0, 500, '/Image/a.png'), ('Medium', 501, 2500, '/Image/b.png'), ('Heavy', 2501, 9999, '/Image/c.png')     
		
INSERT  INTO [Manufacturers](Name)    
        VALUES  ('Mazda'), ('Mercedes'), ('Honda'), ('Ferrari'), ('Toyota')