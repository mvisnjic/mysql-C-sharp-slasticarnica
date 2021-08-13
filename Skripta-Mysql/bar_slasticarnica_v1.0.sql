-- PROJEKT IZ BAZE PODATAKA II, CAFFE BAR/SLASTIČARNICA
DROP DATABASE slastika;
CREATE DATABASE slastika;
USE slastika;

CREATE TABLE info (
	id INTEGER NOT NULL,
    ime_slasticarnice VARCHAR(25),
    broj_telefona VARCHAR(30) NOT NULL,
    adresa VARCHAR(35),
    grad CHAR(25),
    poštanski_broj INTEGER NOT NULL,
    PRIMARY KEY(id)
);

CREATE TABLE manager (
	id INTEGER AUTO_INCREMENT NOT NULL UNIQUE,
    sifra_m VARCHAR(11) NOT NULL UNIQUE,
	OIB VARCHAR(11) NOT NULL UNIQUE,
    ime CHAR(30),
    prezime CHAR(30),
	datum_zaposlenja DATETIME DEFAULT NOW(),
    placa INTEGER DEFAULT 6500,
    PRIMARY KEY(id),
    CHECK (placa >= 6500)
);
                        
CREATE TABLE zaposlenik (
	id INTEGER AUTO_INCREMENT UNIQUE,
    sifra_z VARCHAR(10) NOT NULL UNIQUE,
	OIB VARCHAR(11) NOT NULL UNIQUE,
    ime CHAR(30),
    prezime CHAR(25),
    datum_zaposlenja DATETIME DEFAULT NOW(),
    placa INTEGER DEFAULT 4500,
    PRIMARY KEY (id),
    CHECK (placa >= 4500)
);

CREATE TABLE pice (
	id INTEGER NOT NULL UNIQUE,
    vrsta_pica VARCHAR(30) NOT NULL, 
    ime VARCHAR(30),
    cijena NUMERIC(7,2),
    PRIMARY KEY (id)
);

CREATE TABLE desert(
	id INTEGER NOT NULL UNIQUE,
    vrsta_deserta VARCHAR(30) NOT NULL,
    ime VARCHAR(30),
    cijena NUMERIC(7,2),
    PRIMARY KEY (id)
); 

CREATE TABLE dodaci (	
	id INTEGER NOT NULL UNIQUE,
    vrsta_dodatka VARCHAR(30),
    ime_dodatka VARCHAR(30),
    cijena NUMERIC(7,2),
    PRIMARY KEY (id)
);

CREATE TABLE kupac (
	id INTEGER NOT NULL AUTO_INCREMENT UNIQUE PRIMARY KEY
);

CREATE TABLE stol (
	id INTEGER NOT NULL PRIMARY KEY UNIQUE AUTO_INCREMENT
);	
						
CREATE TABLE narudzba (
	id INTEGER NOT NULL PRIMARY KEY UNIQUE AUTO_INCREMENT,
    id_stol INTEGER NOT NULL,
    id_meni INTEGER,
    kolicina INTEGER NOT NULL,
    FOREIGN KEY (id_stol) REFERENCES stol(id)
);

CREATE TABLE racun (
	id INTEGER NOT NULL AUTO_INCREMENT PRIMARY KEY UNIQUE,
    id_zaposlenik INTEGER NOT NULL,
    id_kupac INTEGER NOT NULL,
    datum_izdavanja DATETIME DEFAULT NOW(),
    iznos_racuna NUMERIC (8,2),
    PDV NUMERIC(8,2),
    FOREIGN KEY (id_zaposlenik) REFERENCES zaposlenik(id),
    FOREIGN KEY (id_kupac) REFERENCES kupac(id)
);

/*********************** TABLICA U KOJOJ SU SVE NARUDŽBE STVORENE,PLAEČENE,BRISANE.. ***********************/
CREATE TABLE backup_narudzba (
	id INTEGER NOT NULL PRIMARY KEY UNIQUE AUTO_INCREMENT,
    id_stol INTEGER NOT NULL,
    id_meni INTEGER,
    kolicina INTEGER NOT NULL
);

