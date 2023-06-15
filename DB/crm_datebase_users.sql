CREATE DATABASE  IF NOT EXISTS `crm_database` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `crm_database`;
-- MySQL dump 10.13  Distrib 8.0.27, for Win64 (x86_64)
--
-- Host: localhost    Database: crm_database
-- ------------------------------------------------------
-- Server version	8.0.27

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
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `users` (
  `id` int NOT NULL AUTO_INCREMENT,
  `fristName` varchar(255) NOT NULL,
  `lastName` varchar(255) NOT NULL,
  `email` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `createdAt` datetime NOT NULL,
  `updateAt` datetime DEFAULT NULL,
  `status` tinyint DEFAULT NULL,
  `userName` varchar(255) NOT NULL,
  `device` varchar(45) NOT NULL,
  `browser` varchar(45) NOT NULL,
  `ipAddress` varchar(45) NOT NULL,
  `isFristTimeLogin` tinyint NOT NULL DEFAULT '0',
  PRIMARY KEY (`id`),
  UNIQUE KEY `id_UNIQUE` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (11,'Farukh','Mushtaq','Farukh.Mustaq@gmail.com','$2a$11$SRfZjR4SZgKSAq89J94TCeuHpGo6ngx0uJ75B.SxOGkygQcMfsOm6','2023-06-13 00:32:47',NULL,1,'Farukh.mushtaq','13231saddsa','12.123.121',1),(12,'Awais','Khan','Awais.Khan@gmail.com','$2a$11$5jZDkJ2bXgEKmK4a3QnKEOm1kkhWZsP4jwPAPNfPtLVkNJ5S.ULtu','2023-06-13 20:55:17',NULL,1,'Awais.Khan','13231saddsa','12.123.121',0),(13,'asdasd','asdsad','xxprince_of_007xx@yahoo.com','$2a$11$LH4Ts.Eby7NRtgtZmAe/0ue1LwHx7yYbDof3VGvJq/HjnDmepk/uG','2023-06-13 23:55:54',NULL,1,'asdasda','123123213','12.12.121',0),(14,'Fazal','Rehman','Faza@gmail.com','$2a$11$exNmAOfNGXsurTRRZDeFdeRXlR95AA74PQSLhCaqQfftGRhcwIo06','2023-06-13 23:57:01',NULL,1,'asasda','123123213','12.12.121',1);
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-06-15  0:27:21
