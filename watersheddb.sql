-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: localhost    Database: watershed
-- ------------------------------------------------------
-- Server version	5.7.20-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `user`
--

DROP TABLE IF EXISTS `user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `user` (
  `uid` int(11) NOT NULL AUTO_INCREMENT,
  `email` varchar(30) NOT NULL,
  `password` varchar(70) NOT NULL,
  `pincode` char(20) NOT NULL,
  `role` char(10) NOT NULL,
  `Name` varchar(30) NOT NULL,
  `ConfirmPassword` varchar(50) NOT NULL,
  PRIMARY KEY (`uid`)
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user`
--

LOCK TABLES `user` WRITE;
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
INSERT INTO `user` VALUES (2,'vallabh.7@gmail.com','斦妤䈠鴯繁杈�롏䪠㼟῿纠躙ꋷ','431005','admin','vallabh','斦妤䈠鴯繁杈�롏䪠㼟῿纠躙ꋷ'),(3,'admin@mytechsite.in','斦妤䈠鴯繁杈�롏䪠㼟῿纠躙ꋷ','431005','user','vallabh','斦妤䈠鴯繁杈�롏䪠㼟῿纠躙ꋷ'),(4,'amit@mytechsite.in','斦妤䈠鴯繁杈�롏䪠㼟῿纠躙ꋷ','431005','user','amit','斦妤䈠鴯繁杈�롏䪠㼟῿纠躙ꋷ'),(5,'akshay_svk@gmail.com','斦妤䈠鴯繁杈�롏䪠㼟῿纠躙ꋷ','431005','user','akshay','斦妤䈠鴯繁杈�롏䪠㼟῿纠躙ꋷ'),(7,'asd@asd.com','斦妤䈠鴯繁杈�롏䪠㼟῿纠躙ꋷ','431005','user','asd','斦妤䈠鴯繁杈�롏䪠㼟῿纠躙ꋷ'),(8,'akshay@mytechsite.in','斦妤䈠鴯繁杈�롏䪠㼟῿纠躙ꋷ','431005','user','akshay','斦妤䈠鴯繁杈�롏䪠㼟῿纠躙ꋷ'),(9,'pol@gmail.com','斦妤䈠鴯繁杈�롏䪠㼟῿纠躙ꋷ','431005','user','pol','斦妤䈠鴯繁杈�롏䪠㼟῿纠躙ꋷ'),(10,'akshay@gmail.com','斦妤䈠鴯繁杈�롏䪠㼟῿纠躙ꋷ','431005','StateAgent','akshay','斦妤䈠鴯繁杈�롏䪠㼟῿纠躙ꋷ'),(11,'paritosh@gmail.com','斦妤䈠鴯繁杈�롏䪠㼟῿纠躙ꋷ','431005','user','paritosh tiwari','斦妤䈠鴯繁杈�롏䪠㼟῿纠躙ꋷ'),(12,'ankitverma@gmail.com','斦妤䈠鴯繁杈�롏䪠㼟῿纠躙ꋷ','431005','StateAgent','ankit','斦妤䈠鴯繁杈�롏䪠㼟῿纠躙ꋷ'),(13,'abc@abc.com','斦妤䈠鴯繁杈�롏䪠㼟῿纠躙ꋷ','431005','StateAgent','abc','斦妤䈠鴯繁杈�롏䪠㼟῿纠躙ꋷ'),(14,'vallabh@abctnc.com','斦妤䈠鴯繁杈�롏䪠㼟῿纠躙ꋷ','431005','user','student','斦妤䈠鴯繁杈�롏䪠㼟῿纠躙ꋷ'),(15,'xyz@xyz.com','斦妤䈠鴯繁杈�롏䪠㼟῿纠躙ꋷ','431005','StateAgent','xyz','斦妤䈠鴯繁杈�롏䪠㼟῿纠躙ꋷ'),(16,'user@watershed.com','斦妤䈠鴯繁杈�롏䪠㼟῿纠躙ꋷ','123456','StateAgent','user','斦妤䈠鴯繁杈�롏䪠㼟῿纠躙ꋷ'),(17,'ak@ak.com','斦妤䈠鴯繁杈�롏䪠㼟῿纠躙ꋷ','431005','StateAgent','vallabh','斦妤䈠鴯繁杈�롏䪠㼟῿纠躙ꋷ'),(18,'am@am.com','斦妤䈠鴯繁杈�롏䪠㼟῿纠躙ꋷ','431005','StateAgent','am','斦妤䈠鴯繁杈�롏䪠㼟῿纠躙ꋷ'),(19,'vb@vb.com','斦妤䈠鴯繁杈�롏䪠㼟῿纠躙ꋷ','431005','StateAgent','123','斦妤䈠鴯繁杈�롏䪠㼟῿纠躙ꋷ');
/*!40000 ALTER TABLE `user` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `watershed_city`
--

DROP TABLE IF EXISTS `watershed_city`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `watershed_city` (
  `cid` int(4) NOT NULL AUTO_INCREMENT,
  `cname` varchar(30) NOT NULL,
  `sid` int(11) NOT NULL,
  `area` double NOT NULL,
  PRIMARY KEY (`cid`),
  KEY `fk_watershed_city` (`sid`),
  CONSTRAINT `fk_watershed_city` FOREIGN KEY (`sid`) REFERENCES `watershed_state` (`sid`)
) ENGINE=InnoDB AUTO_INCREMENT=56 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `watershed_city`
--

LOCK TABLES `watershed_city` WRITE;
/*!40000 ALTER TABLE `watershed_city` DISABLE KEYS */;
INSERT INTO `watershed_city` VALUES (1,'Ahmednagar',19,17413),(2,'Akola',19,5429),(3,'Amravati',19,12235),(4,'Aurangabad',19,10107),(5,'Beed',19,10693),(6,'Bhandara',19,3716),(7,'Buldhana',19,9640),(8,'Chandrapur',19,11443),(9,'Dhule',19,137),(10,'Gadchiroli',19,14412),(11,'Gondia',19,4843),(12,'Hingoli',19,4526),(13,'Jalgaon',19,11765),(14,'Jalna',19,7612),(15,'Kolhapur',19,7685),(16,'Latur',19,7157),(17,'Mumbai	',19,4355),(18,'Nagpur',19,9892),(19,'Nanded',19,10422),(20,'Nandurbar',19,5035),(21,'Parbhani',19,6250),(22,'Nashik',19,15582),(23,'Osmanabad',19,7569),(24,'Pune',19,15642),(25,'Raigad',19,7152),(26,'Ratnagiri',19,8208),(27,'Sangli	',19,8578),(28,'Satara',19,10484),(29,'Sindhudurg',19,5207),(30,'Solapur	',19,14845),(31,'Wardha',19,6309),(32,'Thane',19,4214),(33,'Washim',19,5153),(34,'Yavatmal	',19,13582),(35,'Palghar',19,5344),(36,'Mumbai Suburban',19,446),(37,'Adilabad',36,4153),(38,'Nizamabad',36,4288),(39,'Karimnagar',36,2188),(40,'Medak',36,9699),(41,'Hyderabad',36,650),(42,'Rangareddi',36,5031),(43,'Mahbubnagar',36,18432),(44,'Nalgonda',36,105),(45,'Warangal',36,554.6),(46,'Khammam',36,4360),(47,'Srikakulam',36,5837),(48,'Anantapur',1,19130),(51,'Chittoor',1,15152),(52,'East Godavari',1,10807),(54,'Guntur',1,11391),(55,'Krishna',1,8727);
/*!40000 ALTER TABLE `watershed_city` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `watershed_city_data`
--

DROP TABLE IF EXISTS `watershed_city_data`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `watershed_city_data` (
  `cd_id` int(8) NOT NULL AUTO_INCREMENT,
  `cid` int(11) NOT NULL,
  `population` int(11) NOT NULL,
  `waterreq` double NOT NULL,
  `rainfall` double NOT NULL,
  `wateravail` double NOT NULL,
  `water_sarcacity` double NOT NULL,
  `cycle_year` datetime NOT NULL,
  PRIMARY KEY (`cd_id`),
  KEY `fk_city_data` (`cid`),
  CONSTRAINT `fk_city_data` FOREIGN KEY (`cid`) REFERENCES `watershed_city` (`cid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `watershed_city_data`
--

LOCK TABLES `watershed_city_data` WRITE;
/*!40000 ALTER TABLE `watershed_city_data` DISABLE KEYS */;
/*!40000 ALTER TABLE `watershed_city_data` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `watershed_crop`
--

DROP TABLE IF EXISTS `watershed_crop`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `watershed_crop` (
  `crop_id` int(8) NOT NULL AUTO_INCREMENT,
  `cname` varchar(30) NOT NULL,
  `type` varchar(30) NOT NULL,
  `season` varchar(40) NOT NULL,
  `waterreq` double NOT NULL,
  PRIMARY KEY (`crop_id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `watershed_crop`
--

LOCK TABLES `watershed_crop` WRITE;
/*!40000 ALTER TABLE `watershed_crop` DISABLE KEYS */;
INSERT INTO `watershed_crop` VALUES (1,'Rice','cereal grain','annual',900),(2,'wheat','cereal grain','winter',450),(3,'Sorghum','flowering plants','rainy',450);
/*!40000 ALTER TABLE `watershed_crop` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `watershed_policy`
--

DROP TABLE IF EXISTS `watershed_policy`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `watershed_policy` (
  `pid` int(8) NOT NULL AUTO_INCREMENT,
  `vd_id` int(11) NOT NULL,
  `crop_id` int(11) NOT NULL,
  `cultivated_area` double NOT NULL,
  `year` varchar(45) DEFAULT NULL,
  `uid` int(11) NOT NULL,
  PRIMARY KEY (`pid`),
  KEY `fk_policy_crop_id` (`crop_id`),
  KEY `fk_village_data_id_idx` (`vd_id`),
  KEY `fk_village_user_id_idx` (`uid`),
  CONSTRAINT `fk_policy_crop_id` FOREIGN KEY (`crop_id`) REFERENCES `watershed_crop` (`crop_id`),
  CONSTRAINT `fk_village_data_id` FOREIGN KEY (`vd_id`) REFERENCES `watershed_village_data` (`vd_id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_village_user_id` FOREIGN KEY (`uid`) REFERENCES `user` (`uid`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `watershed_policy`
--

LOCK TABLES `watershed_policy` WRITE;
/*!40000 ALTER TABLE `watershed_policy` DISABLE KEYS */;
INSERT INTO `watershed_policy` VALUES (1,3,2,2,'2017',14),(3,5,1,10,'2016',14),(4,5,2,2,'2016',14);
/*!40000 ALTER TABLE `watershed_policy` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `watershed_state`
--

DROP TABLE IF EXISTS `watershed_state`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `watershed_state` (
  `sid` int(4) NOT NULL AUTO_INCREMENT,
  `sname` varchar(40) NOT NULL,
  PRIMARY KEY (`sid`)
) ENGINE=InnoDB AUTO_INCREMENT=38 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `watershed_state`
--

LOCK TABLES `watershed_state` WRITE;
/*!40000 ALTER TABLE `watershed_state` DISABLE KEYS */;
INSERT INTO `watershed_state` VALUES (1,'Andhra Pradesh'),(2,'Arunachal Pradesh'),(3,'Assam'),(4,'Bihar'),(5,'Chhattisgarh'),(6,'Chandigarh'),(7,'Dadra and Nagar Haveli'),(8,'Daman and Diu'),(9,'Delhi'),(10,'Goa'),(11,'Gujarat'),(12,'Haryana'),(13,'Himachal Pradesh'),(14,'Jammu and Kashmir'),(15,'Jharkhand'),(16,'Karnataka'),(17,'Kerala'),(18,'Madhya Pradesh'),(19,'Maharashtra'),(20,'Manipur'),(21,'Meghalaya'),(22,'Mizoram'),(23,'Nagaland'),(24,'Orissa'),(25,'Punjab'),(26,'Pondicherry'),(27,'Rajasthan'),(28,'Sikkim'),(29,'Tamil Nadu'),(30,'Tripura'),(31,'Uttar Pradesh'),(32,'Uttarakhand'),(33,'West Bengal'),(34,'Andaman and Nicobar Islands'),(35,'Lakshadweep'),(36,'Telangana'),(37,'zebra');
/*!40000 ALTER TABLE `watershed_state` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `watershed_taluka`
--

DROP TABLE IF EXISTS `watershed_taluka`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `watershed_taluka` (
  `tid` int(4) NOT NULL AUTO_INCREMENT,
  `cid` int(4) NOT NULL,
  `area` double NOT NULL,
  `Name` varchar(45) NOT NULL,
  PRIMARY KEY (`tid`),
  KEY `fk_watershed_taluka` (`cid`),
  CONSTRAINT `fk_watershed_taluka` FOREIGN KEY (`cid`) REFERENCES `watershed_city` (`cid`)
) ENGINE=InnoDB AUTO_INCREMENT=25 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `watershed_taluka`
--

LOCK TABLES `watershed_taluka` WRITE;
/*!40000 ALTER TABLE `watershed_taluka` DISABLE KEYS */;
INSERT INTO `watershed_taluka` VALUES (1,4,1,'Aurangabad'),(2,4,1,'Sillod'),(3,4,1,'Gangapur'),(4,4,1,'Paithan'),(5,4,1,'Kannad'),(6,4,1,'Vaijapur'),(7,4,1,'Phulambri'),(8,4,1,'Khuldabad'),(9,4,1,'Soegaon'),(10,1,1,'Sangamner'),(11,1,1,'Nagar'),(12,1,1,'Nevasa'),(13,1,1,'Rahuri'),(14,1,1,'Rahta'),(15,1,1,'Shrigonda'),(16,1,1,'Kopargaon'),(17,1,1,'Akola'),(18,1,1,'Shrirampur'),(19,1,1,'Parner'),(20,1,1,'Pathardi'),(21,1,1,'Shevgaon'),(22,1,1,'Karjat'),(23,1,1,'Jamkhed'),(24,5,8.29,'Beed');
/*!40000 ALTER TABLE `watershed_taluka` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `watershed_taluka_data`
--

DROP TABLE IF EXISTS `watershed_taluka_data`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `watershed_taluka_data` (
  `tal_id` int(8) NOT NULL,
  `population` int(11) NOT NULL,
  `waterreq` double NOT NULL,
  `rainfall` double NOT NULL,
  `wateravail` double NOT NULL,
  `water_sarcacity` double NOT NULL,
  `cycle_year` datetime NOT NULL,
  `td_id` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`td_id`),
  KEY `fk_taluka_data` (`tal_id`),
  CONSTRAINT `fk_taluka_data` FOREIGN KEY (`tal_id`) REFERENCES `watershed_taluka` (`tid`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `watershed_taluka_data`
--

LOCK TABLES `watershed_taluka_data` WRITE;
/*!40000 ALTER TABLE `watershed_taluka_data` DISABLE KEYS */;
/*!40000 ALTER TABLE `watershed_taluka_data` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `watershed_village`
--

DROP TABLE IF EXISTS `watershed_village`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `watershed_village` (
  `vid` int(4) NOT NULL AUTO_INCREMENT,
  `tid` int(4) NOT NULL,
  `Area` double NOT NULL,
  `Pincode` char(20) NOT NULL,
  `Name` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`vid`),
  UNIQUE KEY `Pincode_UNIQUE` (`Pincode`),
  KEY `fk_watershed_village` (`tid`),
  CONSTRAINT `fk_watershed_village` FOREIGN KEY (`tid`) REFERENCES `watershed_taluka` (`tid`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `watershed_village`
--

LOCK TABLES `watershed_village` WRITE;
/*!40000 ALTER TABLE `watershed_village` DISABLE KEYS */;
INSERT INTO `watershed_village` VALUES (1,11,1,'414002','Agadgaon'),(2,11,1,'414005','Akolner'),(5,24,5.85,'431122','Adgaon Gunjala'),(6,24,10,'12345','Ashti'),(7,24,5,'55555','Anjanwati'),(8,4,4.5111,'431107','Paithan');
/*!40000 ALTER TABLE `watershed_village` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `watershed_village_data`
--

DROP TABLE IF EXISTS `watershed_village_data`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `watershed_village_data` (
  `village_id` int(8) NOT NULL,
  `population` int(11) NOT NULL,
  `waterreq` double NOT NULL,
  `rainfall` double NOT NULL,
  `wateravail` double NOT NULL,
  `water_sarcacity` double NOT NULL,
  `cycle_year` datetime NOT NULL,
  `vd_id` int(11) NOT NULL AUTO_INCREMENT,
  `livestock` int(11) DEFAULT NULL,
  `num_families` int(11) NOT NULL,
  PRIMARY KEY (`vd_id`),
  KEY `watershed_villagedata_vid_idx` (`village_id`),
  CONSTRAINT `watershed_villagedata_vid` FOREIGN KEY (`village_id`) REFERENCES `watershed_village` (`vid`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `watershed_village_data`
--

LOCK TABLES `watershed_village_data` WRITE;
/*!40000 ALTER TABLE `watershed_village_data` DISABLE KEYS */;
INSERT INTO `watershed_village_data` VALUES (5,1086,22852988.3599786,35,18720000,4132988.35,'2017-06-06 00:00:00',1,100,219),(6,1000,19727788.5451,2,14000788.5451,5727000,'2019-01-01 00:00:00',2,20,209),(7,500,10593894.27255,50,2250000000,2239406105,'2017-01-01 00:00:00',3,50,209),(8,5000,97726442.72550003,50,2029995000,1932268557.27,'2018-01-01 00:00:00',4,50,500),(8,10000,194540385.45100006,50,1804440000,1609899614.549,'2016-01-01 00:00:00',5,50,600);
/*!40000 ALTER TABLE `watershed_village_data` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-02-05 18:58:59
