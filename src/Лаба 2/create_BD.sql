-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema pharmacy
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema pharmacy
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `pharmacy` DEFAULT CHARACTER SET utf8 ;
USE `pharmacy` ;

-- -----------------------------------------------------
-- Table `pharmacy`.`role`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `pharmacy`.`role` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(50) NOT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `pharmacy`.`pharmacy_schedule`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `pharmacy`.`pharmacy_schedule` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `opening_time` TIME NOT NULL,
  `ending_time` TIME NOT NULL,
  `opening_time_on_weekands` TIME NOT NULL,
  `ending_time_on_weekands` TIME NOT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `pharmacy`.`pharmacy`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `pharmacy`.`pharmacy` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(100) NOT NULL,
  `address` VARCHAR(150) NOT NULL,
  `phone_number` VARCHAR(13) NOT NULL,
  `pharmacy_schedule_id` INT NOT NULL DEFAULT 1,
  PRIMARY KEY (`id`),
  INDEX `fk_pharmacy_pharmacy_schedule1_idx` (`pharmacy_schedule_id` ASC) VISIBLE,
  CONSTRAINT `fk_pharmacy_pharmacy_schedule1`
    FOREIGN KEY (`pharmacy_schedule_id`)
    REFERENCES `pharmacy`.`pharmacy_schedule` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `pharmacy`.`users`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `pharmacy`.`users` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(100) NOT NULL,
  `birth_day` DATE NOT NULL,
  `phone_number` VARCHAR(13) NOT NULL,
  `login` VARCHAR(45) NOT NULL,
  `password` VARCHAR(45) NOT NULL,
  `role_id` INT NOT NULL DEFAULT 1,
  `pharmacy_id` INT NULL DEFAULT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_users_role1_idx` (`role_id` ASC) VISIBLE,
  INDEX `fk_users_pharmacy1_idx` (`pharmacy_id` ASC) VISIBLE,
  CONSTRAINT `fk_users_role1`
    FOREIGN KEY (`role_id`)
    REFERENCES `pharmacy`.`role` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_users_pharmacy1`
    FOREIGN KEY (`pharmacy_id`)
    REFERENCES `pharmacy`.`pharmacy` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `pharmacy`.`medicine_factory`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `pharmacy`.`medicine_factory` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(100) NOT NULL,
  `address` VARCHAR(150) NOT NULL,
  `phone_number` VARCHAR(13) NOT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `pharmacy`.`category`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `pharmacy`.`category` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(100) NOT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `pharmacy`.`medicines`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `pharmacy`.`medicines` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(100) NOT NULL,
  `costs` INT NOT NULL,
  `on_prescription` TINYINT NOT NULL,
  `expiration_date` VARCHAR(100) NOT NULL,
  `volume` VARCHAR(40) NOT NULL,
  `units_of_measurement` VARCHAR(45) NOT NULL,
  `primary_packaging` VARCHAR(100) NOT NULL,
  `active_substance` VARCHAR(150) NOT NULL,
  `special_properties` VARCHAR(150) NOT NULL,
  `release_form` VARCHAR(100) NOT NULL,
  `medicine_factory_id` INT NOT NULL,
  `category_id` INT NOT NULL DEFAULT 1,
  PRIMARY KEY (`id`),
  INDEX `fk_medicines_medicine_factory1_idx` (`medicine_factory_id` ASC) VISIBLE,
  INDEX `fk_medicines_category1_idx` (`category_id` ASC) VISIBLE,
  CONSTRAINT `fk_medicines_medicine_factory1`
    FOREIGN KEY (`medicine_factory_id`)
    REFERENCES `pharmacy`.`medicine_factory` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_medicines_category1`
    FOREIGN KEY (`category_id`)
    REFERENCES `pharmacy`.`category` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `pharmacy`.`medicines_has_pharmacy`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `pharmacy`.`medicines_has_pharmacy` (
  `count` INT NOT NULL DEFAULT 0,
  `medicines_id` INT NOT NULL,
  `pharmacy_id` INT NOT NULL DEFAULT 1,
  INDEX `fk_medicines_has_pharmacy_pharmacy1_idx` (`pharmacy_id` ASC) VISIBLE,
  PRIMARY KEY (`medicines_id`, `pharmacy_id`),
  CONSTRAINT `fk_medicines_has_pharmacy_medicines1`
    FOREIGN KEY (`medicines_id`)
    REFERENCES `pharmacy`.`medicines` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_medicines_has_pharmacy_pharmacy1`
    FOREIGN KEY (`pharmacy_id`)
    REFERENCES `pharmacy`.`pharmacy` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `pharmacy`.`status`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `pharmacy`.`status` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `pharmacy`.`basket_has_users`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `pharmacy`.`basket_has_users` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `date` DATETIME NOT NULL,
  `count` INT NOT NULL,
  `costs` INT NOT NULL,
  `pharmacy_id` INT NOT NULL DEFAULT 1,
  `basket_number` INT NOT NULL,
  `users_id` INT NOT NULL,
  `status_id` INT NOT NULL DEFAULT 1,
  `medicines_id` INT NOT NULL,
  INDEX `fk_basket_has_users_users1_idx` (`users_id` ASC) VISIBLE,
  INDEX `fk_basket_has_users_status1_idx` (`status_id` ASC) INVISIBLE,
  INDEX `fk_basket_has_users_medicines1_idx` (`medicines_id` ASC) VISIBLE,
  PRIMARY KEY (`id`, `pharmacy_id`, `basket_number`, `users_id`),
  CONSTRAINT `fk_basket_has_users_pharmacy1`
    FOREIGN KEY (`pharmacy_id`)
    REFERENCES `pharmacy`.`pharmacy` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_basket_has_users_users1`
    FOREIGN KEY (`users_id`)
    REFERENCES `pharmacy`.`users` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_basket_has_users_status1`
    FOREIGN KEY (`status_id`)
    REFERENCES `pharmacy`.`status` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_basket_has_users_medicines1`
    FOREIGN KEY (`medicines_id`)
    REFERENCES `pharmacy`.`medicines` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
