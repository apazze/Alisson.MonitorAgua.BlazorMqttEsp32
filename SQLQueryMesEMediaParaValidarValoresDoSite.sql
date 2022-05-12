select MONTH (d.TimeStamp) mes, avg(Value) mediaVazao
from dbo.Sensors s
INNER JOIN dbo.Datas d
ON s.Id = d.SensorId
WHERE s.NameSensor = 'Vazao'
GROUP BY month(d.Timestamp)