/************************************************************ INSERTI ******************************************************************************************************************/
/******************************* INFO *************************************/
INSERT INTO info VALUES(1, 'ChocoLatte', '052 684 000', 'Rovinjska 14', 'Pula', 52100);

/**************************** MANAGERI ************************************/
INSERT INTO manager VALUES		(NULL, 100, '97999495939', 'Antonio', 'Banderas', str_to_date('01.10.2020.', '%d.%m.%Y.'), 7000),
								(NULL, 101, '54738264848', 'Marina', 'Lončar', str_to_date('01.10.2020.', '%d.%m.%Y.'), 7500),
                                (NULL, 102, '25738957839', 'Toni', 'Peruško', str_to_date('03.10.2020.', '%d.%m.%Y.'), 10000);
/**************************** ZAPOSLENICI *********************************/                            
INSERT INTO zaposlenik VALUES	(NULL, 11, '12345678910', 'Marko', 'Marić', str_to_date('01.10.2020.', '%d.%m.%Y.'), 6000),
								(NULL, 22, '94394839489', 'Branko', 'Kameni', str_to_date('01.10.2020.', '%d.%m.%Y.'), 5500),
                                (NULL, 33, '12434343434', 'Ivan', 'Kraljević', str_to_date('05.10.2020.', '%d.%m.%Y.'), 4500),
                                (NULL, 44, '56547675656', 'Maria', 'Miškulin', str_to_date('10.10.2020.', '%d.%m.%Y.'), 5000),
                                (NULL, 55, '87878655443', 'Matija', 'Pavić', str_to_date('12.10.2020.', '%d.%m.%Y.'), 4800),
                                (NULL, 66, '65435423434', 'Marin', 'Banani', DEFAULT, 4500),
                                (NULL, 77, '58685454343', 'Ana', 'Kramar', DEFAULT, 4500);	
                                
/*************** UNOS STOLOVA (AUTOINCREMENT) *****************************/
INSERT INTO stol VALUES (NULL);

