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
