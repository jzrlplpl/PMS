USE [kmc_PMS]
GO
/****** Object:  StoredProcedure [dbo].[usp_Tower_GetAll]    Script Date: 6/15/2020 2:40:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Jezreel Pilapil
-- Create date: 6/9/2020
-- Description:	Get all towers
-- =============================================
CREATE PROCEDURE [dbo].[usp_Tower_GetAll]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	SELECT ID, Name, IsDeleted FROM Tower WHERE IsDeleted = 0

END
GO
