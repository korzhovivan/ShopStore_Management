create table Sales
(
ID_SALE int primary key identity(1,1),
ID_BOOK int not null,
Login nvarchar(32) not null,
DateOfSale date not null,
Price money not null,
)