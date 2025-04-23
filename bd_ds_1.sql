create database BD_BCOLOGIN;

use BD_BCOLOGIN;

create table tb_usuario(
id_usu int(8) unsigned not null auto_increment primary key,
nome_usu varchar(50),
senha_usu varchar(15),
email_usu varchar(100)
);

insert into tb_usuario (nome_usu, senha_usu, email_usu) values ('Admin', '1234', 'Admin@etec')