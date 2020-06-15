USE [kmc_PMS]
GO
/****** Object:  StoredProcedure [dbo].[usp_Inspector_GetAll]    Script Date: 6/15/2020 2:40:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Jezreel Pilapil
-- Create date: 6/9/2020
-- Description:	Get all inspectors
-- =============================================
CREATE PROCEDURE [dbo].[usp_Inspector_GetAll]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	SELECT ID, Name, IsDeleted FROM Inspector WHERE IsDeleted = 0

END
GO
