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
CodigoT nvarchar(50) not null, -- 1 perfumes , 2-- colores
NombreP nvarchar(300) not null,-- nombre producto: GALLETITAS DE CHOCOLATE o "perfume sabor chocolate"
DetalleP nvarchar(300) not null,-- cosa especifica del prodcuto: "250g, 6 unidades." o "200 mililitros.
stock int not null default 0, -- cantidad de stock disponible.
precio float not null,
constraint pk_ProductosxMarca Primary Key (CodigoM,CodigoP,CodigoT)
)
go
create table Ventas(
CodigoV int identity(1,1),
CodigoM nvarchar(50) not null, -- codigo de barra de la marca.
CodigoP nvarchar(50) not null,-- codigo de barra del producto
CodigoT nvarchar(50) ,
cantidad int not null,
precio float not null,
fecha date default getdate(),
constraint pk_ventas Primary Key (CodigoV,CodigoM,CodigoP,CodigoT)

)
go
alter table ProductosxMarca add constraint Fk_InterxMarca
foreign key (CodigoM) references Marcas (CodigoM)
alter table Ventas add constraint Fk_Interventas
foreign key (CodigoM,CodigoP,CodigoT) references ProductosxMarca (CodigoM,CodigoP,CodigoT)




insert into Marcas select '791293','Axe','Desodorante' union
select '798152','Carrefour','Corazones de Alcaucil' union
select '796374','Pintura','Para paredes' union
select '798112','STA','Adhesivo Vinilico'

-- yo creo que la base de datos tendria que ser asi, ya que con los codigos de barra como hariamos para conectar los productos  y x marca?
-- porque supongamos que vienen 2 productos que sean galletita...
--ej: galletita de chocolate oreo::: codigo de barra: 002-000542
-- y tambien galletita de chocolate pepito::: codigo :0014-0008
--* suponiendo que lo primero es el codigo de marca, como se relacionaria ese codigo de barra con el tipo "galletita?
-- por eso plantie esta base de datos.
--espero tu comentario y ayuda wey
