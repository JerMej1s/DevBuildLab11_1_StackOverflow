create database assessment08;

use assessment08;

create table teamMember (
	id int not null unique auto_increment,
    firstName varchar(50) not null,
    lastName varchar(50) not null,
    email varchar(50) not null,
    attendanceDate varchar(50),
    guestName varchar(50),
    primary key(id)
);

create table dish (
	id int not null unique auto_increment,
    firstName varchar(50) not null,
    lastName varchar(50) not null,
    phoneNumber varchar(25) not null,
    dishName varchar(50) not null,
    dishDescription varchar(100),
    dishCategory varchar(25) not null
);

insert into teamMember (firstName, lastName, email) values ('Jeremy', 'Jones', 'jeremyjones@rocketmortgage.com');

insert into dish (firstName, lastName, phoneNumber, dishName, dishDescription, dishCategory) values ('Jeremy', 'Jones', '810-347-9536', 'Chili', 'Vegetarian', 'Main');
