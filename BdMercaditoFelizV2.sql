CREATE DATABASE IF NOT EXISTS `mercadofeliz` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `mercadofeliz`;

DELIMITER $$
--
-- Procedimientos
--
DROP PROCEDURE IF EXISTS `sp_DelCliente`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_DelCliente` (IN `_RFC` VARCHAR(13))   begin
    -- 1er validacion _rfc exista
    if exists(select* from cliente where RFC=_RFC)then
    	DELETE FROM cliente WHERE RFC = _RFC;
         select '0' as com_estatus;
    else
       select '1' as com_estatus;
    end if;
 end$$

DROP PROCEDURE IF EXISTS `sp_DelEmpleado`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_DelEmpleado` (IN `_RFC` VARCHAR(13))   begin
    -- 1er validacion _rfc exista
    if exists(select* from empleado where RFC=_RFC)then
    	DELETE FROM empleado WHERE RFC = _RFC;
         select '0' as com_estatus;
    else
       select '1' as com_estatus;
    end if;
 end$$
select* from empleado;
DROP PROCEDURE IF EXISTS `sp_DelProducto`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_DelProducto` (IN `_id` VARCHAR(13))   begin
    -- 1er validacion _rfc exista
    if exists(select* from empleado where id_producto=_id)then
    	DELETE FROM producto WHERE id_producto = _id;
         select '0' as com_estatus;
    else
       select '1' as com_estatus;
    end if;
 end$$

DROP PROCEDURE IF EXISTS `sp_DelProveedor`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_DelProveedor` (IN `_ID` VARCHAR(13))   begin
    -- 1er validacion proveedor exista
    if exists(select* from proveedor where id_proveedor = _ID)then
    	DELETE FROM proveedor WHERE id_proveedor = _ID;
         select '0' as estatus;
    else
       select '1' as estatus;
    end if;
 end$$

DROP PROCEDURE IF EXISTS `sp_InsCliente`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_InsCliente` (IN `_RFC` VARCHAR(13), IN `_nombre` VARCHAR(20), IN `_apPat` VARCHAR(20), IN `_apMat` VARCHAR(20), IN `_tel` NUMERIC(15))   begin
    -- 1er validacion _rfc NO exista
    if not exists(select* from cliente where RFC=_RFC)then
    	insert into cliente values(_RFC, _nombre, _apPat, _apMat,_tel);
         select '0' as com_estatus;
    else
       select '1' as com_estatus;
    end if;
 end$$


DROP PROCEDURE IF EXISTS `sp_InsDetalleVenta`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_InsDetalleVenta` (IN `_nomProducto` VARCHAR(50), IN `_cantidad` DECIMAL(8,2))   begin
	DECLARE idProducto INT;
    SELECT id_producto INTO idProducto FROM producto where nombre = _nomProducto;
	INSERT INTO detalle_venta (cantidad, id_producto,id_venta) VALUES (_cantidad,idProducto,(SELECT id_venta FROM ventas ORDER BY id_venta DESC LIMIT 1));
 end$$

DROP PROCEDURE IF EXISTS `sp_InsEmpleado`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_InsEmpleado` (IN `_RFC` VARCHAR(13), IN `_nombre` VARCHAR(20), IN `_apPat` VARCHAR(20), IN `_apMat` VARCHAR(20), IN `_tel` NUMERIC(15),in `_usuario` VARCHAR(15),in `_contrasena` VARCHAR(15))   begin
    -- 1er validacion _rfc NO exista
    if not exists(select * from empleado where RFC = _RFC)then
    	insert into empleado values(_RFC, _nombre, _apPat, _apMat,_tel,_usuario,_contrasena);
         select '0' as com_estatus;
    else
       select '1' as com_estatus;
    end if;
 end$$
 

DROP PROCEDURE IF EXISTS `sp_InsProducto`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_InsProducto` (IN `_nombre` VARCHAR(50), IN `_existencia` DECIMAL(8,2), IN `_PrecioCompra` DECIMAL(8,3), IN `_PrecioVenta` DECIMAL(8,3), IN `_tipo` VARCHAR(30))   begin
    -- 1er validacion nombre NO exista
    if not exists(select * from producto where nombre = _nombre)then
    	insert into producto values(null, _nombre, _existencia, _PrecioCompra,_PrecioVenta, _tipo);
         select '0' as com_estatus;
    else
       select '1' as com_estatus;
    end if;
 end$$

