-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
-- -----------------------------------------------------
-- Schema bankdb
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema bankdb
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `bankdb` DEFAULT CHARACTER SET utf8 ;
USE `bankdb` ;

-- -----------------------------------------------------
-- Table `bankdb`.`clients`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `bankdb`.`clients` (
  `cnp` VARCHAR(45) NOT NULL,
  `name` VARCHAR(45) NULL DEFAULT NULL,
  `account_id` VARCHAR(45) NULL DEFAULT NULL,
  `type` VARCHAR(45) NULL DEFAULT NULL,
  `address` VARCHAR(45) NULL DEFAULT NULL,
  `date_creation` DATETIME NULL DEFAULT NULL,
  PRIMARY KEY (`cnp`),
  UNIQUE INDEX `card_id_UNIQUE` (`account_id` ASC))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `bankdb`.`accounts`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `bankdb`.`accounts` (
  `id_account` VARCHAR(45) NOT NULL,
  `balance` FLOAT NULL DEFAULT NULL,
  `id_client` VARCHAR(45) NULL DEFAULT NULL,
  PRIMARY KEY (`id_account`),
  INDEX `id_client_idx` (`id_client` ASC),
  CONSTRAINT `id_client`
    FOREIGN KEY (`id_client`)
    REFERENCES `bankdb`.`clients` (`account_id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `bankdb`.`login_accounts`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `bankdb`.`login_accounts` (
  `user` VARCHAR(40) NOT NULL,
  `password` VARCHAR(45) NOT NULL,
  `type` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`user`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8;


-- -----------------------------------------------------
-- Table `bankdb`.`transactions`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `bankdb`.`transactions` (
  `transaction_id` INT(11) NOT NULL AUTO_INCREMENT,
  `amount` FLOAT UNSIGNED ZEROFILL NULL DEFAULT NULL,
  `date` DATETIME NULL DEFAULT NULL,
  `account_id` VARCHAR(45) NULL DEFAULT NULL,
  `transfer_id` VARCHAR(45) NULL DEFAULT NULL,
  `madeby` VARCHAR(45) NULL DEFAULT NULL,
  PRIMARY KEY (`transaction_id`),
  INDEX `account_id_idx` (`account_id` ASC),
  CONSTRAINT `account_id`
    FOREIGN KEY (`account_id`)
    REFERENCES `bankdb`.`accounts` (`id_account`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
AUTO_INCREMENT = 10
DEFAULT CHARACTER SET = utf8;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
