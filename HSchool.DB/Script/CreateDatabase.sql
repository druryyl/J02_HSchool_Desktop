CREATE DATABASE HsolTest
	ON (
		NAME = 'HsolTest_data',
		FILENAME = 'd:\database\HsolTest\HsolTest_data.mdf')
	LOG ON (
		NAME = 'HsolTest_log',
		FILENAME = 'd:\database\HsolTest\HsolTest_log.ldf')
GO
