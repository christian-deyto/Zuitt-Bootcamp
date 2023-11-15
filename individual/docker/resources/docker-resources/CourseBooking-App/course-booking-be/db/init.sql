-- MySQL dump 10.13  Distrib 8.0.33, for macos11.7 (x86_64)
--
-- Host: localhost    Database: CourseBookingDb
-- ------------------------------------------------------
-- Server version 8.0.33


-- ==================================================
-- Table structure for table `Courses`
-- ==================================================

DROP TABLE IF EXISTS `Courses`;

CREATE TABLE `Courses` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` varchar(100) DEFAULT NULL,
  `Description` varchar(255) DEFAULT NULL,
  `Price` double DEFAULT NULL,
  `IsActive` tinyint(1) DEFAULT NULL,
  `DatetimeCreated` datetime DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------
-- Dumping data for table `Courses`
-- --------------------------------------------------

LOCK TABLES `Courses` WRITE;

INSERT INTO `Courses` VALUES 
  (1,'Full-Stack Development Course','Learn all about full-stack development.',19000,1,'2023-05-22 18:16:44'),
  (2,'Introduction to Web','Learn all about basics of the web.',123,1,'2023-05-22 18:16:44');

UNLOCK TABLES;


-- ==================================================
-- Table structure for table `Users`
-- ==================================================

DROP TABLE IF EXISTS `Users`;

CREATE TABLE `Users` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `FirstName` varchar(50) DEFAULT NULL,
  `LastName` varchar(50) DEFAULT NULL,
  `Email` varchar(100) DEFAULT NULL,
  `Password` varchar(100) DEFAULT NULL,
  `IsAdmin` tinyint(1) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- --------------------------------------------------
-- Dumping data for table `Users`
-- --------------------------------------------------

LOCK TABLES `Users` WRITE;

INSERT INTO `Users` VALUES 
  (1,'Jane','Smith','admin@gmail.com','password123',1),
  (2,'John','Doe','johndoe@gmail.com','password456',0);

UNLOCK TABLES;


-- ==================================================
-- Table structure for table `CourseEnrollments`
-- ==================================================

DROP TABLE IF EXISTS `CourseEnrollments`;

CREATE TABLE `CourseEnrollments` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `CourseId` int DEFAULT NULL,
  `UserId` int DEFAULT NULL,
  `DatetimeEnrolled` datetime DEFAULT NULL,
  PRIMARY KEY (`Id`),
  KEY `CourseId` (`CourseId`),
  KEY `UserId` (`UserId`),
  CONSTRAINT `courseenrollments_ibfk_1` FOREIGN KEY (`CourseId`) REFERENCES `Courses` (`Id`),
  CONSTRAINT `courseenrollments_ibfk_2` FOREIGN KEY (`UserId`) REFERENCES `Users` (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;


-- --------------------------------------------------
-- Dumping data for table `CourseEnrollments`
-- --------------------------------------------------

LOCK TABLES `CourseEnrollments` WRITE;

UNLOCK TABLES;