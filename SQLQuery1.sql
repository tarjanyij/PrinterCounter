select * from PrinterCounter inner join Printers on PrinterCounter.PrinterID = Printers.PrinterID
where DATEPART(yy, Date_Counter) = 2019
AND    DATEPART(mm, Date_Counter) = 10 
AND printers.PrinterID ='10';

select MAX(PaperCounter)-MIN(PaperCounter) from PrinterCounter inner join Printers on PrinterCounter.PrinterID = Printers.PrinterID
where DATEPART(yy, Date_Counter) = 2019
AND    DATEPART(mm, Date_Counter) = 10 
AND printers.PrinterID ='10';