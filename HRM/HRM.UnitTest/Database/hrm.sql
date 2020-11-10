drop table [user];
drop table [emplyee];

create table user(
    userID integer primary key AUTOINCREMENT not null,
    loginName varchar(256) not null default '',
    userName varchar(256) not null default '',
    pwd varchar(256) not null default ''
);

create table employee(
    userID integer primary key not null,
    code varchar(28) not null,
    sex varchar(3) not null default 'f',
    birthDate datetime not null default '1900-1-1',
    timeOfDesignInstitute datetime not null default '1900-1-1',
    timeOfWorking datetime not null default '1900-1-1',
    timeOfResearchInstitute datetime not null default '1900-1-1',
    technicalTitle varchar(128) not null default '',
    timeOfTechnicalTitle datetime not null default '1900-1-1',
    jobTitle varchar(128) not null default '',
    education varchar(128) not null default '',
    political varchar(128) not null default '',
    telephone varchar(20) not null default '',
    cellphone varchar(20) not null default '',
    email varchar(128) not null default '',
    wx varchar(128) not null default '',
    dingding varchar(128) not null default '',
    employType varchar(3) not null default ''
);

insert into user(loginName,userName,pwd)values('renkf01','renkf01','123456');