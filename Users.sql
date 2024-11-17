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
delete users;
