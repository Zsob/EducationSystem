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

CREATE TABLE tb_Message




SELECT
	*
	FROM dbo.tb_Student;

	SELECT
		*
	FROM dbo.vw_Student
	WHERE Class='19信管'
	ORDER BY BirthDate DESC

UPDATE dbo.tb_StudentInformation
SET Class='19信管'
WHERE StudentID='3190707011'

SELECT
	 Name
	FROM dbo.tb_Major

UPDATE dbo.tb_StudentInformation
SET Class='信息管理与信息系统'
WHERE StudentID='3190707011'

SELECT
	*
	FROM dbo.tb_StudentLogIn
SELECT
	1
	FROM dbo.tb_StudentLogIn
	WHERE No='3190707011'AND Password='11'

UPDATE dbo.tb_StudentLogIn
SET Password='11'
WHERE No='3190707011'

SELECT
	*
	FROM dbo.tb_Announcement

SELECT
		*
		FROM dbo.tb_Message

UPDATE dbo.tb_Announcement
SET AnnouncementID='A002'
WHERE AnnouncementTitle='计算机二级通知'

UPDATE dbo.tb_StudentInformation
SET Class='信息管理与信息系统'
WHERE StudentID='3190707011'

SELECT
	*
	FROM dbo.tb_StudentLogIn
SELECT
	1
	FROM dbo.tb_StudentLogIn
	WHERE No='3190707011'AND Password='11'

UPDATE dbo.tb_StudentLogIn
SET Password='11'
WHERE No='3190707011'

SELECT
	*
	FROM dbo.tb_Announcement

SELECT
		*
		FROM dbo.tb_Message

UPDATE dbo.tb_Announcement
SET AnnouncementID='A002'
WHERE AnnouncementTitle='计算机二级通知'

UPDATE dbo.tb_StudentInformation
SET Class='信息管理与信息系统'
WHERE StudentID='3190707011'

SELECT
	*
	FROM dbo.tb_StudentLogIn
SELECT
	1
	FROM dbo.tb_StudentLogIn
	WHERE No='3190707011'AND Password='11'

UPDATE dbo.tb_StudentLogIn
SET Password='11'
WHERE No='3190707011'

SELECT
	*
	FROM dbo.tb_Announcement

SELECT
		*
		FROM dbo.tb_Message

UPDATE dbo.tb_Announcement
SET AnnouncementID='A002'
WHERE AnnouncementTitle='计算机二级通知'

SELECT
		Announcement
		FROM dbo.tb_Announcement
		WHERE AnnouncementID='';

SELECT
	*
	FROM dbo.tb_MessageRecord

SELECT
		A.AnnouncementID AS 通知编号
		,A.AnnouncementTitle AS 通知标题
		,A.Announcement AS 通知内容
		,IIF(MR.StudentNo IS NULL,'未读','已读') AS 状态
		FROM dbo.tb_Announcement AS A  LEFT JOIN dbo.tb_MessageRecord AS MR ON A.AnnouncementID=MR.ID AND MR.StudentNo='3190707011'
		

INSERT INTO dbo.tb_MessageRecord
(
    StudentNo,
    ID
)
VALUES
(   '3190707011', -- StudentNo - char(10)
    'A001'  -- ID - varchar(10)
    )

SELECT
                        		A.AnnouncementID AS 通知编号
		                        ,A.AnnouncementTitle AS 通知标题
		                        ,A.Announcement AS 通知内容双击查看详情
		                        ,IIF(MR.StudentNo IS NULL,'未读','已读') AS 状态
		                        FROM dbo.tb_Announcement AS A  LEFT JOIN dbo.tb_MessageRecord AS MR ON A.AnnouncementID=MR.ID AND MR.StudentNo='3190707011'

SELECT Term,CourseNo AS 课程号 
		                        ,BasicScore AS 平时成绩 
		                        ,FinalScore AS 期末成绩 
		                        ,TotalScore AS 总成绩 
                                FROM dbo.vw_StudentScore WHERE StudentNo = '3190707011' AND TotalScore IS NOT NULL

SELECT Term,CourseName AS 课程名称 
		                        ,BasicScore AS 平时成绩 
		                        ,FinalScore AS 期末成绩 
		                        ,TotalScore AS 总成绩 
                                FROM dbo.vw_StudentScore WHERE StudentNo = '3190707011' AND TotalScore IS NOT NULL

SELECT
	*
	FROM dbo.vw_StudentScore
	WHERE StudentNo='3190707011'

SELECT
		S.CourseName,S.FacultyName,IIF(SS.Score IS  NULL,'可退选','不可退选') AS 状态,SS.*
		FROM dbo.vw_StudentScore AS S LEFT JOIN dbo.tb_ScoreStatus AS SS ON SS.CourseNo = S.CourseNo AND SS.StudentNo = S.StudentNo
		WHERE S.StudentNo='3190707011' AND SS.StudentNo IS NOT NULL

SELECT
		S.CourseName,S.FacultyName,IIF(SS.StudentNo IS NOT  NULL,'已选','未选') AS 状态,s.*
		FROM dbo.vw_StudentScore AS S LEFT JOIN dbo.tb_ScoreStatus AS SS ON SS.CourseNo = S.CourseNo AND SS.StudentNo = S.StudentNo
		WHERE S.StudentNo='3190707011'


DELETE dbo.tb_ScoreStatus
WHERE CourseNo='C001' AND StudentNo='3190707011'

UPDATE dbo.tb_StudentInformation
SET StudentName='曾极涵'
WHERE StudentID='3190707011'

SELECT *
FROM dbo.tb_StudentInformation
WHERE StudentID=''