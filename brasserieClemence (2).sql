-- phpMyAdmin SQL Dump
-- version 4.6.6deb4
-- https://www.phpmyadmin.net/
--
-- Client :  localhost:3306
-- Généré le :  Mar 25 Mai 2021 à 11:38
-- Version du serveur :  10.1.41-MariaDB-0+deb9u1
-- Version de PHP :  7.0.33-0+deb9u6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de données :  `brasserieClemence`
--

-- --------------------------------------------------------

--
-- Structure de la table `Composition`
--

CREATE TABLE `Composition` (
  `QuantiteCompo` int(11) NOT NULL,
  `idIngredient` int(11) NOT NULL,
  `idRecette` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Contenu de la table `Composition`
--

INSERT INTO `Composition` (`QuantiteCompo`, `idIngredient`, `idRecette`) VALUES
(2, 29, 29),
(10, 22, 28),
(5, 29, 29),
(5, 31, 28),
(3, 22, 28),
(1, 31, 29),
(1, 22, 28),
(50, 22, 28),
(125, 29, 29),
(1, 98, 29),
(1, 98, 28),
(1, 98, 40),
(1, 101, 40),
(1, 104, 41),
(1, 100, 41),
(1, 98, 41),
(1, 22, 41),
(1, 105, 41),
(1, 103, 41),
(1, 101, 41),
(1, 102, 41),
(1, 99, 40),
(1, 100, 40),
(1, 98, 42),
(1, 99, 42),
(1, 101, 42),
(1, 100, 42),
(1, 29, 42),
(1, 98, 43),
(1, 101, 43),
(1, 100, 43),
(1, 22, 43),
(1, 99, 43),
(1, 103, 40),
(1, 98, 44),
(1, 99, 44),
(1, 102, 44),
(1, 103, 44),
(1, 100, 44),
(1, 106, 44),
(1, 107, 44),
(1, 108, 44),
(1, 101, 44),
(1, 101, 45),
(1, 98, 45),
(1, 99, 45),
(1, 100, 45),
(1, 109, 45),
(1, 103, 45),
(1, 98, 46),
(1, 110, 46),
(1, 111, 46),
(1, 101, 46),
(1, 103, 28),
(1, 112, 47),
(1, 98, 47),
(1, 99, 47),
(1, 101, 47),
(1, 113, 47),
(1, 98, 48),
(1, 114, 48),
(1, 115, 48),
(1, 101, 48),
(1, 100, 48),
(1, 103, 43),
(1, 103, 42),
(1, 103, 48),
(1, 98, 49),
(1, 114, 49),
(1, 116, 49),
(1, 100, 49),
(1, 101, 49),
(1, 98, 50),
(1, 99, 50),
(1, 100, 50),
(1, 101, 50),
(1, 103, 50),
(1, 117, 50),
(1, 98, 51),
(1, 99, 51),
(1, 100, 51),
(1, 101, 51),
(1, 103, 51),
(1, 119, 51),
(1, 98, 52),
(1, 99, 52),
(1, 100, 52),
(1, 101, 52),
(1, 103, 52),
(1, 120, 52),
(1, 98, 53),
(1, 99, 53),
(1, 100, 53),
(1, 101, 53),
(1, 103, 53),
(1, 121, 53),
(1, 98, 54),
(1, 99, 54),
(1, 100, 54),
(1, 101, 54),
(1, 103, 54),
(1, 122, 54),
(1, 103, 47),
(0, 123, 55),
(0, 98, 55),
(0, 100, 55),
(0, 101, 55),
(0, 99, 55),
(0, 103, 55),
(0, 98, 56),
(0, 99, 56),
(0, 100, 56),
(0, 101, 56),
(0, 103, 56),
(0, 124, 56),
(0, 103, 49),
(0, 98, 57),
(0, 100, 57),
(0, 101, 57),
(0, 103, 57),
(0, 99, 57),
(0, 125, 57),
(0, 105, 44),
(0, 126, 56),
(0, 113, 44),
(0, 120, 44),
(0, 105, 48),
(0, 107, 46),
(68, 109, 42),
(300, 98, 58),
(50, 102, 29);

-- --------------------------------------------------------

--
-- Structure de la table `dbo`
--

CREATE TABLE `dbo` (
  `id` int(11) NOT NULL,
  `username` varchar(30) NOT NULL,
  `password` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Contenu de la table `dbo`
--

INSERT INTO `dbo` (`id`, `username`, `password`) VALUES
(1, 'Vladimir', '55OOF'),
(2, 'Steven', '0550002D');

-- --------------------------------------------------------

--
-- Structure de la table `Ingredient`
--

CREATE TABLE `Ingredient` (
  `idIngredient` int(11) NOT NULL,
  `nomIngredient` varchar(500) NOT NULL,
  `bio` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Contenu de la table `Ingredient`
--

INSERT INTO `Ingredient` (`idIngredient`, `nomIngredient`, `bio`) VALUES
(22, 'pomme', 0),
(29, 'peche', 0),
(31, 'abricot', 0),
(98, 'eau', 0),
(99, 'malt', 0),
(100, 'houblon', 0),
(101, 'levure', 0),
(102, 'sirop de glucose', 0),
(103, 'sucre', 0),
(104, 'vodka', 0),
(105, 'caramel', 0),
(106, 'mais', 0),
(107, 'aromes', 0),
(108, 'arome Tequila', 0),
(109, 'framboise', 0),
(110, 'malt bio', 1),
(111, 'houblon bio', 1),
(112, 'houblon aromatique', 0),
(113, 'grain', 0),
(114, 'malt (orge)', 0),
(115, 'malt (ble)', 0),
(116, 'farine de chataigne', 0),
(117, 'fraise', 0),
(119, 'fraise (bio)', 1),
(120, 'pomme (bio)', 1),
(121, 'peche (bio)', 1),
(122, 'framboise (bio)', 1),
(123, 'cerise', 0),
(124, 'cerise (bio)', 1),
(125, 'Menthe', 0),
(126, 'sel', 1);

-- --------------------------------------------------------

--
-- Structure de la table `Recette`
--

CREATE TABLE `Recette` (
  `idRecette` int(11) NOT NULL,
  `nomRecette` varchar(50) NOT NULL,
  `creeLe` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Contenu de la table `Recette`
--

INSERT INTO `Recette` (`idRecette`, `nomRecette`, `creeLe`) VALUES
(28, 'Bière blonde', '2020-09-30'),
(29, 'Bière abricot', '2020-09-30'),
(40, 'Bière ', '2020-10-14'),
(41, 'Bière Vodka&Pomme', '2020-10-15'),
(42, 'Bière Peche', '2020-10-15'),
(43, 'Bière Pomme', '2020-10-15'),
(44, 'Bière Tequila', '2020-10-15'),
(45, 'Bière à la framboise', '2020-10-15'),
(46, 'Bière Alaryk (bio)', '2020-10-15'),
(47, 'Bière Ipa', '2020-10-15'),
(48, 'Bière Duchesse Anne', '2020-10-15'),
(49, 'Bière à la chataigne', '2020-10-15'),
(50, 'Bière Fraise', '2020-10-15'),
(51, 'Bière Fraise (bio)', '2020-10-15'),
(52, 'Bière Pomme (bio)', '2020-10-15'),
(53, 'Bière Peche (bio)', '2020-10-15'),
(54, 'Bière Framboise (bio)', '2020-10-15'),
(55, 'Bière Cerise', '2020-10-15'),
(56, 'Bière Cerise (bio)', '2020-10-15'),
(57, 'Bière Menthe', '2020-10-15'),
(58, 'test', '2021-05-06');

--
-- Index pour les tables exportées
--

--
-- Index pour la table `Composition`
--
ALTER TABLE `Composition`
  ADD KEY `idIngredient` (`idIngredient`),
  ADD KEY `idRecette` (`idRecette`);

--
-- Index pour la table `dbo`
--
ALTER TABLE `dbo`
  ADD PRIMARY KEY (`id`);

--
-- Index pour la table `Ingredient`
--
ALTER TABLE `Ingredient`
  ADD PRIMARY KEY (`idIngredient`);

--
-- Index pour la table `Recette`
--
ALTER TABLE `Recette`
  ADD PRIMARY KEY (`idRecette`);

--
-- AUTO_INCREMENT pour les tables exportées
--

--
-- AUTO_INCREMENT pour la table `dbo`
--
ALTER TABLE `dbo`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT pour la table `Ingredient`
--
ALTER TABLE `Ingredient`
  MODIFY `idIngredient` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=128;
--
-- AUTO_INCREMENT pour la table `Recette`
--
ALTER TABLE `Recette`
  MODIFY `idRecette` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=59;
--
-- Contraintes pour les tables exportées
--

--
-- Contraintes pour la table `Composition`
--
ALTER TABLE `Composition`
  ADD CONSTRAINT `Composition_ibfk_1` FOREIGN KEY (`idIngredient`) REFERENCES `Ingredient` (`idIngredient`),
  ADD CONSTRAINT `Composition_ibfk_2` FOREIGN KEY (`idRecette`) REFERENCES `Recette` (`idRecette`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
