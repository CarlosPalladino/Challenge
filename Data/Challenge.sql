IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Clients] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(50) NOT NULL,
    [LastName] nvarchar(50) NOT NULL,
    [Email] nvarchar(max) NOT NULL,
    [Cuit] bigint NOT NULL,
    [Dni] bigint NOT NULL,
    [Nacimiento] datetime2 NOT NULL,
    [Phone] int NOT NULL,
    CONSTRAINT [PK_Clients] PRIMARY KEY ([Id])
);
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Cuit', N'Dni', N'Email', N'LastName', N'Nacimiento', N'Name', N'Phone') AND [object_id] = OBJECT_ID(N'[Clients]'))
    SET IDENTITY_INSERT [Clients] ON;
INSERT INTO [Clients] ([Id], [Cuit], [Dni], [Email], [LastName], [Nacimiento], [Name], [Phone])
VALUES (1, CAST(20304050601 AS bigint), CAST(20304050 AS bigint), N'maradona10@argentina.com', N'Maradona', '1960-10-30T00:00:00.0000000', N'Diego', 1140000001),
(2, CAST(20708090101 AS bigint), CAST(40708090 AS bigint), N'messi10@argentina.com', N'Messi', '1987-06-24T00:00:00.0000000', N'Lionel', 1140000002),
(3, CAST(20333333401 AS bigint), CAST(30333333 AS bigint), N'sabatini@argentina.com', N'Sabatini', '1970-05-16T00:00:00.0000000', N'Gabriela', 1140000003),
(4, CAST(20123456701 AS bigint), CAST(10123456 AS bigint), N'papa_francisco@vaticano.com', N'Bergoglio', '1936-12-17T00:00:00.0000000', N'Jorge', 1140000004),
(5, CAST(20567890101 AS bigint), CAST(50678901 AS bigint), N'ginobili20@argentina.com', N'Ginóbili', '1977-07-28T00:00:00.0000000', N'Manuel', 1140000005),
(6, CAST(20122334455 AS bigint), CAST(20122334 AS bigint), N'pergolini@cqc.com', N'Pergolini', '1964-07-03T00:00:00.0000000', N'Mario', 1140000006),
(7, CAST(20111223344 AS bigint), CAST(20111223 AS bigint), N'francella@actor.com', N'Francella', '1955-02-14T00:00:00.0000000', N'Guillermo', 1140000007),
(8, CAST(20444444401 AS bigint), CAST(40444444 AS bigint), N'darin@actor.com', N'Darín', '1957-01-16T00:00:00.0000000', N'Ricardo', 1140000010);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Cuit', N'Dni', N'Email', N'LastName', N'Nacimiento', N'Name', N'Phone') AND [object_id] = OBJECT_ID(N'[Clients]'))
    SET IDENTITY_INSERT [Clients] OFF;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20250109154801_Initial', N'8.0.0');
GO

COMMIT;
GO

