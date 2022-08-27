--create database EmployeeTest
--go

use EmployeeTest
go

--create table Employee

create table Employee(
EmployeeID int primary key identity(1,1) not null,
EmployeeFirstName varchar(60) not null,
EmployeeLastName varchar(60) not null,
EmployeePhone varchar(15) not null,
EmployeeZip int not null,
HireDate date not null
)

