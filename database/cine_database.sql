-- ============================================
-- CinemaBox - Script de Base de Datos
-- Ejecutar en MySQL / phpMyAdmin / XAMPP
-- ============================================

-- Crear la base de datos
DROP DATABASE IF EXISTS cine;
CREATE DATABASE cine CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE cine;

-- ============================================
-- TABLA: users (Usuarios del sistema)
-- ============================================
CREATE TABLE users (
    id INT PRIMARY KEY AUTO_INCREMENT,
    cuenta VARCHAR(50) NOT NULL UNIQUE COMMENT 'Nombre de usuario para login',
    nombre VARCHAR(100) NOT NULL COMMENT 'Nombre completo del usuario',
    pword VARCHAR(255) NOT NULL COMMENT 'Contraseña del usuario',
    monto FLOAT DEFAULT 0 COMMENT 'Saldo disponible del usuario'
) ENGINE=InnoDB;

-- ============================================
-- TABLA: products (Películas)
-- ============================================
CREATE TABLE products (
    id INT PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(100) NOT NULL COMMENT 'Nombre de la película',
    img VARCHAR(255) COMMENT 'Nombre del archivo de imagen',
    about TEXT COMMENT 'Sinopsis de la película',
    precio FLOAT NOT NULL COMMENT 'Precio del boleto',
    stock INT DEFAULT 0 COMMENT 'Cantidad de boletos disponibles'
) ENGINE=InnoDB;

-- ============================================
-- TABLA: sweets (Dulcería)
-- ============================================
CREATE TABLE sweets (
    id INT PRIMARY KEY AUTO_INCREMENT,
    name VARCHAR(100) NOT NULL COMMENT 'Nombre del producto',
    stock INT DEFAULT 0 COMMENT 'Cantidad en inventario',
    about TEXT COMMENT 'Descripción del producto',
    price FLOAT NOT NULL COMMENT 'Precio del producto'
) ENGINE=InnoDB;

-- ============================================
-- DATOS DE EJEMPLO: Usuarios
-- ============================================
INSERT INTO users (cuenta, nombre, pword, monto) VALUES
('admin', 'Administrador del Sistema', 'admin123', 10000.00),
('usuario1', 'Juan Pérez López', 'pass123', 500.00),
('usuario2', 'María García Hernández', 'pass456', 750.00),
('usuario3', 'Carlos Rodríguez Martínez', 'pass789', 300.00),
('test', 'Usuario de Prueba', 'test', 1000.00);

-- ============================================
-- DATOS DE EJEMPLO: Películas
-- Las imágenes deben estar en la carpeta Images/
-- ============================================
INSERT INTO products (name, img, about, precio, stock) VALUES
('Back to the Future', 'backToTheFuture.jpg', 
 'Marty McFly, un adolescente, es enviado accidentalmente 30 años al pasado en un DeLorean que viaja en el tiempo, inventado por su amigo, el excéntrico científico Doc Brown.', 
 85.00, 50),

('Emma', 'emma.jpg', 
 'En la Inglaterra del siglo XIX, Emma Woodhouse es una joven rica y hermosa que disfruta inmiscuyéndose en las vidas amorosas de los demás, mientras evita su propio romance.', 
 75.00, 40),

('Ferris Bueller''s Day Off', 'ferris.jpg', 
 'Un estudiante de secundaria muy popular decide tomarse un día libre y convence a su mejor amigo y a su novia de acompañarlo en una aventura por Chicago.', 
 70.00, 45),

('Gone Girl', 'goneGirl.jpg', 
 'Con su esposa desaparecida y los medios de comunicación presionándole, Nick Dunne se encuentra en el centro de una investigación policial que lo considera principal sospechoso.', 
 90.00, 35),

('Knives Out', 'knivesOut.jpg', 
 'Un detective investiga la muerte de un patriarca de una familia excéntrica y disfuncional, descubriendo una red de mentiras y secretos.', 
 95.00, 55),

('La La Land', 'lalaLand.jpg', 
 'En Los Ángeles, el pianista de jazz Sebastian y la aspirante a actriz Mia se enamoran mientras persiguen sus sueños en una ciudad conocida por destruir esperanzas.', 
 85.00, 60),

('Pride and Prejudice', 'prideAndPrej.jpg', 
 'La historia del turbulento romance entre la inteligente Elizabeth Bennet y el orgulloso Mr. Darcy en la Inglaterra de la Regencia.', 
 75.00, 40),

('Shrek', 'shreck.jpg', 
 'Un ogro verde llamado Shrek ve su pantano invadido por personajes de cuentos de hadas, y para recuperar su hogar debe rescatar a una princesa de la torre de un dragón.', 
 65.00, 70);

-- ============================================
-- DATOS DE EJEMPLO: Dulcería
-- ============================================
INSERT INTO sweets (name, stock, about, price) VALUES
('Palomitas Grandes', 100, 'Palomitas de maíz recién hechas con mantequilla derretida - Tamaño grande 170oz', 85.00),
('Palomitas Medianas', 120, 'Palomitas de maíz recién hechas con mantequilla derretida - Tamaño mediano 85oz', 65.00),
('Palomitas Chicas', 150, 'Palomitas de maíz recién hechas con mantequilla derretida - Tamaño chico 46oz', 45.00),
('Refresco Grande', 80, 'Refresco de cola con hielo - Vaso de 32oz', 55.00),
('Refresco Mediano', 100, 'Refresco de cola con hielo - Vaso de 21oz', 45.00),
('Refresco Chico', 120, 'Refresco de cola con hielo - Vaso de 12oz', 35.00),
('Nachos con Queso', 60, 'Crujientes totopos de maíz con queso cheddar caliente y jalapeños', 75.00),
('Hot Dog', 50, 'Hot dog clásico con salchicha de res, cebolla, mostaza y ketchup', 55.00),
('Combo Pareja', 40, 'Incluye: 1 Palomitas grandes + 2 Refrescos medianos', 120.00),
('Combo Familiar', 30, 'Incluye: 2 Palomitas grandes + 4 Refrescos medianos + 1 Nachos', 250.00),
('Chocolates', 200, 'Caja de chocolates surtidos', 45.00),
('Gomitas', 180, 'Bolsa de gomitas de frutas', 35.00);

-- ============================================
-- Verificación de datos insertados
-- ============================================
SELECT 'Usuarios insertados:' AS Info, COUNT(*) AS Total FROM users;
SELECT 'Películas insertadas:' AS Info, COUNT(*) AS Total FROM products;
SELECT 'Dulces insertados:' AS Info, COUNT(*) AS Total FROM sweets;

-- ============================================
-- Consultas útiles para verificación
-- ============================================
-- SELECT * FROM users;
-- SELECT * FROM products;
-- SELECT * FROM sweets;
