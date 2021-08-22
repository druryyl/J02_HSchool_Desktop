CREATE TABLE HSOL_RegScolasticIssue
(
	RegID VARCHAR(2) NOT NULL CONSTRAINT DF_HSOL_RegScolasticIssue_RegID DEFAULT(''),
	TransferIssue VARCHAR(20) NOT NULL CONSTRAINT DF_HSOL_RegScolasticIssue_TransferIssue DEFAULT(''),
	DisiplinaryIssue VARCHAR(20) NOT NULL CONSTRAINT DF_HSOL_RegScolasticIssue_DisiplinaryIssue DEFAULT(''),
	DrugIssue VARCHAR(20) NOT NULL CONSTRAINT DF_HSOL_RegScolasticIssue_DrugIssue DEFAULT(''),
	AcademicFailedIssue VARCHAR(20) NOT NULL CONSTRAINT DF_HSOL_RegScolasticIssue_AcademicFailedIssue DEFAULT(''),
	AcademicLevel INT NOT NULL CONSTRAINT DF_HSOL_RegScolasticIssue_AcademicLevel DEFAULT(0),


	CONSTRAINT PK_HSOL_RegScolasticIssue_RegID PRIMARY KEY CLUSTERED (RegID)
)
