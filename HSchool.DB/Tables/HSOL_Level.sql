﻿CREATE TABLE HSOL_Level
(
	LevelID VARCHAR(3) NOT NULL CONSTRAINT DF_HSOL_Level_LevelID DEFAULT(''),
	LevelName VARCHAR(30) NOT NULL CONSTRAINT DF_HSOL_Level_LevelName DEFAULT(''),
	GradeID VARCHAR(3) NOT NULL CONSTRAINT DF_HSOL_Level_GradeID DEFAULT(''),


	CONSTRAINT PK_HSOL_Level_LevelID PRIMARY KEY CLUSTERED (LevelID)
)
