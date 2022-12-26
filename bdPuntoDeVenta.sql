DROP DATABASE puntodeventa;
CREATE DATABASE puntodeventa;
USE puntodeventa;

CREATE TABLE usuarios(
id INT AUTO_INCREMENT PRIMARY KEY,
usuario VARCHAR(20),
contrasena VARCHAR(100),
TipoUsuario VARCHAR(100));

CREATE TABLE almacen(
id INT auto_increment primary key,
nombre_razon_social VARCHAR(200),
comuna varchar(100));

CREATE TABLE productos(
CODIGO INT PRIMARY KEY,
PRODUCTO VARCHAR(100),
PRECIO DOUBLE,
STOCK DOUBLE);

CREATE TABLE ventas(
id int auto_increment primary key,
producto int,
usuario int,
almacen int,
fecha_hora varchar(20),
constraint fk_codigo_producto foreign key (producto) references productos(codigo),
constraint fk_id_usuario foreign key (usuario) references usuarios(id),
constraint fk_id_almacen foreign key (almacen) references almacen(id));

insert into productos values(00001,"CHOCMAN 350GR",12000.00, 20.00);
insert into productos values(00002,"TKCH 470GR",500.00, 50.00);
insert into usuarios values(00001,"admin","admin1","Administrador");
insert into usuarios values(00002,"franco","admin2","Cajero");
insert into almacen(nombre_razon_social) values("Doña Carmen");
insert into ventas(producto, usuario, almacen, fecha_hora) values(1,1,1,"01-12-2022 14:17");
insert into ventas(producto, usuario, almacen, fecha_hora) values(2,1,1,"01-12-2022 14:21");

SELECT * FROM usuarios;
SELECT * FROM almacen;

SELECT p.producto, u.usuario, a.nombre_razon_social
FROM ventas v 
inner join productos p, usuarios u, almacen a 
where p.codigo = v.producto 
GROUP BY v.id;

select LPAD(codigo, 5, '0'), producto, precio, stock from productos;

CREATE USER 'puntodeventa'@'%' IDENTIFIED BY 'puntodeventa';
flush privileges;
