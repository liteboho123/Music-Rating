create database Music
go

use Music
go 

create table Genre(
ID int identity(1,1) primary key,
GenreType varchar(max) not null)


create table Artist(
ID int identity(1,1) primary key,
ArtistName varchar(max) not null,
GenreID int foreign key references Genre(ID))



create table Track(
ID int identity(1,1) primary key,
Rating char(1) null,
Song varchar(max) not null,
[Year] char(4) null,
ArtistID int foreign key references Artist(ID))


