USE [kmc_PMS]
GO
/****** Object:  StoredProcedure [dbo].[usp_Tower_Insert]    Script Date: 6/15/2020 2:40:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Jezreel Pilapil
-- Create date: 6/14/2020
-- Description:	Insert new tower
-- =============================================

CREATE PROCEDURE [dbo].[usp_Tower_Insert]
	@ID int = 0,
	@Name nvarchar(50) = null,
	@IsDeleted bit = 0
AS
BEGIN
	SET NOCOUNT ON;
	
	INSERT INTO Tower(Name, IsDeleted)
	VALUES (@Name, @IsDeleted)

	SELECT @@IDENTITY
		
END
GO
