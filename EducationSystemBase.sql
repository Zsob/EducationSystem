CREATE DATABASE EducationSystemBase			
	ON		
		(NAME='DataFile'	
		,FILENAME='D:\EducationSystem\EducationSystemBase\DataFile.mdf')	
	LOG ON		
		(NAME='LogFile'	
		,FILENAME='D:\EducationSystem\EducationSystemBase\LogFile.ldf');	

CREATE TABLE tb_Announcement(
	AnnouncementID
		VARCHAR(10)
		NOT NULL
		 CONSTRAINT PK_tb_Announcement PRIMARY KEY (AnnouncementID),
	AnnouncementTitle
		VARCHAR(20)
		NOT NULL,
	Announcement
		VARCHAR(max)
		NOT NULL
);
CREATE TABLE tb_Class(
	No 
		INT 
		NOT NULL,
	Year 
		SMALLINT 
		NOT NULL,
	MajorNo 
		INT 
		NOT NULL,
	AdministrationClass 
		VARCHAR(20) 
		NOT  NULL,
	HasGraduated 
		BIT 
		NOT NULL,
	CampusNo
		INT 
		NOT NULL
) 
CREATE TABLE tb_ClassroomBorrow(
	Classroom 
		VARCHAR(20) 
		NOT NULL,
	Monday 
		NCHAR(10),
	Tuesday 
		NCHAR(10),
	Wednesday 
		NCHAR(10),
	Thursday 
		NCHAR(10),
	Friday 
		NCHAR(10))
CREATE TABLE tb_Degree(
	No 
		INT 
		NOT NULL,
	Name 
		VARCHAR(10) 
		NOT NULL
)
CREATE TABLE tb_Department(
	No 
		INT 
		NOT NULL,
	Name 
		VARCHAR(50) 
		NOT NULL
)
CREATE TABLE tb_Exam(
	ExamNo 
		VARCHAR(10) 
		NOT NULL,
	ExamName 
		VARCHAR(50) 
		NOT NULL,
	Time 
		DATETIME 
		NOT NULL,
)
CREATE TABLE tb_ExamEnroll(
	StudentNo 
		CHAR(10) 
		NOT NULL,
	ExamNo 
		VARCHAR(10) 
		NOT NULL
)
CREATE TABLE tb_Major(
	No 
		INT
		NOT NULL,
	Name 
		VARCHAR(50)
		NOT NULL,
	ShortName 
		VARCHAR(20),
	DegreeNo 
		INT
		NOT NULL,
	Length 
		TINYINT 
		NOT NULL,
	DepartmentNo 
		INT 
		NOT NULL,
	IsEnrolling 
		BIT 
		NOT NULL
)
CREATE TABLE tb_Message(
	MessageID 
		VARCHAR(10)
		NOT NULL,
	MessageTitle 
		VARCHAR(20)
		NOT NULL,
	Message 
		VARCHAR(MAX),
)
CREATE TABLE tb_MessageRecord(
	StudentNo 
		CHAR(10)
		NOT NULL,
	ID 
		VARCHAR(10)
		NOT NULL,
	Reply 
		VARCHAR(MAX)
)
CREATE TABLE tb_ScoreStatus(
	StudentNo 
		CHAR(10)
		NOT NULL,
	CourseNo 
		CHAR(4)
		NOT NULL,
	Score 
		DECIMAL(4, 1)
)
CREATE TABLE tb_StudentInformation(
	StudentID 
		CHAR(10)
		NOT NULL,
	StudentName 
		VARCHAR(10)
		NOT NULL,
	Phone 
		CHAR(11)
		NULL,
	Gender 
		CHAR(2)
		NOT NULL,
	Birthday 
		DATETIME 
		NOT NULL,
	Class 
		VARCHAR(50)
		NOT NULL,
	FirstQuestion 
		VARCHAR(50),
	SecendQuestion 
		VARCHAR(50),
	FirstAnswer 
		VARCHAR(50),
	SecendAnswer 
		VARCHAR(50),
)
CREATE TABLE tb_StudentLogIn(
	No 
		CHAR(10) 
		NOT NULL,
	Password 
		VARCHAR(20) 
		NOT NULL,
)
CREATE TABLE tb_StudentScore(
	StudentNo 
		CHAR(10) 
		NOT NULL,
	StudentName 
		VARCHAR(20),
	Class 
		VARCHAR(44),
	Term 
		VARCHAR(20) 
		NOT NULL,
	CourseNo 
		CHAR(4) 
		NOT NULL,
	CourseName 
		VARCHAR(50) 
		NOT NULL,
	FacultyName 
		VARCHAR(20) 
		NOT NULL,
	BasicScore 
		DECIMAL(4, 1),
	FinalScore 
		DECIMAL(4, 1),
	TotalScore 
		NUMERIC(7, 2),
	FacultyRate 
		DECIMAL(4, 1),
	CourseType 
		VARCHAR(50) 
		NOT NULL,
	BeginningTime 
		DATETIME,
	EndingTime 
		DATETIME
)

