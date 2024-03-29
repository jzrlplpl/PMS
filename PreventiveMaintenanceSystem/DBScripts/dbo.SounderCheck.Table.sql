USE [kmc_PMS]
GO
/****** Object:  Table [dbo].[SounderCheck]    Script Date: 6/11/2020 1:22:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SounderCheck](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Level] [nvarchar](50) NULL,
	[Tower] [nvarchar](50) NULL,
	[MCP1] [bit] NULL,
	[MCP2] [bit] NULL,
	[Sounder1] [bit] NULL,
	[Sounder2] [bit] NULL,
	[Remarks] [nvarchar](250) NULL,
	[InspectionDate] [datetime] NULL,
	[Inspector] [nvarchar](50) NULL,
 CONSTRAINT [PK_SounderCheck] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
