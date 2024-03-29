USE [kmc_PMS]
GO
/****** Object:  StoredProcedure [dbo].[usp_PanelCheck_GetAll]    Script Date: 6/11/2020 1:22:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Jezreel Pilapil
-- Create date: 6/4/2020
-- Description:	Get all panel check
-- =============================================
CREATE PROCEDURE [dbo].[usp_PanelCheck_GetAll]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	SELECT ID, Number, Tower, SounderOutput, BatteryConnector, BatteryVoltage, InspectionDate, Inspector
FROM     PanelCheck

END
GO
