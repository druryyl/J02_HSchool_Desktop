CREATE USER HsolUser FOR LOGIN HsolLogin
GO

sp_addrolemember 'db_datareader','HsolUser'
GO

sp_addrolemember 'db_datawriter', 'HsolUser'
GO