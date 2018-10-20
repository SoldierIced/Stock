use master
drop database stock
go

create database STOCK
go

use STOCK
go

--v2
--tablas-----------------------
create table Marcas(
CodigoM nvarchar(50) not null, -- codigo de barra de la marca.
NombreM nvarchar(100) not null,
DetalleM nvarchar(300),
constraint pk_Marcas Primary Key (CodigoM)
)
go
create table ProductosxMarca (
CodigoM nvarchar(50) not null, -- codigo de barra de la marca.
CodigoP nvarchar(50) not null,-- codigo de barra del producto
CodigoT int not null, -- 1 perfumes , 2-- colores
NombreP nvarchar(300) not null,-- nombre producto: GALLETITAS DE CHOCOLATE o "perfume sabor chocolate"
DetalleP nvarchar(300) not null,-- cosa especifica del prodcuto: "250g, 6 unidades." o "200 mililitros.
stock int not null default 0, -- cantidad de stock disponible.
precio float not null,
constraint pk_ProductosxMarca Primary Key (CodigoM,CodigoP,CodigoT)
)
go

alter table ProductosxMarca add constraint Fk_InterxMarca
foreign key (CodigoM) references Marcas (CodigoM)

-- yo creo que la base de datos tendria que ser asi, ya que con los codigos de barra como hariamos para conectar los productos  y x marca?
-- porque supongamos que vienen 2 productos que sean galletita...
--ej: galletita de chocolate oreo::: codigo de barra: 002-000542
-- y tambien galletita de chocolate pepito::: codigo :0014-0008
--* suponiendo que lo primero es el codigo de marca, como se relacionaria ese codigo de barra con el tipo "galletita?
-- por eso plantie esta base de datos.
--espero tu comentario y ayuda wey
