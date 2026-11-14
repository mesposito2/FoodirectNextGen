select * from fdaction where active=1
update fdaction set lastRun=null, lastLogFile=null,lastMsg='Migration',lastResult=0 where token='BOOKGEN'
update fdaction set lastRun=null, lastLogFile=null,lastMsg='Migration',lastResult=0 where token='SALESBEEFEMAIL'
update fdaction set lastRun=null, lastLogFile=null,lastMsg='Migration',lastResult=0 where token='IMPORTX'
update fdaction set lastRun=null, lastLogFile=null,lastMsg='Migration',lastResult=0 where token='ORDER_EXCHANGE'
update fdaction set lastRun=null, lastLogFile=null,lastMsg='Migration',lastResult=0 where token='EMAILBLAST'
update fdaction set lastRun=null, lastLogFile=null,lastMsg='Migration',lastResult=0 where token='HEALTH'
select * from fdactionhistory
delete from FDACTIONHistory



update V5EmailBlast set LogFile='NOT_MIGRATED_2024_11_23'
truncate table pricemaster 
truncate table chain
truncate table speed
truncate table favorite
truncate table prods

drop database fdv7

CREATE USER FDSQL
	FOR LOGIN FDSQL
	WITH DEFAULT_SCHEMA = FDV5
GO
EXEC sp_addrolemember db_owner, FDSQL