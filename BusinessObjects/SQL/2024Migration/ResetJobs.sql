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


update fdaction set lastMsg='AZURE TESTING',lastResult=0 where token='BOOKGEN'


update fdaction set lastMsg='AZURE TESTING',lastResult=0 where token='SALESBEEFEMAIL'
update fdaction set lastRun=null, lastLogFile=null,lastMsg='Migration',lastResult=0 where token='IMPORTX'
update fdaction set lastRun=null, lastLogFile=null,lastMsg='Migration',lastResult=0 where token='ORDER_EXCHANGE'
update fdaction set lastRun=null, lastLogFile=null,lastMsg='Migration',lastResult=0 where token='EMAILBLAST'
update fdaction set lastRun=null, lastLogFile=null,lastMsg='Migration',lastResult=0 where token='HEALTH'


SELECT SYSDATETIMEOFFSET()
Select GetDate()
SELECT SWITCHOFFSET(SYSDATETIMEOFFSET(), '-05:00') AS LocalTime;

SWITCHOFFSET(SYSDATETIMEOFFSET(), '-05:00')

select CURRENT_TIMEZONE ( ) 


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