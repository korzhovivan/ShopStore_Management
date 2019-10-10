create table Cart
(
	Id int primary key identity(1,1),
	User_Login nvarchar(32) not null,
	Book_ID int not null,
)