GO
CREATE TABLE [dbo].[Ranks]
(
	[rankId] TINYINT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	[rank] NVARCHAR(100) NOT NULL,
	[bonus] MONEY NOT NULL
)
CREATE TABLE [dbo].[Positions]
(
	[positionId] TINYINT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	[position] NVARCHAR(100) NOT NULL,
	[salary] MONEY NOT NULL
)
CREATE TABLE [dbo].[CaseStatus]
(
	[statusId] TINYINT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	[status] NVARCHAR(100) NOT NULL
)
CREATE TABLE [dbo].[Officers]
(
	[officerId] INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	[last_name] NVARCHAR(100) NOT NULL,
	[first_name] NVARCHAR(100) NOT NULL,
	[middle_name] NVARCHAR(100) NOT NULL,
	[rank] TINYINT NOT NULL,
	FOREIGN KEY ([rank]) REFERENCES Ranks (rankId),
	[position] TINYINT NOT NULL,
	FOREIGN KEY (position) REFERENCES Positions (positionId),
	[case] INT NOT NULL,
	[birth_date] DATE NOT NULL,
	[employment_date] DATE NOT NULL,
	[dismissal_date] DATE,
	[salaryFull] MONEY NOT NULL
)
CREATE TABLE [dbo].[Cases]
(
	[caseId] INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	[case] NVARCHAR(100) NOT NULL,
	[article] NVARCHAR(100) NOT NULL,
	[officer] INT NOT NULL,
	[open_date] DATE NOT NULL,
	[status] TINYINT NOT NULL FOREIGN KEY ([status]) REFERENCES CaseStatus (statusId),
	[close_date] DATE
)
CREATE TABLE [dbo].[OfficersCases]
(
	[caseId] INT NOT NULL FOREIGN KEY (caseId) REFERENCES Cases(caseId),
	[officerId] INT NOT NULL FOREIGN KEY (officerId) REFERENCES Officers(officerId),
	primary key(caseId, officerId)
)
CREATE TABLE [dbo].[Suspects]
(
	[suspectId] INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	[last_name] NVARCHAR(100) NOT NULL,
	[first_name] NVARCHAR(100) NOT NULL,
	[middle_name] NVARCHAR(100) NOT NULL,
	[alibi] NVARCHAR(100) NOT NULL,
	[adress] NVARCHAR(100) NOT NULL,
	[birth_date] DATE NOT NULL,
	[arrest_date] DATE,
	[release_date] DATE,
	[work_place] NVARCHAR(100) NOT NULL
)
CREATE TABLE [dbo].[SuspectsCases]
(
	[caseId] INT NOT NULL FOREIGN KEY (caseId) REFERENCES Cases(caseId),
	[suspectId] INT FOREIGN KEY (suspectId) REFERENCES Suspects(suspectId),
	primary key(caseId, suspectId)
)
