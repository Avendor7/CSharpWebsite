
CREATE TABLE [IPAddress] (
    [ID] int NOT NULL IDENTITY,
    [ipv4] varchar(21),
    [ipv6] varchar(45),
	[vm] bit NOT NULL,
	[LXC_container] bit NOT NULL,
	[docker] bit NOT NULL,
	[operating_system] varchar(20) NOT NULL,
	[description] text NOT NULL,
);
GO

INSERT INTO IPAddress values ('192.168.5.143:32400',null,0,1,0,'Ubuntu','Plex Server');
GO

SELECT * FROM [IPAddress];