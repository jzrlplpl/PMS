USE [kmc_PMS]
GO
/****** Object:  StoredProcedure [dbo].[usp_PanelCheck_Update]    Script Date: 6/11/2020 1:22:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		Jezreel Pilapil
-- Create date: 6/4/2020
-- Description:	Update panelcheck
-- =============================================
CREATE PROCEDURE [dbo].[usp_PanelCheck_Update]
	@ID int = 0,
	@Number nvarchar(50) = null,
	@Tower nvarchar(50) = null,
	@SounderOutput bit = null,
	@BatteryConnector bit = null,
	@BatteryVoltage decimal(19,2) = null,
	@InspectionDate datetime = null,
	@Inspector nvarchar(50) = null

AS
BEGIN
	SET NOCOUNT ON;

	UPDATE PanelCheck SET
		Number = ISNULL(@Number, Number),
		Tower = ISNULL(@Tower, Tower),
		SounderOutput = ISNULL(@SounderOutput, SounderOutput),
		BatteryConnector = ISNULL(@BatteryConnector, BatteryConnector),
		BatteryVoltage = ISNULL (@BatteryVoltage, BatteryVoltage),
		InspectionDate = ISNULL (@InspectionDate, InspectionDate),
		Inspector = ISNULL(@Inspector, Inspector)
	WHERE ID = @ID

END
GO
