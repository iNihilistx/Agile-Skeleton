CREATE TABLE [dbo].[Staff] (
    [StaffID]    INT           NOT NULL,
    [StaffName]  VARCHAR (255) NOT NULL,
    [DOB]        DATE          NOT NULL,
    [Department] VARCHAR (255) NOT NULL,
    [Gender]     VARCHAR (10)  NOT NULL,
    [StaffRole]  TEXT          NULL,
	AvailableStaff BOOLEAN NOT NULL
    PRIMARY KEY CLUSTERED ([StaffID] ASC)
);

