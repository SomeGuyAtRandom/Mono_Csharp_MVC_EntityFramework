DROP DATABASE IF EXISTS mvc5;
CREATE DATABASE mvc5;
USE mvc5;

CREATE TABLE people (
  id int(11) NOT NULL AUTO_INCREMENT,
  first_name varchar(20) DEFAULT NULL,
  last_name varchar(20) DEFAULT NULL,
  birth_date date DEFAULT NULL,
  PRIMARY KEY (id)
); 