DROP PROCEDURE IF EXISTS `sp_InsProveedor`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_InsProveedor` (IN `_nombre` VARCHAR(20), IN `_apPat` VARCHAR(20), IN `_apMat` VARCHAR(20), IN `_idProducto` INT(15))   begin
    -- 1er validacion proveedor NO exista
    if not exists(select * from proveedor p where p.id_producto  = _idProducto)then
        insert into proveedor values(null,_nombre,_apPat,_apMat,_idProducto);
        select '0' as estatus;
    else
        select '1' as estatus;
    end if;
 end$$

DROP PROCEDURE IF EXISTS `sp_UpdCliente`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_UpdCliente` (IN `_RFC` VARCHAR(13), IN `_nombre` VARCHAR(20), IN `_apPat` VARCHAR(20), IN `_apMat` VARCHAR(20), IN `_tel` NUMERIC(15))   begin
    -- 1er validacion _rfc exista
    if exists(select* from cliente where RFC=_RFC)then
    	UPDATE cliente 
        SET nombre = _nombre, apellido_paterno = _apPat, apellido_materno = _apMat, telefono = _tel
		WHERE RFC = _RFC;
         select '0' as com_estatus;
    else
       select '1' as com_estatus;
    end if;
 end$$

DROP PROCEDURE IF EXISTS `sp_UpdEmpleado`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_UpdEmpleado` (IN `_RFC` VARCHAR(13), IN `_nombre` VARCHAR(20), IN `_apPat` VARCHAR(20), IN `_apMat` VARCHAR(20), IN `_tel` NUMERIC(15), IN `_usuario` VARCHAR(15), in `_contrasena` VARCHAR(15))   begin
    -- 1er validacion _rfc exista
    if exists(select* from empleado where RFC=_RFC)then
    	UPDATE empleado 
        SET nombre = _nombre, apellido_paterno = _apPat, apellido_materno = _apMat, tlefono = _tel, usuario=_usuario, contrasena=_contrasena
		WHERE RFC = _RFC;
         select '0' as com_estatus;
    else
       select '1' as com_estatus;
    end if;
 end$$

DROP PROCEDURE IF EXISTS `sp_UpdProducto`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_UpdProducto` (IN `_id` VARCHAR(13), IN `_nombre` VARCHAR(50), IN `_existencia` DECIMAL(8,2), IN `_PrecioCompra` DECIMAL(8,3), IN `_PrecioVenta` DECIMAL(8,3), IN `_tipo` VARCHAR(30))   begin
    -- 1er validacion _id exista
    if exists(select* from producto where id_producto=_id)then
    	UPDATE empleado 
        SET nombre = _nombre, existencia = _existencia, precio_compra = _PrecioCompra , precio_venta = _PrecioVenta, tipo=_tipo
		WHERE id_producto  = _id;
         select '0' as com_estatus;
    else
       select '1' as com_estatus;
    end if;
 end$$

DROP PROCEDURE IF EXISTS `sp_UpdProveedor`$$
CREATE DEFINER=`root`@`localhost` PROCEDURE `sp_UpdProveedor` (IN `_id` VARCHAR(13), IN `_nombre` VARCHAR(20), IN `_apPat` VARCHAR(20), IN `_apMat` VARCHAR(20), IN `_IdProducto` NUMERIC(15))   begin
    -- 1er validacion proveedor exista
    if exists(select * from proveedor p where id_proveedor=_id)then
    	UPDATE proveedor 
        SET nombre = _nombre, apellido_paterno = _apPat, apellido_materno = _apMat, p.id_producto = _IdProducto
		WHERE id_proveedor = _id;
         select '0' as estatus;
    else
       select '1' as estatus;
    end if;
 end$$

DELIMITER ;


delimiter $$
create procedure sp_ControlAcceso(
in usuario varchar(15),
in pwd varchar(15)
)
begin
  if exists(
             select e.*
             from   empleado  e
             where  e.usuario=usuario 
             and    e.contrasena=pwd)then
	 
     select '1' as estatus, concat(e.nombre, '',
                                   e.apellido_paterno,'',
                                   e.apellido_materno) as nombre_completo,
							e.usuario
     from   empleado  e
	 where  e.usuario=usuario 
	 and    e.contrasena=pwd;
  else
     select '0' as emp_estatus;
  end if;
end $$
delimiter ;
-- --------------------------------------------------------

-- Estructura de tabla para la tabla `cliente`
--

