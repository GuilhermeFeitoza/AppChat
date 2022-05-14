if not exists(select * from sys.databases where name = 'AppChat')
    CREATE  DATABASE AppChat;
GO
CREATE TABLE tbLogin(Id int primary key identity ,
Nome varchar(20) not null,
Senha varchar(8) not null,
Ativo char(1) not null)


INSERT INTO tbLogin VALUES('admin','123','S');


