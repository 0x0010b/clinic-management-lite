-- SQL Query - Clinic Management Lite v1.5

USE master
GO

-- Creacion de Base de Datos

CREATE DATABASE clinicManagementLite
ON PRIMARY
	(NAME = clinicManagementLite_Dat, FILENAME='C:\Users\Felix Chacaltana\Desktop\ProyClinicManagementLite\database\clinicManagementLite_Dat.mdf', 
 	SIZE  = 5MB, MAXSIZE = 200, FILEGROWTH = 1 )
LOG ON
	(NAME = clinicManagementLite_Log, FILENAME ='C:\Users\Felix Chacaltana\Desktop\ProyClinicManagementLite\database\clinicManagementLite_Log.ldf',
 	SIZE  = 1MB, MAXSIZE = 80, FILEGROWTH= 1MB)
GO

-- Creacion de Tablas

USE clinicManagementLite
GO

-- tb_account
CREATE TABLE tb_account (
	id				INT IDENTITY(1, 1)		NOT NULL,
	username		VARCHAR(8)	 			NOT NULL,
	[password]		VARCHAR(6)   			NOT NULL,
	permission_id   INT			 			NOT NULL,
	employee_id		VARCHAR(8)				NOT NULL,
	created_at		DATE DEFAULT GETDATE()	NOT NULL)
GO

-- tb_permission
CREATE TABLE tb_permission (
	id				INT IDENTITY(1, 1)		NOT NULL,
	[description]	VARCHAR(40)  			NOT NULL,
	created_at		DATE DEFAULT GETDATE()	NOT NULL)
GO

-- tb_person
CREATE TABLE tb_person (
	dni				VARCHAR(8)				NOT NULL,
	[name]			VARCHAR(40) 			NOT NULL,
	lastname		VARCHAR(40) 			NOT NULL,
	phone			VARCHAR(9)  			NOT NULL,
	birthday		DATE					NOT NULL,
	[address]		VARCHAR(80) 			NOT NULL,
	gender			TINYINT					NOT NULL,
	[image]			VARCHAR(255)			NULL,
	is_active		TINYINT	DEFAULT 1		NOT NULL,
	created_at		DATE DEFAULT GETDATE()	NOT NULL)
GO

-- tb_employee
CREATE TABLE tb_employee (
	person_id 		VARCHAR(8)				NOT NULL,
	position_id		INT						NOT NULL,
	area_id			INT						NOT NULL)
GO

-- tb_client
CREATE TABLE tb_client (
	person_id 		VARCHAR(8) 				NOT NULL,
	wheight			VARCHAR(10)  			NULL,
	height			VARCHAR(20)  			NULL,
	blood_type		VARCHAR(20)  			NULL,
	blood_pressure  VARCHAR(20)  			NULL,
	allergies		VARCHAR(140) 			NULL,
	pathologies		VARCHAR(140) 			NULL,
	medicines		VARCHAR(140) 			NULL,
	seizures		VARCHAR(140) 			NULL,
	diabetes		VARCHAR(140) 			NULL,
	cholesterol		VARCHAR(140) 			NULL,
	cancer			VARCHAR(140) 			NULL,
	aids			VARCHAR(140) 			NULL)
GO

-- tb_position
CREATE TABLE tb_position (
	id				INT IDENTITY(1,1)		NOT NULL,
	[description]	VARCHAR(40) 			NOT NULL,
	created_at		DATE DEFAULT GETDATE()	NOT NULL)
GO

-- tb_area
CREATE TABLE tb_area (
	id				INT IDENTITY(1, 1)		NOT NULL,
	[description]	VARCHAR(40)  			NOT NULL,
	created_at		DATE DEFAULT GETDATE()	NOT NULL)
GO

-- tb_turn
CREATE TABLE tb_turn (
	id				INT IDENTITY(1, 1)		NOT NULL,
	[day]			TINYINT 				NOT NULL,
	entry_hour		TIME 					NOT NULL,
	departure_hour	TIME 					NOT NULL,
	created_at		DATE DEFAULT GETDATE()	NOT NULL)
