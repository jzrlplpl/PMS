USE [kmc_PMS]
GO
/****** Object:  StoredProcedure [dbo].[usp_PanelCheck_Insert]    Script Date: 6/5/2020 11:51:57 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Jezreel Pilapil
-- Create date: 6/4/2020
-- Description:	Insert new panel check record
-- =============================================

CREATE PROCEDURE [dbo].[usp_PanelCheck_Insert]
	@Number int = null,
	@Tower nvarchar(50) = null,
	@SounderOutput bit = null,
	@BatteryConnector bit = null,
	@BatteryVoltage decimal(19,2) = null,
	@InspectionDate datetime = null,
	@Inspector nvarchar(50) = null
AS
BEGIN
	SET NOCOUNT ON;
	
	INSERT INTO PanelCheck (Number, Tower, SounderOutput, BatteryConnector, BatteryVoltage, InspectionDate, Inspector)
	VALUES (@Number, @Tower, @SounderOutput, @BatteryConnector, @BatteryVoltage, @InspectionDate, @Inspector)

	SELECT @@IDENTITY
		
END
GO
