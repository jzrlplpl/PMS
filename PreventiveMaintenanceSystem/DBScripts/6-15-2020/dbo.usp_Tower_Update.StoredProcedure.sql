USE [kmc_PMS]
GO
/****** Object:  StoredProcedure [dbo].[usp_Tower_Update]    Script Date: 6/15/2020 2:40:57 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


-- =============================================
-- Author:		Jezreel Pilapil
-- Create date: 6/14/2020
-- Description:	Update tower
-- =============================================
CREATE PROCEDURE [dbo].[usp_Tower_Update]
	@ID int = null,
	@Name nvarchar(50) = null,
	@IsDeleted bit = 0
AS
BEGIN
	SET NOCOUNT ON;

	UPDATE Tower SET
		Name = ISNULL(@Name, Name),
		IsDeleted = ISNULL(@IsDeleted, IsDeleted)
	WHERE ID = @ID

END
GO
