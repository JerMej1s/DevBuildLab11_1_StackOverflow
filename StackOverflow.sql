create database StackOverflow;

use StackOverflow;

create table questions (
	question_id int not null unique auto_increment,
    username varchar(30) not null,
    question_title varchar(30) not null,
    question_detail varchar(250) not null,
    question_posted datetime not null,
    question_upvotes int,
    category varchar(30),
    tag varchar(12),
    status int not null,
    primary key(question_id)
);

create table answers (
	answer_id int not null unique auto_increment,
    question_id int not null,
    username varchar(30) not null,
    answer_detail varchar(500) not null,
    answer_posted datetime not null,
    answer_upvotes int,
    primary key(answer_id),
    foreign key(question_id) references questions(question_id)
);

insert into questions (username, question_title, question_detail, question_posted, status) values ('Jeremy', 'A Title', 'Some description', '2022-08-08 12:00:00', 0);