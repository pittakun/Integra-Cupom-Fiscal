-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: 27-Dez-2018 às 21:26
-- Versão do servidor: 5.7.23
-- versão do PHP: 7.2.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `bdonlineservice`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `client`
--

DROP TABLE IF EXISTS `client`;
CREATE TABLE IF NOT EXISTS `client` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `phone` varchar(15) COLLATE utf8_bin NOT NULL,
  `address` varchar(150) COLLATE utf8_bin NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=35 DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Extraindo dados da tabela `client`
--

INSERT INTO `client` (`id`, `phone`, `address`) VALUES
(1, '9228 5395', 'r joão luis alves 472 ap 11'),
(2, '9 8421 0669', 'r tupinambas 154'),
(3, '9 8848 1521', 'r ministro salgado filho 182'),
(4, '8722 0586', 'gabriel moura leite 365'),
(5, '3292 6910', 'r martins alfenas 2285'),
(6, '32974800', 'praça getulio vargas 44'),
(7, '8836 4699', 'r alferes domingues vieira e silva 206'),
(8, '-', '-'),
(9, '32926910', 'martins alfenas 2285'),
(10, '9 9716 1220', 'r altino basto carneiro 34'),
(11, '8424 1807', 'r joaquim bernardes da silva 356'),
(12, '991091759', 'r lucas bento da fonseca 27'),
(13, '988264149', 'r rodolfo prado 210'),
(14, '988468112', 'lucas bento da fonseca 84'),
(15, '-', '-'),
(16, '9 8838 9901', 'joão paulino 1193'),
(17, '88793221', 'r tiradentes 1584'),
(18, '98813 2620', 'r joaquim manso vieira 430'),
(19, '988049585', 'r dom pedro ii 151'),
(20, '988049585', 'r dom pedro ii 151'),
(21, '9270 5355', 'r don pedro segundo 555 bloco shiva n6 - condominio são miguel'),
(22, '9 9119 2508', 'professor carvalho junior 39 ap 605'),
(23, '98433 2095', 'ministro salgado filho 433'),
(24, '9 9976 1658', 'r das violetas 54'),
(25, '8892 3601', 'r florentino jose ribeiro 502'),
(26, '99815 7192', 'r coronel pedro correia 737 ap 20'),
(27, '8886 0426', 'dr luis libanio prado 236 ap 06'),
(28, '9708 4445', 'r da amizade 359 casa e fundo'),
(29, '99726 7301', 'r manoel jose de almeida 258'),
(31, '3293 5827', 'r joão custódio da silva 220'),
(32, '987054677', 'r cristina mendes 269'),
(33, '988194556', 'av franisco mariano 384 ap 1203');

-- --------------------------------------------------------

--
-- Estrutura da tabela `count`
--

DROP TABLE IF EXISTS `count`;
CREATE TABLE IF NOT EXISTS `count` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `number` int(11) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Extraindo dados da tabela `count`
--

INSERT INTO `count` (`id`, `number`) VALUES
(1, 13);

-- --------------------------------------------------------

--
-- Estrutura da tabela `product`
--

DROP TABLE IF EXISTS `product`;
CREATE TABLE IF NOT EXISTS `product` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `name` varchar(100) COLLATE utf8_bin NOT NULL,
  `value` varchar(15) COLLATE utf8_bin NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=227 DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

--
-- Extraindo dados da tabela `product`
--

