-- MySQL dump 10.13  Distrib 8.0.46, for Win64 (x86_64)
--
-- Host: localhost    Database: productosdb
-- ------------------------------------------------------
-- Server version	8.0.46

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
-- Table structure for table `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuarios` (
  `id` int NOT NULL AUTO_INCREMENT,
  `dsId` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `dsUsuario` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `dsPassword` varbinary(64) NOT NULL,
  `dsEstado` char(1) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `dsUsuarioCreacion` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL,
  `dtFechaCreacion` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `dsUsuarioModificacion` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci NOT NULL DEFAULT 'Sistema',
  `dtFechaModificacion` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuarios`
--

LOCK TABLES `usuarios` WRITE;
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
INSERT INTO `usuarios` VALUES (4,'001','admin',_binary '∫2Sáj\Ìk\¬-Joı=Ñ∆≠ÜAï\ÌJµ\»v!∂\¬3µH∫\Í\ÊïmÛF\Ïåı\ÍÛ^\„\À\≈y~\◊\›\”Td‚†∫¥','1','Sistema','2026-10-11 03:57:23','Sistema','2026-10-11 03:57:23'),(5,'002','root',_binary '\≈\◊	°ıúñå\Íˆoê4≤\∆l±TJa,´]\⁄@[\Õ¡-\‰\‚Å\n\œ*ï]q ü6˛ä\ÊX\ÿ•ÿ≥\—¿yDïæ:','1','Sistema','2026-10-11 04:00:04','Sistema','2026-10-11 04:00:04'),(6,'001','admin',_binary '∫2Sáj\Ìk\¬-Joı=Ñ∆≠ÜAï\ÌJµ\»v!∂\¬3µH∫\Í\ÊïmÛF\Ïåı\ÍÛ^\„\À\≈y~\◊\›\”Td‚†∫¥','1','Sistema','2026-10-12 10:57:30','Sistema','2026-10-12 10:57:30'),(7,'003','estudiante',_binary '±	Ûªº$N∏$Aë~\–maãê\›	≥æ˝^9LpjãπÄ±\◊x^Yv\ÏõF\ﬂ_&ØZ.¶\—˝\…SÖˇ´¨ºÜ','1','Sistema','2026-10-19 08:19:55','','2026-10-19 08:19:55');
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2026-11-04 16:57:31