GO

-- tb_schedule
CREATE TABLE tb_schedule (
	employee_id		VARCHAR(8)				NOT NULL,
	turn_id			INT						NOT NULL)
GO

-- Asignacion de Constraints

-- Unique
ALTER TABLE tb_account ADD UNIQUE (username)
GO

ALTER TABLE tb_permission ADD UNIQUE ([description])
GO

ALTER TABLE tb_employee ADD UNIQUE (person_id)
GO

ALTER TABLE tb_client ADD UNIQUE (person_id)
GO

ALTER TABLE tb_position ADD UNIQUE ([description])
GO

ALTER TABLE tb_area ADD UNIQUE ([description])
GO

-- Primary Key
ALTER TABLE tb_account ADD CONSTRAINT pk_user PRIMARY KEY (id)
GO

ALTER TABLE tb_permission ADD CONSTRAINT pk_permission PRIMARY KEY (id)
GO

ALTER TABLE tb_person ADD CONSTRAINT pk_person PRIMARY KEY (dni)
GO
 
ALTER TABLE tb_position ADD CONSTRAINT pk_position PRIMARY KEY (id)
GO
 
ALTER TABLE tb_area ADD CONSTRAINT pk_area PRIMARY KEY (id)
GO
 
ALTER TABLE tb_turn ADD CONSTRAINT pk_turn PRIMARY KEY (id)
GO
	
-- Foreign Key

-- tb_account
ALTER TABLE tb_account ADD FOREIGN KEY (permission_id) REFERENCES tb_permission
GO

ALTER TABLE tb_account ADD FOREIGN KEY (employee_id) REFERENCES tb_employee(person_id)
GO

-- tb_employee
ALTER TABLE tb_employee ADD FOREIGN KEY (person_id) REFERENCES tb_person
GO

ALTER TABLE tb_employee ADD FOREIGN KEY (position_id) REFERENCES tb_position
GO

ALTER TABLE tb_employee ADD FOREIGN KEY (area_id) REFERENCES tb_area
GO

-- tb_client
ALTER TABLE tb_client ADD FOREIGN KEY (person_id)	REFERENCES tb_person
GO

-- tb_schedule
ALTER TABLE tb_schedule ADD FOREIGN KEY (employee_id) REFERENCES tb_employee(person_id)
GO

ALTER TABLE tb_schedule ADD FOREIGN KEY (turn_id) REFERENCES tb_turn
GO

-- Views

-- vw_accountGetAll
CREATE VIEW vw_accountGetAll
AS 
	SELECT
		tb_account.id				AS [account_id],
		tb_account.username			AS [account_username],
		tb_account.[password]		AS [account_password],
		tb_account.created_at		AS [account_created_at],
		tb_account.employee_id		AS [employee_id],
		tb_permission.id			AS [permission_id],
		tb_permission.[description]	AS [permission_description]
	FROM tb_account
	INNER JOIN tb_permission ON tb_account.permission_id = tb_permission.id
GO

-- vw_permissionGetAll
CREATE VIEW vw_permissionGetAll
AS 
	SELECT
		tb_permission.id			AS [permission_id],
		tb_permission.[description]	AS [permission_description],
		tb_permission.created_at	AS [permission_created_at]
	FROM tb_permission
GO

-- vw_employeeGetAll
CREATE VIEW vw_employeeGetAll
AS
	SELECT
		tb_person.dni				AS [person_id],
		tb_person.[name]			AS [person_name],
		tb_person.lastname			AS [person_lastname],
		tb_person.phone				AS [person_phone],
		tb_person.birthday			AS [person_birthday],
		tb_person.[address]			AS [person_addres],
		tb_person.gender			AS [person_gender],
		tb_person.[image]			AS [person_image],
		tb_person.created_at		AS [person_created_at],
		tb_position.id				AS [position_id],
		tb_position.[description]	AS [position_description],
		tb_area.id					AS [area_id],
		tb_area.[description]		AS [area_description]
	FROM tb_employee
	INNER JOIN tb_person			ON tb_employee.person_id = tb_person.dni
	INNER JOIN tb_position			ON tb_employee.position_id = tb_position.id
	INNER JOIN tb_area				ON tb_employee.area_id = tb_area.id
	WHERE tb_person.is_active = 1
