USE [kmc_PMS]
GO
/****** Object:  StoredProcedure [dbo].[usp_Inspector_Insert]    Script Date: 6/15/2020 2:40:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Jezreel Pilapil
-- Create date: 6/14/2020
-- Description:	Insert new inspector
-- =============================================

CREATE PROCEDURE [dbo].[usp_Inspector_Insert]
	@ID int = 0,
	@Name nvarchar(50) = null,
	@IsDeleted bit = 0
AS
BEGIN
	SET NOCOUNT ON;
	
	INSERT INTO Inspector(Name, IsDeleted)
	VALUES (@Name, @IsDeleted)

	SELECT @@IDENTITY
		
END
GO
