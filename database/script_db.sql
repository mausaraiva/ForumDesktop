-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Schema db_forum
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema db_forum
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `db_forum` DEFAULT CHARACTER SET utf8 ;
USE `db_forum` ;

-- -----------------------------------------------------
-- Table `db_forum`.`usuario`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `db_forum`.`usuario` (
  `usu_login` VARCHAR(15) NOT NULL,
  `usu_nome` VARCHAR(100) NOT NULL,
  `usu_email` VARCHAR(150) NOT NULL,
  `usu_senha` VARCHAR(60) NOT NULL,
  PRIMARY KEY (`usu_login`))
ENGINE = InnoDB;

-- -----------------------------------------------------
-- Table `db_forum`.`tema`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `db_forum`.`tema` (
  `tem_id` INT NOT NULL AUTO_INCREMENT,
  `tem_descricao` VARCHAR(250) NOT NULL,
  `tem_momento` DATETIME NOT NULL,
  `usu_login` VARCHAR(15) NOT NULL,
  PRIMARY KEY (`tem_id`),
  INDEX `fk_tema_usuario_idx` (`usu_login` ASC),
  CONSTRAINT `fk_tema_usuario`
    FOREIGN KEY (`usu_login`)
    REFERENCES `db_forum`.`usuario` (`usu_login`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;

-- -----------------------------------------------------
-- Table `db_forum`.`comentario`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `db_forum`.`comentario` (
  `com_id` INT NOT NULL AUTO_INCREMENT,
  `com_descricao` VARCHAR(2000) NOT NULL,
  `com_momento` DATETIME NULL,
  `usu_login` VARCHAR(15) NOT NULL,
  `tem_id` INT NOT NULL,
  PRIMARY KEY (`com_id`),
  INDEX `fk_comantario_usuario1_idx` (`usu_login` ASC),
  INDEX `fk_comantario_tema1_idx` (`tem_id` ASC),
  CONSTRAINT `fk_comantario_usuario1`
    FOREIGN KEY (`usu_login`)
    REFERENCES `db_forum`.`usuario` (`usu_login`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_comantario_tema1`
    FOREIGN KEY (`tem_id`)
    REFERENCES `db_forum`.`tema` (`tem_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;



