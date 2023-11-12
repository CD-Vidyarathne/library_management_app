-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 12, 2023 at 03:20 PM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `librarydb`
--

-- --------------------------------------------------------

--
-- Table structure for table `books`
--

CREATE TABLE `books` (
  `title` varchar(150) NOT NULL,
  `classification` varchar(1) NOT NULL,
  `identifier` varchar(4) NOT NULL,
  `numberOfCopies` int(1) NOT NULL DEFAULT 0,
  `availableCopies` int(11) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `books`
--

INSERT INTO `books` (`title`, `classification`, `identifier`, `numberOfCopies`, `availableCopies`) VALUES
('Harry Potter by JK Rowling', 'H', '5672', 2, 2),
('Sherlock Holmes by Arthur Conan Doyle', 'D', '1463', 2, 2);

-- --------------------------------------------------------

--
-- Table structure for table `loans`
--

CREATE TABLE `loans` (
  `loanId` int(11) NOT NULL,
  `bookNumber` varchar(6) NOT NULL,
  `userNumber` int(11) NOT NULL,
  `dueDate` date NOT NULL,
  `isReturned` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `loans`
--

INSERT INTO `loans` (`loanId`, `bookNumber`, `userNumber`, `dueDate`, `isReturned`) VALUES
(8, 'D 1463', 1, '2023-10-06', 1);

-- --------------------------------------------------------

--
-- Table structure for table `reservations`
--

CREATE TABLE `reservations` (
  `userNumber` int(11) NOT NULL,
  `bookNumber` varchar(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `userNumber` int(11) NOT NULL,
  `userName` varchar(50) NOT NULL,
  `sex` varchar(10) NOT NULL,
  `nic` varchar(15) NOT NULL,
  `address` varchar(100) NOT NULL,
  `isMember` tinyint(1) NOT NULL,
  `borrowedBooks` int(11) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`userNumber`, `userName`, `sex`, `nic`, `address`, `isMember`, `borrowedBooks`) VALUES
(1, 'Chamindu Vidyarathne', 'Male', '200224302937', 'Studio Vijaya, Mahiyangana Rd, Bibile', 1, 0),
(2, 'Shashikala Swarnamali', 'Female', '200011934313', '145/ A 11, Udathalawitiya, Parakaduwa', 0, 0),
(3, 'John Cena', 'Male', '132432543514', 'New york, America', 1, 0);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `books`
--
ALTER TABLE `books`
  ADD PRIMARY KEY (`title`);

--
-- Indexes for table `loans`
--
ALTER TABLE `loans`
  ADD PRIMARY KEY (`loanId`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`userNumber`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `loans`
--
ALTER TABLE `loans`
  MODIFY `loanId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
