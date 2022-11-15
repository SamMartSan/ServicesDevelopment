/****** Table [dbo].[Orders] ******/
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Orders]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Orders](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CustomerId] [int] NOT NULL,
	[CretedDate] [datetime] NOT NULL,
	[DeliveryFirstName] [varchar](50) NOT NULL,
	[DeliveryLastName] [varchar](50) NOT NULL,
	[DeliveryAddress] [varchar](255) NOT NULL,
	[DeliveryPhoneNumber] [varchar](50) NOT NULL,
	[Notes] [varchar](255) NULL,
	[TotalOrder] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