INSERT dbo.tb_Exam
(
    ExamNo,
    ExamName,
    Time
)
VALUES
('C0001', '大学生四级考试(上半年）',2020-06-30),
('C0002', '大学生六级考试(上半年）',2020-06-30),
('C0003', '计算机一级考试(上半年）',2020-04-01),
('C0004', '计算机二级考试(上半年）',2020-03-01),
('C0005', '教师资格证考试',2020-10-31),
('C0006', '普通话等级考试',2020-08-30),
('C0007', '计算机一级考试（下半年）',2020-09-15),
('C0008', '计算机二级考试(下半年）',2020-11-15),
('C0009', '大学生四级考试(下半年）',2020-12-12),
('C0010', '大学生六级考试(下半年）',2020-12-12);
INSERT dbo.tb_ExamEnroll
(
    StudentNo,
    ExamNo
)
VALUES
('3190707011', 'A0002'),
('3190707011', 
'C0004')
INSERT dbo.tb_Message
(
    MessageID,
    MessageTitle,
    Message
)
VALUES ('M001', '计算机等级考试须知', '福建省计算机等级考试将在12月1日在福建中医药大学开始')
INSERT dbo.tb_MessageRecord
(
    StudentNo,
    ID,
    Reply
)
VALUES ('3190707011', 'A001', 
'11111111')
INSERT dbo.tb_ScoreStatus
(
    StudentNo,
    CourseNo,
    Score
)
VALUES 
(N'3190707011', N'A001', CAST(101.0 AS Decimal(4, 1))),
(N'3190707011', N'A002', NULL),
(N'3190707011', N'C001', NULL),
(N'3190707011', N'B001', NULL),
(N'3190707011', N'E003', NULL),
(N'3190707011', N'C002', NULL),
(N'3190707011', N'A009', NULL)
INSERT dbo.tb_StudentInformation
(
    StudentID,
    StudentName,
    Phone,
    Gender,
    Birthday,
    Class,
    FirstQuestion,
    SecendQuestion,
    FirstAnswer,
    SecendAnswer
)
VALUES
(   '3190707011',        -- StudentID - char(10)
    '曾极涵',        -- StudentName - varchar(10)
    '15080491384',        -- Phone - char(11)
    '男',        -- Gender - char(2)
    2001-3-27, -- Birthday - datetime
    '2019级信息管理与信息系统',        -- Class - varchar(50)
    '',        -- FirstQuestion - varchar(50)
    '',        -- SecendQuestion - varchar(50)
    '',        -- FirstAnswer - varchar(50)
    ''         -- SecendAnswer - varchar(50)
    )
INSERT dbo.tb_StudentLogIn
(
    No,
    Password
)
VALUES
(   '3190707011', -- No - char(10)
    HASHBYTES('MD5','11')  -- Password - varchar(20)
    )
