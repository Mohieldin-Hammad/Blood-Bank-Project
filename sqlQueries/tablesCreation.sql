----------------------------------
--This sql file is used for creating the tables of the database
----------------------------------
use BloodBankDB


-- Creating the patients table ... select the code and click F5 on keyboard
create table Patients(
P_ID int identity,
PName varchar(50) not null,
PGender varchar(5) not null,
PBlood varchar(5) not null,
PBirthDate date not null,
P_Age as (year(getdate()) - year(PBirthDate)),
PPhone varchar(50) not null,
PCity VarChar(50) not null,
PTransferDate date,
constraint PatientsPK primary key(P_ID),
constraint PGenderCheck check(PGender in ('M', 'F')),
constraint PBloodCheck check(PBlood in ('A+', 'A-', 'B+', 'B-', 'AB+', 'AB-', 'O+', 'O-'))
)


-- Creating the Donors table ... select the code and click F5 on keyboard
create table Donors(
D_ID int identity,
DName varchar(50) not null,
DGender varchar(5) not null,
DBlood varchar(5) not null,
DBirthDate date not null,
D_Age as (year(getdate()) - year(DBirthDate)),
DPhone varchar(50) not null,
DCity VarChar(50) not null,
DDonationDate date,
constraint DonorsPK primary key(D_ID),
constraint DGenderCheck check(DGender in ('M', 'F')),
constraint DBloodCheck check(DBlood in ('A+', 'A-', 'B+', 'B-', 'AB+', 'AB-', 'O+', 'O-'))
)


-- Creating Bloods table
create table Bloods(
BGroup varchar(5) not null primary key,
BCounts int not null default 0
)

-- Creating table of all admins password which will let me create new users
create table Admins(
AdminPass varchar(50) primary key
)

-- adding new admin to the Admins table
insert into Admins values ('123456789')


-- Creating table for users and have the admin passwords as a foreign key
create table Users(
UName varchar(50) not null,
UPass varchar(50) not null, 
APass varchar(50) not null,
constraint Aforeign foreign key(APass) references Admins(AdminPass)
	on delete cascade on update cascade,
constraint PrimaryKey primary key(Uname, APass)
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
