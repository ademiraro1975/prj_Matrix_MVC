create database MATRIZDB
GO
use MATRIZDB
go
create schema pizzaria
go
create table pizzaria.tabelaPreco(
	tabelaPrecoId int identity(1,1),
	preco decimal(10,2) not null,
	primary key (tabelaPrecoId)
);
go
create table pizzaria.tamanho(
	tamanhoId int identity(1,1),
	descricao varchar(100) not null,
	numPedaco int not null,
	primary key (tamanhoId)
);
go
create table pizzaria.tipo(
	tipoId int identity(1,1),
	descricao varchar(100) not null,
	primary key(tipoId)
);
go
create table pizzaria.pizza(
	pizzaId int identity(1,1),
	nome varchar(100) not null,
	descricao varchar(100) not null,
	primary key(pizzaId)
);
go
create table pizzaria.pizzaDetalhe(
	pizzaDetalheId int identity(1,1),
	pizzaId int not null,
	tabelaPrecoId int not null,
	tamanhoId int not null,
	tipoId int not null,
	primary key (pizzaDetalheId),
	FOREIGN KEY (pizzaId) REFERENCES pizzaria.pizza(pizzaId),
	FOREIGN KEY (tabelaPrecoId) REFERENCES pizzaria.tabelaPreco(tabelaPrecoId),
	FOREIGN KEY (tamanhoId) REFERENCES pizzaria.tamanho(tamanhoId),
	FOREIGN KEY (tipoId) REFERENCES pizzaria.tipo(tipoId)
);
go
create table pizzaria.ingrediente(
	ingredienteId int identity(1,1),
	ingrediente varchar(100) not null,
	primary key(ingredienteId)
);
go
create table pizzaria.pizzaIngrediente(
	pizzaIngredienteId int identity(1,1),
	pizzaId int not null,
	ingredienteId int not null,
	primary key (pizzaIngredienteId),
	FOREIGN KEY (pizzaId) REFERENCES pizzaria.pizza(pizzaId),
	FOREIGN KEY (ingredienteId) REFERENCES pizzaria.ingrediente(ingredienteId)
);
go
create table pizzaria.fotoPizza(
	fotoPizzaId int identity(1,1),
	pizzaId int not null,
	foto varchar(100) not null
	primary key (fotoPizzaId),
	FOREIGN KEY (pizzaId) REFERENCES pizzaria.pizza(pizzaId)
);
go
create table pizzaria.refrigerante(
	refrigeranteId int identity(1,1),
	nome varchar(100) not null,
	descricao varchar(100) not null,
	primary key(refrigeranteId)
);
go
create table pizzaria.refrigeranteDetalhe(
	refrigeranteDetalheId int identity(1,1),
	refrigeranteId int not null,
	tabelaPrecoId int not null,
	tamanhoId int not null,
	tipoId int not null,
	primary key (refrigeranteDetalheId),
	FOREIGN KEY (refrigeranteId) REFERENCES pizzaria.refrigerante(refrigeranteId),
	FOREIGN KEY (tabelaPrecoId) REFERENCES pizzaria.tabelaPreco(tabelaPrecoId),
	FOREIGN KEY (tamanhoId) REFERENCES pizzaria.tamanho(tamanhoId),
	FOREIGN KEY (tipoId) REFERENCES pizzaria.tipo(tipoId)
);
go
create table pizzaria.fotoRefrigerante(
	fotoRefrigeranteId int identity(1,1),
	refrigeranteId int not null,
	foto varchar(100) not null
	primary key (fotoRefrigeranteId),
	FOREIGN KEY (refrigeranteId) REFERENCES pizzaria.refrigerante(refrigeranteId)
);
GO
SELECT * FROM pizzaria.pizza