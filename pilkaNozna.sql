IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE table_name='gracz')
DROP TABLE gracz;
IF EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE table_name='druzyna')
DROP TABLE druzyna;

CREATE TABLE druzyna (
  id INT IDENTITY(1,1) PRIMARY KEY,
  nazwa VARCHAR(15) UNIQUE,
  miasto VARCHAR(20) CHECK(LEN(miasto)>2)
);


CREATE TABLE gracz (
  id INT IDENTITY(1,1) PRIMARY KEY,
  druzyna_id INT NOT NULL REFERENCES druzyna(id),
  pozycja VARCHAR NOT NULL CHECK(LEN(pozycja)>2),
  imie VARCHAR(15) NOT NULL CHECK(LEN(imie)>2),
  nazwisko VARCHAR(20) NOT NULL CHECK(LEN(nazwisko)>2),
  data_ur DATETIME NOT NULL CHECK(data_ur<GETDATE()),
  notatka TEXT NULL,
  zdjecie image NULL
);


INSERT INTO druzyna(nazwa, miasto) VALUES
('Lechia','Gdańsk'),
('Legia','Warszawa'),
('Lech','Poznań'),
('Raków','Czestochowa'),
('Gornik','Zabrze'),
('Jagielonia','Białystok');



INSERT INTO gracz(druzyna_id, pozycja, imie, nazwisko, data_ur) VALUES
(1,'Napastnik','Flávio','Paixão','1984-09-19'),
(1,'Bramkarz','Dušan','Kuciak','1985-05-21'),
(2,'Pomocnik','Bartosz','Kapustka','1996-12-23'),
(2,'Obronca','Artur','Jędrzejczyk','1987-11-04'),
(3,'Napastnik','Mikael','Ishak','1993-03-31'),
(3,'Bramkarz','Rud´ko','Eminencja','1992-05-07'),
(4, 'Pomocnik', 'Marcin', 'Cebula', '1994-01-08'), 
(4, 'Pomocnik', 'Alan', 'Czerwiński', '1998-01-24'),
(5, 'Napastnik', 'Szymon', 'Matuszek', '1997-07-15'), 
(5, 'Pomocnik', 'Erik', 'Janza', '1992-08-03'),
(6, 'Pomocnik', 'Bartosz', 'Bida', '1996-03-28'),
(6, 'Pomocnik', 'Piotr', 'Wlazło', '1996-05-13');



UPDATE gracz SET zdjecie=(SELECT BulkColumn FROM OPENROWSET (BULK 'E:\Zajęcia .NET 13.04.2023\zdjecia_projekt\Lechia.jpg', SINGLE_BLOB) a) WHERE id=1;
UPDATE gracz SET zdjecie=(SELECT BulkColumn FROM OPENROWSET (BULK 'E:\Zajęcia .NET 13.04.2023\zdjecia_projekt\Legia.jpg', SINGLE_BLOB) a) WHERE id=2;
UPDATE gracz SET zdjecie=(SELECT BulkColumn FROM OPENROWSET (BULK 'E:\Zajęcia .NET 13.04.2023\zdjecia_projekt\Lech.jpg', SINGLE_BLOB) a) WHERE id=3;
UPDATE gracz SET zdjecie=(SELECT BulkColumn FROM OPENROWSET (BULK 'E:\Zajęcia .NET 13.04.2023\zdjecia_projekt\Rakow.jpg', SINGLE_BLOB) a) WHERE id=4;
UPDATE gracz SET zdjecie=(SELECT BulkColumn FROM OPENROWSET (BULK 'E:\Zajęcia .NET 13.04.2023\zdjecia_projekt\Gornik.png', SINGLE_BLOB) a) WHERE id=5;
UPDATE gracz SET zdjecie=(SELECT BulkColumn FROM OPENROWSET (BULK 'E:\Zajęcia .NET 13.04.2023\zdjecia_projekt\Jagielonia.jpg', SINGLE_BLOB) a) WHERE id=6;

