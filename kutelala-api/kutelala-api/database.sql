use DataWareHouse
go
drop table Product
create table Product 
(
	ID int primary key identity(1,1),
	Name nvarchar(200)
)