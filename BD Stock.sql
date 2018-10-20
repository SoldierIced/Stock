use master
drop database stock
go

create database STOCK
go

use STOCK
go
--tablas-----------------------
create table Marcas(
CodigoM nvarchar(50) not null,
NombreM nvarchar(100) not null,
DetalleM nvarchar(300),
constraint pk_Marcas Primary Key (CodigoM)
)
go
create table Productos(
CodigoP nvarchar(50) not null,
NombreP nvarchar(100) not null,
detalleP nvarchar(300) not null,
constraint pk_Productos Primary Key (CodigoP)
)
go
create table ProductosxMarca (
CodigoM nvarchar(50) not null,
CodigoP nvarchar(50) not null,
CodigoT int not null,
stock int not null default 0,
constraint pk_ProductosxMarca Primary Key (CodigoM,CodigoP,CodigoT)
)
go
create table Tipos(
CodigoT int not null, -- color o tamaño.
especificacion varchar(400),

constraint pk_Tipos Primary Key (CodigoT)
)
go
create table Tiposxprod(
CodigoT int not null, -- color o tamaño.
CodigoP nvarchar(50) not null,
Detalle nvarchar(500) not null,
constraint pk_Tiposxprod Primary Key (CodigoT,CodigoP)
)
go
--conecciones de Productos x marcas
alter table ProductosxMarca add constraint Fk_InterxMarca
foreign key (CodigoM) references Marcas (CodigoM)
alter table ProductosxMarca add constraint Fk_InterxProduc
foreign key (CodigoP) references Productos (CodigoP)
-- conexiones de TIPOS x Productos
alter table Tiposxprod add constraint Fk_tipxprod
foreign key (CodigoP) references Productos (CodigoP)
alter table Tiposxprod add constraint Fk_tipxtip
foreign key (CodigoT) references Tipos (CodigoT)

insert into Marcas select '12385','Pedigree','Comida para perros, ultra buena.' union
select '123145','Microsoft','Empresa de equipamiento y software.'
insert into Tipos select '2222','Color fuxia v5jr3GGF'
select CodigoM as [Codigo de Marca], NombreM as [Nombre de la Marca], detalleM as [Detalle] from marcas


select CodigoM as [Marca],pm.CodigoT as Tipo,Productos.NombreP as [Nombre del Producto],Stock,Productos.detalleP from ProductosxMarca as pm inner join Productos on Productos.CodigoP=pm.CodigoP
