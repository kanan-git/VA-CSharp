/* 
—————————————————————————————————————————————————————————————————————
######################## TASK 2 INSTRUCTIONS ########################
—————————————————————————————————————————————————————————————————————
2.Tables & Relations  E-commerce DB
Customers (Id,Name,Email,Phone)
Products(Id,Name,Description,Price)
Categories(Id,Name,Description)
Orders(Id,OrderDate,Status)
OrderItems(Id,Quantity,UnitPrice)
Suppliers(Id,Name,ContactInfo)
ProductSuppliers(Id)

Elaqeler bu shekilde olacag

Customers ---- Orders → One-to-many
Orders  -----OrderItems → One-to-many
Products ---- OrderItems → One-to-many
Products ----- Categories → Many-to-one
Products ------ Suppliers → Many-to-many
—————————————————————————————————————————————————————————————————————
*/

/* CREATE DATABASE */
create database E_Commerce_DB;

/* CREATING ALL TABLES */
create table Customers (
	Id int primary key identity(1,1),
	Name varchar(20) not null,
	Email varchar(30) unique,
	Phone varchar(13) unique -- '+994501234567'
);
create table Products(
	Id int primary key identity(1,1),
	Name varchar(20) not null,
	Description varchar(max),
	Price int not null check(Price>0)
);
create table Categories(
	Id int primary key identity(1,1),
	Name varchar(20) not null,
	Description varchar(max)
);
create table Orders(
	Id int primary key identity(1,1),
	OrderDate varchar(10), -- 'YYYY/MM/DD'
	Status smallint, -- 0 or 1
	CustomerId int foreign key references Customers(Id)
);
create table OrderItems(
	Id int primary key identity(1,1),
	Quantity int,
	UnitPrice int
);
create table Suppliers(
	Id int primary key identity(1,1),
	Name varchar(20) not null,
	ContactInfo varchar
);
create table ProductSuppliers(
	Id int primary key identity(1,1)
);

/* SHOW ALL CREATED TABLES AT ONCE */
SELECT * FROM Customers,Products,Categories,Orders,OrderItems,Suppliers,ProductSuppliers;
