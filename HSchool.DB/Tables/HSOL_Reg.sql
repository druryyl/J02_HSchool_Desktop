﻿CREATE TABLE HSOL_Reg
(
	RegID VARCHAR(13) NOT NULL CONSTRAINT DF_HSOL_Reg_RegID DEFAULT(''),
	RegDate DATETIME NOT NULL CONSTRAINT DF_HSOL_Reg_RegDate DEFAULT('3000-01-01'),
	PersonID VARCHAR(13) NOT NULL CONSTRAINT DF_HSOL_Reg_PersonID DEFAULT(''),
	AcademicYearID VARCHAR(3) NOT NULL CONSTRAINT DF_HSOL_Reg_AcademicYearID DEFAULT(''),
	GradeID VARCHAR(3) NOT NULL CONSTRAINT DF_HSOL_Reg_GradeID DEFAULT(''),


	CONSTRAINT PK_HSOL_Reg_RegID PRIMARY KEY CLUSTERED (RegID)
)