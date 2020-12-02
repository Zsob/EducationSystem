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
	WHERE Class='19�Ź�'
	ORDER BY BirthDate DESC

UPDATE dbo.tb_StudentInformation
SET Class='19�Ź�'
WHERE StudentID='3190707011'

SELECT
	 Name
	FROM dbo.tb_Major

UPDATE dbo.tb_StudentInformation
SET Class='��Ϣ��������Ϣϵͳ'
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
WHERE AnnouncementTitle='���������֪ͨ'

UPDATE dbo.tb_StudentInformation
SET Class='��Ϣ��������Ϣϵͳ'
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
WHERE AnnouncementTitle='���������֪ͨ'

UPDATE dbo.tb_StudentInformation
SET Class='��Ϣ��������Ϣϵͳ'
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
WHERE AnnouncementTitle='���������֪ͨ'

SELECT
		Announcement
		FROM dbo.tb_Announcement
		WHERE AnnouncementID='';

SELECT
	*
	FROM dbo.tb_MessageRecord

SELECT
		A.AnnouncementID AS ֪ͨ���
		,A.AnnouncementTitle AS ֪ͨ����
		,A.Announcement AS ֪ͨ����
		,IIF(MR.StudentNo IS NULL,'δ��','�Ѷ�') AS ״̬
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
                        		A.AnnouncementID AS ֪ͨ���
		                        ,A.AnnouncementTitle AS ֪ͨ����
		                        ,A.Announcement AS ֪ͨ����˫���鿴����
		                        ,IIF(MR.StudentNo IS NULL,'δ��','�Ѷ�') AS ״̬
		                        FROM dbo.tb_Announcement AS A  LEFT JOIN dbo.tb_MessageRecord AS MR ON A.AnnouncementID=MR.ID AND MR.StudentNo='3190707011'

SELECT Term,CourseNo AS �γ̺� 
		                        ,BasicScore AS ƽʱ�ɼ� 
		                        ,FinalScore AS ��ĩ�ɼ� 
		                        ,TotalScore AS �ܳɼ� 
                                FROM dbo.vw_StudentScore WHERE StudentNo = '3190707011' AND TotalScore IS NOT NULL

SELECT Term,CourseName AS �γ����� 
		                        ,BasicScore AS ƽʱ�ɼ� 
		                        ,FinalScore AS ��ĩ�ɼ� 
		                        ,TotalScore AS �ܳɼ� 
                                FROM dbo.vw_StudentScore WHERE StudentNo = '3190707011' AND TotalScore IS NOT NULL

SELECT
	*
	FROM dbo.vw_StudentScore
	WHERE StudentNo='3190707011'

SELECT
		S.CourseName,S.FacultyName,IIF(SS.Score IS  NULL,'����ѡ','������ѡ') AS ״̬,SS.*
		FROM dbo.vw_StudentScore AS S LEFT JOIN dbo.tb_ScoreStatus AS SS ON SS.CourseNo = S.CourseNo AND SS.StudentNo = S.StudentNo
		WHERE S.StudentNo='3190707011' AND SS.StudentNo IS NOT NULL

SELECT
		S.CourseName,S.FacultyName,IIF(SS.StudentNo IS NOT  NULL,'��ѡ','δѡ') AS ״̬,s.*
		FROM dbo.vw_StudentScore AS S LEFT JOIN dbo.tb_ScoreStatus AS SS ON SS.CourseNo = S.CourseNo AND SS.StudentNo = S.StudentNo
		WHERE S.StudentNo='3190707011'


DELETE dbo.tb_ScoreStatus
WHERE CourseNo='C001' AND StudentNo='3190707011'

UPDATE dbo.tb_StudentInformation
SET StudentName='������'
WHERE StudentID='3190707011'

SELECT *
FROM dbo.tb_StudentInformation
WHERE StudentID=''