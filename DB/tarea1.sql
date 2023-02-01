create database controldeusuario;

use controldeusuario;

create table usuarios(
ID_usuario int primary key,
nombre varchar(50),
apellido varchar(50),
correo varchar(90),
contraseña varchar(50),
roll varchar(50)
);

insert into usuarios values(1, 'Marcos', 'Apellido', 'marcos@gmail.com', 'marc6280','cliente');
insert into usuarios values(1, 'Marcos', 'Apellido', 'marcos@gmail.com', 'marc6280','Administrador');

drop table usuarios

select *from usuarios

