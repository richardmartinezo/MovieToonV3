USE [OEA]
GO

/****** Object: Table [dbo].[Customer] Script Date: 2021-10-14 1:19:24 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Customer] (
    [Id]         INT            IDENTITY (1, 1) NOT NULL,
    [UID]        NVARCHAR (MAX) NULL,
    [Name]       NVARCHAR (MAX) NULL,
    [Age]        NVARCHAR (MAX) NULL,
    [Telephone]  NVARCHAR (50)  NULL,
    [Email]      NVARCHAR (MAX) NULL,
    [Membership] NVARCHAR (MAX) NULL
);

SET IDENTITY_INSERT [dbo].[Customer] ON
INSERT INTO [dbo].[Customer] ([Id], [UID], [Name], [Age], [Telephone], [Email], [Membership]) VALUES (2, N'00000002', N'Customer2', N'25', N'022223555', N'email2@email2.com', N'Yearly')
INSERT INTO [dbo].[Customer] ([Id], [UID], [Name], [Age], [Telephone], [Email], [Membership]) VALUES (3, N'00000003', N'Customer3', N'36', N'9958788845', N'email3@email3.com', N'Quarterly')
INSERT INTO [dbo].[Customer] ([Id], [UID], [Name], [Age], [Telephone], [Email], [Membership]) VALUES (1002, N'115445', N'Richard', N'99', N'+59322340800', N'riddick.rules@gmail.com', N'Pay to go')
SET IDENTITY_INSERT [dbo].[Customer] OFF


CREATE TABLE [dbo].[Membership] (
    [Id]       INT            IDENTITY (1, 1) NOT NULL,
    [Type]     NVARCHAR (MAX) NULL,
    [Discount] INT            NULL
);


SET IDENTITY_INSERT [dbo].[Membership] ON
INSERT INTO [dbo].[Membership] ([Id], [Type], [Discount]) VALUES (1, N'Pay as you go', 0)
INSERT INTO [dbo].[Membership] ([Id], [Type], [Discount]) VALUES (2, N'Monthly', 10)
INSERT INTO [dbo].[Membership] ([Id], [Type], [Discount]) VALUES (3, N'Quarterly', 20)
INSERT INTO [dbo].[Membership] ([Id], [Type], [Discount]) VALUES (4, N'Yearly', 50)
SET IDENTITY_INSERT [dbo].[Membership] OFF


CREATE TABLE [dbo].[Movie] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (MAX) NULL,
    [Description] NVARCHAR (MAX) NULL,
    [RentPrice]   FLOAT (53)     NULL
);

SET IDENTITY_INSERT [dbo].[Movie] ON
INSERT INTO [dbo].[Movie] ([Id], [Name], [Description], [RentPrice]) VALUES (1, N'Rambo', N'War Movie', 5)
INSERT INTO [dbo].[Movie] ([Id], [Name], [Description], [RentPrice]) VALUES (2, N'Home Alone', N'Christmas Movie', 5)
INSERT INTO [dbo].[Movie] ([Id], [Name], [Description], [RentPrice]) VALUES (3, N'Avengers', N'Superheroe Movie', 10)
INSERT INTO [dbo].[Movie] ([Id], [Name], [Description], [RentPrice]) VALUES (4, N'Shang Chi', N'Superheroe Movie', 20)
INSERT INTO [dbo].[Movie] ([Id], [Name], [Description], [RentPrice]) VALUES (5, N'Casablanca', N'Classic Movie', 6)
SET IDENTITY_INSERT [dbo].[Movie] OFF

CREATE TABLE [dbo].[Rentals] (
    [Id]                        BIGINT         IDENTITY (1, 1) NOT NULL,
    [Movie]                     NVARCHAR (MAX) NULL,
    [Membership]                NVARCHAR (MAX) NULL,
    [PriceToPayWithoutDiscount] FLOAT (53)     NULL,
    [PriceToPayWithDiscount]    FLOAT (53)     NULL,
    [PayMethod]                 NVARCHAR (MAX) NULL,
    [Customer]                  NVARCHAR (MAX) NULL
);

SET IDENTITY_INSERT [dbo].[Rentals] ON
INSERT INTO [dbo].[Rentals] ([Id], [Movie], [Membership], [PriceToPayWithoutDiscount], [PriceToPayWithDiscount], [PayMethod], [Customer]) VALUES (1, N'Casablanca', N'Monthly', 6, 5.4, N'Cash', N'Customer2')
INSERT INTO [dbo].[Rentals] ([Id], [Movie], [Membership], [PriceToPayWithoutDiscount], [PriceToPayWithDiscount], [PayMethod], [Customer]) VALUES (2, N'Shang Chi', N'Yearly', 20, 10, N'CreditCard', N'Customer3')
SET IDENTITY_INSERT [dbo].[Rentals] OFF


CREATE TABLE [dbo].[User] (
    [Id]       INT            IDENTITY (1, 1) NOT NULL,
    [Username] NVARCHAR (MAX) NULL,
    [Password] NVARCHAR (MAX) NULL,
    [Role]     NVARCHAR (MAX) NULL
);

SET IDENTITY_INSERT [dbo].[User] ON
INSERT INTO [dbo].[User] ([Id], [Username], [Password], [Role]) VALUES (1, N'Admin1', N'Admin1', N'Administrator')
INSERT INTO [dbo].[User] ([Id], [Username], [Password], [Role]) VALUES (2, N'Employee1', N'Employee1', N'Employee')
SET IDENTITY_INSERT [dbo].[User] OFF


