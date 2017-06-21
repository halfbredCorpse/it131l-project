
CREATE SEQUENCE Account_Number_Seq
	AS INT
	START WITH 10000000
	MAXVALUE 99999999
	INCREMENT BY 1
	NO CYCLE;

CREATE SEQUENCE Transac_Number_Seq
	AS INT
	START WITH 100000
	MAXVALUE 999999
	INCREMENT BY 1
	NO CYCLE;


CREATE TABLE Bank_Account(
	Account_Number int PRIMARY KEY NOT NULL,
	First_Name varchar(30),
	Last_Name varchar(30),
	Balance decimal(20,2) NOT NULL,
	PIN varchar(6) NOT NULL
);

CREATE TABLE Transaction_History(
	Transaction_Number int PRIMARY KEY NOT NULL,
	Transaction_Type varchar(40) NOT NULL,
	Amount decimal(20,2) NOT NULL,
	Date_Time datetime NOT NULL,
	Account_Number bigint NOT NULL
);

INSERT INTO Bank_Account VALUES (NEXT VALUE FOR Account_Number_Seq, 'Nath', 'Aguas', 10000.96, '123456');
INSERT INTO Bank_Account VALUES (NEXT VALUE FOR Account_Number_Seq, 'John', 'Doe', 14482.10, '647282');
INSERT INTO Bank_Account VALUES (NEXT VALUE FOR Account_Number_Seq, 'Maria', 'Makiling', 200125.53, '042168');