GO

-- vw_positionGetAll
CREATE VIEW vw_positionGetAll
AS 
	SELECT
		tb_position.id				AS [position_id],
		tb_position.[description]	AS [position_description],
		tb_position.created_at		AS [position_created_at]
	FROM tb_position
GO

-- vw_areaGetAll
CREATE VIEW vw_areaGetAll
AS
	SELECT
		tb_area.id					AS [area_id],
		tb_area.[description]		AS [area_description],
		tb_area.created_at			AS [area_created_at]
	FROM tb_area
GO

-- vw_clientGetAll
CREATE VIEW vw_clientGetAll
AS
	SELECT
		tb_person.dni				AS [person_id],
		tb_person.[name]			AS [person_name],
		tb_person.lastname			AS [person_lastname],
		tb_person.phone				AS [person_phone],
		tb_person.birthday			AS [person_birthday],
		tb_person.[address]			AS [person_addres],
		tb_person.gender			AS [person_gender],
		tb_person.[image]			AS [person_image],
		tb_person.created_at		AS [person_created_at],
		tb_client.aids				AS [client_aids],
		tb_client.allergies			AS [client_allergies],
		tb_client.blood_pressure	AS [client_blood_pressure],
		tb_client.blood_type		AS [client_blood_type],
		tb_client.cancer			AS [client_cancer],
		tb_client.cholesterol		AS [client_cholesterol],
		tb_client.diabetes			AS [client_diabetes],
		tb_client.height			AS [client_height],
		tb_client.medicines			AS [client_medicines],
		tb_client.pathologies		AS [client_pathologies],
		tb_client.seizures			AS [client_seizures],
		tb_client.wheight			AS [client_wheight]
	FROM tb_client
	INNER JOIN tb_person			ON tb_client.person_id = tb_person.dni
	WHERE tb_person.is_active = 1
GO

-- Stored Procedures

-- tb_account

-- usp_accountCreate
CREATE PROCEDURE usp_accountCreate
	@nameVal	VARCHAR(8),
	@passVal	VARCHAR(6),
	@permVal	INT,
	@emplVal	VARCHAR(8)
AS
	INSERT INTO tb_account (username, [password],permission_id, employee_id)
	VALUES (@nameVal, @passVal, @permVal, @emplVal)
GO

-- usp_accountGetAll
CREATE PROCEDURE usp_accountGetAll
	@sort TINYINT = 0
AS
	IF @sort = 0 -- Ordernar por nombre
		BEGIN
			SELECT * FROM vw_accountGetAll ORDER BY vw_accountGetAll.account_username ASC
		END
	ELSE IF @sort = 1 -- Ordenar mas antiguo
		BEGIN
			SELECT * FROM vw_accountGetAll ORDER BY vw_accountGetAll.account_created_at DESC
		END
	ELSE IF @sort = 2 -- Ordenar mas reciente
		BEGIN
			SELECT * FROM vw_accountGetAll ORDER BY vw_accountGetAll.account_created_at ASC
		END
GO

-- usp_accountUpdate
CREATE PROCEDURE usp_accountUpdate
	@idVal		INT,
	@nameVal	VARCHAR(8),
	@passVal	VARCHAR(6),
	@permVal	INT,
	@emplVal	VARCHAR(8)
AS
	UPDATE tb_account SET
		username		= @nameVal,
		[password]		= @passVal,
		permission_id	= @permVal,
		employee_id		= @emplVal
	WHERE id = @idVal
GO

-- usp_accountDelete
CREATE PROCEDURE usp_accountDelete
	@idVal	INT
AS
	DELETE FROM tb_account WHERE id = @idVal
GO

-- usp_accountLogin
CREATE PROCEDURE usp_accountLogin
	@nameVal	VARCHAR(8),
	@passVal	VARCHAR(6)
