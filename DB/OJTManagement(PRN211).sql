

CREATE DATABASE OJT_MANAGEMENT_PRN211_Vs2

CREATE TABLE tblAccount (
	username varchar(40) NOT NULL,
	password varchar(20),
	isAdmin int, /*0: university, 1: student, 2: company*/

	PRIMARY KEY (username)
);


CREATE TABLE tblMajor (
	majorCode int identity(1, 1) NOT NULL,
	majorName nvarchar(100),

	PRIMARY KEY (majorCode) 
);

CREATE TABLE tblStudent (
	studentCode varchar(8) NOT NULL,
	username varchar(40) NOT NULL unique,
	studentName nvarchar(50),
	gender bit, /*false: Female, true: Male*/
	birthOfDate date,
	credit int,
	address nvarchar(100),
	is_Intern int, /*0: not yet, 1: working, 2: finished*/
	majorname nvarchar(100),

	PRIMARY KEY (studentCode)
);

ALTER TABLE tblStudent
ADD CONSTRAINT FK_student_account FOREIGN KEY (username)
REFERENCES tblAccount(username)


CREATE TABLE tblCompany (
	taxCode varchar(10) NOT NULL,
	username varchar(40) NOT NULL unique,
	companyName nvarchar(100),
	address nvarchar(100),

	PRIMARY KEY (taxCode)
);

ALTER TABLE tblCompany
ADD CONSTRAINT FK_Company_account FOREIGN KEY (username)
REFERENCES tblAccount(username)


CREATE TABLE tblJob (
	jobCode int identity(1, 1) NOT NULL,
	jobName nvarchar(50),
	numberInterns int,
	expirationDate date,
	status bit, /*0: active, 1: unactive*/
	taxCode varchar(10) NOT NULL,
	majorCode int NOT NULL,
	admin_Confirm int, /*0: not yet, 1: accepted, 2: denied*/
	jobDescription nvarchar(300),

	PRIMARY KEY (jobCode)
);

ALTER TABLE tblJob
ADD CONSTRAINT FK_company_job FOREIGN KEY (taxCode)
REFERENCES tblCompany(taxCode)

ALTER TABLE tblJob
ADD CONSTRAINT FK_job_major FOREIGN KEY (majorCode)
REFERENCES tblMajor(majorCode)


CREATE TABLE tblRegister_Job (
	studentCode varchar(8) NOT NULL,
	jobCode int NOT NULL,
	grade float,
	comment nvarchar(200),
	student_Confirm bit, /*false: cancel, true: accepted*/
	isCompanyConfirm int, /*0: not yet, 1: accepted, 2: denied*/
	is_Pass bit, /*0: passed, 1: not pass*/
	aspiration int,

	PRIMARY KEY (studentCode, jobCode)
);

ALTER TABLE tblRegister_Job
ADD CONSTRAINT FK_registerJob_student FOREIGN KEY (studentCode)
REFERENCES tblStudent(studentCode)

ALTER TABLE tblRegister_Job
ADD CONSTRAINT FK_registerJob_job FOREIGN KEY (jobCode)
REFERENCES tblJob(jobCode)

CREATE TABLE tblSemester (
	semesterID int identity(1,1),
	semesterName nvarchar(50),
	startDate date,
	endDate date,

	PRIMARY KEY (semesterID)
);

CREATE TABLE tblStudent_Semester(
	recordID int identity(1, 1),
	studentCode varchar(8),
	semesterID int, 

	PRIMARY KEY (recordID)
);

ALTER TABLE tblStudent_Semester
ADD CONSTRAINT FK_studentSemester_Semester FOREIGN KEY (semesterID)
REFERENCES tblSemester(semesterID)

ALTER TABLE tblStudent_Semester
ADD CONSTRAINT FK_studentSemester_Student FOREIGN KEY (studentCode)
REFERENCES tblStudent(studentCode)