INSERT INTO `product` (`id`, `name`, `value`) VALUES
(1, 'skol 350ml (lata)', '3,50'),
(2, 'skol 350ml (lata) -  fardo(12 unidades)', '36,00'),
(3, 'skol 350ml (lata) -  fardo(18 unidades)', '50,00'),
(4, 'skol 475ml (latão)', '4,00'),
(5, 'skol 475ml (latão) - fardo(12 unidades)', '46,00'),
(6, 'skol 550ml (super latão)', '4,50'),
(7, 'skol 550ml (super latão) - fardo(12 unidades)', '52,00'),
(8, 'skol 300ml (litrinho)', '2,50'),
(9, 'skol 300ml (litrinho) - caixa(23 unidades)', '55,00'),
(10, 'skol 600ml (garrafa)', '6,00'),
(11, 'skol 600ml (garrafa) - caixa(24 unidades)', '140,00'),
(12, 'skol 1l (litrão)', '7,00'),
(13, 'skol 1l (litrão) - caixa(12 unidades)', '84,00'),
(14, 'skol beats azul (lata)', '5,00'),
(15, 'skol beats verde (lata)', '5,00'),
(16, 'skol beats vermelha (lata)', '5,00'),
(17, 'skol beats azul (l-neck)', '5,50'),
(18, 'skol beats verelha (l-neck)', '6,50'),
(19, 'skol beats verde (l-neck)', '5,50'),
(20, 'brahma 350ml (lata)', '3,50'),
(21, 'brahma 350ml (lata) -  fardo(12 unidades)', '36,00'),
(22, 'brahma 350ml (lata) -  fardo(18 unidades)', '50,00'),
(23, 'brahma 475ml (latão)', '4,00'),
(24, 'brahma 475ml (latão) - fardo(12 unidades)', '46,00'),
(25, 'brahma 550ml (super latão)', '4,50'),
(26, 'brahma 550ml (super latão) - fardo(12 unidades)', '52,00'),
(27, 'brahma 300ml (litrinho)', '2,50'),
(28, 'brahma 300ml (litrinho) - caixa(23 unidades)', '55,00'),
(29, 'brahma 600ml (garrafa)', '6,00'),
(30, 'brahma 600ml (garrafa) - caixa(24 unidades)', '140,00'),
(31, 'brahma 1l (litrão)', '7,00'),
(32, 'brahma 1l (litrão) - caixa(12 unidades)', '84,00'),
(33, 'brahma malzebier (l-neck)', '4,50'),
(34, 'brahma (l-neck)', '4,00'),
(35, 'skol (l-neck)', '4,00'),
(36, 'bohemia (l-neck)', '4,50'),
(37, 'antartica 350ml (lata)', '3,00'),
(38, 'antartica 350ml (lata) - fardo(12 unidades)', '36,00'),
(39, 'antartica 600ml (garrafa)', '6,00'),
(40, 'subzero 350ml (lata)', '3,00'),
(41, 'subzero 350ml (lata) -  fardo(12 unidades)', '30,00'),
(42, 'subzero 475ml (latão)', '3,75'),
(43, 'subzero 475ml (latão) - fardo(12 unidades)', '40,00'),
(44, 'subzero 300ml (litrinho)', '2,50'),
(45, 'subzero 300ml (litrinho) - caixa(23 unidades)', '55,00'),
(46, 'subzero 600ml (garrafa)', '4,50'),
(47, 'subzero 600ml (garrafa) - caixa(24 unidades)', '110,00'),
(48, 'subzero 1l (litrão)', '6,00'),
(49, 'subzero 1l (litrão) - caixa(12 unidades)', '72,00'),
(50, 'itaipava 350ml (lata)', '3,00'),
(51, 'itaipava 350ml (lata) - fardo(12 unidades)', '30,00'),
(52, 'itaipava 475ml (latão) - fardo(12 unidades)', '40,00'),
(53, 'itaipava 600ml (garrafa)', '4,50'),
(54, 'itaipava 600ml (garrafa) - caixa(24 unidades)', '110,00'),
(55, 'itaipava 1l (litrão)', '6,00'),
(56, 'itaipava 1l (litrão) - caixa(12 unidades)', '72,00'),
(57, 'budweiser 350ml (lata)', '4,00'),
(58, 'budweiser 350ml (lata) - fardo(12 unidades)', '48,00'),
(59, 'budweiser (l-neck)', '4,50'),
(60, 'budweiser 475ml (latão)', '5,00'),
(61, 'budweiser 600ml(garrafa)', '7,50'),
(62, 'kaiser 350ml (lata)', '3,00'),
(63, 'kaiser 350ml (lata) - fardo(12 unidades)', '30,00'),
(64, 'kaiser 475ml (latão)', '3,50'),
(65, 'kaiser 475ml (latão) - fardo(12 unidades)', '40,00'),
(66, 'lokal 350ml (lata)', '2,00'),
(67, 'lokal 350ml (lata) - fardo(12 unidades)', '24,00'),
(68, 'lokal 475ml (latão)', '3,00'),
(69, 'lokal 475ml (latão) - fardo(12 unidades)', '36,00'),
(70, 'lokal 1l (litrão)', '5,00'),
(71, 'lokal 1l (litrão) - caixa(12 unidades)', '60,00'),
(72, 'heineken 350ml (lata)', '4,00'),
(73, 'heineken 350ml (lata) - fardo(12 unidades)', '48,00'),
(74, 'heineken (l-neck)', '5,00'),
(75, 'heineken (l-neck) - fardo(6 unidades)', '30,00'),
(76, 'heineken 600ml (garrafa)', '9,00'),
(77, 'heineken 600ml (garrafa) - caixa(12 anidades)', '108,00'),
(78, 'glacial 350ml (lata)', '2,00'),
(79, 'glacial 250ml (lata) - fardo(12 unidades)', '24,00'),
(80, 'glacial 475ml (latão)', '3,00'),
(81, 'glacial 475ml (latão) - fardo(12 unidadades)', '36,00'),
(82, 'amistel 350ml (lata)', '4,00'),
(83, 'amistel 475ml (latão)', '5,00'),
(84, 'devassa 350ml (lata)', '5,00'),
(85, 'devassa 600ml (garrafa)', '8,00'),
(86, 'stella artois (l-neck)', '4,50'),
(87, 'stella artois 550ml (garrafa)', '7,50'),
(88, 'petra (l-neck)', '4,50'),
(89, 'petra 350ml (lata)', '4,00'),
(90, 'corona (l-neck)', '7,00'),
(91, 'eisenbahn pilsen (l-neck)', '4,50'),
(92, 'coca-cola 350ml (lata)', '3,50'),
(93, 'coca-cola 350ml (lata) - fardo(12 unidades)', '40,00'),
(94, 'coca-cola 600ml', '4,50'),
(95, 'coca-cola 1l (vidro)', '3,50'),
(96, 'coca-cola 1,5l', '7,00'),
(97, 'coca-cola 2l', '8,00'),
(98, 'coca-cola 2l zero', '8,00'),
(99, 'coca-cola 3,3l', '10,00'),
(100, 'coca-cola 2,5l', '9,00'),
(101, 'coca-cola 200ml', '1,50'),
(102, 'fanta 350ml (lata)', '3,50'),
(103, 'fanta 600ml', '4,50'),
(104, 'fanta 2l', '7,00'),
(105, 'fanta zero 2l', '7,00'),
(106, 'fanta uva 350ml (lata)', '3,50'),
(107, 'fanta uva 600ml', '4,50'),
(108, 'fanta uva 2l', '7,00'),
(109, 'sprite 350ml (lata)', '3,50'),
(110, 'sprite 600ml', '4,50'),
(111, 'sprite 2l', '7,00'),
(112, 'sprite zero 2l', '7,00'),
(113, 'guarana antartica 350ml (lata)', '3,50'),
(114, 'guarana antartica 600ml', '4,50'),
(115, 'guarana antartica 2l', '7,00'),
(116, 'guarana antartica zero 2l', '7,00'),
(117, 'guarana antartica 2,5l', '9,00'),
(118, 'guarana antartica 3,3l', '10,00'),
(119, 'sukita 350ml (lata)', '3,50'),
(120, 'sukita 600ml', '4,50'),
(121, 'sukita 2l', '7,00'),
(122, 'pepsi 350ml (lata)', '3,50'),
(123, 'pepsi 600ml', '4,50'),
(124, 'pepsi 2l', '7,00'),
(125, 'pepsi twiste 2l', '8,00'),
(126, 'pepsi twiste 350ml (lata)', '3,50'),
(127, 'pepsi twiste 600ml', '4,50'),
(128, 'soda 350ml (lata)', '3,50'),
(129, 'soda 600ml', '4,50'),
(130, 'soda 2l', '7,00'),
(131, 'schweppes 350ml (lata)', '3,50'),
(132, 'schweppes 1,5l', '7,00'),
(133, 'frutty sodinha (garrafinha) - caixa(48 unidades)', '36,00'),
(134, 'frutty 350ml (lata)', '1,50'),
(135, 'frutty 500ml', '2,50'),
(136, 'frutty 2l', '4,50'),
(137, 'skol 269ml (palito)', '3,25'),
(138, 'skol 269 (palito) - fardo(15 unidades)', '36,00'),
(139, 'tampico 250ml', '2,00'),
(140, 'tampico 1l', '5,50'),
(141, 'tampico 2l', '9,50'),
(142, 'delvale 1l abacaxi', '6,50'),
(143, 'delvale 1l manga', '6,50'),
(144, 'delvale 1l pessego', '6,50'),
(145, 'delvale 1l laranja', '6,50'),
(146, 'delvale 1l uva', '6,50'),
(147, 'concho y toro taberna', '40,00'),
(148, 'agua c/ gas 500ml', '2,50'),
(149, 'agua c/ gas 1,5l', '4,50'),
(150, 'orloff 1l', '32,00'),
(151, 'kriskoff 1l', '12,00'),
(152, 'askov roxa 1l', '14,00'),
(153, 'askov verde 1l', '14,00'),
(154, 'askov vermelha 1l', '14,00'),
(155, 'askov azul 1l', '14,00'),
(156, 'askov maçã 1l', '14,00'),
(157, 'askov 1l (pura)', '14,00'),
(158, 'natasha 1l', '20,00'),
(159, 'bacadi lemon 1l', '40,00'),
(160, 'bacardi big apple 1l', '40,00'),
(161, 'eisenbahn pilsen (lata)', '4,50'),
(162, 'fusion 1l', '10,00'),
(163, 'speedlife 2l', '15,00'),
(164, 'galão de agua 20l', '10,00'),
(165, 'galão de agua 20l (sem taxa)', '7,00'),
(166, 'caracu 350ml (lata)', '4,00'),
(167, 'caracu (l-neck)', '4,50'),
(168, 'selvagem 300ml', '6,00'),
(169, 'salvagem 1l', '14,00'),
(170, 'selvagem c/açai 1l', '16,00'),
(171, 'selvagem pina 1l (branca)', '16,00'),
(172, 'virtude 1l', '12,00'),
(173, 'malboro box', '8,75'),
(174, 'malboro maço', '8,00'),
(175, 'malboro gold box', '8,75'),
(176, 'malboro gold maço', '8,00'),
(177, 'malboro blue ice', '8,75'),
(178, 'malboro double mix', '9,25'),
(179, 'palermo', '3,50'),
(180, 'dunhill (calton)', '8,75'),
(181, 'dunhill cereja', '9,25'),
(182, 'kent (free) box', '8,25'),
(183, 'kent (free) maço', '8,00'),
(184, 'kent (free) vermelho box', '8,25'),
(185, 'kent (free) vermelho maço', '8,00'),
(186, 'kent (free) azul box', '8,25'),
(187, 'kent (free) azul maço', '8,00'),
(188, 'kent (free) prata', '8,25'),
(189, 'kent (free) verde', '8,25'),
(190, 'kent (free) verde c/ amarula', '8,25'),
(191, 'lucky strike azul', '7,25'),
(192, 'lucky strike verde (menta)', '7,25'),
(193, 'lucky strike double mix', '7,75'),
(194, 'derby azul', '6,75'),
(195, 'derby vermelho', '6,75'),
(196, 'derby prata', '6,75'),
(197, 'miniter silver', '5,25'),
(198, 'minister silver', '5,25'),
(199, 'minister braco/azul', '5,25'),
(200, 'minister vermelho', '5,25'),
(201, 'l.a cereja', '18,00'),
(202, 'sumpoerna', '10,00'),
(203, 'original 600ml (garrafa)', '8,00'),
(204, 'casco ceveja 1l (litrão)', '2,00'),
(205, 'casco ceveja 600ml (garrafa)', '1,00'),
(206, 'casco ceveja 300ml (litrinho)', '1,00'),
(207, 'taxa cigarro (unidade)', '1,00'),
(208, 'sorvete icebom 370ml napolitano', '5,50'),
(209, 'corote', '4,00'),
(210, 'azeitona pequena', '3,00'),
(211, 'halls preto', '2,00'),
(212, 'gelo cubo grande', '10,00'),
(213, 'brahma zero', '4,00'),
(214, 'gelo escamado grande', '10,00'),
(215, 'camel double', '9,00'),
(216, 'carvão de narguile', '8,00'),
(217, 'balalaica', '14,00'),
(218, 'cebolitos pequeno', '3,75'),
(219, 'sorvete napolitano 1,5l', '24,00'),
(221, 'tang limao', '1,25'),
(222, 'flor do norte (5 unidades)', '2,50'),
(223, 'halls menta', '2,00'),
(225, 'gás', '80,00'),
(226, 'gudan chocolate', '20,00');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
