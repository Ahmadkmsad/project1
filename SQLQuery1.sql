CREATE DATABASE studentinfo2;
USE  studentinfo2;
CREATE TABLE Weather
(
 id  int , 
 recordDate Date,
 temperature int,
  PRIMARY KEY (ID)
)
CREATE TABLE weather_details (
    Desc_id int NOT NULL PRIMARY KEY,
	tempID int ,
    Description varchar(8000)
   
);

EXEC sp_rename 'dbo.weather_details.tempID', 'temperatureID', 'COLUMN';
select * FROM Weather ;
select * FROM weather_details ;

INSERT INTO Weather VALUES (1,'2022-01-22',51);
INSERT INTO Weather VALUES (2,'2022-01-22',60);
INSERT INTO Weather VALUES (3,'2021-01-2',26);
INSERT INTO Weather VALUES (4,'2020-01-7',23);
INSERT INTO Weather VALUES (5,'2021-01-22',65);
INSERT INTO Weather VALUES (6,'2022-01-2',66);
INSERT INTO Weather VALUES (7,'2021-01-12',11);
INSERT INTO Weather VALUES (8,'2004-01-2',45);
INSERT INTO Weather VALUES (9,'2021-01-28',65);
INSERT INTO Weather VALUES (10,'2028-01-22',21);

INSERT INTO weather_details ( Desc_id,tempID,Description)VALUES (1,2,'windy');
INSERT INTO weather_details ( Desc_id,tempID,Description)VALUES (2,1,'stromy');
INSERT INTO weather_details ( Desc_id,tempID,Description)VALUES (3,4,'stromy');
INSERT INTO weather_details ( Desc_id,tempID,Description)VALUES (4,5,'windy');
INSERT INTO weather_details ( Desc_id,tempID,Description)VALUES (5,2,'windy');
INSERT INTO weather_details ( Desc_id,tempID,Description)VALUES (6,1,'stromy');
INSERT INTO weather_details ( Desc_id,tempID,Description)VALUES (7,6,'windy');
INSERT INTO weather_details ( Desc_id,tempID,Description)VALUES (8,8,'windy');
INSERT INTO weather_details ( Desc_id,tempID,Description)VALUES (9,9,'stromy');
INSERT INTO weather_details ( Desc_id,tempID,Description)VALUES (10,6,'windy');

UPDATE dbo.Weather
  
SET Weather.temperature=temperature*1.8+32;
SELECT  temperature,recordDate FROM  Weather WHERE   YEAR(recordDate)=2021 ;

UPDATE dbo.weather_details
  
SET weather_details.Description='stromy'
WHERE weather_details.Description='windy';

DELETE FROM Weather WHERE  recordDate>GETDATE();
DELETE FROM Weather ;


TRUNCATE TABLE weather_details;


DROP TABLE Weather;
DROP TABLE weather_details;
