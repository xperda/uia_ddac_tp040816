INSERT INTO [reservation](u.[username],u.[fullname],u.[passportNo],f.[flightID],f.[timeofDepature],f.[timeofArrival],f.[destination])
SELECT u.[username],u.[fullname],u.[passportNo],f.[flightID],f.[timeofDepature],f.[timeofArrival],f.[destination]
FROM [user] u ,[flight] f
WHERE u.username ='demouser' and f.flightID ='2';