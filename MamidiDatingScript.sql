Create table RegisteredUser
(
	registeredUserId int identity(1,1) not null primary key,
	username varchar(100) not null,
	password varchar(50) not null,
    salt varchar(100) not null,
	firstName varchar(100) not null,
    lastName varchar(100) not null,
	emailAddress varchar(50) not null,
	month varchar(25) not null,
    day varchar(5) not null,
    year varchar(10) not null,
    age varchar(5) not null,
	isYes bit not null
);

Create table Message
(
	messageId int identity(1,1) not null primary key,
	registrationId int not null,
	toUsername varchar(100) not null,
	subject varchar(100) not null,
	message varchar(MAX) not null,
	fromUsername varchar(100) not null
);

Create table Contact
(
	contactId int identity(1,1) not null primary key,
	firstName varchar(100) not null,
	lastName varchar(100) not null,
	emailAddress varchar(50) not null,
	contactReason varchar(50) not null,
	message varchar(MAX) not null
);

Alter table Registration
Alter column age varchar(5) not null;
Alter table Registration
Drop column isBackgroundCheck;

Alter table Registration
Add isYes bit not null;

Drop table Registration;
Drop table Login;
Drop table NewRegisteredUser;
