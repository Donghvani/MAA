USE [Maa]
GO

/****** Object:  Table [dbo].[mortgage_approval_application]    Script Date: 12/13/2017 8:32:20 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[mortgage_approval_application](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[value_of_home] [money] NOT NULL,
	[loan_amount] [money] NOT NULL,
	[term_of_loan] [smallint] NOT NULL,
	[interest_id] [bigint] NOT NULL,
	[monthly_repayment] [money] NOT NULL,
	[creation_datetime] [datetime] NOT NULL,
 CONSTRAINT [PK_mortgage_approval_application] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[mortgage_approval_application] ADD  CONSTRAINT [DF_mortgage_approval_application_creation_timestamp]  DEFAULT (getutcdate()) FOR [creation_datetime]
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Record Id; Also used as Unique Quote No' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'mortgage_approval_application', @level2type=N'COLUMN',@level2name=N'id'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Value of home' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'mortgage_approval_application', @level2type=N'COLUMN',@level2name=N'value_of_home'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Loan amount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'mortgage_approval_application', @level2type=N'COLUMN',@level2name=N'loan_amount'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Term of loan' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'mortgage_approval_application', @level2type=N'COLUMN',@level2name=N'term_of_loan'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Interest id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'mortgage_approval_application', @level2type=N'COLUMN',@level2name=N'interest_id'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Monthly repayment' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'mortgage_approval_application', @level2type=N'COLUMN',@level2name=N'monthly_repayment'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Quote calculation datetime' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'mortgage_approval_application', @level2type=N'COLUMN',@level2name=N'creation_datetime'
GO


