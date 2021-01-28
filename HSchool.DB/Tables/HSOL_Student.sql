﻿CREATE TABLE HSOL_Student
(
	StudentID VARCHAR(2) NOT NULL CONSTRAINT DF_HSOL_Student_StudentID DEFAULT(''),
	PersonID VARCHAR(20) NOT NULL CONSTRAINT DF_HSOL_Student_PersonID DEFAULT(''),
	LevelID VARCHAR(20) NOT NULL CONSTRAINT DF_HSOL_Student_LevelID DEFAULT(''),
	TglGraduate VARCHAR(20) NOT NULL CONSTRAINT DF_HSOL_Student_field4 DEFAULT(''),
	field5 VARCHAR(20) NOT NULL CONSTRAINT DF_HSOL_Student_field5 DEFAULT(''),


	CONSTRAINT PK_HSOL_Student_StudentID PRIMARY KEY CLUSTERED (StudentID)
)