INSERT dbo.tb_StudentScore
(
    StudentNo,
    StudentName,
    Class,
    Term,
    CourseNo,
    CourseName,
    FacultyName,
    BasicScore,
    FinalScore,
    TotalScore,
    FacultyRate,
    CourseType,
    BeginningTime,
    EndingTime
)
VALUES
('3190707011', '曾极涵', '19信管', '2019-2020-1', 'A001', '计算机导论', '刘闽碧', 51, 49, 83, 1, '学科基础课', 2020-12-1,2021-1-15),
('3190707011', '曾极涵', '19信管', '2019-2020-1', 'A002', 'C语言程序设计', '张翠萍', 87, 85.5, 87, 5, '学科基础课', 2020-12-1, 2021-1-15),
('3190707011', '曾极涵', '19信管', '2019-2020-1', 'C001', '英语1', '林翰',70,4, 90, 2, '通识教育课', 2020-12-1, 2021-1-15),
('3190707011', '曾极涵', '19信管', '2019-2020-2', 'A007', '计算机网络', '陈林',66, 59,88,3, '学科基础课', 2020-12-1, 2021-1-15),
('3190707011', '曾极涵', '19信管', '2019-2020-2', 'A009', '面向对象程序设计', '林立',52, 60, 85, 3, '学科基础课', 2020-12-1, 2021-1-15),
('3190707011', '曾极涵', '19信管', '2019-2020-2', 'C002', '英语2', '陈斯歆', 68, 67, 88,3, '通识教育课', 2020-12-1, 2021-1-15),
('3190707011', '曾极涵', '19信管', '2019-2020-2', 'E003', '中医学基础', '杜建', 82, 81,82, 3, '专业教育课', 2020-12-1, 2021-1-15),
('3190707011', '曾极涵', '19信管', '2020-2021-1', 'A004', '数据库原理', '林立', NULL, NULL, NULL, NULL, '专业教育课', NULL, NULL),
('3190707011', '曾极涵', '19信管', '2020-2021-1', 'B001', '管理学基础', '金浪', NULL, NULL, NULL, NULL, '学科基础课', NULL, NULL),
('3190707011', '曾极涵', '19信管', '2020-2021-1', 'F001', '概率论与数理统计', '魏国强', NULL, NULL, NULL, NULL, '学科基础课', NULL, NULL),
('3190707011', '曾极涵', '19信管', '2020-2021-2', 'A008', '动态网站建设', '陈林', NULL, NULL, NULL, NULL, '学科基础课', NULL, NULL),
('3190707011', '曾极涵', '19信管', '2021-2022-1', 'A005', 'SPSS统计软件', '陈桂芬', NULL, NULL, NULL, NULL, '专业教育课', NULL, NULL),
('3190707011', '曾极涵', '19信管', '2021-2022-1', 'B002', '医学信息学', '陈桂芬', NULL, NULL, NULL, NULL, '专业教育课', NULL, NULL),
('3190707011', '曾极涵', '19信管', '2021-2022-2', 'A006', '信息系统分析与设计', '黄至辉', NULL, NULL, NULL, NULL, '专业教育课', NULL, NULL),
('3190707011', '曾极涵', '19信管', '2021-2022-2', 'D001', '马克思主义基本原理概论', '王尊旺', NULL, NULL, NULL, NULL, '通识教育课', NULL, NULL)
INSERT dbo.tb_Class
(
    No,
    Year,
    MajorNo,
    AdministrationClass,
    HasGraduated,
    CampusNo
)
VALUES
(312, 2019, 1, '1', 0, 1),
(313, 2019, 1, '2', 0, 1),
(314, 2019, 1, '3', 0, 1),
(315, 2019, 1, '4', 0, 1),
(316, 2019, 1, '5', 0, 1),
(317, 2019, 1, '6', 0, 1),
(318, 2019, 42, '1', 0, 1),
(319, 2019, 42, '2', 0, 1)
INSERT dbo.tb_ClassroomBorrow
(
    Classroom,
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday
)
VALUES
('1109', '0', '3190707011', NULL, NULL, NULL),
('1110', NULL, NULL, '3190707001', NULL, '0'),
('1115', '3190707011', '3190707001', NULL, '0', NULL),
('2101', '0', '0', NULL, '3190707011', NULL),
('2210', NULL, NULL, '0', NULL, NULL),
('2303', NULL, '0', NULL, '3190707058', NULL)
INSERT dbo.tb_Degree
(
    No,
    Name
)
VALUES
(1, N'医学'),
(2, N'理学'),
(3, N'工学'),
(4, N'管理学')

CREATE TABLE dbo.tb_Term
	(No 
		CHAR(10)
		NOT NULL,
	Name 
		VARCHAR(20) 
		NOT NULL)

INSERT dbo.tb_Term
(
    No,
    Name
)
VALUES
('23', '2019-2020-1'),
('24', '2019-2020-2'),
('25', '2020-2021-1'),
('26', '2020-2021-2'),
('27', '2021-2022-1')

DROP TABLE IF EXISTS dbo.tb_TeachingTask;
CREATE TABLE dbo.tb_TeachingTask
	(No 
		VARCHAR(50)
		NOT NULL,
	TermNo
		VARCHAR(10) 
		NOT NULL,
	FacultyNo 
		CHAR(7) 
		NOT NULL,
	CourseNo
		CHAR(4)
		NOT NULL,
	BookNo 
		VARCHAR(10) 
		NULL,
	BookNo2 
		VARCHAR(10)
		NULL)