/************INSERTI OD PICA, DESERTA I DODATAKA!*************************/
INSERT INTO pice VALUES (1, 'TOPLI NAPICI', 'Espresso', 6.00),
						(2, 'TOPLI NAPICI', 'Veliki macchiato', 9.00),
						(3, 'TOPLI NAPICI', 'Mali macchiato', 8.00),
                        (4, 'TOPLI NAPICI', 'Kava sa šlagom', 10.00),
						(5, 'TOPLI NAPICI', 'Bijela Kava', 12.00),
						(6, 'TOPLI NAPICI', 'Latte macchiato', 16.00),
                        (7, 'TOPLI NAPICI', 'Kakao', 12.00),
                        (8, 'TOPLI NAPICI', 'Topla Čokolada', 12.00),
                        (9, 'TOPLI NAPICI', 'Nescaffe Classic', 12.00),
                        (10, 'TOPLI NAPICI', 'Nescaffe s okusom', 12.00),
                        (11, 'ČAJEVI', 'Vočni čaj', 10.00),
                        (12, 'ČAJEVI', 'Zeleni čaj', 10.00),
                        (13, 'ČAJEVI', 'Indijski čaj', 10.00),
                        (14, 'ČAJEVI', 'Biljni čaj', 10.00),
                        (15, 'GAZIRANO', 'Coca-Cola 0.25', 17.00),
                        (16, 'GAZIRANO', 'Fanta 0.25', 17.00),
                        (17, 'GAZIRANO', 'Cola Light 0.25', 17.00),
                        (18, 'GAZIRANO', 'Schweppes 0.25', 17.00),
                        (19, 'GAZIRANO', 'Pepsi 0.25', 17.00),
                        (20, 'GAZIRANO', 'Sprite 0.25', 17.00),
                        (21, 'GAZIRANO', 'Točena cola 0.1', 6.00),
                        (22, 'GAZIRANO', 'Mineralna 0.25', 8.00),
                        (23, 'GAZIRANO', 'Mineralna 0.5', 15.00),
                        (24, 'GAZIRANO', 'Mineralna 1L', 30.00),
                        (25, 'GAZIRANO', 'Romerquelle 0.33', 10.00),
                        (26, 'GAZIRANO', 'Romerquelle 0.5', 20.00),
                        (27, 'GAZIRANO', 'Romerquelle 0.75', 25.00),
                        (28, 'NEGAZIRANO', 'Voda 0.5', 12.00),
                        (29, 'NEGAZIRANO', 'Cedevita', 12.00),
                        (30, 'NEGAZIRANO', 'Sok crni ribiz 0.2', 15.00),
                        (31, 'NEGAZIRANO', 'Sok jabuka 0.2', 15.00),
                        (32, 'NEGAZIRANO', 'Sok naranča 0.2', 15.00),
                        (33, 'NEGAZIRANO', 'Sok marelica 0.2', 15.00),
                        (34, 'NEGAZIRANO', 'Sok jagoda 0.2', 15.00),
                        (35, 'NEGAZIRANO', 'Sok točeni 0.1', 5.00),
                        (36, 'NEGAZIRANO', 'Red Bull', 25.00),
                        (37, 'PIVO', 'Točeno pivo 0.5', 22.00),
                        (38, 'PIVO', 'Točeno pivo 0.3', 17.00),
                        (39, 'PIVO', 'Točeno pivo 0.2', 15.00),
                        (40, 'PIVO', 'Ožujsko 0.5', 20.00),
                        (41, 'PIVO', 'Karlovačko 0.5', 20.00),
                        (42, 'PIVO', 'Laško 0.5', 20.00),
                        (43, 'PIVO', 'Heineken 0.33', 25.00),
                        (44, 'PIVO', 'Domaće pivo 0.5', 20.00),
                        (45, 'VINO', 'Vino 0.1', 10.00),
                        (46, 'VINO', 'Vino 0.75', 90.00),
                        (47, 'VINO', 'Merlot 0.75', 115.00),
                        (48, 'VINO', 'Malvazija', 130.00),
                        (49, 'VINO', 'Vino rose 0.1', 15.00),
                        (50, 'VINO', 'Šampanjac 0.1', 20.00),
                        (51, 'VINO', 'Šampanjac 0.75', 150.00),
                        (52, 'ŽESTOKA PIĆA', 'Jack Daniels 0.33', 25.00),
                        (53, 'ŽESTOKA PIĆA', 'Jeger 0.33', 25.00),
                        (54, 'ŽESTOKA PIĆA', 'Johnny Walker 0.33', 25.00),
                        (55, 'ŽESTOKA PIĆA', 'Stock 0.33', 18.00),
                        (56, 'ŽESTOKA PIĆA', 'Pelinkovac 0.33', 18.00),
                        (57, 'ŽESTOKA PIĆA', 'Vodka domaća 0.33', 14.00),
                        (58, 'ŽESTOKA PIĆA', 'Vodka belvedere 0.33', 40.00),
                        (59, 'ŽESTOKA PIĆA', 'Medenica 0.33', 12.00),
                        (60, 'ŽESTOKA PIĆA', 'Travarica 0.33', 12.00),
                        (61, 'ŽESTOKA PIĆA', 'Tequila 0.33 + limun i sol', 20.00);

INSERT INTO desert VALUES 	(100, 'SLADOLED', 'Kuglica', 10.00),
							(101, 'SLADOLED', 'Pola-pola kuglice', 11.00),
                            (102, 'KUPOVI', 'Čoko kup', 50.00),
                            (103, 'KUPOVI', 'Banana split', 50.00),
                            (104, 'KUPOVI', 'Vočni kup', 50.00),
                            (105, 'KUPOVI', 'Mix kup', 60.00),
                            (106, 'KUPOVI', 'Family kup', 120.00),
                            (107, 'PALAČINKE', 'Palačinke sa nutellom', 40.00),
                            (108, 'PALAČINKE', 'Palačinke sa marmeladom', 40.00),
                            (109, 'PALAČINKE', 'Palačinke sa sladoledom', 50.00),
                            (110, 'KOLAČI', 'Tiramisu', 20.00),
                            (111, 'KOLAČI', 'Ledena torta', 20.00),
                            (112, 'KOLAČI', 'Kremšnita', 20.00),
                            (113, 'KOLAČI', 'Suhi kolači mix', 30.00),
                            (114, 'KOLAČI', 'Čupavci', 30.00);
     
