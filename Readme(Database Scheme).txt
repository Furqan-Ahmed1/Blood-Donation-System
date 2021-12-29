CREATE TABLE [dbo].[Admin] (
    [Admin_Id]   INT           IDENTITY (1, 1) NOT NULL,
    [First_Name] NVARCHAR (50) NOT NULL,
    [Last_Name]  NVARCHAR (50) NOT NULL,
    [Email]      NVARCHAR (50) NOT NULL,
    [Password]   NVARCHAR (50) NOT NULL,
    [Phone_no]   NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Admin_Id] ASC)
);


CREATE TABLE [dbo].[Donor] (
    [donor_Id]   INT           IDENTITY (1, 1) NOT NULL,
    [First_Name] NVARCHAR (50) NOT NULL,
    [Last_Name]  NVARCHAR (50) NOT NULL,
    [Email]      NVARCHAR (50) NOT NULL,
    [Password]   NVARCHAR (50) NOT NULL,
    [Gender]     NVARCHAR (50) NOT NULL,
    [Occupation] NVARCHAR (50) NULL,
    [Phone_no]   NVARCHAR (50) NULL,
    [Cnic]       NVARCHAR (50) NULL,
    [Blocked]    INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([donor_Id] ASC),
    UNIQUE NONCLUSTERED ([Cnic] ASC),
    UNIQUE NONCLUSTERED ([Email] ASC)
);


CREATE TABLE [dbo].[Recipient] (
    [recipient_Id] INT           IDENTITY (1, 1) NOT NULL,
    [First_Name]   NVARCHAR (50) NOT NULL,
    [Last_Name]    NVARCHAR (50) NOT NULL,
    [Email]        NVARCHAR (50) NOT NULL,
    [Password]     NVARCHAR (50) NOT NULL,
    [Gender]       NVARCHAR (50) NOT NULL,
    [Occupation]   NVARCHAR (50) NULL,
    [Phone_no]     NVARCHAR (50) NULL,
    [Cnic]         NVARCHAR (50) NULL,
    [Blocked]      INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([recipient_Id] ASC),
    UNIQUE NONCLUSTERED ([Email] ASC),
    UNIQUE NONCLUSTERED ([Cnic] ASC)
);


CREATE TABLE [dbo].[Blocked] (
    [Blocked_id] INT           IDENTITY (1, 1) NOT NULL,
    [Email]      NVARCHAR (50) NOT NULL,
    [Cnic]       NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Blocked_id] ASC)
);


CREATE TABLE [dbo].[MedicalReport] (
    [report_Id]     INT           IDENTITY (1, 1) NOT NULL,
    [Blood_Group]   NVARCHAR (50) NULL,
    [Compatibility] NVARCHAR (50) NULL,
    [donor_id]      INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([report_Id] ASC),
    CONSTRAINT [FK_medical_donor] FOREIGN KEY ([donor_id]) REFERENCES [dbo].[Donor] ([donor_Id])
);

CREATE TABLE [dbo].[History] (
    [donor_id]     INT NOT NULL,
    [recipient_id] INT NULL,
    [quantity]     INT NOT NULL,
    [report_id]    INT NOT NULL,
    CONSTRAINT [FK_history_donor] FOREIGN KEY ([donor_id]) REFERENCES [dbo].[Donor] ([donor_Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_history_recipient] FOREIGN KEY ([recipient_id]) REFERENCES [dbo].[Recipient] ([recipient_Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_history_medical] FOREIGN KEY ([report_id]) REFERENCES [dbo].[MedicalReport] ([report_Id]) ON DELETE CASCADE
);


CREATE TABLE [dbo].[Inventory] (
    [blood_id]  INT IDENTITY (1, 1) NOT NULL,
    [donor_id]  INT NOT NULL,
    [quantity]  INT NULL,
    [report_id] INT NOT NULL,
    CONSTRAINT [PK_Inventory] PRIMARY KEY CLUSTERED ([blood_id] ASC),
    CONSTRAINT [FK_inventory_donor] FOREIGN KEY ([donor_id]) REFERENCES [dbo].[Donor] ([donor_Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_inventory_medical] FOREIGN KEY ([report_id]) REFERENCES [dbo].[MedicalReport] ([report_Id]) ON DELETE CASCADE
);


CREATE TABLE [dbo].[Proff] (
    [recipient_Id]      INT            NOT NULL,
    [Blood_Group]       NVARCHAR (50)  NULL,
    [Quantity_ltr]      INT            NULL,
    [Medical_Report]    NVARCHAR (MAX) NULL,
    [Conclusion_Rating] INT            NULL,
    [Approval]          INT            NULL,
    CONSTRAINT [FK_Proff_Recipient] FOREIGN KEY ([recipient_Id]) REFERENCES [dbo].[Recipient] ([recipient_Id]) ON DELETE CASCADE
);