AS
	SELECT
		tb_account.id				AS [account_id],
		tb_account.username			AS [account_username],
		tb_account.[password]		AS [account_password],
		tb_account.employee_id		AS [employee_id],
		tb_permission.id			AS [permission_id],
		tb_permission.[description]	AS [permission_description]
	FROM tb_account
	INNER JOIN tb_permission ON tb_account.permission_id = tb_permission.id
	WHERE tb_account.username = @nameVal AND tb_account.[password] = @passVal
GO

-- tb_permission

-- usp_permissionCreate
CREATE PROCEDURE usp_permissionCreate
	@descVal	VARCHAR(40)
AS
	INSERT INTO tb_permission ([description])
	VALUES (@descVal)
GO

-- usp_permissionGetAll
CREATE PROCEDURE usp_permissionGetAll
	@sort TINYINT = 0
AS
	IF @sort = 0 -- Ordernar por nombre
		BEGIN
			SELECT * FROM vw_permissionGetAll ORDER BY vw_permissionGetAll.permission_description ASC
		END
	ELSE IF @sort = 1 -- Ordenar mas antiguo
		BEGIN
			SELECT * FROM vw_permissionGetAll ORDER BY vw_permissionGetAll.permission_created_at DESC
		END
	ELSE IF @sort = 2 -- Ordenar mas reciente
		BEGIN
			SELECT * FROM vw_permissionGetAll ORDER BY vw_permissionGetAll.permission_created_at ASC
		END
GO

-- usp_permissionUpdate
CREATE PROCEDURE usp_permissionUpdate
	@idVal		INT,
	@descVal	VARCHAR(40)
AS
	UPDATE tb_permission SET
		[description] = @descVal
	WHERE id = @idVal
GO

-- usp_permissionDelete
CREATE PROCEDURE usp_permissionDelete
	@idVal	INT
AS
	DELETE FROM tb_permission WHERE id = @idVal
GO

-- tb_person

-- usp_personCreate
CREATE PROCEDURE usp_personCreate
	@dniVal		VARCHAR(8),
	@nameVal	VARCHAR(40),
	@lnameVal	VARCHAR(40),
	@phoneVal	VARCHAR(9),
	@birthVal	DATE,
	@addreVal	VARCHAR(80),
	@gendeVal	TINYINT,
	@imgVal		VARCHAR(255)
AS
	DECLARE @existDNI VARCHAR(8) = '';
	SELECT @existDNI = dni FROM tb_person WHERE tb_person.dni = @dniVal;

	IF @existDNI = ''
		BEGIN
			INSERT INTO tb_person (dni, [name], lastname, phone, birthday, [address], gender, [image])
			VALUES (@dniVal, @nameVal, @lnameVal, @phoneVal, @birthVal, @addreVal, @gendeVal, @imgVal)
		END
	ELSE
		BEGIN
			EXEC usp_personUpdate @dniVal, @nameVal, @lnameVal, @phoneVal, @birthVal, @addreVal, @gendeVal, @imgVal
			UPDATE tb_person SET is_active = 1 WHERE dni = @dniVal
		END
GO

-- usp_personUpdate
CREATE PROCEDURE usp_personUpdate
	@dniVal		VARCHAR(8),
	@nameVal	VARCHAR(40),
	@lnameVal	VARCHAR(40),
	@phoneVal	VARCHAR(9),
	@birthVal	DATE,
	@addreVal	VARCHAR(80),
	@gendeVal	TINYINT,
	@imgVal		VARCHAR(255)
AS
	UPDATE tb_person SET
		[name]		= @nameVal,
		lastname	= @lnameVal,
		phone		= @phoneVal,
		birthday	= @birthVal,
		[address]	= @addreVal,
		gender		= @gendeVal,
		[image]		= @imgVal
	WHERE dni = @dniVal
GO

-- usp_personDelete
CREATE PROCEDURE usp_personDelete
	@dniVal		VARCHAR(8)
AS
	UPDATE tb_person SET
		is_active	= 0
	WHERE dni = @dniVal
GO

-- tb_employee