INSERT INTO dodaci VALUE  	(200, 'PALAČINKE', '+preljeva', 3.00),
							(201, 'PALAČINKE', '+šlag', 5.00),
                            (202, 'PALAČINKE', '+voće', 3.00),
                            (203, 'KOLAČI', '+preljeva', 3.00),
                            (204, 'KOLAČI', '+šlag', 5.00),
                            (205, 'KOLAČI', '+šećer', 3.00),
                            (206, 'SLADOLED', '+šlag', 5.00),
                            (207, 'SLADOLED', '+preljev', 3.00),
                            (208, 'SLADOLED', '+voće', 3.00);
			
/******************** DODACI - VIEWS ********************************/
CREATE VIEW dodaci_palacinke AS 
SELECT * FROM dodaci WHERE vrsta_dodatka = 'PALAČINKE';
CREATE VIEW dodaci_kolaci AS 
SELECT * FROM dodaci WHERE vrsta_dodatka = 'KOLAČI';
CREATE VIEW dodaci_sladoled AS 
SELECT * FROM dodaci WHERE vrsta_dodatka = 'SLADOLED';

/****************** VRSTA PIĆA - VIEWS ************************/
CREATE VIEW topli_napici AS
SELECT * FROM pice WHERE vrsta_pica='TOPLI NAPICI';
CREATE VIEW cajevi AS
SELECT * FROM pice WHERE vrsta_pica='ČAJEVI';
CREATE VIEW gazirano AS
SELECT * FROM pice WHERE vrsta_pica='GAZIRANO';
CREATE VIEW negazirano AS
SELECT * FROM pice WHERE vrsta_pica='NEGAZIRANO';
CREATE VIEW pivo AS
SELECT * FROM pice WHERE vrsta_pica='PIVO';
CREATE VIEW vino AS
SELECT * FROM pice WHERE vrsta_pica='VINO';
CREATE VIEW zestoka_pica AS
SELECT * FROM pice WHERE vrsta_pica='ŽESTOKA PIĆA';

/******************* VIEW-MENI ******************************/
CREATE VIEW meni AS
SELECT * FROM pice
UNION 
SELECT * FROM desert
UNION
SELECT * FROM dodaci;

/******************* VIEW- AKTIVNE NARUDŽBE ******************/
CREATE VIEW aktivne_narudzbe AS
SELECT id_stol AS broj_stola,ime,cijena,kolicina FROM meni m
INNER JOIN narudzba n ON m.id = n.id_meni
ORDER BY id_stol;

/************************USER'S*******************************/
CREATE USER manager IDENTIFIED BY 'manager';
SHOW GRANTS FOR manager;
GRANT ALL PRIVILEGES ON slastika.* TO manager;
GRANT SELECT,UPDATE,DELETE ON slasticarnica.* TO manager;
DROP USER manager;

CREATE USER zaposlenik IDENTIFIED BY 'zaposlenik';
GRANT SELECT ON slastika.racun TO zaposlenik;
drop user zaposlenik;

GRANT EXECUTE ON PROCEDURE slastika.ispis_racun TO 'zaposlenik';

