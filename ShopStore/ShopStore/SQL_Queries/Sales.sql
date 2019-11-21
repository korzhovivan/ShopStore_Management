create table Sales
(
ID_SALE int primary key identity(1,1),
ID_BOOK int not null,
Login nvarchar(32) not null,
DateOfSale date not null,
Price money not null,
)

insert into Sales
values (1, 'korzik', '2019-01-15', 2560),
(2, 'korzik', '2019-02-15', 452),
(1, 'korzik', '2019-03-15', 4537),
(1, 'korzik', '2019-04-15', 856),
(8, 'korzik', '2019-05-15', 444),
(4, 'korzik', '2019-06-15', 415),
(3, 'korzik', '2019-07-15', 783),
(5, 'korzik', '2019-08-15', 452),
(2, 'korzik', '2019-09-15', 4523),
(1, 'korzik', '2019-10-15', 145),
(1, 'korzik', '2019-11-15', 2560),
(1, 'korzik', '2019-12-15', 745)