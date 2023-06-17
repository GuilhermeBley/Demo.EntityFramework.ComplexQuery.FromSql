CREATE SCHEMA `demo_ef_compq`;

CREATE TABLE `sales` (
   `Id` char(36) NOT NULL,
   `Description` varchar(45) NOT NULL,
   `Value` double NOT NULL,
   `Date` datetime NOT NULL,
   `CustomerId` char(36) NOT NULL,
   PRIMARY KEY (`Id`),
   KEY `fk_sales_customer_idx` (`CustomerId`),
   CONSTRAINT `fk_sales_customer` FOREIGN KEY (`CustomerId`) REFERENCES `customer` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
 ) ENGINE=InnoDB DEFAULT CHARSET=latin1

 CREATE TABLE `customer` (
   `id` char(36) NOT NULL,
   `Name` varchar(45) NOT NULL,
   `Address` varchar(45) DEFAULT NULL,
   PRIMARY KEY (`id`)
 ) ENGINE=InnoDB DEFAULT CHARSET=latin1;

