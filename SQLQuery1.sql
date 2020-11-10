CREATE DATABASE EducationSystemBase		
	ON		
		(NAME='DataFile'	
		,FILENAME='D:\EducationSystem\EducationSystemBase\DataFile.mdf')	
	LOG ON		
		(NAME='LogFile'	
		,FILENAME='D:\EducationSystem\EducationSystemBase\LogFile.ldf');	

CREATE TABLE tb_Student	
	(No
		CHAR(10)
		NOT NULL
		CONSTRAINT pk_Student_No
			PRIMARY KEY(No)
		CONSTRAINT ck_Student_No	
			CHECK(No LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')
	,Password
		VARCHAR(20)
		NOT NULL
	);

INSERT dbo.tb_Student
(
    No,
    Password
)
VALUES
(   '3190707011', -- No - char(10)
    '11'  -- Password - varchar(20)
    )

SELECT
	*
	FROM dbo.tb_Student;