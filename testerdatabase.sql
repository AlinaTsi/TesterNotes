-- phpMyAdmin SQL Dump
-- version 3.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Jun 10, 2022 at 07:40 AM
-- Server version: 5.5.25
-- PHP Version: 5.3.13

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `testerdatabase`
--

-- --------------------------------------------------------

--
-- Table structure for table `projects`
--

CREATE TABLE IF NOT EXISTS `projects` (
  `id_project` int(11) NOT NULL AUTO_INCREMENT,
  `id_user` int(11) NOT NULL,
  `name_project` varchar(35) NOT NULL,
  `customer_project` varchar(35) NOT NULL,
  PRIMARY KEY (`id_project`),
  KEY `id_user` (`id_user`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=12 ;

--
-- Dumping data for table `projects`
--

INSERT INTO `projects` (`id_project`, `id_user`, `name_project`, `customer_project`) VALUES
(7, 25, 'SoftKey', ''),
(8, 25, 'Сайт з продажу квартир', 'РІЕЛ'),
(9, 25, 'Draft Tracker', 'Intelliam'),
(10, 25, 'Особисті справи', ''),
(11, 25, 'Додаток гри в пазли', 'FunnyPlay');

-- --------------------------------------------------------

--
-- Table structure for table `reports`
--

CREATE TABLE IF NOT EXISTS `reports` (
  `id_bug` int(11) NOT NULL AUTO_INCREMENT,
  `id_project` int(11) NOT NULL,
  `summary_bug` varchar(200) NOT NULL,
  `platform_bug` varchar(50) NOT NULL,
  `environment_bug` varchar(100) NOT NULL,
  `steps_bug` text NOT NULL,
  `actualresult_bug` varchar(200) NOT NULL,
  `expectedresult_bug` varchar(200) NOT NULL,
  `notes_bug` text NOT NULL,
  PRIMARY KEY (`id_bug`),
  KEY `id_project` (`id_project`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=9 ;

--
-- Dumping data for table `reports`
--

INSERT INTO `reports` (`id_bug`, `id_project`, `summary_bug`, `platform_bug`, `environment_bug`, `steps_bug`, `actualresult_bug`, `expectedresult_bug`, `notes_bug`) VALUES
(5, 7, 'The “Username” field isn’t highlighted in red on the registration form after entering blank spaces and special characters into the “Username” field.', '', '', '1. Go to the site http://softkey.net/\r\n2. Click the “Sign-up” link.\r\n3. Enter valid data into the required fields.\r\n4. Enter blank spaces and special characters into the “Username” field.\r\n5. Pay attention to the “Username” field.', 'Blank spaces and special characters are accepted in the “Username” field on the registration form.', '', ''),
(6, 7, 'The error message is not displayed on the “Profile” form after entering no existed date into the “Date of Birth” field.', 'Windows 10', 'Google', '', '', 'The error message is displayed on the “Profile” form after entering no existed date into the “Date of Birth” field.', ''),
(7, 7, 'The slider picture is not fully displayed at the slider after clicking the "Results" tab.', '', '', '1. Open the site http://softkey.com\r\n2. Click the "Results" tab of the main menu.\r\n3. Take a look at the slider pictures.', 'The slider picture is not fully displayed at the slider after clicking the "Results" tab.', 'The slider picture is fully displayed at the slider after clicking the "Results" tab.', ''),
(8, 8, 'Пустий коментар відображається в розділі “Коментарі” після натискання кнопки “Відправити”.', 'Windows', 'Google', '', '', '', 'Баг проявляється не на постійній основі.');

-- --------------------------------------------------------

--
-- Table structure for table `tasks`
--

CREATE TABLE IF NOT EXISTS `tasks` (
  `id_task` int(11) NOT NULL AUTO_INCREMENT,
  `name_task` varchar(200) NOT NULL,
  `description_task` text,
  `id_project` int(11) NOT NULL,
  `priority_task` int(11) NOT NULL,
  `status_task` varchar(10) NOT NULL,
  `enddate_task` date DEFAULT NULL,
  PRIMARY KEY (`id_task`),
  KEY `id_project` (`id_project`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=15 ;

--
-- Dumping data for table `tasks`
--

INSERT INTO `tasks` (`id_task`, `name_task`, `description_task`, `id_project`, `priority_task`, `status_task`, `enddate_task`) VALUES
(9, 'Перевірити роботу форм авторизації та реєстрації', '', 11, 6, 'відкрито', '2022-06-30'),
(10, 'Дописати тест-кейси до спадаючого меню та передати колегам', '', 7, 3, 'відкрито', '2022-06-08'),
(11, 'Домовитись з менеджером про зустріч для уточнення завдання', '', 8, 4, 'відкрито', '2022-06-08'),
(12, 'Забрати тестовий годинник з офісу та перевірити підключення до пристроїв', '', 9, 1, 'відкрито', '2022-06-17'),
(13, 'Забрати документи з сервісного центру', '', 10, 1, 'відкрито', '2022-06-04'),
(14, 'Пройти перші 3 рівні та перевірити графіку', '', 11, 6, 'відкрито', '2022-06-26');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE IF NOT EXISTS `users` (
  `id_user` int(11) NOT NULL AUTO_INCREMENT,
  `pib_user` varchar(50) NOT NULL,
  `mail_user` varchar(50) NOT NULL,
  `login_user` varchar(20) NOT NULL,
  `password_user` varchar(20) NOT NULL,
  PRIMARY KEY (`id_user`)
) ENGINE=InnoDB  DEFAULT CHARSET=utf8 AUTO_INCREMENT=28 ;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`id_user`, `pib_user`, `mail_user`, `login_user`, `password_user`) VALUES
(25, 'Цігуш Аліна Віталіївна', 'alinats516@gmail.com', 'alina0203', 'qpщnmбdй');

--
-- Constraints for dumped tables
--

--
-- Constraints for table `projects`
--
ALTER TABLE `projects`
  ADD CONSTRAINT `projects_ibfk_2` FOREIGN KEY (`id_user`) REFERENCES `users` (`id_user`) ON DELETE CASCADE ON UPDATE NO ACTION;

--
-- Constraints for table `reports`
--
ALTER TABLE `reports`
  ADD CONSTRAINT `reports_ibfk_2` FOREIGN KEY (`id_project`) REFERENCES `projects` (`id_project`) ON DELETE CASCADE ON UPDATE NO ACTION;

--
-- Constraints for table `tasks`
--
ALTER TABLE `tasks`
  ADD CONSTRAINT `tasks_ibfk_2` FOREIGN KEY (`id_project`) REFERENCES `projects` (`id_project`) ON DELETE CASCADE ON UPDATE NO ACTION;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
