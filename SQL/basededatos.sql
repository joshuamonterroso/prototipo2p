create database parcial2;
use parcial2;
create table proveedores(
id_proveedor int primary key auto_increment,
nombre varchar(200),
direccion varchar(200),
telefono int,
email varchar(200)
);

create table marca(
id_marca int primary key auto_increment,
nombre varchar(200),
direccion varchar(200)
);

create table linea(
id_linea int primary key auto_increment,
nombre varchar(200),
descripcion varchar(200),
id_marca int
);

create table producto(
id_producto int primary key auto_increment,
nombre varchar(200),
descripcion varchar(200),
id_linea int,
cantidad int
);

create table bodega(
id_bodega int primary key auto_increment,
nombre varchar(100)
);

create table inventario(
id_inventario int primary key auto_increment,
id_producto int,
id_bodega int,
cantidad int
);


create table registro_compra(
id_registro int primary key auto_increment,
id_factura int,
id_producto int,
cantidad int,
id_proveedor int,
descripcion varchar(200)
);

alter table linea add foreign key fklineamarca (id_marca) references marca(id_marca);
alter table producto add foreign key fkproductolinea (id_linea) references linea(id_linea);
alter table inventario add foreign key fkinventariobodega (id_bodega) references bodega(id_bodega);
alter table inventario add foreign key fkinventarioproducto (id_producto) references producto(id_producto);
alter table registro_compra add foreign key fkregproducto (id_producto) references producto(id_producto);
alter table registro_compra add foreign key fkregproveedor (id_proveedor) references proveedores(id_proveedor);

insert into proveedores (nombre,direccion,telefono,email) values ('pepsico','Zona 6 Guatemala','12344321','pepsi@gmail.com');
insert into proveedores (nombre,direccion,telefono,email) values ('cocaco','Zona 18 Guatemala','33344321','coca@gmail.com');
insert into proveedores (nombre,direccion,telefono,email) values ('fud','Zona 19 Guatemala','12356321','fud@gmail.com');

insert into bodega (nombre) values ('Bodega principal');
insert into bodega (nombre) values ('Bodega secundaria');
insert into bodega (nombre) values ('Bodega reserva');

insert into marca (nombre,direccion) values ('Embutidos Fud','zona17 Guatemala');
insert into marca (nombre,direccion) values ('Sodas Coca Cola','Zona 18 Guatemala');
insert into marca (nombre,direccion) values ('Sodas Pepsi cola','Zona 6 Guatemala');


insert into linea (nombre,descripcion,id_marca) values ('coca cola cherry','Coca cola sabor cereza','2');
insert into linea (nombre,descripcion,id_marca) values ('coca cola classic','Coca cola sabor clasico','2');
insert into linea (nombre,descripcion,id_marca) values ('pepsi classic','pepsi sabor clasico','1');
insert into linea (nombre,descripcion,id_marca) values ('pepsi blue','pepsi sabor mora','1');
insert into linea (nombre,descripcion,id_marca) values ('jamon virgina','jamo de pavo','4');
insert into linea (nombre,descripcion,id_marca) values ('jamon pollo','jamon de pollo','4');

insert into producto (nombre,descripcion,id_linea) values ('Jamon de pollo','Jamon de pollo para desayuno','6');
insert into producto (nombre,descripcion,id_linea) values ('Jamon de pavo','Jamon de pavo para desayuno','5');
insert into producto (nombre,descripcion,id_linea) values ('Pepsi cola blue','Sodas frias','4');
insert into producto (nombre,descripcion,id_linea) values ('Pepsi','sodas frias','3');
insert into producto (nombre,descripcion,id_linea) values ('coca cola cherry','sodas frias','2');
insert into producto (nombre,descripcion,id_linea) values ('coca cola','sodas frias','2');
select * from producto;

insert into registro_compra (id_factura,id_producto,cantidad,id_proveedor,descripcion) values ('1','1','50','3','Compras varias');
insert into registro_compra (id_factura,id_producto,cantidad,id_proveedor,descripcion) values ('2','2','50','3','Compras varias');
insert into registro_compra (id_factura,id_producto,cantidad,id_proveedor,descripcion) values ('3','3','124','1','Compras varias');
insert into registro_compra (id_factura,id_producto,cantidad,id_proveedor,descripcion) values ('4','4','124','1','Compras varias');
insert into registro_compra (id_factura,id_producto,cantidad,id_proveedor,descripcion) values ('5','5','124','2','Compras varias');
insert into registro_compra (id_factura,id_producto,cantidad,id_proveedor,descripcion) values ('6','8','124','2','Compras varias');

insert into inventario (id_producto,id_bodega,cantidad) values ('1','1','50');
insert into inventario (id_producto,id_bodega,cantidad) values ('2','1','50');
insert into inventario (id_producto,id_bodega,cantidad) values ('3','2','124');
insert into inventario (id_producto,id_bodega,cantidad) values ('4','2','124');
insert into inventario (id_producto,id_bodega,cantidad) values ('5','3','124');
insert into inventario (id_producto,id_bodega,cantidad) values ('8','3','124');

