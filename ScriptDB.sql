﻿CREATE DATABASE SPENDMANAGEMENT
GO

USE SPENDMANAGEMENT
GO

CREATE TABLE USERACCOUNT
(
	USERNAME VARCHAR(20) PRIMARY KEY,
	PASSWORD VARCHAR(20),
	MONEY INT DEFAULT 0
)
GO

CREATE TABLE CHITIEU
(
	USERNAME VARCHAR(20) NOT NULL,
	TENCT NVARCHAR(50) NOT NULL,
	SOTIEN INT NOT NULL DEFAULT 0,
	NGAYGIO DATE, -- THOI GIAN DIEN RA
	PRIMARY KEY(USERNAME, NGAYGIO)
)
GO

ALTER TABLE CHITIEU ADD CONSTRAINT FK_CHITIEU_USERACCOUNT FOREIGN KEY (USERNAME) REFERENCES USERACCOUNT(USERNAME)
GO

--- Trigger đảm bảo khi có một chi tiêu thêm vào thì số tiền còn dư sẽ được trừ theo số tiền chi tiêu đó
CREATE TRIGGER MONEY_CHITIEU
ON [CHITIEU]
FOR INSERT
AS
	UPDATE [USERACCOUNT]
	SET MONEY = MONEY - (SELECT SUM(SOTIEN) FROM inserted I WHERE I.USERNAME = [USERACCOUNT].USERNAME)
	WHERE [USERACCOUNT].USERNAME IN (SELECT I.USERNAME FROM inserted I)
GO

-- procedure add money to user
CREATE PROCEDURE sp_ADD_MONEY @USERNAME VARCHAR(20), @MONEY INT
AS
	UPDATE [USERACCOUNT]
	SET MONEY = MONEY + @MONEY
	WHERE USERNAME = @USERNAME
GO

-- procedure lấy các chi tiêu theo ngày
CREATE PROCEDURE sp_GET_SPEND @USERNAME VARCHAR(20), @DATE DATE
AS
	SELECT * FROM [CHITIEU] CT WHERE CT.USERNAME = @USERNAME AND YEAR(CT.NGAYGIO) = YEAR(@DATE) AND MONTH(CT.NGAYGIO) = MONTH(@DATE) AND DAY(CT.NGAYGIO) = DAY(@DATE)
GO

-- procedure xóa các chi tiêu theo ngày
CREATE PROCEDURE [dbo].[sp_DELETE_SPEND] @USERNAME VARCHAR(20), @DATE DATE
AS
	DELETE [CHITIEU] WHERE USERNAME = @USERNAME AND YEAR(NGAYGIO) = YEAR(@DATE) AND MONTH(NGAYGIO) = MONTH(@DATE) AND DAY(NGAYGIO) = DAY(@DATE)
GO

-- procedure check login
CREATE PROCEDURE sp_LOGIN @USERNAME VARCHAR(20), @PASSWORD VARCHAR(20)
AS
	SELECT * FROM [USERACCOUNT] UA WHERE UA.USERNAME= @USERNAME AND UA.PASSWORD = @PASSWORD
GO
