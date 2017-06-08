CREATE DATABASE Project;
USE Project;

--> Still kept just in case. <--

--CREATE SEQUENCE Account_Number_Seq
--	AS INT
--	START WITH 1000000000000000
--	MAXVALUE 9999999999999999
--	INCREMENT BY 1
--	NO CYCLE;

--CREATE SEQUENCE Transac_Number_Seq
--	AS INT
--	START WITH 100000
--	INCREMENT BY 1
--	NO CYCLE;

--CREATE VIEW randomize 
--AS 
--SELECT 10000000 + FLOOR(99999999*RAND(CONVERT(varbinary, NEWID()))) AS acc_id, 
--		100000 + FLOOR(999999*RAND(CONVERT(varbinary, NEWID()))) AS trans_id

--CREATE FUNCTION ReturnRandomId(@choice int)
--RETURNS int
--AS
--BEGIN
--	DECLARE @id_num int
--	DECLARE @random_num int

--	IF @choice = 1 --> Randomize Account Number
--	BEGIN
--		SET @random_num = (select acc_id from randomize)
--		SET @id_num = CONVERT(int, @random_num)

--		IF @id_num / 100000000 != 0
--		BEGIN
--			SET @id_num = dbo.ReturnRandomId(1)
--		END
--	END
	--IF @choice = 2
	--BEGIN
	--	SET @random_num = (select trans_id from randomize) --> Randomize Transaction Number
	--	SET @id_num = CONVERT(int, @random_num)

	--	IF @id_num / 100000!= 0
	--	BEGIN
	--		SET @id_num = dbo.ReturnRandomId(1)
	--	END
	--END

--	RETURN @id_num
--END

CREATE TABLE Bank_Account(
	Account_Number int IDENTITY(10000000,1) PRIMARY KEY NOT NULL,
	Balance decimal(20,2) NOT NULL,
	First_Name varchar(30),
	Last_Name varchar(30),
	PIN varchar(6) NOT NULL
);

CREATE TABLE Transaction_History(
	Transaction_Number int IDENTITY(100000,1) PRIMARY KEY NOT NULL,
	Transaction_Type varchar(25) NOT NULL,
	Amount decimal(20,2) NOT NULL,
	Date_Time datetime NOT NULL,
	Account_Number bigint NOT NULL
);

INSERT INTO Bank_Account VALUES (10000.96, 'Nath', 'Aguas', '123456');
INSERT INTO Bank_Account VALUES (14482.10, 'John', 'Doe', '647282');
INSERT INTO Bank_Account VALUES (200125.53, 'Maria', 'Makiling', '042168');

SELECT * FROM Bank_Account;
SELECT * FROM Transaction_History;

DROP TABLE Bank_Account;
DROP TABLE Transaction_History;
DROP VIEW randomize;
DROP FUNCTION ReturnRandomId;
