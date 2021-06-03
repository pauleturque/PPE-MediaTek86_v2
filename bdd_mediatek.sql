-- phpMyAdmin SQL Dump
-- version 4.9.2
-- https://www.phpmyadmin.net/
--
-- Hôte : 127.0.0.1:3308
-- Généré le :  jeu. 03 juin 2021 à 22:14
-- Version du serveur :  5.7.28
-- Version de PHP :  7.3.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `bdd_mediatek`
--

-- --------------------------------------------------------

--
-- Structure de la table `absence`
--

DROP TABLE IF EXISTS `absence`;
CREATE TABLE IF NOT EXISTS `absence` (
  `IDPERSONNEL` int(2) NOT NULL,
  `DATEDEBUT` datetime NOT NULL,
  `IDMOTIF` int(2) NOT NULL,
  `DATEFIN` datetime DEFAULT NULL,
  PRIMARY KEY (`IDPERSONNEL`,`DATEDEBUT`),
  KEY `I_FK_ABSENCE_MOTIF` (`IDMOTIF`),
  KEY `I_FK_ABSENCE_PERSONNEL` (`IDPERSONNEL`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `absence`
--

INSERT INTO `absence` (`IDPERSONNEL`, `DATEDEBUT`, `IDMOTIF`, `DATEFIN`) VALUES
(6, '2019-11-04 12:57:47', 2, '2021-01-30 19:11:14'),
(8, '2018-10-01 04:17:41', 4, '2021-05-04 13:07:50'),
(8, '2018-05-24 04:52:13', 3, '2020-06-12 15:13:32'),
(4, '2018-08-27 21:05:30', 1, '2021-03-30 20:34:10'),
(1, '2020-05-26 04:03:49', 2, '2021-05-04 00:03:39'),
(10, '2018-09-07 17:55:06', 3, '2021-05-06 14:57:40'),
(7, '2019-07-11 04:25:57', 4, '2020-06-25 23:20:42'),
(4, '2019-09-03 20:14:05', 1, '2020-08-10 17:11:16'),
(1, '2020-03-20 17:33:06', 4, '2021-04-12 19:27:26'),
(8, '2018-04-03 05:57:01', 1, '2020-09-15 04:11:54'),
(8, '2019-08-18 19:16:07', 4, '2020-09-07 21:14:36'),
(1, '2020-04-01 23:28:53', 3, '2020-09-07 21:02:16'),
(4, '2020-01-08 23:13:02', 1, '2021-02-28 23:00:36'),
(8, '2020-03-02 23:23:36', 3, '2021-05-06 16:50:43'),
(4, '2020-02-06 14:46:49', 3, '2020-09-12 22:04:58'),
(1, '2020-05-03 15:41:46', 3, '2021-01-16 22:48:41'),
(6, '2018-05-10 21:31:51', 1, '2020-08-21 15:48:16'),
(1, '2019-07-17 10:17:06', 2, '2020-11-07 20:31:04'),
(8, '2019-12-10 23:30:04', 1, '2021-04-07 09:23:54'),
(5, '2018-10-04 22:40:49', 1, '2021-04-29 13:15:33'),
(6, '2020-02-24 05:25:09', 1, '2021-05-12 06:18:52'),
(10, '2019-07-03 14:29:51', 1, '2020-08-15 09:47:08'),
(5, '2018-06-11 20:32:50', 1, '2020-08-02 18:56:20'),
(10, '2020-03-23 07:56:26', 2, '2021-01-06 07:35:56'),
(5, '2018-11-03 20:24:52', 3, '2020-07-18 17:55:07'),
(5, '2019-03-18 07:37:59', 4, '2021-05-31 05:26:38'),
(2, '2019-08-12 19:50:01', 2, '2020-12-09 02:03:11'),
(9, '2019-07-03 04:53:33', 3, '2021-06-01 22:57:18'),
(4, '2019-02-12 19:17:03', 2, '2021-01-01 12:20:54'),
(5, '2018-02-06 03:22:13', 3, '2021-03-29 03:02:45'),
(9, '2019-11-01 16:11:18', 1, '2020-11-06 08:30:28'),
(6, '2018-07-23 16:31:00', 3, '2021-01-15 08:36:34'),
(8, '2018-04-17 07:07:24', 4, '2020-12-09 10:53:24'),
(10, '2021-06-01 17:28:31', 2, '2021-06-03 17:28:31'),
(9, '2020-01-12 12:55:06', 4, '2020-07-24 01:40:21'),
(1, '2020-02-09 18:41:36', 2, '2020-07-17 06:23:02'),
(6, '2020-05-03 07:46:19', 4, '2020-07-04 16:32:13'),
(7, '2018-06-20 00:19:57', 4, '2020-07-22 20:29:06'),
(10, '2020-05-09 08:13:10', 3, '2021-03-09 23:39:10'),
(7, '2021-06-01 17:13:32', 2, '2021-06-03 17:13:32'),
(7, '2019-03-13 09:47:32', 3, '2020-11-15 01:27:33'),
(5, '2019-11-26 08:30:38', 2, '2020-08-10 23:57:28'),
(2, '2019-04-10 10:54:20', 2, '2020-10-02 00:18:15'),
(1, '2021-06-02 22:14:36', 2, '2021-06-03 22:14:37'),
(2, '2021-06-03 15:46:43', 2, '2021-06-04 15:46:43');

-- --------------------------------------------------------

--
-- Structure de la table `motif`
--

DROP TABLE IF EXISTS `motif`;
CREATE TABLE IF NOT EXISTS `motif` (
  `IDMOTIF` int(2) NOT NULL AUTO_INCREMENT,
  `LIBELLE` varchar(128) DEFAULT NULL,
  PRIMARY KEY (`IDMOTIF`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `motif`
--

INSERT INTO `motif` (`IDMOTIF`, `LIBELLE`) VALUES
(1, 'vacances'),
(2, 'maladie'),
(3, 'motif familial'),
(4, 'congé parental');

-- --------------------------------------------------------

--
-- Structure de la table `personnel`
--

DROP TABLE IF EXISTS `personnel`;
CREATE TABLE IF NOT EXISTS `personnel` (
  `IDPERSONNEL` int(2) NOT NULL AUTO_INCREMENT,
  `IDSERVICE` int(2) NOT NULL,
  `NOM` varchar(50) DEFAULT NULL,
  `PRENOM` varchar(50) DEFAULT NULL,
  `TEL` varchar(15) DEFAULT NULL,
  `MAIL` varchar(128) DEFAULT NULL,
  PRIMARY KEY (`IDPERSONNEL`),
  KEY `I_FK_PERSONNEL_SERVICE` (`IDSERVICE`)
) ENGINE=MyISAM AUTO_INCREMENT=60 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `personnel`
--

INSERT INTO `personnel` (`IDPERSONNEL`, `IDSERVICE`, `NOM`, `PRENOM`, `TEL`, `MAIL`) VALUES
(1, 1, 'Conner', 'Tanya', '01 56 75 94 81', 'dolor.dolor@tempus.ca'),
(2, 2, 'Callahan', 'Kiara', '01 52 62 11 81', 'netus@tellusNunclectus.org'),
(3, 3, 'Pratt', 'Zelda', '04 23 24 08 14', 'ultrices.sit@lectusjusto.co.uk'),
(4, 3, 'Hurley', 'Leo', '03 82 81 63 00', 'interdum.ligula@ridiculusmusDonec.net'),
(53, 1, 'Bob', 'Marrley', 'XXXXXXXX', 'ljhs@ljks.fr'),
(6, 3, 'Howell', 'Miranda', '04 01 50 18 56', 'urna@congue.com'),
(7, 1, 'Kent', 'Brady', '03 77 28 97 70', 'ultrices@nisidictum.org'),
(8, 3, 'Tanner', 'Conan', '05 95 04 54 07', 'Cras.lorem.lorem@ornare.org'),
(9, 2, 'Lawrence', 'Quemby', '05 87 21 97 63', 'pulvinar.arcu@ullamcorpervelitin.co.uk'),
(10, 1, 'Hoover', 'Colton', '06 61 57 45 57', 'erat.semper.rutrum@eratnonummy.ca'),
(59, 0, 'on', 'y ', 'croit', 'dds'),
(58, 0, 'jony', 'bigoud', 'lukh', 'kjg'),
(57, 0, 'poppy', 'cool', 'poiu', 'kjshq'),
(56, 0, 'ok', 'frr', 'ta mal', 'o cuisse'),
(55, 0, 'pooooooo', 'ds', 'dsd', 'ds'),
(52, 0, 'Baboune', 'Wakatépé', '00000', 'JHG'),
(54, 3, 'popo', 'popo', 'popo', 'popo');

-- --------------------------------------------------------

--
-- Structure de la table `responsable`
--

DROP TABLE IF EXISTS `responsable`;
CREATE TABLE IF NOT EXISTS `responsable` (
  `login` varchar(64) NOT NULL,
  `pwd` varchar(64) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `responsable`
--

INSERT INTO `responsable` (`login`, `pwd`) VALUES
('fc0e47bbd41bd93175ae44aa39241a312f293916e91e8996efa5d1a4b1225389', '20eadc7fe97c98dd760cd39dc7266827f707c89bf90c5054f7b3262cd7684e3e');

-- --------------------------------------------------------

--
-- Structure de la table `service`
--

DROP TABLE IF EXISTS `service`;
CREATE TABLE IF NOT EXISTS `service` (
  `IDSERVICE` int(2) NOT NULL AUTO_INCREMENT,
  `NOM` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`IDSERVICE`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

--
-- Déchargement des données de la table `service`
--

INSERT INTO `service` (`IDSERVICE`, `NOM`) VALUES
(1, 'administratif'),
(2, 'médiation culturelle'),
(3, 'prêt'),
(4, 'aaa');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