/********************** PROCEDURA-ZA-NARUDZBU ****************/
DELIMITER //
CREATE PROCEDURE naruci(p_id_stol INTEGER,p_id_meni INTEGER, p_kolicina INTEGER)
BEGIN 
	DECLARE id_postoji INTEGER DEFAULT 0;
	DECLARE id_stol_postoji INTEGER DEFAULT 0;

	DECLARE EXIT HANDLER FOR SQLEXCEPTION
	BEGIN
	SELECT 'Procedura obustavljena, probajte ponovno!';
	END;

	SET SESSION TRANSACTION ISOLATION LEVEL READ COMMITTED;
	START TRANSACTION;

	SELECT id INTO id_postoji FROM meni
		WHERE id = p_id_meni;
	SELECT id INTO id_stol_postoji FROM stol
		WHERE id = p_id_stol;

	INSERT INTO narudzba (id_stol,id_meni,kolicina) VALUES (id_stol_postoji,id_postoji, p_kolicina);

	IF id_postoji != p_id_meni THEN 
		ROLLBACK;
		SELECT 'ID ne postoji, narudžba poništena!';
	ELSEIF id_stol_postoji != p_id_stol THEN
		ROLLBACK;
		SELECT 'ID stola ne postoji, narudžba poništena!';
	ELSEIF p_id_stol = 0 OR p_id_meni = 0 OR p_kolicina = 0 THEN
		ROLLBACK;
		SELECT 'ID stola/menija/kolicine je 0!';
	ELSE 
		COMMIT;
		SELECT 'Narudžba postavljena!';
	END IF;

END//
DELIMITER ;
DROP PROCEDURE naruci;
--     id_stol, id_meni, kolicina
CALL naruci(1, 1, 1);

/************ PROCEDURA-ZA-ISPIS-RACUNA ************************/
DELIMITER //
CREATE PROCEDURE ispis_racun (p_id_zaposlenik INTEGER, p_id_stol INTEGER) 
BEGIN 
	DECLARE kup INTEGER;
	DECLARE p_iznos_racuna NUMERIC(10,2);
	DECLARE PDV NUMERIC(10,2);

	SET SESSION TRANSACTION ISOLATION LEVEL READ COMMITTED;
	START TRANSACTION;

	INSERT INTO kupac VALUES (NULL);
	SELECT id INTO kup 
		FROM kupac
		WHERE id
		ORDER BY id DESC
		LIMIT 1; 
  
	SELECT SUM(cijena * kolicina) INTO p_iznos_racuna from narudzba n
		INNER JOIN meni m ON m.id = n.id_meni
		WHERE id_stol = p_id_stol;

	SELECT SUM(p_iznos_racuna * 0.25) INTO PDV FROM narudzba n INNER JOIN meni m ON m.id = n.id_meni
		WHERE id_stol = p_id_stol;


	INSERT INTO racun (id_zaposlenik,id_kupac,datum_izdavanja, iznos_racuna, PDV) VALUES (p_id_zaposlenik, kup, NOW(), p_iznos_racuna, PDV);
	IF p_iznos_racuna IS NULL THEN
		ROLLBACK;
		SELECT 'Stol je prazan! Nemoguće istipkati račun!';
	END IF;

	INSERT INTO backup_narudzba (SELECT * FROM narudzba WHERE id_stol = p_id_stol);
	DELETE FROM narudzba WHERE id_stol = p_id_stol;

	COMMIT;
END //
DELIMITER ;
--        id_zaposlenik, id_stol
CALL ispis_racun(3, 4);

/********************* PROCEDURA ZA BRISANJE NARUDŽBE **********************/
DELIMITER //
CREATE PROCEDURE obrisi_narudzbu (p_id INTEGER)
BEGIN
	DECLARE id_postoji INTEGER;
	
	SET SESSION TRANSACTION ISOLATION LEVEL READ COMMITTED;
    START TRANSACTION;
    
    IF p_id NOT IN (SELECT id FROM narudzba) THEN
		ROLLBACK;
		SELECT 'Došlo je do greške,id narudžbe ne postoji!';
	ELSE
		SELECT 'Narudžba obrisana!';
	END IF;
    
    DELETE FROM narudzba WHERE id=p_id;
    COMMIT;
END //
DELIMITER ;

CALL obrisi_narudzbu(4);

