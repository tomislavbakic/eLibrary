create database elibrary

go

use elibrary


create table korisnik
(
	id int identity(1,1) not null,
	ime varchar(50) not null,
	prezime varchar(50) not null,
	adresa varchar(50) not null,
	email varchar(50) not null,
	brojTelefona varchar(15) not null,
	username varchar(20) not null,
	password varchar(50) not null,
	uloga varchar(50) not null
	primary key(id)
)

create table autor
(
	id int identity(1,1) not null,
	ime varchar(50) not null,
	prezime varchar(50),
	primary key(id),
)


create table knjiga
(
	id int identity(1,1) not null,
	naslov varchar(50) not null,
	idAutora int not null,
	godinaIzdanja int not null,
	kolicina int not null,
	primary key(id),
	foreign key (idAutora) references autor(id)
)

create table zaduzenje
(
	id int identity(1,1) not null,
	sifraKnjige int not null,
	sifraKorisnika int not null,
	datumZaduzenja date not null,
	primary key(id),
	foreign key(sifraKnjige) references knjiga(id),
	foreign key(sifraKorisnika) references korisnik(id)
)


insert into korisnik values('Tomislav','Bakic','Potocanje','bakic.tomislav@gmail.com','066421962','tomo','tomo98','admin');

insert into korisnik values('Marko','Pekovic','Mojsinje','mare.pek@gmail.com','0614578965','mare','mare11','clan');
insert into korisnik values('Ilija','Garasanin','Petrovac','ilija@gmail.com','0664214568','gari','gari98','clan');
insert into korisnik values('Nikola','Mitrovic','Mitrovac','nik.mitar@gmail.com','062135465','nixa11','nixa11','clan');

select * from korisnik;


insert into autor values ('Ivo','Andric');

insert into autor values ('Mesa','Selimovic');
insert into autor values ('Renato','Karizi');
insert into autor values ('Vuk','Draskovic');
insert into autor values ('Vanja','Bulic');
insert into autor values ('Agata','Kristi');
insert into autor values ('Dzejms','Paterson');
insert into autor values ('Franc','Kafka');
insert into autor values ('Dobrica','Cosic');
insert into autor values ('Milos','Crnjanski');
insert into autor values ('Trevor','Rejvenskroft');


select * from autor;

insert into knjiga values ('Na Drini cuprija',1,1980,2);
insert into knjiga values ('Goja',1,1958,1);
insert into knjiga values ('Aska i vuk',1,1965,2);
insert into knjiga values ('Znakovi pored puta',1,1980,2);
insert into knjiga values ('Prokleta avlija',1,1980,5);

select naslov,concat(ime,' ',prezime) as autor,godinaIzdanja from knjiga join autor on knjiga.idAutora = autor.id;
