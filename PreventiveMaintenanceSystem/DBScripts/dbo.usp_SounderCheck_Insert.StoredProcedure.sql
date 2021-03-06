USE [kmc_PMS]
GO
/****** Object:  StoredProcedure [dbo].[usp_SounderCheck_Insert]    Script Date: 6/11/2020 1:22:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Jezreel Pilapil
-- Create date: 6/5/2020
-- Description:	Insert new sounder check record
-- =============================================

CREATE PROCEDURE [dbo].[usp_SounderCheck_Insert]
	@Level nvarchar(50) = null,
	@Tower nvarchar(50) = null,
	@MCP1 bit = null,
	@MCP2 bit = null,
	@Sounder1 bit = null,
	@Sounder2 bit = null,
	@Remarks nvarchar(250) = null,
	@InspectionDate datetime = null,
	@Inspector nvarchar(50) = null
AS
BEGIN
	SET NOCOUNT ON;
	
	INSERT INTO SounderCheck (Level, Tower, MCP1, MCP2, Sounder1, Sounder2, Remarks, InspectionDate, Inspector)
	VALUES (@Level, @Tower, @MCP1, @MCP2, @Sounder1, @Sounder2, @Remarks, @InspectionDate, @Inspector)

	SELECT @@IDENTITY
		
END
GO
