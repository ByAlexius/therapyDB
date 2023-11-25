/** Delete all data from Tables **/

DELETE FROM [dbo].[meetings];
DELETE FROM [dbo].[room_times];
DELETE FROM [dbo].[addresses];
DELETE FROM [dbo].[locations];
DELETE FROM [dbo].[patients];
DELETE FROM [dbo].[rooms];
DELETE FROM [dbo].[therapist_treatments];
DELETE FROM [dbo].[therapists];
DELETE FROM [dbo].[times];
DELETE FROM [dbo].[treatments];

/** Reseed to 0 **/

DECLARE @TableName NVARCHAR(255)
DECLARE @sql NVARCHAR(MAX)
DECLARE table_cursor CURSOR FOR
SELECT t.name
FROM sys.tables t
INNER JOIN sys.columns c ON t.object_id = c.object_id
WHERE c.is_identity = 1

OPEN table_cursor
FETCH NEXT FROM table_cursor INTO @TableName

WHILE @@FETCH_STATUS = 0
BEGIN
    SET @sql = 'DBCC CHECKIDENT(''' + @TableName + ''', RESEED, 0)'
    EXEC sp_executesql @sql

    FETCH NEXT FROM table_cursor INTO @TableName
END

CLOSE table_cursor
DEALLOCATE table_cursor

/** load random data **/

INSERT INTO [dbo].[addresses] ([city], [postal], [street], [nr])
VALUES
    ('New York', '10001', 'Broadway', 123),
    ('Los Angeles', '90001', 'Hollywood Blvd', 456),
    ('Chicago', '60601', 'Michigan Ave', 789);

INSERT INTO [dbo].[locations] ([name], [address_id])
VALUES
    ('New York', '1'),
    ('Los Angeles', '1'),
    ('Chicago', '1');


INSERT INTO [dbo].[patients] ([firstname], [lastname], [phone], [address])
VALUES
    ('Test', 'Tester', '123455', '2'),
    ('Test', 'Tester', '123455', '2'),
    ('Test', 'Tester', '123455', '2');

INSERT INTO [dbo].[rooms] ([location_id], [room])
VALUES
    ('1', '1'),
    ('2', '2'),
    ('3', '3');

INSERT INTO [dbo].[therapists] ([firstname], [lastname], [phone], [email])
VALUES
    ('Therapist', 'Tester1', '1234554', 'tester1@mail.com'),
    ('Therapist', 'Tester2', '1234558', 'tester2@mail.com'),
    ('Therapist', 'Tester3', '1234556', 'tester3@mail.com');

INSERT INTO [dbo].[times] ([time], [date])
VALUES
    ('12:34:56', '2023-11-24'),
    ('22:45:56', '2023-11-28');

INSERT INTO [dbo].[treatments] ([name])
VALUES
    ('Treatment1'),
    ('Treatment2'),
    ('Treatment3');

INSERT INTO [dbo].[therapist_treatments] ([therapist_id], [treatment_id])
VALUES
    ('1', '2'),
    ('3', '1');

INSERT INTO [dbo].[room_times] ([room_id], [time_id])
VALUES
    ('1', '2'),
    ('3', '1');

INSERT INTO [dbo].[meetings] ([patient_id], [room_time_id], [therapist_treatment_id])
VALUES
    ('1', '2', '1'),
    ('2', '1', '2');

/** Delete all data from Tables **/

DELETE FROM [dbo].[meetings];
DELETE FROM [dbo].[room_times];
DELETE FROM [dbo].[addresses];
DELETE FROM [dbo].[locations];
DELETE FROM [dbo].[patients];
DELETE FROM [dbo].[rooms];
DELETE FROM [dbo].[therapist_treatments];
DELETE FROM [dbo].[therapists];
DELETE FROM [dbo].[times];
DELETE FROM [dbo].[treatments];

/** Reseed to 0 **/

DECLARE table_cursor CURSOR FOR
SELECT t.name
FROM sys.tables t
INNER JOIN sys.columns c ON t.object_id = c.object_id
WHERE c.is_identity = 1

OPEN table_cursor
FETCH NEXT FROM table_cursor INTO @TableName

WHILE @@FETCH_STATUS = 0
BEGIN
    SET @sql = 'DBCC CHECKIDENT(''' + @TableName + ''', RESEED, 0)'
    EXEC sp_executesql @sql

    FETCH NEXT FROM table_cursor INTO @TableName
END

CLOSE table_cursor
DEALLOCATE table_cursor