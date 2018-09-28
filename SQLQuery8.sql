 INSERT INTO [reservation]([fullname],[passportNo],[flightID],[timeofDepature],[timeofArrival],[destination])
                    SELECT u.[fullname],u.[passportNo],f.[flightID],f.[timeofDepature],f.[timeofArrival],f.[destination]
                    FROM[user] u CROSS JOIN[flight] f 
                    WHERE u.username = 'demouser' and f.flightID = 2;
 
 SELECT * FROM reservation WHERE EXISTS (SELECT fullname from [user] where username = 'demouser');

 SELECT * FROM reservation;