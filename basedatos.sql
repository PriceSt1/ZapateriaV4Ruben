SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `zapateriaBadajoz`
--
DROP DATABASE IF EXISTS zapateriaBadajoz;
CREATE DATABASE zapateriaBadajoz;
USE zapateriaBadajoz;
-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tcliente`
--

CREATE TABLE `tcliente` (
  `CodCliente` int AUTO_INCREMENT PRIMARY KEY,
  `Nombre` varchar(50) NOT NULL,
  `Apellidos` varchar(50) NOT NULL,
  `DNI` varchar(50) NOT NULL,
  `Direccion` varchar(100) NOT NULL,
  `Email` varchar(100) NOT NULL,
  `Borrado` varchar(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `tcliente`
--

INSERT INTO `tcliente` (`Nombre`, `Apellidos`, `DNI`, `Direccion`, `Email`, `Borrado`) VALUES
('Javi', 'Díaz', '45562345L', 'Calle falsa nº2', 'javi@email.com', '0');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tfactura`
--

CREATE TABLE `tfactura` (
  `CodFactura` int AUTO_INCREMENT PRIMARY KEY,
  `Cliente` varchar(50) NOT NULL,
  `FechaFactura` varchar(50) NOT NULL,
  `Borrado` varchar(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `tfactura`
--

INSERT INTO `tfactura` (`Cliente`, `FechaFactura`, `Borrado`) VALUES
('Javi Díaz', '16/02/2017', '0');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tlibro`
-- 

CREATE TABLE `tzapato` (
  `CodZapato` int AUTO_INCREMENT PRIMARY KEY,
  `Marca` varchar(50) NOT NULL,
  `Nombre` varchar(50) NOT NULL,
  `Color` varchar(50) NOT NULL,
  `Tipo` varchar(50) NOT NULL,
  `Precio` varchar(50) NOT NULL,
  `Formatouno` varchar(50) NOT NULL,
  `Formatodos` varchar(50) NOT NULL,
  `Formatotres` varchar(50) NOT NULL,
  `Estado` varchar(50) NOT NULL,
  `Borrado` varchar(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `tlibro`
--

INSERT INTO `tzapato` (`Marca`, `Nombre`, `Color`, `Tipo`, `Precio`, `Formatouno`, `Formatodos`, `Formatotres`, `Estado`, `Borrado`) VALUES
('Converse', 'All Stars', 'Negro', 'Deportivas', '120,00', 'N/A', 'Tela', 'N/A', 'Stock', '0');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `tlineafactura`
--

CREATE TABLE `tlineafactura` (
  `CodFactura` int AUTO_INCREMENT PRIMARY KEY,
  `Zapato` varchar(50) NOT NULL,
  `Cantidad` varchar(50) NOT NULL,
  `Total` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `tlineafactura`
--

INSERT INTO `tlineafactura` (`Zapato`, `Cantidad`, `Total`) VALUES
('All Stars', '4', '142,0');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ttema`
--

CREATE TABLE `tcolor` (
  `color` varchar(30) NOT NULL,
  `Borrado` tinyint(1) NOT NULL DEFAULT '0'
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `ttema`
--

INSERT INTO `tcolor` (`color`, `Borrado`) VALUES
('Blanco', 0),
('Negro', 0),
('Azul', 0),
('Verde', 0),
('Amarillo', 0),
('Cian', 0),
('Morado', 0),
('Rojo', 0),
('Rosa', 0),
('Naranja', 0),
('Turquesa', 0),
('Beige', 0);

ALTER TABLE `tcolor`
  ADD PRIMARY KEY (`color`),
  ADD UNIQUE KEY `color` (`color`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

DROP USER IF EXISTS 'AdminZapateria'@'localhost';
CREATE USER 'AdminZapateria'@'localhost' IDENTIFIED BY 'ClaveRoot#20';
GRANT ALL PRIVILEGES ON zapateriaBadajoz.* TO 'AdminZapateria'@'localhost';