INSERT dbo.tb_TeachingTask
(
    No,
    TermNo,
    FacultyNo,
    CourseNo,
    BookNo,
    BookNo2
)
VALUES
('2019-2020-1_339_A002',	'23',	'2001018',	'A002',	'3',	NULL),
('2019-2020-1_277_B001',	'23',	'1994001',	'B001',	'21',	NULL),
('2019-2020-2_339_A009',	'24',	'2004034',	'A009',	'26',	NULL),
('2019-2020-1_277_A004',	'23',	'2004034',	'A004',	'6',	NULL),
('2019-2020-1_339_A001',	'23',	'1989008',	'A001',	'1',	NULL),
('2019-2020-2_277_A008',	'24',	'2009015',	'A008',	'12',	NULL),
('2019-2020-2_276_D001',	'24',	'2002008',	'D001',	'20',	NULL),
('2019-2020-2_339_E010',	'25',	'1980001',	'C001',	'13',	NULL),
('2020-2021-1_273_B011',	'26',	'2004005',	'C002',	'22',	NULL),
('2019-2020-2_339_E012',	'23',	'1980001',	'E003',	'13',	NULL),
('2019-2010-1_156_A003',	'25',	'1989008',	'A003',	'5',	NULL),
('2019-2020-1_276_A005',	'23',	'2004005',	'A005',	'8',	NULL),
('2019-2020-2_276_A006',	'24',	'2010007',	'A006',	'9',	NULL),
('2019-2020-1_336_A100',	'23',	'2004034',	'A100',	'14',	NULL),
('2019-2020-2_336_A101',	'24',	'2009015',	'A101',	'25',	NULL),
('2019-2020-1_251_B002',	'23',	'2004005',	'B002',	'22',	NULL)

CREATE TABLE dbo.tb_Course
	(No 
		CHAR(4) 
		NOT NULL,
	Name 
		VARCHAR(50)
		NOT NULL,
	PinYin 
		VARCHAR(50)
		NULL,
	PreCourseNo 
		CHAR(4) SPARSE 
		NULL,
	Credit 
		FLOAT
		NOT NULL,
	StudyTypeNo 
		CHAR(10) 
		NOT NULL,
	ExamTypeNo 
		CHAR(10)
		NOT NULL,
	DefaultFacultyNo 
		VARCHAR(10)
	NULL)
INSERT dbo.tb_Course
(
    No,
    Name,
    PinYin,
    PreCourseNo,
    Credit,
    StudyTypeNo,
    ExamTypeNo,
    DefaultFacultyNo
)
VALUES
('A001', '计算机导论', 'jsjdl', NULL, 2, '1', '1', NULL),
('A002', 'C语言程序设计', 'cyycxsj', NULL, 2, '1', '1', NULL),
('A003', 'VB语言程序设计', 'vbyycxsj', NULL, 2, '1', '1', NULL),
('A004', '数据库原理', 'sjkyl', NULL, 3, '1', '1', NULL),
('A005','SPSS统计软件', 'spsstjrj', '3.0 ', 2, '2', '1 ', NULL),
('A006', '信息系统分析与设计', 'xxxtfxysj', 'A004', 4, '3', '1', '2010007'),
('A007', '计算机网络', 'jsjwlytx', 'A001', 4, '3', '1', '2009015'),
('A008','动态网站建设', 'dtwzjs', 'A004', 4.5, '4','1', '2009015'),
('A009', '面向对象程序设计','mxdxcxsj', 'A002', 4.5, '2', '1','2004034'),
('A100', '计算机基础', 'jsjjc', NULL, 3, '1 ', '1', '1988012'),
('A101','计算机应用','jsjyy', NULL, 4, '1 ', '1', '2009015'),
('B001', '管理学基础', 'glxjc', NULL, 4, '2 ', '1', '1994001'),
('B002', '医学信息学', 'yxxxx', 'B001', 3, '2', '1', '1988012'),
('C001','英语1', 'yy1', NULL, 4, '1', '1', '2001016'),
('C002', '英语2', 'yy2', 'C001', 4, '1', '1', '2001016'),
('D001', '马克思主义基本原理概论', 'mkszyjbylgl', NULL, 3,'1','2', '2002008'), 
('E003','中医学基础', 'zyxjc', NULL, 4, '4', '1 ', '1980001')