/****************** PROCEDURA ZA KOLIČINU ARTIKALA KOJI SU PRODANI*************/
DROP PROCEDURE kolicina_prodanog;
DELIMITER //
CREATE PROCEDURE kolicina_prodanog (IN p_id_meni INTEGER)
BEGIN
	     
	SELECT vrsta_pica,ime,SUM(kolicina) AS ukupno_prodano
		FROM backup_narudzba b
        INNER JOIN meni m ON m.id=b.id_meni
		WHERE id_meni=p_id_meni;
        
END //
DELIMITER ;

CALL kolicina_prodanog (1);  

/******************** PROCEDURA ZA LAKŠE PRETRAŽIVANJE MENI-a ******************/
DROP PROCEDURE sadrzi;
DELIMITER //
CREATE PROCEDURE sadrzi (p_ime VARCHAR(50))
BEGIN 

SELECT * FROM meni WHERE ime LIKE CONCAT('%', p_ime, '%');

END//
DELIMITER ;

CALL sadrzi('ess');

/********************** PROCEDURA ZA SNIŽENJE CIJENE ****************************/
DROP PROCEDURE snizi;
DELIMITER //
CREATE PROCEDURE snizi (p_popust DECIMAL (10,2))
BEGIN
    
    UPDATE pice
		SET cijena = cijena - cijena * p_popust;
	
    UPDATE desert
		SET cijena = cijena - cijena * p_popust;

END //
DELIMITER ;

CALL snizi (0.5);

/*********************** PROCEDURA ZA POVEĆANJE CIJENE***************************/
DROP PROCEDURE povecaj
DELIMITER //
CREATE PROCEDURE povecaj (p_popust DECIMAL (10,2))
BEGIN
    
    UPDATE pice
		SET cijena = cijena + cijena * p_popust;

	UPDATE desert
		SET cijena = cijena + cijena * p_popust;
        
END //
DELIMITER ;

CALL povecaj (1.0);

/*********** PROCEDURA ZA RAČUNANJE IZDANIH RAČUNA POJEDINOG ZAPOSLENIKA (bez PDV-a) ***************/
DROP PROCEDURE naj_zaposlenik;
DELIMITER //
CREATE PROCEDURE naj_zaposlenik ()
BEGIN

    SELECT ime,prezime,SUM(iznos_racuna) AS ukupan_iznos_racuna,COUNT(id_zaposlenik) AS broj_izdanih_racuna
		FROM racun r
        INNER JOIN zaposlenik z ON z.id=r.id_zaposlenik
		GROUP BY z.id;

END //
DELIMITER ;

CALL naj_zaposlenik();

/*********************** PROCEDURA ZA DODAVANJE ZAPOSLENIKA *********************/
DROP PROCEDURE dodaj_zaposlenika;
DELIMITER //
CREATE PROCEDURE dodaj_zaposlenika (p_sifra_z VARCHAR(10), p_oib VARCHAR(11), p_ime CHAR(30), p_prezime CHAR(25),p_placa INTEGER)
BEGIN
	
    DECLARE EXIT HANDLER FOR 1062
	BEGIN
	ROLLBACK;
	SELECT CONCAT('Zaposlenik sa oibom "', p_oib, '" već postoji!');
	END;
    
    SET SESSION TRANSACTION ISOLATION LEVEL READ COMMITTED;
    START TRANSACTION;
    
    INSERT INTO zaposlenik (id,sifra_z, OIB, ime, prezime,datum_zaposlenja,placa) VALUES (NULL, p_sifra_z, p_oib, p_ime, p_prezime, NOW(), p_placa);

	COMMIT;
END //
DELIMITER ;

CALL dodaj_zaposlenika ('11', '22345678910', 'Ivan', 'Ivić', 4555);

