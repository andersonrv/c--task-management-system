DROP TABLE IF EXISTS [TTasks]
GO
DROP TABLE IF EXISTS [TStatus]
GO
DROP TABLE IF EXISTS [TLists]
GO
DROP TABLE IF EXISTS [TBoardAccess]
GO
DROP TABLE IF EXISTS [TBoards]
GO
DROP TABLE IF EXISTS [TUsers]
GO

CREATE TABLE [TUsers] (
  [UserId] int IDENTITY(100, 1),
  [UserName] nvarchar(80) UNIQUE,
  [Pass] nvarchar(12),
  PRIMARY KEY ([UserId])
);

CREATE TABLE [TBoards] (
  [BoardId] int IDENTITY(1, 1),
  [BoardName] nvarchar(80),
  [UserId] int FOREIGN KEY REFERENCES [TUsers]([UserId]),
  PRIMARY KEY ([BoardId])
);

CREATE TABLE [TBoardAccess] (
  [AccessId] int IDENTITY(1, 1),
  [BoardId] int FOREIGN KEY REFERENCES [TBoards]([BoardId]),
  [UserId] int FOREIGN KEY REFERENCES [TUsers]([UserId]),
  [IsUserAdm] bit,
  PRIMARY KEY ([AccessId])
);

CREATE TABLE [TLists] (
  [ListId] int IDENTITY(1,1),
  [ListName] nvarchar(80),
  [BoardId] int FOREIGN KEY REFERENCES [TBoards]([BoardId]),
  PRIMARY KEY ([ListId])
);

CREATE TABLE [TStatus] (
  [StatusId] int IDENTITY(1,1),
  [StatusName] nvarchar(30),
  PRIMARY KEY ([StatusId])
);

CREATE TABLE [TTasks] (
  [TasktId] int IDENTITY(10000, 1),
  [TaskName] nvarchar(80),
  [TaskDescription] nvarchar(2000),
  [TaskDue] datetime2,
  [TaskWho] int	FOREIGN KEY REFERENCES [TBoards]([BoardId]),
  [TaskStatus] int FOREIGN KEY REFERENCES [TStatus]([StatusId]),
  [TaskList] int FOREIGN KEY REFERENCES [TLists]([ListId]),
  PRIMARY KEY ([TasktId])
);

INSERT INTO [TUsers](UserName, Pass) VALUES('anderson', '1234'), ('jl', '1234'), ('parvir', '1234');
INSERT INTO [TStatus]([StatusName]) VALUES('Ongoing'), ('Completed'), ('Obstructed');







