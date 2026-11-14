--use master


-- Password supplied at run time (never commit it): sqlcmd ... -v FDSQL_PASSWORD="..."
Create LOGIN FDSQL WITH PASSWORD = '$(FDSQL_PASSWORD)'
