use BloodBankDB

create table People(
P_ID int identity,
PName varchar(50) not null,
PGender varchar(50) not null,
PBlood varchar(5) not null,
PBirthDate date not null,
P_Age as (year(getdate()) - year(PBirthDate)),
PEmail varchar(320) not null unique,
PCity VarChar(50) not null, 
PType VarChar(5) not null
constraint PeoplePK primary key(P_ID),
constraint PGenderCheck check(PGender in ('Male', 'Female')),
constraint PTypeCheck check(PType in ('D', 'P')), --0 for patients and 1 for Donors
constraint PBloodCheck check(PBlood in ('A+', 'A-', 'B+', 'B-', 'AB+', 'AB-', 'O+', 'O-'))
)

-- adding unique constraint to Name in people table as a combination with personType
ALTER TABLE dbo.People
  ADD CONSTRAINT uq_people UNIQUE(PName, PType);

-- create Donoations History Table
create table Donations(
D_ID int not null, 
D_Date varchar(50) not null default convert(varchar, getdate(), 20)
constraint IDforeign foreign key(D_ID) references People(P_ID)
	on delete cascade on update cascade,
constraint PrimaryKey primary key(D_ID, D_Date)
)


-- create Transfers History Table
create table Transfers(
P_ID int not null, 
P_Date varchar(50) not null default convert(varchar, getdate(), 20)
constraint IDforeign1 foreign key(P_ID) references People(P_ID)
	on delete cascade on update cascade
constraint PrimaryKey1 primary key(P_ID, P_Date)
)


-- Creating Bloods table
create table Bloods(
BGroup varchar(5) not null primary key,
BCounts int not null default 0
constraint BloodCountCheck check(BCounts >= 0),
)

-- Adding all the bloods types to the bloods table
insert into Bloods(BGroup) values('A+')
insert into Bloods(BGroup) values('A-')
insert into Bloods(BGroup) values('B+')
insert into Bloods(BGroup) values('B-')
insert into Bloods(BGroup) values('AB+')
insert into Bloods(BGroup) values('AB-')
insert into Bloods(BGroup) values('O+')
insert into Bloods(BGroup) values('O-')



create table Users(
	ID int identity ,
	UserName varchar(50) not null unique,
	Email varchar(320) not null unique,
	Password BINARY(64) NOT NULL,
	Gender varchar(50) not null,
	BirthDate date not null
	constraint UserPK primary key(ID),
	constraint UserGenderCheck check(Gender in ('Male', 'Female'))
)





