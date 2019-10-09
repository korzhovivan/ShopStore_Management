create table Users
(
Id int primary key identity(1,1),
Login nvarchar(32) not null unique,
Password nvarchar(32) not null,
)

insert into Users
values
('Korzik', '123456'),
('Vadym123', 'helloworld'),
('Inga', 'iamgod'),
('qwerty123', 'qwerty123'),
('Gordey228', 'KORZIK1'),
('KORZIK19', 'KorzUm51')


create table Books
(
ID_BOOK int primary key identity(1,1),
NameBook nvarchar(32) not null,
Fio nvarchar(64) not null,
PublishName nvarchar(64) not null,
Price money not null,
Pages int not null,
DateOfPublishing date not null,
SalePrice money not null
)

insert into Books
values ('First steps on PC','Korzov Ivan', 'GOD1',128, 254,'2000-01-11', 3255),
('C++','Bill Gates', 'GOD1',64, 254,'2010-05-05', 12)