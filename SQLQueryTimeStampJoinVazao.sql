select Datas.TimeStamp from Sensors
INNER JOIN Datas ON Sensors.Id = Datas.SensorId
where Sensors.NameSensor = 'Vazao'