-- usp_employeeCreate
CREATE PROCEDURE usp_employeeCreate
	@dniVal			VARCHAR(8),
	@positionVal	INT,
	@areaVal		INT
AS
	INSERT INTO tb_employee VALUES (@dniVal, @positionVal, @areaVal)
GO

-- usp_employeeGetAll
CREATE PROCEDURE usp_employeeGetAll
	@sort TINYINT = 0
AS
	IF @sort = 0 -- Ordernar por nombre
		BEGIN
			SELECT * FROM vw_employeeGetAll ORDER BY vw_employeeGetAll.person_name ASC
		END
	ELSE IF @sort = 1 -- Ordenar mas antiguo
		BEGIN
			SELECT * FROM vw_employeeGetAll ORDER BY vw_employeeGetAll.person_created_at DESC
		END
	ELSE IF @sort = 2 -- Ordenar mas reciente
		BEGIN
			SELECT * FROM vw_employeeGetAll ORDER BY vw_employeeGetAll.person_created_at ASC
		END
GO

-- usp_employeeUpdate
CREATE PROCEDURE usp_employeeUpdate
	@dniVal			VARCHAR(8),
	@positionVal	INT,
	@areaVal		INT
AS
	UPDATE tb_employee SET
		position_id	= @positionVal,
		area_id		= @areaVal
	WHERE person_id = @dniVal
GO

-- tb_position

-- usp_positionCreate
CREATE PROCEDURE usp_positionCreate
	@descVal	VARCHAR(40)
AS
	INSERT INTO tb_position ([description])
	VALUES (@descVal)
GO

-- usp_positionGetAll
CREATE PROCEDURE usp_positionGetAll
	@sort TINYINT = 0
AS
	IF @sort = 0 -- Ordernar por nombre
		BEGIN
			SELECT * FROM vw_positionGetAll ORDER BY vw_positionGetAll.position_description ASC
		END
	ELSE IF @sort = 1 -- Ordenar mas antiguo
		BEGIN
			SELECT * FROM vw_positionGetAll ORDER BY vw_positionGetAll.position_created_at DESC
		END
	ELSE IF @sort = 2 -- Ordenar mas reciente
		BEGIN
			SELECT * FROM vw_positionGetAll ORDER BY vw_positionGetAll.position_created_at ASC
		END
GO

-- usp_positionUpdate
CREATE PROCEDURE usp_positionUpdate
	@idVal		INT,
	@descVal	VARCHAR(40)
AS
	UPDATE tb_position SET
		[description] = @descVal
	WHERE id = @idVal
GO

-- usp_positionDelete
CREATE PROCEDURE usp_positionDelete
	@idVal	INT
AS
	DELETE FROM tb_position WHERE id = @idVal
GO

-- tb_area

-- usp_areaCreate
CREATE PROCEDURE usp_areaCreate
	@descVal	VARCHAR(40)
AS
	INSERT INTO tb_area ([description])
	VALUES (@descVal)
GO

-- usp_areaGetAll
CREATE PROCEDURE usp_areaGetAll
	@sort TINYINT = 0
AS
	IF @sort = 0 -- Ordernar por nombre
		BEGIN
			SELECT * FROM vw_areaGetAll ORDER BY vw_areaGetAll.area_description ASC
		END
	ELSE IF @sort = 1 -- Ordenar mas antiguo
		BEGIN
			SELECT * FROM vw_areaGetAll ORDER BY vw_areaGetAll.area_created_at DESC
		END
	ELSE IF @sort = 2 -- Ordenar mas reciente
		BEGIN
			SELECT * FROM vw_areaGetAll ORDER BY vw_areaGetAll.area_created_at ASC
		END
GO

-- usp_areaUpdate
CREATE PROCEDURE usp_areaUpdate
	@idVal		INT,
	@descVal	VARCHAR(40)
AS
	UPDATE tb_area SET
		[description] = @descVal
	WHERE id = @idVal
GO

-- usp_areaDelete
CREATE PROCEDURE usp_areaDelete
	@idVal	INT
AS
	DELETE FROM tb_area WHERE id = @idVal
GO