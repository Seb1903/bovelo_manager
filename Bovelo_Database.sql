-- MySQL dump 10.13  Distrib 8.0.23, for Win64 (x86_64)
--
-- Host: 193.191.240.67    Database: bovelo
-- ------------------------------------------------------
-- Server version	8.0.23-0ubuntu0.20.04.1

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `bike`
--

DROP TABLE IF EXISTS `bike`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `bike` (
  `id` int NOT NULL AUTO_INCREMENT,
  `type` varchar(45) NOT NULL,
  `size` varchar(65) NOT NULL,
  `color` varchar(65) NOT NULL,
  `cstr_status` varchar(45) NOT NULL DEFAULT 'Not active',
  `model` int NOT NULL DEFAULT '1',
  PRIMARY KEY (`id`),
  UNIQUE KEY `id_bike_UNIQUE` (`id`),
  KEY `fk_model_id_idx` (`model`),
  CONSTRAINT `fk_model_id` FOREIGN KEY (`model`) REFERENCES `model_catalog` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=125 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bike`
--

LOCK TABLES `bike` WRITE;
/*!40000 ALTER TABLE `bike` DISABLE KEYS */;
INSERT INTO `bike` VALUES (1,'Explorer','26\"','Light Blue','Active',9),(2,'Explorer','28\"','Dark blue','Active',11),(3,'Explorer','28\"','Dark blue','Not active',11),(4,'City','26\"','Black','Not active',1),(5,'City','26\"','Black','Not active',1),(6,'City','26\"','Black','Not active',1),(7,'Adventure','28\"','Light Blue','Not active',15),(8,'Adventure','28\"','Light Blue','Not active',15),(9,'Adventure','28\"','Black','Not active',16),(10,'Adventure','28\"','Black','Not active',16),(11,'Adventure','28\"','Black','Not active',16),(12,'Adventure','28\"','Black','Not active',16),(13,'City','26\"','Light Blue','Not active',3),(14,'Adventure','28\"','Black','Not active',16),(15,'Explorer','26\"','Dark blue','Not active',8),(16,'Explorer','26\"','Dark blue','Not active',8),(17,'Explorer','26\"','Dark blue','Not active',8),(18,'City','26\"','Dark Blue','Not active',2),(19,'City','26\"','Light Blue','Not active',3),(20,'Adventure','28\"','Black','Not active',16),(21,'City','28\"','Light Blue','Not active',6),(22,'City','28\"','Black','Not active',4),(23,'City','28\"','Black','Not active',4),(24,'City','28\"','Black','Not active',4),(40,'City','28\"','Light Blue','Not active',5),(41,'City','28\"','Light Blue','Not active',5),(42,'Explorer','26\"','Black','Not active',7),(43,'Explorer','28\"','Dark Blue','Not active',11),(44,'Explorer','28\"','Dark Blue','Not active',11),(45,'Explorer','28\"','Dark Blue','Done',11),(46,'Explorer','28\"','Black','Active',10),(47,'Explorer','28\"','Black','Done',10),(48,'Explorer','28\"','Black','Not active',10),(49,'City','28\"','Black','Not active',4),(50,'City','28\"','Black','Not active',4),(51,'City','28\"','Black','Not active',4),(52,'City','28\"','Black','Not active',4),(53,'City','28\"','Black','Not active',4),(54,'City','28\"','Black','Not active',4),(55,'City','28\"','Black','Done',4),(56,'City','28\"','Black','Done',4),(57,'City','28\"','Black','Not active',4),(58,'Adventure','26\"','Black','Not active',16),(59,'Adventure','26\"','Black','Done',16),(60,'Adventure','26\"','Black','Not active',16),(61,'Adventure','26\"','Black','Not active',16),(62,'Adventure','26\"','Black','Not active',16),(63,'Adventure','26\"','Black','Not active',16),(64,'Adventure','28\"','Light Blue','Not active',18),(65,'Adventure','28\"','Light Blue','Not active',18),(66,'Adventure','28\"','Light Blue','Not active',18),(67,'City','28\"','Light Blue','Not active',6),(68,'City','28\"','Light Blue','Not active',6),(69,'City','28\"','Light Blue','Not active',6),(70,'City','28\"','Light Blue','Not active',6),(71,'Adventure','26\"','Light Blue','Not active',15),(72,'Adventure','26\"','Light Blue','Not active',15),(73,'Adventure','26\"','Light Blue','Not active',15),(74,'City','26\"','Light Blue','Not active',3),(75,'City','26\"','Light Blue','Not active',3),(76,'City','26\"','Black','Not active',1),(77,'City','26\"','Black','Active',1),(78,'City','26\"','Black','Not active',1),(79,'City','28\"','Black','Not active',1),(80,'City','28\"','Black','Not active',1),(81,'City','28\"','Black','Not active',1),(82,'City','28\"','Black','Not active',1),(83,'City','28\"','Black','Not active',1),(84,'City','28\"','Black','Not active',1),(85,'City','28\"','Black','Not active',1),(86,'City','28\"','Black','Not active',1),(87,'Adventure','28\"','Black','Not active',16),(88,'Adventure','28\"','Black','Not active',16),(89,'Adventure','28\"','Black','Not active',16),(90,'Adventure','28\"','Black','Not active',16),(91,'Adventure','28\"','Black','Not active',16),(92,'Adventure','28\"','Black','Not active',16),(93,'Adventure','28\"','Black','Not active',16),(94,'Adventure','28\"','Black','Not active',16),(95,'Adventure','28\"','Black','Not active',16),(96,'Adventure','28\"','Black','Not active',16),(97,'Adventure','28\"','Black','Not active',16),(98,'Adventure','28\"','Black','Not active',16),(99,'Adventure','28\"','Black','Not active',16),(100,'Adventure','28\"','Black','Not active',16),(102,'Adventure','28\"','Black','Not active',16),(103,'Adventure','28\"','Black','Not active',16),(104,'Adventure','28\"','Black','Not active',16),(105,'City','28\"','Light Blue','Not active',6),(106,'Adventure','26\"','Dark blue','Not active',14),(107,'Adventure','26\"','Dark blue','Not active',14),(108,'Adventure','26\"','Dark blue','Not active',14),(109,'Explorer','28\"','Light Blue','Not active',12),(110,'Explorer','28\"','Light Blue','Not active',12),(111,'Explorer','28\"','Light Blue','Not active',12),(112,'Explorer','28\"','Light Blue','Not active',12),(113,'Explorer','28\"','Dark blue','Not active',11),(114,'Explorer','28\"','Dark blue','Not active',11),(115,'Explorer','28\"','Dark blue','Not active',11),(116,'Explorer','28\"','Dark blue','Not active',11),(117,'Adventure','28\"','Dark blue','Done',17),(118,'Adventure','28\"','Dark blue','Done',17),(119,'Adventure','28\"','Dark blue','Done',17),(120,'Adventure','28\"','Dark blue','Done',17),(121,'City','28\"','Light Blue','Not active',6),(122,'City','28\"','Light Blue','Not active',6),(123,'Adventure','28\"','Light Blue','Not active',18),(124,'Adventure','28\"','Light Blue','Not active',18);
/*!40000 ALTER TABLE `bike` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`3BE-GRP5`@`%`*/ /*!50003 TRIGGER `bike_BEFORE_INSERT` BEFORE INSERT ON `bike` FOR EACH ROW BEGIN

#select max(id)+1 from bike into @bike_id;
select concat(new.`type`," ", new.`size` ," ", new.`color`) into @model_name; 
#select id from model_catalog where `name`= @model_name into @model_id;
SET NEW.model = (SELECT id FROM model_catalog WHERE `name`= @model_name);

END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`3BE-GRP5`@`%`*/ /*!50003 TRIGGER `bike_AFTER_INSERT_mapping` AFTER INSERT ON `bike` FOR EACH ROW BEGIN

select max(id) from bike into @bike_id; 
select max(id) from `order` into @order_id; 
insert into mapping(bike_id, order_id) values(@bike_id,@order_id);



END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Temporary view structure for view `bike_models_view`
--

DROP TABLE IF EXISTS `bike_models_view`;
/*!50001 DROP VIEW IF EXISTS `bike_models_view`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `bike_models_view` AS SELECT 
 1 AS `Reference`,
 1 AS `Name`,
 1 AS `Price`,
 1 AS `Quantity`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `bikes_stock`
--

DROP TABLE IF EXISTS `bikes_stock`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `bikes_stock` (
  `bike` int NOT NULL,
  PRIMARY KEY (`bike`),
  CONSTRAINT `bike_stock_id` FOREIGN KEY (`bike`) REFERENCES `bike` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bikes_stock`
--

LOCK TABLES `bikes_stock` WRITE;
/*!40000 ALTER TABLE `bikes_stock` DISABLE KEYS */;
INSERT INTO `bikes_stock` VALUES (123),(124);
/*!40000 ALTER TABLE `bikes_stock` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `bikes_stock_view`
--

DROP TABLE IF EXISTS `bikes_stock_view`;
/*!50001 DROP VIEW IF EXISTS `bikes_stock_view`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `bikes_stock_view` AS SELECT 
 1 AS `bike_id`,
 1 AS `name`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `client`
--

DROP TABLE IF EXISTS `client`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `client` (
  `id` int NOT NULL AUTO_INCREMENT,
  `lastname` varchar(65) NOT NULL,
  `firstname` varchar(65) NOT NULL,
  `country` varchar(65) NOT NULL,
  `city` varchar(65) NOT NULL,
  `street` varchar(65) NOT NULL,
  `number` int NOT NULL,
  `zipcode` int NOT NULL,
  `phoneNumber` varchar(65) NOT NULL,
  `emailAddress` varchar(65) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id_client_UNIQUE` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `client`
--

LOCK TABLES `client` WRITE;
/*!40000 ALTER TABLE `client` DISABLE KEYS */;
INSERT INTO `client` VALUES (1,'Stock','Stock','Belgium','Brussels','Avenue de l\' entreprise',0,1000,'0000000000','bovelo@gmail.com'),(2,'Marti','Seb','Belgium','Brussels','Testing street ',1024,1000,'Phone number','E-mail'),(3,'Doe','John','US','Chicago','Low street',125,8540,'+49875623','info@bikago.com'),(4,'Dreamland','Jacques','Belgium','Waterloo','Faubourg Namur',61,2500,'56321789','sport@dreamland.be'),(5,'Lennon','John','US','New York','5th Avenue',50,4000,'+8051426','john@lennon.com'),(6,'de Belgique','Philippe','Belgium','Brussels','Palais ',1,1000,'696969696969','king@belgium.be'),(7,'Brassens','Georges','Belgium','Brussels','Rue des copains',3,1000,'0455625432','georges@brassens.be'),(8,'Donnay','Jean-marc','Belgium','Nivelles','Avenue du centenaire',3,1400,'0456321589','jmd@cmn.be'),(9,'Aegirsson','Thorgal','Sweden','Northland','Niflheim srteet',9,7475,'90739300','child_of_stars@vikings.com'),(10,'Tesla','Nikola','Serbia','Beograd','Beograd Aerodrom',1,10000,'055589639','nikola.tesla@gmail.com');
/*!40000 ALTER TABLE `client` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `employee`
--

DROP TABLE IF EXISTS `employee`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `employee` (
  `id` int NOT NULL AUTO_INCREMENT,
  `firstname` varchar(64) NOT NULL,
  `lastname` varchar(64) NOT NULL,
  `status` varchar(64) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employee`
--

LOCK TABLES `employee` WRITE;
/*!40000 ALTER TABLE `employee` DISABLE KEYS */;
INSERT INTO `employee` VALUES (1,'John','Doe','maker'),(2,'Ulysse','31','administrator'),(3,'Aelita','Schaeffer','salesman'),(4,'Sacha','Ketchum','maker');
/*!40000 ALTER TABLE `employee` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `fitter`
--

DROP TABLE IF EXISTS `fitter`;
/*!50001 DROP VIEW IF EXISTS `fitter`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `fitter` AS SELECT 
 1 AS `id`,
 1 AS `type`,
 1 AS `color`,
 1 AS `size`*/;
SET character_set_client = @saved_cs_client;

--
-- Temporary view structure for view `manager`
--

DROP TABLE IF EXISTS `manager`;
/*!50001 DROP VIEW IF EXISTS `manager`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `manager` AS SELECT 
 1 AS `id`,
 1 AS `order_id`,
 1 AS `type`,
 1 AS `color`,
 1 AS `size`,
 1 AS `state`,
 1 AS `date`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `mapping`
--

DROP TABLE IF EXISTS `mapping`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `mapping` (
  `bike_id` int NOT NULL,
  `order_id` int NOT NULL,
  UNIQUE KEY `bike_id_UNIQUE` (`bike_id`),
  KEY `bike_id_idx` (`bike_id`),
  KEY `order_id_idx` (`order_id`),
  CONSTRAINT `bike_id` FOREIGN KEY (`bike_id`) REFERENCES `bike` (`id`),
  CONSTRAINT `order_id` FOREIGN KEY (`order_id`) REFERENCES `order` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci COMMENT='Maps which bike is in which order. ';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mapping`
--

LOCK TABLES `mapping` WRITE;
/*!40000 ALTER TABLE `mapping` DISABLE KEYS */;
INSERT INTO `mapping` VALUES (1,1),(2,1),(3,1),(4,1),(5,1),(6,1),(7,2),(8,2),(9,2),(10,2),(11,2),(12,2),(13,3),(14,3),(15,3),(16,3),(17,3),(18,3),(19,3),(20,3),(21,3),(22,3),(23,3),(24,3),(40,3),(41,3),(42,6),(43,7),(44,7),(45,7),(46,8),(47,8),(48,8),(49,9),(50,9),(51,9),(52,9),(53,9),(54,9),(55,9),(56,9),(57,9),(58,10),(59,10),(60,10),(61,10),(62,10),(63,10),(64,11),(65,11),(66,11),(67,12),(68,12),(69,12),(70,12),(71,13),(72,13),(73,13),(74,14),(75,14),(76,15),(77,15),(78,15),(79,16),(80,16),(81,16),(82,16),(83,17),(84,17),(85,17),(86,17),(87,18),(88,18),(89,18),(90,18),(91,19),(92,19),(93,19),(94,19),(95,19),(96,19),(97,19),(98,19),(99,19),(100,19),(102,19),(103,19),(104,19),(105,20),(106,21),(107,21),(108,21),(109,22),(110,22),(111,22),(112,22),(113,23),(114,23),(115,23),(116,23),(117,24),(118,25),(119,25),(120,25),(121,26),(122,26),(123,27),(124,27);
/*!40000 ALTER TABLE `mapping` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `model_catalog`
--

DROP TABLE IF EXISTS `model_catalog`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `model_catalog` (
  `id` int NOT NULL AUTO_INCREMENT,
  `name` varchar(45) NOT NULL,
  `price` int DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `name_UNIQUE` (`name`)
) ENGINE=InnoDB AUTO_INCREMENT=27 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `model_catalog`
--

LOCK TABLES `model_catalog` WRITE;
/*!40000 ALTER TABLE `model_catalog` DISABLE KEYS */;
INSERT INTO `model_catalog` VALUES (1,'City 26\" Black',250),(2,'City 26\" Dark Blue',250),(3,'City 26\" Light Blue',250),(4,'City 28\" Black',270),(5,'City 28\" Dark Blue',270),(6,'City 28\" Light Blue',270),(7,'Explorer 26\" Black',350),(8,'Explorer 26\" Dark Blue',350),(9,'Explorer 26\" Light Blue',350),(10,'Explorer 28\" Black',370),(11,'Explorer 28\" Dark Blue',370),(12,'Explorer 28\" Light Blue',370),(13,'Adventure 26\" Black',300),(14,'Adventure 26\" Dark Blue',300),(15,'Adventure 26\" Light Blue',300),(16,'Adventure 28\" Black',320),(17,'Adventure 28\" Dark Blue',320),(18,'Adventure 28\" Light Blue',320),(25,'Electric_Bike',100),(26,'bmw_bike',100);
/*!40000 ALTER TABLE `model_catalog` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `model_structure`
--

DROP TABLE IF EXISTS `model_structure`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `model_structure` (
  `model_name` varchar(45) NOT NULL,
  `reference` varchar(45) NOT NULL,
  `quantity` int NOT NULL,
  UNIQUE KEY `pk_model_to_part` (`model_name`,`reference`),
  KEY `fk_model_idx` (`model_name`) /*!80000 INVISIBLE */,
  KEY `fk_parts_catalog_idx` (`reference`),
  CONSTRAINT `fk_model_idx` FOREIGN KEY (`model_name`) REFERENCES `model_catalog` (`name`),
  CONSTRAINT `fk_parts_catalog_idx` FOREIGN KEY (`reference`) REFERENCES `parts_catalog` (`reference`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `model_structure`
--

LOCK TABLES `model_structure` WRITE;
/*!40000 ALTER TABLE `model_structure` DISABLE KEYS */;
INSERT INTO `model_structure` VALUES ('Adventure 26\" Black','00007',1),('Adventure 26\" Black','00008',1),('Adventure 26\" Black','00009',1),('Adventure 26\" Black','00010',1),('Adventure 26\" Black','00016',1),('Adventure 26\" Black','00017',1),('Adventure 26\" Black','00018',4),('Adventure 26\" Black','00019',1),('Adventure 26\" Black','00020',1),('Adventure 26\" Black','00027',1),('Adventure 26\" Black','00029',2),('Adventure 26\" Black','00030',1),('Adventure 26\" Black','00031',2),('Adventure 26\" Black','00033',1),('Adventure 26\" Black','00035',1),('Adventure 26\" Black','00036',1),('Adventure 26\" Black','00039',2),('Adventure 26\" Black','00042',2),('Adventure 26\" Dark Blue','00007',1),('Adventure 26\" Dark Blue','00008',1),('Adventure 26\" Dark Blue','00009',1),('Adventure 26\" Dark Blue','00011',1),('Adventure 26\" Dark Blue','00016',1),('Adventure 26\" Dark Blue','00017',1),('Adventure 26\" Dark Blue','00018',4),('Adventure 26\" Dark Blue','00019',1),('Adventure 26\" Dark Blue','00020',1),('Adventure 26\" Dark Blue','00027',1),('Adventure 26\" Dark Blue','00029',2),('Adventure 26\" Dark Blue','00030',1),('Adventure 26\" Dark Blue','00031',2),('Adventure 26\" Dark Blue','00033',1),('Adventure 26\" Dark Blue','00035',1),('Adventure 26\" Dark Blue','00036',1),('Adventure 26\" Dark Blue','00039',2),('Adventure 26\" Dark Blue','00042',2),('Adventure 26\" Light Blue','00007',1),('Adventure 26\" Light Blue','00008',1),('Adventure 26\" Light Blue','00009',1),('Adventure 26\" Light Blue','00012',1),('Adventure 26\" Light Blue','00016',1),('Adventure 26\" Light Blue','00017',1),('Adventure 26\" Light Blue','00018',4),('Adventure 26\" Light Blue','00019',1),('Adventure 26\" Light Blue','00020',1),('Adventure 26\" Light Blue','00027',1),('Adventure 26\" Light Blue','00029',2),('Adventure 26\" Light Blue','00030',1),('Adventure 26\" Light Blue','00031',2),('Adventure 26\" Light Blue','00033',1),('Adventure 26\" Light Blue','00035',1),('Adventure 26\" Light Blue','00036',1),('Adventure 26\" Light Blue','00039',2),('Adventure 26\" Light Blue','00042',2),('Adventure 28\" Black','00007',1),('Adventure 28\" Black','00008',1),('Adventure 28\" Black','00009',1),('Adventure 28\" Black','00013',1),('Adventure 28\" Black','00016',1),('Adventure 28\" Black','00017',1),('Adventure 28\" Black','00018',4),('Adventure 28\" Black','00019',1),('Adventure 28\" Black','00020',1),('Adventure 28\" Black','00028',1),('Adventure 28\" Black','00029',2),('Adventure 28\" Black','00030',1),('Adventure 28\" Black','00031',2),('Adventure 28\" Black','00034',1),('Adventure 28\" Black','00035',1),('Adventure 28\" Black','00036',1),('Adventure 28\" Black','00040',2),('Adventure 28\" Black','00043',2),('Adventure 28\" Dark Blue','00007',1),('Adventure 28\" Dark Blue','00008',1),('Adventure 28\" Dark Blue','00009',1),('Adventure 28\" Dark Blue','00014',1),('Adventure 28\" Dark Blue','00016',1),('Adventure 28\" Dark Blue','00017',1),('Adventure 28\" Dark Blue','00018',4),('Adventure 28\" Dark Blue','00019',1),('Adventure 28\" Dark Blue','00020',1),('Adventure 28\" Dark Blue','00028',1),('Adventure 28\" Dark Blue','00029',2),('Adventure 28\" Dark Blue','00030',1),('Adventure 28\" Dark Blue','00031',2),('Adventure 28\" Dark Blue','00034',1),('Adventure 28\" Dark Blue','00035',1),('Adventure 28\" Dark Blue','00036',1),('Adventure 28\" Dark Blue','00040',2),('Adventure 28\" Dark Blue','00043',2),('Adventure 28\" Light Blue','00007',1),('Adventure 28\" Light Blue','00008',1),('Adventure 28\" Light Blue','00009',1),('Adventure 28\" Light Blue','00015',1),('Adventure 28\" Light Blue','00016',1),('Adventure 28\" Light Blue','00017',1),('Adventure 28\" Light Blue','00018',4),('Adventure 28\" Light Blue','00019',1),('Adventure 28\" Light Blue','00020',1),('Adventure 28\" Light Blue','00028',1),('Adventure 28\" Light Blue','00029',2),('Adventure 28\" Light Blue','00030',1),('Adventure 28\" Light Blue','00031',2),('Adventure 28\" Light Blue','00034',1),('Adventure 28\" Light Blue','00035',1),('Adventure 28\" Light Blue','00036',1),('Adventure 28\" Light Blue','00040',2),('Adventure 28\" Light Blue','00043',2),('bmw_bike','00004',1),('City 26\" Black','00001',1),('City 26\" Black','00007',1),('City 26\" Black','00008',1),('City 26\" Black','00009',1),('City 26\" Black','00016',1),('City 26\" Black','00017',1),('City 26\" Black','00018',4),('City 26\" Black','00019',1),('City 26\" Black','00020',1),('City 26\" Black','00021',1),('City 26\" Black','00029',2),('City 26\" Black','00030',1),('City 26\" Black','00031',2),('City 26\" Black','00032',1),('City 26\" Black','00033',1),('City 26\" Black','00035',1),('City 26\" Black','00036',1),('City 26\" Black','00037',2),('City 26\" Black','00041',1),('City 26\" Black','00042',2),('City 26\" Dark Blue','00002',1),('City 26\" Dark Blue','00007',1),('City 26\" Dark Blue','00008',1),('City 26\" Dark Blue','00009',1),('City 26\" Dark Blue','00016',1),('City 26\" Dark Blue','00017',1),('City 26\" Dark Blue','00018',4),('City 26\" Dark Blue','00019',1),('City 26\" Dark Blue','00020',1),('City 26\" Dark Blue','00022',1),('City 26\" Dark Blue','00027',2),('City 26\" Dark Blue','00030',1),('City 26\" Dark Blue','00031',2),('City 26\" Dark Blue','00032',1),('City 26\" Dark Blue','00033',1),('City 26\" Dark Blue','00035',1),('City 26\" Dark Blue','00036',1),('City 26\" Dark Blue','00037',2),('City 26\" Dark Blue','00041',1),('City 26\" Dark Blue','00042',2),('City 26\" Light Blue','00002',1),('City 26\" Light Blue','00007',1),('City 26\" Light Blue','00008',1),('City 26\" Light Blue','00009',1),('City 26\" Light Blue','00016',1),('City 26\" Light Blue','00017',1),('City 26\" Light Blue','00018',4),('City 26\" Light Blue','00019',1),('City 26\" Light Blue','00020',1),('City 26\" Light Blue','00023',1),('City 26\" Light Blue','00029',2),('City 26\" Light Blue','00030',1),('City 26\" Light Blue','00031',2),('City 26\" Light Blue','00032',1),('City 26\" Light Blue','00033',1),('City 26\" Light Blue','00035',1),('City 26\" Light Blue','00036',1),('City 26\" Light Blue','00037',2),('City 26\" Light Blue','00039',1),('City 26\" Light Blue','00042',2),('City 28\" Black','00004',1),('City 28\" Black','00007',1),('City 28\" Black','00008',1),('City 28\" Black','00009',1),('City 28\" Black','00016',1),('City 28\" Black','00017',1),('City 28\" Black','00018',4),('City 28\" Black','00019',1),('City 28\" Black','00020',1),('City 28\" Black','00024',1),('City 28\" Black','00029',2),('City 28\" Black','00030',1),('City 28\" Black','00031',2),('City 28\" Black','00032',1),('City 28\" Black','00034',1),('City 28\" Black','00035',1),('City 28\" Black','00036',1),('City 28\" Black','00038',2),('City 28\" Black','00041',1),('City 28\" Black','00043',2),('City 28\" Dark Blue','00005',1),('City 28\" Dark Blue','00007',1),('City 28\" Dark Blue','00008',1),('City 28\" Dark Blue','00009',1),('City 28\" Dark Blue','00016',1),('City 28\" Dark Blue','00017',1),('City 28\" Dark Blue','00018',4),('City 28\" Dark Blue','00019',1),('City 28\" Dark Blue','00020',1),('City 28\" Dark Blue','00025',1),('City 28\" Dark Blue','00029',2),('City 28\" Dark Blue','00030',1),('City 28\" Dark Blue','00031',2),('City 28\" Dark Blue','00032',1),('City 28\" Dark Blue','00034',1),('City 28\" Dark Blue','00035',1),('City 28\" Dark Blue','00036',1),('City 28\" Dark Blue','00038',2),('City 28\" Dark Blue','00041',1),('City 28\" Dark Blue','00043',2),('City 28\" Light Blue','00006',1),('City 28\" Light Blue','00007',1),('City 28\" Light Blue','00008',1),('City 28\" Light Blue','00009',1),('City 28\" Light Blue','00016',1),('City 28\" Light Blue','00017',1),('City 28\" Light Blue','00018',4),('City 28\" Light Blue','00019',1),('City 28\" Light Blue','00020',1),('City 28\" Light Blue','00026',1),('City 28\" Light Blue','00029',2),('City 28\" Light Blue','00030',1),('City 28\" Light Blue','00031',2),('City 28\" Light Blue','00032',1),('City 28\" Light Blue','00034',1),('City 28\" Light Blue','00035',1),('City 28\" Light Blue','00036',1),('City 28\" Light Blue','00038',2),('City 28\" Light Blue','00041',1),('City 28\" Light Blue','00043',2),('Electric_Bike','00002',1),('Explorer 26\" Black','00001',1),('Explorer 26\" Black','00007',1),('Explorer 26\" Black','00008',1),('Explorer 26\" Black','00009',1),('Explorer 26\" Black','00016',1),('Explorer 26\" Black','00017',1),('Explorer 26\" Black','00018',4),('Explorer 26\" Black','00019',1),('Explorer 26\" Black','00020',1),('Explorer 26\" Black','00027',1),('Explorer 26\" Black','00029',2),('Explorer 26\" Black','00030',1),('Explorer 26\" Black','00031',2),('Explorer 26\" Black','00032',1),('Explorer 26\" Black','00033',1),('Explorer 26\" Black','00035',1),('Explorer 26\" Black','00036',1),('Explorer 26\" Black','00039',2),('Explorer 26\" Black','00041',1),('Explorer 26\" Black','00042',2),('Explorer 26\" Dark Blue','00002',1),('Explorer 26\" Dark Blue','00007',1),('Explorer 26\" Dark Blue','00008',1),('Explorer 26\" Dark Blue','00009',1),('Explorer 26\" Dark Blue','00016',1),('Explorer 26\" Dark Blue','00017',1),('Explorer 26\" Dark Blue','00018',4),('Explorer 26\" Dark Blue','00019',1),('Explorer 26\" Dark Blue','00020',1),('Explorer 26\" Dark Blue','00027',1),('Explorer 26\" Dark Blue','00029',2),('Explorer 26\" Dark Blue','00030',1),('Explorer 26\" Dark Blue','00031',2),('Explorer 26\" Dark Blue','00032',1),('Explorer 26\" Dark Blue','00033',1),('Explorer 26\" Dark Blue','00035',1),('Explorer 26\" Dark Blue','00036',1),('Explorer 26\" Dark Blue','00039',2),('Explorer 26\" Dark Blue','00041',1),('Explorer 26\" Dark Blue','00042',2),('Explorer 26\" Light Blue','00003',1),('Explorer 26\" Light Blue','00007',1),('Explorer 26\" Light Blue','00008',1),('Explorer 26\" Light Blue','00009',1),('Explorer 26\" Light Blue','00016',1),('Explorer 26\" Light Blue','00017',1),('Explorer 26\" Light Blue','00018',4),('Explorer 26\" Light Blue','00019',1),('Explorer 26\" Light Blue','00020',1),('Explorer 26\" Light Blue','00027',1),('Explorer 26\" Light Blue','00029',2),('Explorer 26\" Light Blue','00030',1),('Explorer 26\" Light Blue','00031',2),('Explorer 26\" Light Blue','00032',1),('Explorer 26\" Light Blue','00033',1),('Explorer 26\" Light Blue','00035',1),('Explorer 26\" Light Blue','00036',1),('Explorer 26\" Light Blue','00039',2),('Explorer 26\" Light Blue','00041',1),('Explorer 26\" Light Blue','00042',2),('Explorer 28\" Black','00004',1),('Explorer 28\" Black','00007',1),('Explorer 28\" Black','00008',1),('Explorer 28\" Black','00009',1),('Explorer 28\" Black','00016',1),('Explorer 28\" Black','00017',1),('Explorer 28\" Black','00018',4),('Explorer 28\" Black','00019',1),('Explorer 28\" Black','00020',1),('Explorer 28\" Black','00028',1),('Explorer 28\" Black','00029',2),('Explorer 28\" Black','00030',1),('Explorer 28\" Black','00031',2),('Explorer 28\" Black','00032',1),('Explorer 28\" Black','00034',1),('Explorer 28\" Black','00036',1),('Explorer 28\" Black','00040',2),('Explorer 28\" Black','00041',1),('Explorer 28\" Black','00043',2),('Explorer 28\" Dark Blue','00005',1),('Explorer 28\" Dark Blue','00007',1),('Explorer 28\" Dark Blue','00008',1),('Explorer 28\" Dark Blue','00009',1),('Explorer 28\" Dark Blue','00016',1),('Explorer 28\" Dark Blue','00017',1),('Explorer 28\" Dark Blue','00018',4),('Explorer 28\" Dark Blue','00019',1),('Explorer 28\" Dark Blue','00020',1),('Explorer 28\" Dark Blue','00028',1),('Explorer 28\" Dark Blue','00029',2),('Explorer 28\" Dark Blue','00030',1),('Explorer 28\" Dark Blue','00031',2),('Explorer 28\" Dark Blue','00032',1),('Explorer 28\" Dark Blue','00034',1),('Explorer 28\" Dark Blue','00035',1),('Explorer 28\" Dark Blue','00036',1),('Explorer 28\" Dark Blue','00040',2),('Explorer 28\" Dark Blue','00041',1),('Explorer 28\" Dark Blue','00043',2),('Explorer 28\" Light Blue','00006',1),('Explorer 28\" Light Blue','00007',1),('Explorer 28\" Light Blue','00008',1),('Explorer 28\" Light Blue','00009',1),('Explorer 28\" Light Blue','00016',1),('Explorer 28\" Light Blue','00017',1),('Explorer 28\" Light Blue','00018',4),('Explorer 28\" Light Blue','00019',1),('Explorer 28\" Light Blue','00020',1),('Explorer 28\" Light Blue','00028',1),('Explorer 28\" Light Blue','00029',2),('Explorer 28\" Light Blue','00030',1),('Explorer 28\" Light Blue','00031',2),('Explorer 28\" Light Blue','00032',1),('Explorer 28\" Light Blue','00034',1),('Explorer 28\" Light Blue','00035',1),('Explorer 28\" Light Blue','00036',1),('Explorer 28\" Light Blue','00040',2),('Explorer 28\" Light Blue','00041',1),('Explorer 28\" Light Blue','00043',2);
/*!40000 ALTER TABLE `model_structure` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `order`
--

DROP TABLE IF EXISTS `order`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `order` (
  `id` int NOT NULL AUTO_INCREMENT,
  `client` int NOT NULL,
  `date` date NOT NULL,
  `deliveryDate` date NOT NULL,
  `totalPrice` int NOT NULL,
  `status` varchar(45) DEFAULT 'Not active',
  `comments` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id_order_UNIQUE` (`id`),
  KEY `id_client` (`client`),
  CONSTRAINT `id_client` FOREIGN KEY (`client`) REFERENCES `client` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=28 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `order`
--

LOCK TABLES `order` WRITE;
/*!40000 ALTER TABLE `order` DISABLE KEYS */;
INSERT INTO `order` VALUES (1,7,'2021-02-24','2021-02-24',1840,'Not active',NULL),(2,2,'2021-02-25','2021-02-25',1920,'Not active',NULL),(3,8,'2021-02-28','2021-02-28',1620,'Not active',NULL),(6,1,'2021-03-07','2021-03-07',0,'Not active',NULL),(7,1,'2021-03-08','2021-08-11',0,'Not active',NULL),(8,1,'2021-03-08','2021-08-11',0,'Not active',NULL),(9,1,'2021-03-15','2021-03-19',0,'Not active',NULL),(10,1,'2021-03-15','2021-03-22',0,'Not active',NULL),(11,1,'2021-03-15','2021-03-22',0,'Not active',NULL),(12,1,'2021-03-15','2021-03-22',0,'Not active',NULL),(13,1,'2021-03-15','2021-03-22',0,'Not active',NULL),(14,1,'2021-03-15','2021-03-22',0,'Not active',NULL),(15,1,'2021-03-15','2021-03-22',0,'Not active',NULL),(16,1,'2021-03-15','2021-03-22',0,'Not active',NULL),(17,1,'2021-03-15','2021-03-22',0,'Not active',NULL),(18,1,'2021-03-15','2021-03-23',0,'Not active',NULL),(19,1,'2021-03-16','2021-03-24',0,'Not active',NULL),(20,2,'2021-04-24','2021-04-16',270,'Not active',NULL),(21,5,'2021-05-01','2021-05-07',900,'Not active',NULL),(22,2,'2021-05-01','2021-05-07',1480,'Not active',NULL),(23,3,'2021-05-01','2021-05-07',1480,'Not active',NULL),(24,4,'2021-05-02','2021-05-07',320,'Not active',NULL),(25,2,'2021-06-13','2021-06-17',960,'Not active',NULL),(26,1,'2021-06-13','2021-06-21',0,'Not active',NULL),(27,1,'2021-06-13','2021-06-21',0,'Not active',NULL);
/*!40000 ALTER TABLE `order` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `parts_catalog`
--

DROP TABLE IF EXISTS `parts_catalog`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `parts_catalog` (
  `reference` varchar(5) NOT NULL,
  `name` varchar(45) DEFAULT NULL,
  `description` varchar(45) DEFAULT NULL,
  `provider` int DEFAULT NULL,
  PRIMARY KEY (`reference`),
  UNIQUE KEY `reference_UNIQUE` (`reference`),
  KEY `fk_supplier_idx` (`provider`),
  CONSTRAINT `fk_supplier` FOREIGN KEY (`provider`) REFERENCES `supplier` (`id_supplier`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `parts_catalog`
--

LOCK TABLES `parts_catalog` WRITE;
/*!40000 ALTER TABLE `parts_catalog` DISABLE KEYS */;
INSERT INTO `parts_catalog` VALUES ('00001','Frame 26\" Black',NULL,2),('00002','Frame 26\" Dark Blue',NULL,3),('00003','Frame 26\" Light Blue',NULL,4),('00004','Frame 28\" Black',NULL,3),('00005','Frame 28\" Dark Blue',NULL,2),('00006','Frame 28\" Light Blue',NULL,2),('00007','Stand',NULL,3),('00008','Brakes Kit',NULL,4),('00009','Shifter Kit',NULL,2),('00010','Reinforced Frame 26\" Black',NULL,3),('00011','Reinforced Frame 26\" Dark Blue',NULL,2),('00012','Reinforced Frame 26\" Light Blue',NULL,3),('00013','Reinforced Frame 28\" Black',NULL,3),('00014','Reinforced Frame 28\" Dark Blue',NULL,4),('00015','Reinforced Frame 28\" Light Blue',NULL,4),('00016','Pedal Kit',NULL,3),('00017','Sproket Cassette',NULL,2),('00018','Catadioptre',NULL,3),('00019','Saddle',NULL,4),('00020','Chain',NULL,2),('00021','Mudguard 26\" Black',NULL,2),('00022','Mudguard 26\" Dark Blue',NULL,3),('00023','Mudguard 26\" Light Blue',NULL,4),('00024','Mudguard 28\" Black',NULL,2),('00025','Mudguard 28\" Dark Blue',NULL,2),('00026','Mudguard 28\" Light Blue',NULL,4),('00027','Large Mudguard 26\" Black',NULL,4),('00028','Large Mudguard 28\" Black',NULL,4),('00029','Air Chamber',NULL,4),('00030','Derailleur',NULL,3),('00031','Brake Disk',NULL,3),('00032','Lighting',NULL,3),('00033','Fork 26\"',NULL,4),('00034','Fork 28\"',NULL,3),('00035','Handlebar',NULL,2),('00036','Tray',NULL,2),('00037','Tire 26\"',NULL,3),('00038','Tire 28\"',NULL,4),('00039','Wide Tire 26\"',NULL,2),('00040','Wide Tire 28\"',NULL,3),('00041','Luggage Rack',NULL,4),('00042','Wheel 26\"',NULL,4),('00043','Wheel 28\"',NULL,3),('00100','Battery','Battery',2);
/*!40000 ALTER TABLE `parts_catalog` ENABLE KEYS */;
UNLOCK TABLES;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
/*!50003 CREATE*/ /*!50017 DEFINER=`3BE-GRP5`@`%`*/ /*!50003 TRIGGER `parts_catalog_AFTER_INSERT` AFTER INSERT ON `parts_catalog` FOR EACH ROW BEGIN
INSERT INTO `parts_stock`(`reference`,`quantity`) VALUES(NEW.`reference`,0);
END */;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Table structure for table `parts_stock`
--

DROP TABLE IF EXISTS `parts_stock`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `parts_stock` (
  `reference` varchar(5) NOT NULL,
  `quantity` int unsigned DEFAULT NULL,
  `ordered` int unsigned DEFAULT NULL,
  `necessary` int unsigned DEFAULT NULL,
  PRIMARY KEY (`reference`),
  UNIQUE KEY `reference_UNIQUE` (`reference`),
  KEY `fk_part_reference_idx` (`reference`),
  CONSTRAINT `fk_stock_part_reference` FOREIGN KEY (`reference`) REFERENCES `parts_catalog` (`reference`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `parts_stock`
--

LOCK TABLES `parts_stock` WRITE;
/*!40000 ALTER TABLE `parts_stock` DISABLE KEYS */;
INSERT INTO `parts_stock` VALUES ('00001',100,8,7),('00002',1,4,5),('00003',0,0,1),('00004',0,1,20),('00005',3,6,2),('00006',100,0,14),('00007',100,0,87),('00008',100,2,87),('00009',100,0,87),('00010',100,0,5),('00011',100,0,0),('00012',100,0,3),('00013',100,0,23),('00014',100,0,0),('00015',100,0,7),('00016',100,0,87),('00017',100,0,87),('00018',100,248,348),('00019',100,0,87),('00020',100,0,87),('00021',100,0,6),('00022',100,0,1),('00023',100,0,4),('00024',100,0,18),('00025',100,0,0),('00026',100,0,10),('00027',100,0,12),('00028',100,0,38),('00029',100,72,172),('00030',100,0,87),('00031',100,74,174),('00032',100,0,49),('00033',100,0,21),('00034',100,0,66),('00035',100,0,85),('00036',100,0,87),('00037',100,0,22),('00038',100,5,56),('00039',100,1,24),('00040',100,2,76),('00041',100,2,45),('00042',100,2,42),('00043',100,32,132),('00100',1,NULL,NULL);
/*!40000 ALTER TABLE `parts_stock` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `parts_stock_view`
--

DROP TABLE IF EXISTS `parts_stock_view`;
/*!50001 DROP VIEW IF EXISTS `parts_stock_view`*/;
SET @saved_cs_client     = @@character_set_client;
/*!50503 SET character_set_client = utf8mb4 */;
/*!50001 CREATE VIEW `parts_stock_view` AS SELECT 
 1 AS `Reference`,
 1 AS `Name`,
 1 AS `Provider`,
 1 AS `Quantity`,
 1 AS `Ordered`,
 1 AS `Necessary`,
 1 AS `Description`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `planning`
--

DROP TABLE IF EXISTS `planning`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `planning` (
  `date` date NOT NULL,
  `bike` int NOT NULL,
  `maker_id` int DEFAULT NULL,
  PRIMARY KEY (`bike`),
  UNIQUE KEY `bike_UNIQUE` (`bike`),
  KEY `fk_maker_id_idx` (`maker_id`),
  CONSTRAINT `fk_bike_id` FOREIGN KEY (`bike`) REFERENCES `bike` (`id`),
  CONSTRAINT `fk_maker_id` FOREIGN KEY (`maker_id`) REFERENCES `employee` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `planning`
--

LOCK TABLES `planning` WRITE;
/*!40000 ALTER TABLE `planning` DISABLE KEYS */;
INSERT INTO `planning` VALUES ('2021-03-25',1,1),('2021-03-26',2,NULL),('2021-03-25',3,NULL),('2021-04-24',4,1),('2021-04-24',5,4),('2021-07-14',6,NULL),('2021-06-14',7,NULL),('2021-06-14',8,NULL),('2021-05-05',9,NULL),('2021-04-20',10,NULL),('2021-03-13',11,NULL),('2021-03-10',12,NULL),('2021-03-13',13,NULL),('2021-03-13',14,NULL),('2021-03-13',15,NULL),('2021-03-13',16,NULL),('2021-03-08',17,NULL),('2021-03-12',18,NULL),('2021-03-13',19,NULL),('2021-03-13',20,NULL),('2021-03-13',21,NULL),('2021-03-14',22,NULL),('2021-03-14',23,NULL),('2021-03-14',24,NULL),('2021-03-14',40,NULL),('2021-03-14',41,NULL),('2021-03-14',42,NULL),('2021-03-14',43,NULL),('2021-03-14',44,NULL),('2021-03-15',45,NULL),('2021-03-26',46,1),('2021-03-15',47,NULL),('2021-03-15',48,NULL),('2021-03-15',49,NULL),('2021-03-15',50,NULL),('2021-03-15',51,NULL),('2021-03-15',52,NULL),('2021-03-15',53,NULL),('2021-03-15',54,NULL),('2021-03-16',55,NULL),('2021-03-16',56,NULL),('2021-03-16',57,NULL),('2021-03-16',58,NULL),('2021-03-16',59,NULL),('2021-03-16',60,NULL),('2021-03-16',61,NULL),('2021-03-16',62,NULL),('2021-03-17',63,NULL),('2021-03-17',64,NULL),('2021-03-17',65,NULL),('2021-03-17',66,NULL),('2021-03-17',67,NULL),('2021-03-17',68,NULL),('2021-03-17',69,NULL),('2021-03-17',70,NULL),('2021-03-26',71,1),('2021-03-26',72,4),('2021-03-26',73,1),('2021-03-26',74,1),('2021-03-26',75,4),('2021-03-15',76,NULL),('2021-03-26',77,4),('2021-03-26',78,4),('2021-03-29',79,NULL),('2021-03-29',80,NULL),('2021-03-29',81,NULL),('2021-03-29',82,NULL),('2021-03-29',83,NULL),('2021-03-29',84,NULL),('2021-03-29',85,NULL),('2021-03-29',86,NULL),('2021-03-18',87,NULL),('2021-03-18',88,NULL),('2021-03-19',89,NULL),('2021-03-19',90,NULL),('2021-03-18',91,NULL),('2021-03-18',92,NULL),('2021-03-18',93,NULL),('2021-03-18',94,NULL),('2021-03-18',95,NULL),('2021-03-18',96,NULL),('2021-03-19',97,NULL),('2021-03-19',98,NULL),('2021-03-19',99,NULL),('2021-03-19',100,NULL),('2021-04-12',102,NULL),('2021-04-12',103,NULL),('2021-04-12',104,NULL),('2021-05-03',105,NULL),('2021-05-03',106,NULL),('2021-05-03',107,NULL),('2021-05-03',108,NULL),('2021-05-03',109,NULL),('2021-05-03',110,NULL),('2021-05-03',111,NULL),('2021-05-03',112,NULL),('2021-05-04',113,NULL),('2021-05-04',114,NULL),('2021-05-04',115,NULL),('2021-05-04',116,NULL),('2021-06-13',117,4),('2021-06-13',118,1),('2021-06-13',119,4),('2021-06-14',120,4);
/*!40000 ALTER TABLE `planning` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `supplier`
--

DROP TABLE IF EXISTS `supplier`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `supplier` (
  `id_supplier` int NOT NULL AUTO_INCREMENT,
  `supplier_name` varchar(45) NOT NULL,
  `Vat_number` varchar(45) NOT NULL,
  `e-mail` varchar(45) DEFAULT NULL,
  `phone` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`id_supplier`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `supplier`
--

LOCK TABLES `supplier` WRITE;
/*!40000 ALTER TABLE `supplier` DISABLE KEYS */;
INSERT INTO `supplier` VALUES (2,'shp 1','456',NULL,NULL),(3,'45_shop','98',NULL,'+478563698'),(4,'bike_stop','45',NULL,NULL);
/*!40000 ALTER TABLE `supplier` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `supplier_order`
--

DROP TABLE IF EXISTS `supplier_order`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `supplier_order` (
  `id_supplier_order` int NOT NULL AUTO_INCREMENT,
  `id_supplier` int NOT NULL,
  `part_reference` varchar(5) NOT NULL,
  `part_order_qty` int NOT NULL,
  PRIMARY KEY (`id_supplier_order`),
  KEY `id_supplier_idx` (`id_supplier`),
  KEY `part_reference_idx` (`part_reference`),
  CONSTRAINT `id_supplier` FOREIGN KEY (`id_supplier`) REFERENCES `supplier` (`id_supplier`)
) ENGINE=InnoDB AUTO_INCREMENT=327 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `supplier_order`
--

LOCK TABLES `supplier_order` WRITE;
/*!40000 ALTER TABLE `supplier_order` DISABLE KEYS */;
INSERT INTO `supplier_order` VALUES (1,4,'00008',16),(2,2,'11',3),(3,2,'11',5),(4,2,'1',4),(5,3,'2',5),(6,4,'3',2),(7,3,'4',4),(8,2,'1',6),(9,2,'1',6),(10,2,'1',9),(12,2,'00001',5),(18,2,'00001',6),(19,3,'00002',2),(20,4,'00003',4),(21,3,'00004',2),(22,2,'00005',1),(23,2,'00001',8),(24,2,'00001',50),(25,3,'00002',90),(26,2,'00001',59),(27,3,'00002',88),(28,4,'00003',35),(29,4,'00003',8),(30,2,'00001',0),(31,3,'00002',0),(32,4,'00003',0),(33,3,'00004',0),(34,2,'00005',0),(35,2,'00035',5),(36,2,'00001',0),(37,3,'00002',0),(38,4,'00003',0),(39,3,'00004',0),(40,2,'00005',0),(41,3,'00016',58),(42,2,'00001',0),(43,3,'00002',0),(44,4,'00003',0),(45,3,'00004',0),(46,2,'00005',0),(47,2,'00017',3),(48,2,'00001',0),(49,3,'00002',0),(50,4,'00003',0),(51,3,'00004',0),(52,2,'00005',50),(53,2,'00006',60),(54,2,'00001',38),(55,3,'00002',71),(56,4,'00003',27),(57,3,'00004',14),(58,4,'00027',11),(59,2,'00001',8),(60,3,'00002',4),(61,4,'00003',9),(62,3,'00004',10),(63,2,'00021',5),(64,3,'00002',4),(65,3,'00012',6),(66,2,'00001',56),(67,2,'00001',92),(68,2,'00001',56),(69,2,'00001',56),(70,3,'00002',9),(71,2,'00001',7),(72,3,'00002',5),(73,4,'00003',1),(74,3,'00004',20),(75,2,'00005',2),(76,2,'00006',12),(77,3,'00007',83),(78,4,'00008',83),(79,2,'00009',83),(80,3,'00010',5),(81,3,'00012',3),(82,3,'00013',23),(83,4,'00015',5),(84,3,'00016',83),(85,2,'00017',83),(86,3,'00018',332),(87,4,'00019',83),(88,2,'00020',83),(89,2,'00021',6),(90,3,'00022',1),(91,4,'00023',4),(92,2,'00024',18),(93,4,'00026',8),(94,4,'00027',12),(95,4,'00028',36),(96,4,'00029',164),(97,3,'00030',83),(98,3,'00031',166),(99,3,'00032',47),(100,4,'00033',21),(101,3,'00034',62),(102,2,'00035',81),(103,2,'00036',83),(104,3,'00037',22),(105,4,'00038',52),(106,2,'00039',24),(107,3,'00040',72),(108,4,'00041',43),(109,4,'00042',42),(110,3,'00043',124),(111,2,'00001',7),(112,3,'00002',5),(113,4,'00003',1),(114,3,'00004',20),(115,2,'00005',2),(116,2,'00006',12),(117,3,'00007',83),(118,4,'00008',83),(119,2,'00009',83),(120,3,'00010',5),(121,3,'00012',3),(122,3,'00013',23),(123,4,'00015',5),(124,3,'00016',83),(125,2,'00017',83),(126,3,'00018',332),(127,4,'00019',83),(128,2,'00020',83),(129,2,'00021',6),(130,3,'00022',1),(131,4,'00023',4),(132,2,'00024',18),(133,4,'00026',8),(134,4,'00027',12),(135,4,'00028',36),(136,4,'00029',164),(137,3,'00030',83),(138,3,'00031',166),(139,3,'00032',47),(140,4,'00033',21),(141,3,'00034',62),(142,2,'00035',81),(143,2,'00036',83),(144,3,'00037',22),(145,4,'00038',52),(146,2,'00039',24),(147,3,'00040',72),(148,4,'00041',43),(149,4,'00042',42),(150,3,'00043',124),(151,2,'00001',7),(152,3,'00002',5),(153,4,'00003',1),(154,3,'00004',20),(155,2,'00005',2),(156,2,'00006',12),(157,3,'00007',83),(158,4,'00008',83),(159,2,'00009',83),(160,3,'00010',5),(161,3,'00012',3),(162,3,'00013',23),(163,4,'00015',5),(164,3,'00016',83),(165,2,'00017',83),(166,3,'00018',332),(167,4,'00019',83),(168,2,'00020',83),(169,2,'00021',6),(170,3,'00022',1),(171,4,'00023',4),(172,2,'00024',18),(173,4,'00026',8),(174,4,'00027',12),(175,4,'00028',36),(176,4,'00029',164),(177,3,'00030',83),(178,3,'00031',166),(179,3,'00032',47),(180,4,'00033',21),(181,3,'00034',62),(182,2,'00035',81),(183,2,'00036',83),(184,3,'00037',22),(185,4,'00038',52),(186,2,'00039',24),(187,3,'00040',72),(188,4,'00041',43),(189,4,'00042',42),(190,3,'00043',124),(191,2,'00001',7),(192,3,'00002',5),(193,4,'00003',1),(194,3,'00004',20),(195,2,'00005',2),(196,2,'00006',14),(197,3,'00007',87),(198,4,'00008',87),(199,2,'00009',87),(200,3,'00010',5),(201,3,'00012',3),(202,3,'00013',23),(203,4,'00015',7),(204,3,'00016',87),(205,2,'00017',87),(206,3,'00018',348),(207,4,'00019',87),(208,2,'00020',87),(209,2,'00021',6),(210,3,'00022',1),(211,4,'00023',4),(212,2,'00024',18),(213,4,'00026',10),(214,4,'00027',12),(215,4,'00028',38),(216,4,'00029',172),(217,3,'00030',87),(218,3,'00031',174),(219,3,'00032',49),(220,4,'00033',21),(221,3,'00034',66),(222,2,'00035',85),(223,2,'00036',87),(224,3,'00037',22),(225,4,'00038',56),(226,2,'00039',24),(227,3,'00040',76),(228,4,'00041',45),(229,4,'00042',42),(230,3,'00043',132),(231,2,'00001',7),(232,3,'00002',5),(233,4,'00003',1),(234,3,'00004',20),(235,2,'00005',2),(236,2,'00006',14),(237,3,'00007',87),(238,4,'00008',87),(239,2,'00009',87),(240,3,'00010',5),(241,3,'00012',3),(242,3,'00013',23),(243,4,'00015',7),(244,3,'00016',87),(245,2,'00017',87),(246,3,'00018',348),(247,4,'00019',87),(248,2,'00020',87),(249,2,'00021',6),(250,3,'00022',1),(251,4,'00023',4),(252,2,'00024',18),(253,4,'00026',10),(254,4,'00027',12),(255,4,'00028',38),(256,4,'00029',172),(257,3,'00030',87),(258,3,'00031',174),(259,3,'00032',49),(260,4,'00033',21),(261,3,'00034',66),(262,2,'00035',85),(263,2,'00036',87),(264,3,'00037',22),(265,4,'00038',56),(266,2,'00039',24),(267,3,'00040',76),(268,4,'00041',45),(269,4,'00042',42),(270,3,'00043',132),(271,3,'00018',254),(272,4,'00029',78),(273,3,'00031',80),(274,3,'00043',38),(275,2,'00001',3),(276,3,'00002',4),(277,4,'00003',4),(278,3,'00004',4),(279,3,'00018',249),(280,4,'00026',15),(281,4,'00029',73),(282,3,'00031',75),(283,3,'00032',5),(284,3,'00043',33),(285,2,'00001',5),(286,3,'00002',5),(287,4,'00003',5),(288,3,'00004',5),(289,2,'00001',10),(290,3,'00018',248),(291,2,'00001',10),(292,3,'00043',32),(293,3,'00018',248),(294,4,'00029',72),(295,3,'00031',74),(296,2,'00001',1),(297,2,'00006',14),(298,4,'00029',68),(299,3,'00030',74),(300,3,'00002',5),(301,3,'00002',5),(302,4,'00029',4),(303,2,'00100',1),(304,3,'00018',100),(305,3,'00018',148),(306,3,'00018',248),(307,4,'00029',72),(308,3,'00031',74),(309,3,'00043',32),(310,4,'00008',2),(311,2,'00001',1),(312,2,'00001',7),(313,3,'00002',5),(314,4,'00003',4),(315,3,'00004',6),(316,2,'00005',6),(317,3,'00002',4),(318,4,'00003',2),(319,4,'00041',1),(320,4,'00042',1),(321,3,'00040',1),(322,2,'00039',1),(323,4,'00038',5),(324,3,'00002',1),(325,3,'00004',1),(326,3,'00002',3);
/*!40000 ALTER TABLE `supplier_order` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'bovelo'
--

--
-- Dumping routines for database 'bovelo'
--
/*!50003 DROP FUNCTION IF EXISTS `date_slider` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`3BE-GRP5`@`%` FUNCTION `date_slider`(capacity INT, currentDate DATE) RETURNS int
    DETERMINISTIC
BEGIN
DECLARE freeprod INT;
DECLARE result INT;
SELECT count(*) into freeprod FROM manager where `date`=currentDate;
SET result = (capacity-freeprod);
RETURN result;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `AddToStock` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`3BE-GRP5`@`%` PROCEDURE `AddToStock`(N int)
BEGIN
#DECLARE LastBikeID int;
#SELECT MAX(id) Into LastBikeID FROM bike;
INSERT INTO bikes_stock SELECT id from bike order by id desc limit N;

#insert into bike_stock(bike) value(LastBikeID);

END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `autoPlanner` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`3BE-GRP5`@`%` PROCEDURE `autoPlanner`(capacity INT, prodDate DATE)
BEGIN
DECLARE minID INT;
DECLARE Counter INT default 1;
DECLARE ProdMax INT;
Select bovelo.date_slider(capacity, prodDate) into ProdMax;
assignLoop: LOOP
IF (Counter>ProdMax) THEN
LEAVE assignLOOP;
END IF;
Select MIN(id) into minID FROM bovelo.manager where `date`IS NULL;
INSERT INTO bovelo.planning(`date`,bike) VALUES(prodDate,minID);
SET Counter = Counter+1;
END LOOP;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `ChangeBikeStatus` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`3BE-GRP5`@`%` PROCEDURE `ChangeBikeStatus`(bike_id int, new_status varchar(45))
BEGIN
UPDATE bike SET cstr_status = new_status WHERE id = bike_id ;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `ChangeOrderStatus` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`3BE-GRP5`@`%` PROCEDURE `ChangeOrderStatus`(order_id int, new_status varchar(45))
BEGIN
UPDATE `bovelo`.`order` SET `status` = new_status WHERE id = order_id ;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `part_order` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`3BE-GRP5`@`%` PROCEDURE `part_order`(id_part varchar(5), quantity INT)
BEGIN
 DECLARE provider_id INT DEFAULT 0;
 SELECT `provider` into provider_id from parts_catalog where `reference` = id_part ;
 INSERT INTO supplier_order(id_supplier,part_reference,part_order_qty) value(provider_id,id_part,quantity);
 UPDATE `parts_stock` SET `ordered` = `ordered` + quantity WHERE `reference` = id_part;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `updateQuantities` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`3BE-GRP5`@`%` PROCEDURE `updateQuantities`()
BEGIN
  DECLARE orderCounter INT DEFAULT 0;
  declare ordersTotal INT Default 0;
  DECLARE orderPres INT default 0;
  SELECT count(id) into orderPres FROM bovelo.orderQuantities;
  SELECT max(id) into ordersTotal FROM bovelo.`order`;
  test_loop : LOOP
  SELECT max(id) into orderPres FROM bovelo.orderQuantities;
    IF (orderPres >= ordersTotal) THEN
      LEAVE test_loop;
    END IF;

    SELECT MAX(id) into orderCounter FROM orderQuantities;
    Set orderCounter = orderCounter+1;
    Insert into orderQuantities (id) values (orderCounter);
    
  END LOOP; 
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;

--
-- Final view structure for view `bike_models_view`
--

/*!50001 DROP VIEW IF EXISTS `bike_models_view`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`3BE-GRP5`@`%` SQL SECURITY DEFINER */
/*!50001 VIEW `bike_models_view` AS select `model_catalog`.`id` AS `Reference`,`model_catalog`.`name` AS `Name`,`model_catalog`.`price` AS `Price`,count(`bikes_stock_view`.`name`) AS `Quantity` from (`model_catalog` left join `bikes_stock_view` on((`model_catalog`.`name` = `bikes_stock_view`.`name`))) group by `model_catalog`.`id`,`model_catalog`.`name` */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `bikes_stock_view`
--

/*!50001 DROP VIEW IF EXISTS `bikes_stock_view`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`3BE-GRP5`@`%` SQL SECURITY DEFINER */
/*!50001 VIEW `bikes_stock_view` AS select `bikes_stock`.`bike` AS `bike_id`,concat(`bike`.`type`,' ',`bike`.`size`,' ',`bike`.`color`) AS `name` from (`bikes_stock` left join `bike` on((`bikes_stock`.`bike` = `bike`.`id`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `fitter`
--

/*!50001 DROP VIEW IF EXISTS `fitter`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`3BE-GRP5`@`%` SQL SECURITY DEFINER */
/*!50001 VIEW `fitter` AS select `bike`.`id` AS `id`,`bike`.`type` AS `type`,`bike`.`color` AS `color`,`bike`.`size` AS `size` from `bike` where `bike`.`id` in (select `planning`.`bike` from `planning` where (`planning`.`date` = curdate())) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `manager`
--

/*!50001 DROP VIEW IF EXISTS `manager`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`3BE-GRP5`@`%` SQL SECURITY DEFINER */
/*!50001 VIEW `manager` AS select `bike`.`id` AS `id`,`mapping`.`order_id` AS `order_id`,`bike`.`type` AS `type`,`bike`.`color` AS `color`,`bike`.`size` AS `size`,`bike`.`cstr_status` AS `state`,`planning`.`date` AS `date` from ((`bike` left join `planning` on((`bike`.`id` = `planning`.`bike`))) left join `mapping` on((`bike`.`id` = `mapping`.`bike_id`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `parts_stock_view`
--

/*!50001 DROP VIEW IF EXISTS `parts_stock_view`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8mb4 */;
/*!50001 SET character_set_results     = utf8mb4 */;
/*!50001 SET collation_connection      = utf8mb4_0900_ai_ci */;
/*!50001 CREATE ALGORITHM=UNDEFINED */
/*!50013 DEFINER=`3BE-GRP5`@`%` SQL SECURITY DEFINER */
/*!50001 VIEW `parts_stock_view` AS select `parts_stock`.`reference` AS `Reference`,`parts_catalog`.`name` AS `Name`,`parts_catalog`.`provider` AS `Provider`,`parts_stock`.`quantity` AS `Quantity`,`parts_stock`.`ordered` AS `Ordered`,`parts_stock`.`necessary` AS `Necessary`,`parts_catalog`.`description` AS `Description` from (`parts_stock` left join `parts_catalog` on((`parts_stock`.`reference` = `parts_catalog`.`reference`))) */;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-06-13 23:34:52
