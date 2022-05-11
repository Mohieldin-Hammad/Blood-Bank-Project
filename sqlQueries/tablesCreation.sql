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
PCity VarChar(50) not null
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
DCity VarChar(50) not null
constraint DonorsPK primary key(D_ID),
constraint DGenderCheck check(DGender in ('M', 'F')),
constraint DBloodCheck check(DBlood in ('A+', 'A-', 'B+', 'B-', 'AB+', 'AB-', 'O+', 'O-'))
)

-- create Donor History Table
create table Donations(
ID_Donor int not null, 
D_Date date not null,
D_Blood varchar(5) not null
constraint IDforeign foreign key(ID_Donor) references Donors(D_ID)
	on delete cascade on update cascade,
constraint Bloodforeign foreign key(D_Blood) references Bloods(BGroup)
	on delete cascade on update cascade,
constraint PrimaryKey primary key(ID_Donor, D_Date)
)


-- create Donor History Table
create table transfers(
ID_Patient int not null, 
P_Date date not null,
P_Blood varchar(5) not null
constraint IDforeign1 foreign key(ID_Patient) references Patients(P_ID)
	on delete cascade on update cascade,
constraint Bloodforeign1 foreign key(P_Blood) references Bloods(BGroup)
	on delete cascade on update cascade,
constraint PrimaryKey1 primary key(ID_Patient, P_Date)
)


-- Creating Bloods table
create table Bloods(
BGroup varchar(5) not null primary key,
BCounts int not null default 0
)

-- Creating table of all admins password which will let me create new users
create table Admins(
A_ID int identity primary key,
AdminUName varchar(50) not null,
AdminPass varchar(50) not null
)

-- adding new admin to the Admins table
insert into Admins(AdminUName, AdminPass) values('mohee', '1234')


-- Creating table for users and have the admin passwords as a foreign key
create table Users(
A_ID int not null,
U_ID int not null,
UName varchar(50) not null,
UPass varchar(50) not null
constraint Uforeign foreign key(A_ID) references Admins(A_ID)
	on delete cascade on update cascade,
constraint UPrimaryKey primary key(A_ID, U_ID)
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