/*********************** PROCEDURA ZA BRISANJE ZAPOSLENIKA ********************/
DROP PROCEDURE obrisi_zaposlenika;
DELIMITER //
CREATE PROCEDURE obrisi_zaposlenika (p_sifra_z VARCHAR(10))
BEGIN
	DECLARE sifra_postoji VARCHAR(10);
    
    SET SESSION TRANSACTION ISOLATION LEVEL READ COMMITTED;
    START TRANSACTION;
        
    IF p_sifra_z NOT IN (SELECT sifra_z FROM zaposlenik) THEN
    ROLLBACK;
		SELECT 'Došlo je do greške, šifra zaposlenika ne postoji!';
	ELSE 
		SELECT 'Zaposlenik obrisan';
    END IF;
    
	DELETE FROM zaposlenik WHERE p_sifra_z=sifra_z;
    
    COMMIT;
END //
DELIMITER ;

CALL obrisi_zaposlenika('88');

/********************* PROCEDURA ZA DODAVANJE PICA/DESERTA ********************/

DROP PROCEDURE dodaj;
DELIMITER //
CREATE PROCEDURE dodaj (p_id INTEGER, p_vrsta VARCHAR(30), p_ime VARCHAR(30), p_cijena NUMERIC(7,2))
BEGIN
	DECLARE p_vrsta_pica VARCHAR(30);
    DECLARE p_vrsta_deserta VARCHAR(30);
   
	SET SESSION TRANSACTION ISOLATION LEVEL READ COMMITTED;
	START TRANSACTION;
	
    SELECT vrsta_pica INTO p_vrsta_pica
		FROM pice
        WHERE vrsta_pica=p_vrsta
        LIMIT 1;
	SELECT vrsta_deserta INTO p_vrsta_deserta
		FROM desert
        WHERE vrsta_deserta=p_vrsta
        LIMIT 1;
    
    IF p_vrsta = p_vrsta_pica THEN
		INSERT INTO pice VALUES (p_id, p_vrsta, p_ime, p_cijena);
	ELSEIF p_vrsta = p_vrsta_deserta THEN 
		INSERT INTO desert VALUES (p_id, p_vrsta, p_ime, p_cijena);
	ELSEIF p_vrsta NOT IN (SELECT vrsta_pica FROM pice) AND p_vrsta NOT IN (SELECT vrsta_deserta FROM desert) THEN
		ROLLBACK;
		SELECT 'Vrsta pića/deserta ne postoji!';
	END IF;
    
    COMMIT;
    
END //
DELIMITER ;

CALL dodaj (12, 'test' , 'Kup', 50.00);

/********************* PROCEDURA ZA BRISANJE IZ MENI-a *************************/
DROP PROCEDURE obrisi_iz_meni;
DELIMITER //
CREATE PROCEDURE obrisi_iz_meni (p_id INTEGER)
BEGIN

	DECLARE pice_id_postoji INTEGER;
	DECLARE desert_id_postoji INTEGER;
	DECLARE dodaci_id_postoji INTEGER;

	SET SESSION TRANSACTION ISOLATION LEVEL READ COMMITTED;
    START TRANSACTION;
    
    SELECT id INTO pice_id_postoji
		FROM pice
        WHERE p_id = id;
	SELECT id INTO desert_id_postoji
		FROM desert
        WHERE p_id = id;
	SELECT id INTO dodaci_id_postoji
		FROM dodaci
        WHERE p_id = id;
    
    IF p_id = pice_id_postoji THEN
		DELETE FROM pice WHERE p_id=id;
	ELSEIF p_id = desert_id_postoji THEN
		DELETE FROM desert WHERE p_id=id;
	ELSEIF p_id = dodaci_id_postoji THEN
		DELETE FROM dodaci WHERE p_id=id;
	ELSEIF p_id NOT IN (SELECT id FROM pice) AND p_id NOT IN (SELECT id FROM desert) AND p_id NOT IN (SELECT id FROM dodaci) THEN
		ROLLBACK;
		SELECT 'Došlo je do greške,ID ne postoji!';
	ELSE 
		SELECT 'Obrisano!';
    END IF;
    
	DELETE  FROM pice WHERE p_id = id;
	    
	COMMIT;
END //
DELIMITER ;
CALL obrisi_iz_meni (1);
