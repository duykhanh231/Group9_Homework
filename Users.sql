create database Users;
use Users;

create table users
(
	UserID int primary key,
	Username varchar(50),
	Password varchar(50),
	Email varchar(50),
	Fullname varchar(50),
	Birthday smalldatetime
);


select * from users;
insert into users(Username,Password,Email,Fullname,Birthday)
values('namanh','2508','namanh2508@gmail.com','namanh','2005-08-25')
delete users;
update users
set Password = 'namanh1'
where Password = '2508'