CREATE TABLE [dbo].[Msgs] (
    [Mid]     INT          IDENTITY (1, 1) NOT NULL,
    [Sid]     INT          NULL,
    [Tid]     INT          NULL,
    [Message] NCHAR (2000) NULL,
    PRIMARY KEY CLUSTERED ([Mid] ASC)
);
CREATE TABLE [dbo].[Scores] (
    [Mid]     INT        IDENTITY (1, 1) NOT NULL,
    [Sid]     INT        NULL,
    [Subject] NCHAR (50) NULL,
    [Score]   INT        NULL,
    PRIMARY KEY CLUSTERED ([Mid] ASC)
);
CREATE TABLE [dbo].[Students] (
    [Sid]      INT        NOT NULL,
    [Name]     NCHAR (20) NULL,
    [Sex]      NCHAR (10) NULL,
    [Class]    NCHAR (20) NULL,
    [Username] NCHAR (20) NULL,
    [Password] NCHAR (20) NULL,
    PRIMARY KEY CLUSTERED ([Sid] ASC)
);
CREATE TABLE [dbo].[Teachers] (
    [Tid]      INT        NOT NULL,
    [Name]     NCHAR (20) NULL,
    [Sex]      NCHAR (10) NULL,
    [Subject]  NCHAR (20) NULL,
    [Username] NCHAR (20) NULL,
    [Password] NCHAR (20) NULL,
    PRIMARY KEY CLUSTERED ([Tid] ASC)
);

SET IDENTITY_INSERT [dbo].[Msgs] ON
INSERT INTO [dbo].[Msgs] ([Mid], [Sid], [Tid], [Message]) VALUES (1, 222000224, 123456, N'再接再厉！                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           ')
INSERT INTO [dbo].[Msgs] ([Mid], [Sid], [Tid], [Message]) VALUES (2, 1, 123456, N'吃得苦中苦,方为人上人。                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    ')
INSERT INTO [dbo].[Msgs] ([Mid], [Sid], [Tid], [Message]) VALUES (3, 2, 123456, N'请劳逸结合。                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          ')
SET IDENTITY_INSERT [dbo].[Msgs] OFF

SET IDENTITY_INSERT [dbo].[Scores] ON
INSERT INTO [dbo].[Scores] ([Mid], [Sid], [Subject], [Score]) VALUES (1, 222000224, N'计算机                                               ', 85)
INSERT INTO [dbo].[Scores] ([Mid], [Sid], [Subject], [Score]) VALUES (2, 1, N'高等数学                                              ', 60)
INSERT INTO [dbo].[Scores] ([Mid], [Sid], [Subject], [Score]) VALUES (3, 2, N'高等数学                                              ', 59)
INSERT INTO [dbo].[Scores] ([Mid], [Sid], [Subject], [Score]) VALUES (4, 222000224, N'高等数学                                              ', 70)
INSERT INTO [dbo].[Scores] ([Mid], [Sid], [Subject], [Score]) VALUES (5, 1, N'计算机                                               ', 70)
INSERT INTO [dbo].[Scores] ([Mid], [Sid], [Subject], [Score]) VALUES (6, 2, N'计算机                                               ', 75)
SET IDENTITY_INSERT [dbo].[Scores] OFF

INSERT INTO [dbo].[Students] ([Sid], [Name], [Sex], [Class], [Username], [Password]) VALUES (1, N'李四                  ', N'男         ', N'1                   ', N'1                   ', N'1                   ')
INSERT INTO [dbo].[Students] ([Sid], [Name], [Sex], [Class], [Username], [Password]) VALUES (2, N'王五                  ', N'女         ', N'计算机1班               ', NULL, NULL)
INSERT INTO [dbo].[Students] ([Sid], [Name], [Sex], [Class], [Username], [Password]) VALUES (222000224, N'赵翊琛                 ', N'男         ', N'软件工程哦班              ', N'std                 ', N'std                 ')

INSERT INTO [dbo].[Teachers] ([Tid], [Name], [Sex], [Subject], [Username], [Password]) VALUES (123456, N'张三                  ', N'男         ', N'计算机                 ', N'admin               ', N'admin               ')
