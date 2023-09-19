select * from DoctorLogin
select * from Doctor


create trigger InsertInDoctorLogin ON DoctorLogin
FOR INSERT
AS
BEGIN
    DECLARE @Id int,
     @Pass nvarchar,
     @Doc_ID int
    
    
INSERT INTO DoctorLogin values(+

