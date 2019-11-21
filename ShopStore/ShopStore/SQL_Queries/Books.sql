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
('C++','Bill Gates', 'GOD1',64, 254,'2010-05-05', 12),
('C++','Bill Gates', 'GOD1',64, 254,'2010-05-05', 12),
('First steps on PC','Korzov Ivan', 'GOD1',128, 254,'2000-01-11', 3255),
('C++','Bill Gates', 'GOD1',64, 254,'2010-05-05', 12),
('First steps on PC','Korzov Ivan', 'GOD1',128, 254,'2000-01-11', 3255),
('C++','Bill Gates', 'GOD1',64, 254,'2010-05-05', 12),
('C++','Bill Gates', 'GOD1',64, 254,'2010-05-05', 12),
('First steps on PC','Korzov Ivan', 'GOD1',128, 254,'2000-01-11', 3255),
('C++','Bill Gates', 'GOD1',64, 254,'2010-05-05', 12),
('First steps on PC','Korzov Ivan', 'GOD1',128, 254,'2000-01-11', 3255),
('C++','Bill Gates', 'GOD1',64, 254,'2010-05-05', 12),
('C++','Bill Gates', 'GOD1',64, 254,'2010-05-05', 12),
('First steps on PC','Korzov Ivan', 'GOD1',128, 254,'2000-01-11', 3255),
('C++','Bill Gates', 'GOD1',64, 254,'2010-05-05', 12),
('First steps on PC','Korzov Ivan', 'GOD1',128, 254,'2000-01-11', 3255),
('C++','Bill Gates', 'GOD1',64, 254,'2010-05-05', 12),
('C++','Bill Gates', 'GOD1',64, 254,'2010-05-05', 12),
('First steps on PC','Korzov Ivan', 'GOD1',128, 254,'2000-01-11', 3255),
('C++','Bill Gates', 'GOD1',64, 254,'2010-05-05', 12),
('First steps on PC','Korzov Ivan', 'GOD1',128, 254,'2000-01-11', 3255),