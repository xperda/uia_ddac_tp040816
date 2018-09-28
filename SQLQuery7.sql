USE [UIA]
INSERT INTO [reservation]([username],[fullname],[passportNo],[flightID],[timeofDepature],[timeofArrival],[destination])
                    SELECT u.[username],u.[fullname],u.[passportNo],f.[flightID],f.[timeofDepature],f.[timeofArrival],  f.[destination]
                    FROM
					[user] u  WHERE u.username = 'demouser2'
					wWJERECROSS JOIN[flight] f 
                    and f.flightID = '2';

/*truncate table reservation;*/


select * from reservation;
	