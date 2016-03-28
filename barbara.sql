CREATE DATABASE if not exists libreria;


USE `libreria` ;

drop table if exists detalle_librocomprado;

drop table if exists compra;
drop table if exists cliente;
drop table if exists libro;


CREATE TABLE IF NOT EXISTS `libreria`.`libro` (
  `idlibro` INT NOT NULL AUTO_INCREMENT,
  `nombrelibro` VARCHAR(45) NOT NULL,
  `cantidad` INT NOT NULL,
  `precio` FLOAT NOT NULL,
  `autor` VARCHAR(45) NULL,
  `editorial` VARCHAR(45) NULL,
  `genero` VARCHAR(25) NOT NULL,
  `descripcion` VARCHAR(100) NOT NULL,
  PRIMARY KEY (`idlibro`))
ENGINE = InnoDB;


CREATE TABLE IF NOT EXISTS `libreria`.`cliente` (
  `ruc` VARCHAR(13) NOT NULL,
  `nombre` VARCHAR(100) NOT NULL,
  `telefono` VARCHAR(45) NULL,
  `direccion` VARCHAR(100) NULL,
  PRIMARY KEY (`ruc`))
ENGINE = InnoDB;


CREATE TABLE IF NOT EXISTS `libreria`.`compra` (
  `idcompra` INT NOT NULL,
  `ruclibreria` VARCHAR(13) NOT NULL,
  `subtotal` FLOAT NULL,
  `iva` FLOAT NULL,
  `total` FLOAT NULL,
  `rucCliente` VARCHAR(13) NOT NULL,
  PRIMARY KEY (`idcompra`),

  CONSTRAINT `ruc`
    FOREIGN KEY (`rucCliente`)
    REFERENCES `libreria`.`cliente` (`ruc`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


CREATE TABLE IF NOT EXISTS `libreria`.`detalle_librocomprado` (
  `iddetalle_librocomprado` INT NOT NULL AUTO_INCREMENT,
  `cantidad` INT NOT NULL,
  `libro` INT NOT NULL,
  `idcompra` INT NOT NULL,
  PRIMARY KEY (`iddetalle_librocomprado`) , 
    CONSTRAINT `libro`
    FOREIGN KEY (`libro`)
    REFERENCES `libreria`.`libro` (`idlibro`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `idcompra`
    FOREIGN KEY (`idcompra`)
    REFERENCES `libreria`.`compra` (`idcompra`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


#`idlibro`,`nombrelibro`,`cantidad`,`precio`,`autor`,`editorial`,`genero`,`descripcion`
INSERT INTO libro values('1','mama esta enojada','10','3.00','gabriel','el hocicon','sci fi','muy bonito el libro');
INSERT INTO libro values('2','tacita de te','3','5.50','barbara gallegos','tu librito','drama','es una taza de te muy bonita');
INSERT INTO libro values('3','un grito deseperado','4','9.90','carlos cuauhtecmoc sanchez','tu librito','drama','casi me deja sordo');
INSERT INTO libro values('4','juventud en extasis','6','9.90','carlos cuauhtecmoc sanchez','tu librito','drama','sin palabras');
INSERT INTO libro values('5','sinsajo','3','15.00','r.r tomlin','summit','sci fi','sin ajo y sin verduras');
INSERT INTO libro values('6','harry potter','5','20.00','j.k rowling','summit','sci fi','severus no debio morir');
INSERT INTO libro values('7','divergente','6','18.00','tiburinsin','summit','sci fi','ya se sabe que estan en marte');
INSERT INTO libro values('8','percy jackson','7','15.00','michael bay','paramount','sci fi','aun no le encuentro sentido');
INSERT INTO libro values('9','el caliz','3','20.00','j.k rowling','summit','sci fi','de fuego');
INSERT INTO libro values('10','la biblia','3','35.00','Dios','sbu','todos','los demás libros le quedan corto');
INSERT INTO libro values('11','major payne','2','10.00','payne jhonson','tu librito','comedia','te mata de risa o te mata el mayor');





select * from libro ;
insert into cliente values ('0923728792001','Barbara','0979717761', 'Coop.24 de agosto');


drop procedure if exists listarclientes;
drop procedure if exists verificarRuc;
drop procedure if exists añadirNuevoCliente;
drop procedure if exists mostrarfiltrogen;
DELIMITER //
create procedure listarclientes ()
begin
	select nombre from cliente;
end
//
DELIMITER ;


call listarclientes();

DELIMITER //
CREATE procedure verificarRUC(IN rucing varchar(30), OUT existeRUC int)
BEGIN
  if exists (SELECT * FROM cliente where cliente.ruc = rucing)
  THEN
	SET existeRUC := 1;
  else 
    SET existeRUC := 0;
END if;
end
 //
DELIMITER ;



DELIMITER //
CREATE procedure añadirNuevoCliente(IN ruc varchar(13), IN nombre VARCHAR(100),IN direccion VARCHAR(100),IN  telefono VARCHAR(100))
BEGIN
  INSERT INTO cliente values(ruc,nombre,direccion,telefono);
  COMMIT;
end
//
DELIMITER ;

select * from cliente

DELIMITER //
CREATE procedure mostrar()
BEGIN
  select * from libro;
  
  COMMIT;
end
//
DELIMITER ;

DELIMITER //
CREATE procedure mostrarfiltrogen(IN gene varchar(45), IN minim float, IN maxim float)
BEGIN


select * from libro where libro.genero= gene and libro.precio >= minim and libro.precio <= maxim;
  
COMMIT;
end
//
DELIMITER ;




DELIMITER //
CREATE procedure verificarLib(IN lib varchar(45), OUT existelib int)
BEGIN
  if exists (SELECT * FROM libro where libro.nombrelibro = lib)
  THEN
	SET existeLib := 1;
  else 
    SET existeLib := 0;
END if;
end
 //
DELIMITER ;