DROP TABLE IF EXISTS `cliente`;
CREATE TABLE `cliente` (
  `RFC` varchar(13) NOT NULL,
  `nombre` varchar(20) NOT NULL,
  `apellido_paterno` varchar(20) NOT NULL,
  `apellido_materno` varchar(20) NOT NULL,
  `telefono` decimal(15,0) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

select*from cliente;
ALTER TABLE cliente MODIFY COLUMN `apellido_materno` varchar(20) NULL;


--
-- Volcado de datos para la tabla `cliente`
--

INSERT INTO `cliente` (`RFC`, `nombre`, `apellido_paterno`, `apellido_materno`, `telefono`) VALUES
('1234567890xyz', 'Nancy', 'Villeda', 'Villeda', 1234567890);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `detalle_venta`
--

DROP TABLE IF EXISTS `detalle_venta`;
CREATE TABLE `detalle_venta` (
  `id_detalle` int(11) NOT NULL,
  `id_venta` int(11) NOT NULL,
  `id_producto` int(11) NOT NULL,
  `cantidad` decimal(8,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `detalle_venta`
--

INSERT INTO `detalle_venta` (`id_detalle`, `id_venta`, `id_producto`, `cantidad`) VALUES
(1, 1, 1, 2.50),
(2, 1, 2, 1.00),
(4, 3, 1, 10.00),
(7, 5, 2, 2.00),
(8, 5, 2, 2.00),
(9, 5, 2, 5.00);

--
-- Disparadores `detalle_venta`
--
DROP TRIGGER IF EXISTS `BajaInventarioProductos`;
DELIMITER $$
CREATE TRIGGER `BajaInventarioProductos` AFTER INSERT ON `detalle_venta` FOR EACH ROW BEGIN
    UPDATE producto 
    SET existencia = existencia - NEW.cantidad
    WHERE id_producto = NEW.id_producto;
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `empleado`
--

DROP TABLE IF EXISTS `empleado`;
CREATE TABLE `empleado` (
  `RFC` varchar(13) NOT NULL,
  `nombre` varchar(20) NOT NULL,
  `apellido_paterno` varchar(20) NOT NULL,
  `apellido_materno` varchar(20) NOT NULL,
  `tlefono` decimal(15,0) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

ALTER TABLE empleado MODIFY COLUMN `apellido_materno` varchar(20) NULL;
select * from empleado;

--
-- Volcado de datos para la tabla `empleado`
--

INSERT INTO `empleado` (`RFC`, `nombre`, `apellido_paterno`, `apellido_materno`, `tlefono`) VALUES
('1234567890abc', 'Luis', 'Hernandez', 'Torres', 1234567890),
('1234567890cde', 'Hugo', 'Castillo', 'Guzman', 1234567890);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `producto`
--

DROP TABLE IF EXISTS `producto`;
CREATE TABLE `producto` (
  `id_producto` int(11) NOT NULL,
  `nombre` varchar(50) NOT NULL,
  `existencia` decimal(8,2) NOT NULL,
  `precio_compra` decimal(8,3) NOT NULL,
  `precio_venta` decimal(8,3) NOT NULL,
  `tipo` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `producto`
--

INSERT INTO `producto` (`id_producto`, `nombre`, `existencia`, `precio_compra`, `precio_venta`, `tipo`) VALUES
(1, 'Arroz', 40.00, 13.300, 15.900, 'Grano'),
(2, 'Sabritas', 23.00, 15.000, 18.000, 'Fritura');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `proveedor`
--

DROP TABLE IF EXISTS `proveedor`;
CREATE TABLE `proveedor` (
  `id_proveedor` int(11) NOT NULL,
  `nombre` varchar(30) NOT NULL,
  `apellido_paterno` varchar(25) DEFAULT NULL,
  `apellido_materno` varchar(25) DEFAULT NULL,
  `telefono` decimal(13,0) DEFAULT NULL,
  `id_producto` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Estructura Stand-in para la vista `ticket`
-- (Véase abajo para la vista actual)
--
DROP VIEW IF EXISTS `ticket`;
CREATE TABLE `ticket` (
`Fecha` timestamp
,`cliente` varchar(13)
,`empleado` varchar(13)
,`nombre_producto` varchar(50)
,`precio_unitario` decimal(8,3)
,`cantidad_comprada` decimal(8,2)
,`id_venta` int(11)
,`total_venta` decimal(16,5)
);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `ventas`
--

DROP TABLE IF EXISTS `ventas`;
CREATE TABLE `ventas` (
  `id_venta` int(11) NOT NULL,
  `fecha` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  `rfc_cliente` varchar(13) NOT NULL,
  `rfc_empledo` varchar(13) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Volcado de datos para la tabla `ventas`
--

INSERT INTO `ventas` (`id_venta`, `fecha`, `rfc_cliente`, `rfc_empledo`) VALUES
(1, '2024-05-08 16:30:00', '1234567890xyz', '1234567890abc'),
(2, '2024-05-22 02:39:03', '1234567890xyz', '1234567890abc'),
(3, '2024-05-22 02:39:49', '1234567890xyz', '1234567890abc'),
(4, '2024-05-22 02:41:47', '1234567890xyz', '1234567890abc'),
(5, '2024-05-22 18:20:04', '1234567890xyz', '1234567890abc');

-- --------------------------------------------------------

--
-- Estructura para la vista `ticket`
--
DROP TABLE IF EXISTS `ticket`;

DROP VIEW IF EXISTS `ticket`;
CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `ticket`  AS SELECT `v`.`fecha` AS `Fecha`, `v`.`rfc_cliente` AS `cliente`, `v`.`rfc_empledo` AS `empleado`, `p`.`nombre` AS `nombre_producto`, `p`.`precio_venta` AS `precio_unitario`, `dv`.`cantidad` AS `cantidad_comprada`, `dv`.`id_venta` AS `id_venta`, `p`.`precio_venta`* `dv`.`cantidad` AS `total_venta` FROM ((`ventas` `v` join `detalle_venta` `dv` on(`v`.`id_venta` = `dv`.`id_venta`)) join `producto` `p` on(`dv`.`id_producto` = `p`.`id_producto`)) ;

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `cliente`
--
ALTER TABLE `cliente`
  ADD PRIMARY KEY (`RFC`);


ALTER TABLE empleado
ADD COLUMN usuario VARCHAR(15),
ADD COLUMN contrasena VARCHAR(15);

UPDATE empleado
SET usuario = 'LuisHT',
    contrasena = 'luheto'
WHERE RFC= "1234567890abc";

UPDATE empleado
SET usuario = 'HugoCG',
    contrasena = 'hucagu'
WHERE RFC= "1234567890cde";
--
-- Indices de la tabla `detalle_venta`
--
ALTER TABLE `detalle_venta`
  ADD PRIMARY KEY (`id_detalle`),
  ADD KEY `id_venta` (`id_venta`),
  ADD KEY `id_producto` (`id_producto`);

--
-- Indices de la tabla `empleado`
--
ALTER TABLE `empleado`
  ADD PRIMARY KEY (`RFC`);

--
-- Indices de la tabla `producto`
--
ALTER TABLE `producto`
  ADD PRIMARY KEY (`id_producto`);

--
-- Indices de la tabla `proveedor`
--
ALTER TABLE `proveedor`
  ADD PRIMARY KEY (`id_proveedor`),
  ADD KEY `id_producto` (`id_producto`);

--
-- Indices de la tabla `ventas`
--
ALTER TABLE `ventas`
  ADD PRIMARY KEY (`id_venta`),
  ADD KEY `rfc_cliente` (`rfc_cliente`),
  ADD KEY `rfc_empledo` (`rfc_empledo`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `detalle_venta`
--
ALTER TABLE `detalle_venta`
  MODIFY `id_detalle` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT de la tabla `producto`
--
ALTER TABLE `producto`
  MODIFY `id_producto` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT de la tabla `proveedor`
--
ALTER TABLE `proveedor`
  MODIFY `id_proveedor` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `ventas`
--
ALTER TABLE `ventas`
  MODIFY `id_venta` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- Restricciones para tablas volcadas
--

--
-- Filtros para la tabla `detalle_venta`
--
ALTER TABLE `detalle_venta`
  ADD CONSTRAINT `detalle_venta_ibfk_1` FOREIGN KEY (`id_venta`) REFERENCES `ventas` (`id_venta`),
  ADD CONSTRAINT `detalle_venta_ibfk_2` FOREIGN KEY (`id_producto`) REFERENCES `producto` (`id_producto`);

--
-- Filtros para la tabla `proveedor`
--
ALTER TABLE `proveedor`
  ADD CONSTRAINT `proveedor_ibfk_1` FOREIGN KEY (`id_producto`) REFERENCES `producto` (`id_producto`);

--
-- Filtros para la tabla `ventas`
--
ALTER TABLE `ventas`
  ADD CONSTRAINT `ventas_ibfk_1` FOREIGN KEY (`rfc_cliente`) REFERENCES `cliente` (`RFC`),
  ADD CONSTRAINT `ventas_ibfk_2` FOREIGN KEY (`rfc_empledo`) REFERENCES `empleado` (`RFC`);
COMMIT;