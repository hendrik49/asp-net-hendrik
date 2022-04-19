-- phpMyAdmin SQL Dump
-- version 4.9.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Apr 19, 2022 at 08:07 AM
-- Server version: 8.0.18
-- PHP Version: 7.3.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `aspnet`
--

-- --------------------------------------------------------

--
-- Table structure for table `productcategories`
--

CREATE TABLE `productcategories` (
  `Seq_Id` int(11) NOT NULL,
  `Product_Category_Code` varchar(50) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `Category_Name` varchar(100) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `Category_Description` varchar(150) CHARACTER SET utf8 COLLATE utf8_unicode_ci DEFAULT NULL,
  `Status` varchar(50) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `Create_Date` datetime NOT NULL,
  `Update_Date` datetime DEFAULT NULL,
  `Is_Deleted` tinyint(1) DEFAULT '1'
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `productcategories`
--

INSERT INTO `productcategories` (`Seq_Id`, `Product_Category_Code`, `Category_Name`, `Category_Description`, `Status`, `Create_Date`, `Update_Date`, `Is_Deleted`) VALUES
(5, 'CAT1', 'Category 1', 'Category Desc', 'Active', '0001-01-01 00:00:00', '0001-01-01 00:00:00', 0),
(6, 'CAT2', 'Category 2', 'Category Desc 2', 'Active', '0001-01-01 00:00:00', '0001-01-01 00:00:00', 0);

-- --------------------------------------------------------

--
-- Table structure for table `products`
--

CREATE TABLE `products` (
  `Seq_Id` int(11) NOT NULL,
  `Product_Code` varchar(50) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `Product_Category_Code` varchar(50) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `Product_Type_Code` varchar(50) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `Product_Name` varchar(100) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `Product_Description` varchar(150) CHARACTER SET utf8 COLLATE utf8_unicode_ci DEFAULT NULL,
  `Status` varchar(50) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `Create_Date` datetime NOT NULL,
  `Update_Date` datetime DEFAULT NULL,
  `Is_Deleted` tinyint(1) DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `products`
--

INSERT INTO `products` (`Seq_Id`, `Product_Code`, `Product_Category_Code`, `Product_Type_Code`, `Product_Name`, `Product_Description`, `Status`, `Create_Date`, `Update_Date`, `Is_Deleted`) VALUES
(1, 'AE32', 'CAT1', 'TP1', 'Mama', 'Descssss', 'Active', '0001-01-01 00:00:00', '0001-01-01 00:00:00', 0),
(3, 'AE32', 'CAT2', 'TP1', 'Mama', 'Desc desc', 'Active', '0001-01-01 00:00:00', '2022-04-19 15:04:06', 0);

-- --------------------------------------------------------

--
-- Table structure for table `producttypes`
--

CREATE TABLE `producttypes` (
  `Seq_Id` int(11) NOT NULL,
  `Product_Type_Code` varchar(50) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `Product_Category_Code` varchar(50) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `Type_Name` varchar(100) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `Type_Description` varchar(150) CHARACTER SET utf8 COLLATE utf8_unicode_ci DEFAULT NULL,
  `Status` varchar(50) CHARACTER SET utf8 COLLATE utf8_unicode_ci NOT NULL,
  `Create_Date` datetime NOT NULL,
  `Update_Date` datetime DEFAULT NULL,
  `Is_Deleted` tinyint(1) DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;

--
-- Dumping data for table `producttypes`
--

INSERT INTO `producttypes` (`Seq_Id`, `Product_Type_Code`, `Product_Category_Code`, `Type_Name`, `Type_Description`, `Status`, `Create_Date`, `Update_Date`, `Is_Deleted`) VALUES
(5, 'TP1', 'CAT1', 'Type 1', 'Type Desc', 'Active', '0001-01-01 00:00:00', '0001-01-01 00:00:00', 0),
(6, 'TP2', 'CAT2', 'Type 2', 'Type Desc 2', 'Inactive', '0001-01-01 00:00:00', '0001-01-01 00:00:00', 0);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `productcategories`
--
ALTER TABLE `productcategories`
  ADD PRIMARY KEY (`Seq_Id`);

--
-- Indexes for table `products`
--
ALTER TABLE `products`
  ADD PRIMARY KEY (`Seq_Id`);

--
-- Indexes for table `producttypes`
--
ALTER TABLE `producttypes`
  ADD PRIMARY KEY (`Seq_Id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `productcategories`
--
ALTER TABLE `productcategories`
  MODIFY `Seq_Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `products`
--
ALTER TABLE `products`
  MODIFY `Seq_Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `producttypes`
--
ALTER TABLE `producttypes`
  MODIFY `Seq_Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
