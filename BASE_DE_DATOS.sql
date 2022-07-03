--CREACION DE BASE DE DATOS
USE master
GO

CREATE DATABASE DBCine
GO

USE DBCine
GO
--1
CREATE TABLE Usuarios(
ID_Usuario_U int NOT NULL identity (1,1),
Nombre_U varchar(100) NOT NULL,
Apellido_U varchar(100) NOT NULL,
DNI_U varchar(100) NOT NULL,
Telefono_U varchar(100) NOT NULL,
Email_U varchar(100) NOT NULL,
Contraseña_U varchar(100) NOT NULL,
Tipo_Usuario_U bit,
Estado_U bit DEFAULT 1,
CONSTRAINT PK_Usuarios PRIMARY KEY (ID_Usuario_U),
CONSTRAINT UQ_Usuarios_Dni Unique (DNI_U)
)
GO

--2
CREATE TABLE Ventas(
ID_Venta_V int NOT NULL identity (1,1),
ID_Usuario_V int NOT NULL,
Fecha_V smalldatetime NOT NULL,
Metodo_Pago_V varchar(100) NOT NULL,
Monto_Final_V DECIMAL(8,2) DEFAULT '0,00',
CodigoQR_V VARCHAR(50),
CodigoAlfanumerico_V VARCHAR(50)
CONSTRAINT PK_Ventas PRIMARY KEY (ID_Venta_V),
CONSTRAINT FK_Ventas_Usuarios FOREIGN KEY (ID_Usuario_V) REFERENCES Usuarios (ID_Usuario_U)
)
GO

--3
CREATE TABLE Complejos(
ID_Complejo_Co char(5) NOT NULL,
Nombre_Co varchar(100) NOT NULL,
Direccion_Co varchar(100) NOT NULL,
Telefono_Co varchar(100) NOT NULL,
Email_Co varchar(100) NOT NULL,
Estado_Co bit DEFAULT 1,
CONSTRAINT PK_Complejos PRIMARY KEY(ID_Complejo_Co),
CONSTRAINT UQ_Complejos_Nombre UNIQUE (Nombre_Co),
CONSTRAINT UQ_Complejos_Direccion UNIQUE (Direccion_Co)
)
GO

--4
CREATE TABLE Salas(
ID_Sala_S char(5) NOT NULL,
ID_Complejo_S char(5) NOT NULL,
Total_Asientos_S int NOT NULL,
Estado_S bit DEFAULT 1,
CONSTRAINT PK_Salas_S PRIMARY KEY (ID_Sala_S, ID_Complejo_S),
CONSTRAINT FK_Salas_Complejos FOREIGN KEY (ID_Complejo_S) REFERENCES Complejos (ID_Complejo_Co)

)
GO

--5
CREATE TABLE Peliculas(
ID_Pelicula_P char(5) NOT NULL,
Titulo_P varchar(100) NOT NULL,
Descripcion_P text NOT NULL,
Duracion_P char(5) NOT NULL,
Clasificacion_P char(5) NOT NULL,
Genero_P varchar(100) NOT NULL,
Portada_P varchar(100) NULL,
Estado_P bit DEFAULT 1,
LinkYoutube_P varchar(1000) NULL,
CONSTRAINT PK_Peliculas PRIMARY KEY (ID_Pelicula_P)
)
GO

--6
CREATE TABLE Funciones(
ID_Funcion_F char(5) NOT NULL,
ID_Pelicula_F char(5) NOT NULL,
ID_Sala_F char(5) NOT NULL,
ID_Complejo_F char(5) NOT NULL,
Fecha_F date NOT NULL,
Horario_F time NOT NULL,
Idioma_F varchar(100) NOT NULL,
Precio_F DECIMAL(8,2) DEFAULT '0,00',
Formato_F char(5) NOT NULL,
Estado_F bit DEFAULT 1,
CONSTRAINT PK_Funciones PRIMARY KEY (ID_Funcion_F),
CONSTRAINT FK_Funciones_Peliculas FOREIGN KEY (ID_Pelicula_F) REFERENCES Peliculas (ID_Pelicula_P),
CONSTRAINT FK_Funciones_Salas FOREIGN KEY (ID_Sala_F,ID_Complejo_F) REFERENCES Salas (ID_Sala_S,ID_Complejo_S),
)
GO

--7
CREATE TABLE Asientos(
ID_Asiento_A char(5) NOT NULL,
ID_Sala_A char(5) NOT NULL,
ID_Complejo_A char(5) NOT NULL,
Estado_A bit DEFAULT 1,
CONSTRAINT PK_Asientos PRIMARY KEY (ID_Asiento_A,ID_Sala_A,ID_Complejo_A),
CONSTRAINT FK_Asientos_Salas FOREIGN KEY (ID_Sala_A,ID_Complejo_A) REFERENCES Salas (ID_Sala_S,ID_Complejo_S)
)
GO

--8
CREATE TABLE Detalle_Ventas(
ID_DetalleVenta_DV int NOT NULL identity (1,1),
ID_Venta_DV int NOT NULL,
ID_Funcion_DV char(5) NOT NULL,
ID_Sala_DV char(5) NOT NULL,
ID_Complejo_DV char(5) NOT NULL,
Cantidad_DV int NOT NULL,
Precio_DV DECIMAL(8,2) DEFAULT '0,00',
CONSTRAINT PK_DetalleVentas PRIMARY KEY (ID_DetalleVenta_DV,ID_Venta_DV, ID_Funcion_DV),
CONSTRAINT FK_DetalleVentas FOREIGN KEY (ID_Venta_DV) REFERENCES Ventas (ID_Venta_V),
CONSTRAINT FK_DetalleVentas_Salas FOREIGN KEY (ID_Sala_DV,ID_Complejo_DV) REFERENCES Salas (ID_Sala_S,ID_Complejo_S),
CONSTRAINT FK_DetalleVentas_Funciones FOREIGN KEY (ID_Funcion_DV) REFERENCES Funciones (ID_Funcion_F)
)
GO

--9
CREATE TABLE AsientosComprados(
ID_Asiento_AC char(5) NOT NULL,
ID_DetalleVenta_AC int NOT NULL,
ID_Venta_AC int NOT NULL,
ID_Funcion_AC char(5) NOT NULL,
ID_Sala_AC char(5) NOT NULL,
ID_Complejo_AC char(5) NOT NULL,
Estado_AC bit DEFAULT 1,
CONSTRAINT PK_AsientosComprados PRIMARY KEY (ID_Asiento_AC,ID_DetalleVenta_AC,ID_Venta_AC,ID_Funcion_AC,ID_Sala_AC,ID_Complejo_AC),
CONSTRAINT FK_AsientosComprados_Asientos FOREIGN KEY (ID_Asiento_AC,ID_Sala_AC,ID_Complejo_AC) REFERENCES Asientos (ID_Asiento_A,ID_Sala_A,ID_Complejo_A),
CONSTRAINT FK_AsientosComprados_DetalleVentas FOREIGN KEY (ID_DetalleVenta_AC,ID_Venta_AC,ID_Funcion_AC) REFERENCES Detalle_Ventas (ID_DetalleVenta_DV,ID_Venta_DV,ID_Funcion_DV),
CONSTRAINT FK_AsientosComprados_Funciones FOREIGN KEY (ID_Funcion_AC) REFERENCES Funciones (ID_Funcion_F)
)
GO


--COMPLEJOS
INSERT INTO Complejos (ID_Complejo_Co,Nombre_Co,Direccion_Co,Telefono_Co,Email_Co)
SELECT 1,'Galag Pacheco','Hipolito Yrigoyen 213',1168082134,'galagpacheco@gmail.com' UNION
SELECT 2,'Galag Pilar','San Martin 1943',1142134322,'galagpilar@gmail.com' UNION
SELECT 3,'Galag Tigre','Pedro Lagrave 392',1143920193,'galagtigre@gmail.com'
GO

--SALAS
INSERT INTO Salas (ID_Sala_S,ID_Complejo_S,Total_Asientos_S,Estado_S)
SELECT 1,1,9,1 UNION
SELECT 2,1,9,1 UNION
SELECT 3,1,9,1 UNION
SELECT 1,2,9,1 UNION
SELECT 2,2,9,1 UNION
SELECT 3,2,9,1 UNION
SELECT 1,3,9,1 UNION
SELECT 2,3,9,1 UNION
SELECT 3,3,9,1
GO

--ASIENTOS
--SALA 1 COMPLEJO 1
INSERT INTO Asientos (ID_Asiento_A,ID_Sala_A,ID_Complejo_A)
SELECT 1,1,1 UNION
SELECT 2,1,1 UNION
SELECT 3,1,1 UNION
SELECT 4,1,1 UNION
SELECT 5,1,1 UNION
SELECT 6,1,1 UNION
SELECT 7,1,1 UNION
SELECT 8,1,1 UNION
SELECT 9,1,1 UNION
--SALA 2 COMPLEJO 1
SELECT 1,2,1 UNION
SELECT 2,2,1 UNION
SELECT 3,2,1 UNION
SELECT 4,2,1 UNION
SELECT 5,2,1 UNION
SELECT 6,2,1 UNION
SELECT 7,2,1 UNION
SELECT 8,2,1 UNION
SELECT 9,2,1 UNION
--SALA 3 COMPLEJO 1
SELECT 1,3,1 UNION
SELECT 2,3,1 UNION
SELECT 3,3,1 UNION
SELECT 4,3,1 UNION
SELECT 5,3,1 UNION
SELECT 6,3,1 UNION
SELECT 7,3,1 UNION
SELECT 8,3,1 UNION
SELECT 9,3,1 UNION
--SALA 1 COMPLEJO 2
SELECT 1,1,2 UNION
SELECT 2,1,2 UNION
SELECT 3,1,2 UNION
SELECT 4,1,2 UNION
SELECT 5,1,2 UNION
SELECT 6,1,2 UNION
SELECT 7,1,2 UNION
SELECT 8,1,2 UNION
SELECT 9,1,2 UNION
--SALA 2 COMPLEJO 2
SELECT 1,2,2 UNION
SELECT 2,2,2 UNION
SELECT 3,2,2 UNION
SELECT 4,2,2 UNION
SELECT 5,2,2 UNION
SELECT 6,2,2 UNION
SELECT 7,2,2 UNION
SELECT 8,2,2 UNION
SELECT 9,2,2 UNION
--SALA 3 COMPLEJO 2
SELECT 1,3,2 UNION
SELECT 2,3,2 UNION
SELECT 3,3,2 UNION
SELECT 4,3,2 UNION
SELECT 5,3,2 UNION
SELECT 6,3,2 UNION
SELECT 7,3,2 UNION
SELECT 8,3,2 UNION
SELECT 9,3,2 UNION
--SALA 1 COMPLEJO 3
SELECT 1,1,3 UNION
SELECT 2,1,3 UNION
SELECT 3,1,3 UNION
SELECT 4,1,3 UNION
SELECT 5,1,3 UNION
SELECT 6,1,3 UNION
SELECT 7,1,3 UNION
SELECT 8,1,3 UNION
SELECT 9,1,3 UNION
--SALA 2 COMPLEJO 3
SELECT 1,2,3 UNION
SELECT 2,2,3 UNION
SELECT 3,2,3 UNION
SELECT 4,2,3 UNION
SELECT 5,2,3 UNION
SELECT 6,2,3 UNION
SELECT 7,2,3 UNION
SELECT 8,2,3 UNION
SELECT 9,2,3 UNION
--SALA 3 COMPLEJO 3
SELECT 1,3,3 UNION
SELECT 2,3,3 UNION
SELECT 3,3,3 UNION
SELECT 4,3,3 UNION
SELECT 5,3,3 UNION
SELECT 6,3,3 UNION
SELECT 7,3,3 UNION
SELECT 8,3,3 UNION
SELECT 9,3,3 
GO

-- Tabla Peliculas
INSERT INTO Peliculas (ID_Pelicula_P, Titulo_P, Descripcion_P,Duracion_P, Clasificacion_P, Genero_P, Portada_P, Estado_P, LinkYoutube_P)
SELECT '1','Pulp Fiction', 'La vida de un boxeador, dos sicarios, la esposa de un gánster y dos bandidos se entrelaza en una historia de violencia y redención.', '153 m', 'P-18', 'Thriller, Crimen', '/Imagenes/Portadas/Pulp Fiction.jpg', 1,'s7EdQ4FqbhY' UNION
SELECT '2','Doctor Strange en el multiverso de la locura', 'El Dr. Stephen Strange abre un portal al multiverso al utilizar un hechizo prohibido. Ahora, su equipo debe enfrentarse a una amenaza que podría destruirlo todo.', '126 m', 'P-13', 'Fantasía, Acción, Aventura, Terror', '/Imagenes/Portadas/Doctor Strange.jpg', 1,'D9AzGVmMVpk' UNION
SELECT '3', 'Jurassic World', 'La isla Nublar y su parque han sido destruidos, pero el problema no se terminó. Con los dinosaurios dispersos por todo el mundo, la convivencia entre el presente y el pasado alcanza un nuevo nivel de tensión.', '135 m', 'P-13', 'Aventura, Acción', '/Imagenes/Portadas/Jurassic World.jpg', 1,'qehG9dKVDG4' UNION
SELECT '4', 'Lightyear', 'Buzz Lightyear se embarca en una aventura intergaláctica con un grupo de reclutas ambiciosos y su compañero robot.', '100 m', 'ATP', 'Animación, Familia, Ciencia Ficción', '/Imagenes/Portadas/Lightyear.jpg', 1,'WikwAJ3NQew' UNION
SELECT '5', 'Rápidos y Furiosos 9', 'Dom Toretto vive una vida tranquila junto a Letty y su hijo, pero el peligro siempre regresa a su vida. En esta ocasión, el equipo se enfrenta a un complot mundial orquestado por el asesino más temible del mundo: el hermano de Dom', '143 m', 'P- 13', 'Acción, Aventura', 'Imagenes\Portadas\Rápidos y Furiosos 9.png',1,'t3DpuQrBivU' UNION
SELECT '6', 'Había una vez en Hollywood', 'A finales de los 60, Hollywood empieza a cambiar y el actor Rick Dalton trata de adaptarse a los nuevos tiempos. Junto a su doble, ambos experimentan problemas para modificar sus hábitos, debido a lo enraizados que están. Al mismo tiempo, nace una relación entre Rick y la actriz Sharon Tate, que fue víctima de la familia Manson en la matanza de 1969.', '160 m', 'P- 16', 'Drama, Comedia', 'Imagenes\Portadas\Habia una vez en Hollywood.png',1,'bLqTt35GCA4' UNION
SELECT '7', 'Interestelar', 'Un grupo de científicos y exploradores, encabezados por Cooper, se embarcan en un viaje espacial para encontrar un lugar con las condiciones necesarias para reemplazar a la Tierra y comenzar una nueva vida allí.', '169 m', 'P- 16', 'Ciencia Ficción, Aventura', 'Imagenes\Portadas\Interestelar.png',1,'zSWdZVtXT7E' UNION
SELECT '8', 'Nace una estrella', 'Jackson, una estrella de la música country con problemas de alcoholismo, descubre el talento de Ally, una joven cantante de la cual se enamora. Mientras la carrera de ella despega, Jackson percibe que sus días de gloria están llegando a su fin.', '135 m', 'P- 16', 'Romance, Musical', 'Imagenes\Portadas\Nace una estrella.png',1,'M12R2MXkELs' UNION
SELECT '9', 'Revenant: el renacido', 'Hugh Glass, un trampero y explorador de finales del siglo XIX resulta herido de muerte por el ataque de un oso. Sus compañeros deciden dejarle para proseguir con la expedición.', '156 m', 'P- 16', 'Wéstern, Aventura', 'Imagenes\Portadas\Revenant el renacido.png',1,'LoebZZ8K5N0' UNION
SELECT '10', 'Bastardos sin gloria', 'II Guerra Mundial, Francia, Shosanna presencia la ejecución de su familia por orden del coronel nazi Hans Landa. Huye a Paris y adopta una nueva identidad como propietaria de un cine. Mientras el teniente Aldo Raine adiestra a un grupo de soldados judíos.', '153 m', 'P- 16', 'Acción, Bélico', 'Imagenes\Portadas\Bastardos sin gloria.png',1,'b8J_kP8Mses'
GO

--Tabla Funciones
INSERT INTO Funciones (ID_Funcion_F, ID_Pelicula_F, ID_Sala_F, ID_Complejo_F, Fecha_F, Horario_F, Idioma_F, Precio_F, Estado_F,Formato_F)
-- COMPLEJO 1
-- Pelicula 1
SELECT '1', '1', '1', '1','20220702', '20:00:00', 'Español', 500 , 1 ,'2D' UNION
SELECT '2', '1', '2', '1',  '20220702', '22:45:00', 'Español', 500 , 1,'2D' UNION
SELECT '3', '1', '3', '1',  '20220703', '22:00:00', 'Subtitulado', 600 ,1,'3D' UNION
SELECT '4', '1', '2', '1',  '20220706', '19:00:00', 'Subtitulado', 600 ,1,'3D' UNION
-- Pelicula 2
SELECT '5', '2', '1', '1',  '20220710', '22:45:00', 'Español', 500 , 1,'2D' UNION
SELECT '6', '2', '2', '1',  '20220712', '20:00:00', 'Español', 500 , 1,'2D' UNION
SELECT '7', '2', '3', '1',  '20220714', '20:00:00', 'Subtitulado', 600 , 1,'3D' UNION
SELECT '8', '2', '2', '1',  '20220715', '17:00:00', 'Subtitulado', 600 , 1,'3D' UNION
 --Pelicula 3
SELECT '9', '3', '1', '1',  '20220711', '18:00:00', 'Español', 500 , 1,'2D' UNION
SELECT '10', '3', '2', '1',  '20220716', '17:30:00', 'Español', 500 , 1,'2D' UNION
SELECT '11', '3', '3', '1',  '20220718', '23:30:00', 'Subtitulado', 600 , 1,'3D' UNION
SELECT '12', '3', '2', '1',  '20220719', '14:30:00', 'Subtitulado', 600 , 1,'3D' UNION
--Pelicula 4
SELECT '13', '4', '1', '1',  '20220720', '13:30:00', 'Español', 500 , 1,'2D' UNION
SELECT '14', '4', '2', '1',  '20220720', '14:45:00', 'Español', 500 , 1,'2D' UNION
SELECT '15', '4', '3', '1',  '20220721', '17:30:00', 'Subtitulado', 600 , 1,'3D' UNION
--Pelicula 5
SELECT '16', '5', '1', '1',  '20220722', '20:00:00', 'Español', 500 , 1,'2D' UNION
SELECT '17', '5', '2', '1',  '20220722', '23:30:00', 'Español', 600 , 1,'3D' UNION
--Pelicula 6
SELECT '18', '6', '1', '1','20220702', '19:00:00', 'Español', 500 , 1 ,'2D' UNION
SELECT '19', '6', '2', '1',  '20220702', '21:45:00', 'Español', 500 , 1,'2D' UNION
SELECT '20', '6', '3', '1',  '20220703', '23:00:00', 'Subtitulado', 600 ,1,'3D' UNION
SELECT '21', '6', '2', '1',  '20220706', '17:00:00', 'Subtitulado', 600 ,1,'3D' UNION
--Pelicula 7
SELECT '22', '7', '3', '1',  '20220710', '21:45:00', 'Español', 500 , 1,'2D' UNION
SELECT '23', '7', '1', '1',  '20220712', '18:00:00', 'Español', 500 , 1,'2D' UNION
SELECT '24', '7', '2', '1',  '20220714', '22:00:00', 'Subtitulado', 600 , 1,'3D' UNION
SELECT '25', '7', '3', '1',  '20220715', '17:00:00', 'Subtitulado', 600 , 1,'3D' UNION
--Pelicula 8
SELECT '26', '8', '3', '1',  '20220711', '20:00:00', 'Español', 500 , 1,'2D' UNION
SELECT '27', '8', '1', '1',  '20220716', '15:30:00', 'Español', 500 , 1,'2D' UNION
SELECT '28', '8', '2', '1',  '20220718', '21:30:00', 'Subtitulado', 600 , 1,'3D' UNION
SELECT '29', '8', '1', '1',  '20220719', '18:30:00', 'Subtitulado', 600 , 1,'3D' UNION
--Pelicula 9
SELECT '30', '9', '3', '1',  '20220720', '17:30:00', 'Español', 500 , 1,'2D' UNION
SELECT '31', '9', '1', '1',  '20220720', '21:45:00', 'Español', 500 , 1,'2D' UNION
SELECT '32', '9', '2', '1',  '20220721', '19:30:00', 'Subtitulado', 600 , 1,'3D' UNION
--Pelicula 10
SELECT '33', '10', '3', '1',  '20220722', '22:00:00', 'Español', 500 , 1,'2D' UNION
SELECT '34', '10', '1', '1',  '20220722', '20:30:00', 'Español', 600 , 1,'3D' UNION

--COMPLEJO 2

--Pelicula 1
SELECT '35', '1', '1', '2','20220702', '20:00:00', 'Español', 500 , 1 ,'2D' UNION
SELECT '36', '1', '2', '2',  '20220702', '22:45:00', 'Español', 500 , 1,'2D' UNION
SELECT '37', '1', '3', '2',  '20220703', '22:00:00', 'Subtitulado', 600 ,1,'3D' UNION
SELECT '38', '1', '2', '2',  '20220706', '19:00:00', 'Subtitulado', 600 ,1,'3D' UNION
-- Pelicula 2
SELECT '39', '2', '1', '2',  '20220710', '22:45:00', 'Español', 500 , 1,'2D' UNION
SELECT '40', '2', '2', '2',  '20220712', '20:00:00', 'Español', 500 , 1,'2D' UNION
SELECT '41', '2', '3', '2',  '20220714', '20:00:00', 'Subtitulado', 600 , 1,'3D' UNION
SELECT '42', '2', '2', '2',  '20220715', '17:00:00', 'Subtitulado', 600 , 1,'3D' UNION
 --Pelicula 3
SELECT '44', '3', '1', '2',  '20220711', '18:00:00', 'Español', 500 , 1,'2D' UNION
SELECT '45', '3', '2', '2',  '20220716', '17:30:00', 'Español', 500 , 1,'2D' UNION
SELECT '46', '3', '3', '2',  '20220718', '23:30:00', 'Subtitulado', 600 , 1,'3D' UNION
SELECT '47', '3', '2', '2',  '20220719', '14:30:00', 'Subtitulado', 600 , 1,'3D' UNION
--Pelicula 4
SELECT '48', '4', '1', '2',  '20220720', '13:30:00', 'Español', 500 , 1,'2D' UNION
SELECT '49', '4', '2', '2',  '20220720', '14:45:00', 'Español', 500 , 1,'2D' UNION
SELECT '50', '4', '3', '2',  '20220721', '17:30:00', 'Subtitulado', 600 , 1,'3D' UNION
--Pelicula 5
SELECT '51', '5', '1', '2',  '20220722', '20:00:00', 'Español', 500 , 1,'2D' UNION
SELECT '52', '5', '2', '2',  '20220722', '23:30:00', 'Español', 600 , 1,'3D' UNION
--Pelicula 6
SELECT '53', '6', '3', '2','20220702', '19:00:00', 'Español', 500 , 1 ,'2D' UNION
SELECT '54', '6', '1', '2',  '20220702', '21:45:00', 'Español', 500 , 1,'2D' UNION
SELECT '55', '6', '2', '2',  '20220703', '23:00:00', 'Subtitulado', 600 ,1,'3D' UNION
SELECT '56', '6', '3', '2',  '20220706', '17:00:00', 'Subtitulado', 600 ,1,'3D' UNION
--Pelicula 7
SELECT '57', '7', '3', '2',  '20220710', '21:45:00', 'Español', 500 , 1,'2D' UNION
SELECT '58', '7', '1', '2',  '20220712', '18:00:00', 'Español', 500 , 1,'2D' UNION
SELECT '59', '7', '2', '2',  '20220714', '22:00:00', 'Subtitulado', 600 , 1,'3D' UNION
SELECT '60', '7', '1', '2',  '20220715', '17:00:00', 'Subtitulado', 600 , 1,'3D' UNION
--Pelicula 8
SELECT '61', '8', '3', '2',  '20220711', '20:00:00', 'Español', 500 , 1,'2D' UNION
SELECT '62', '8', '1', '2',  '20220716', '15:30:00', 'Español', 500 , 1,'2D' UNION
SELECT '63', '8', '2', '2',  '20220718', '21:30:00', 'Subtitulado', 600 , 1,'3D' UNION
SELECT '64', '8', '3', '2',  '20220719', '18:30:00', 'Subtitulado', 600 , 1,'3D' UNION
--Pelicula 9
SELECT '65', '9', '3', '2',  '20220720', '17:30:00', 'Español', 500 , 1,'2D' UNION
SELECT '66', '9', '1', '2',  '20220720', '21:45:00', 'Español', 500 , 1,'2D' UNION
SELECT '67', '9', '2', '2',  '20220721', '19:30:00', 'Subtitulado', 600 , 1,'3D' UNION
--Pelicula 10
SELECT '68', '10', '3', '2',  '20220722', '22:00:00', 'Español', 500 , 1,'2D' UNION
SELECT '69', '10', '1', '2',  '20220722', '20:30:00', 'Español', 600 , 1,'3D' UNION

-- COMPLEJO 3

--Pelicula 1
SELECT '70', '1', '1', '3','20220702', '20:00:00', 'Español', 500 , 1 ,'2D' UNION
SELECT '71', '1', '2', '3',  '20220702', '22:45:00', 'Español', 500 , 1,'2D' UNION
SELECT '72', '1', '3', '3',  '20220703', '22:00:00', 'Subtitulado', 600 ,1,'3D' UNION
SELECT '73', '1', '2', '3',  '20220706', '19:00:00', 'Subtitulado', 600 ,1,'3D' UNION
--Pelicula 2
SELECT '74', '2', '1', '3',  '20220710', '22:45:00', 'Español', 500 , 1,'2D' UNION
SELECT '75', '2', '2', '3',  '20220712', '20:00:00', 'Español', 500 , 1,'2D' UNION
SELECT '76', '2', '3', '3',  '20220714', '20:00:00', 'Subtitulado', 600 , 1,'3D' UNION
SELECT '77', '2', '2', '3',  '20220715', '17:00:00', 'Subtitulado', 600 , 1,'3D' UNION
 --Pelicula 3
SELECT '78', '3', '1', '3',  '20220711', '18:00:00', 'Español', 500 , 1,'2D' UNION
SELECT '79', '3', '2', '3',  '20220716', '17:30:00', 'Español', 500 , 1,'2D' UNION
SELECT '80', '3', '3', '3',  '20220718', '23:30:00', 'Subtitulado', 600 , 1,'3D' UNION
SELECT '81', '3', '2', '3',  '20220719', '14:30:00', 'Subtitulado', 600 , 1,'3D' UNION
--Pelicula 4
SELECT '82', '4', '1', '3',  '20220720', '13:30:00', 'Español', 500 , 1,'2D' UNION
SELECT '83', '4', '2', '3',  '20220720', '14:45:00', 'Español', 500 , 1,'2D' UNION
SELECT '84', '4', '3', '3',  '20220721', '17:30:00', 'Subtitulado', 600 , 1,'3D' UNION
--Pelicula 5
SELECT '85', '5', '1', '3',  '20220722', '20:00:00', 'Español', 500 , 1,'2D' UNION
SELECT '86', '5', '2', '3',  '20220722', '23:30:00', 'Español', 600 , 1,'3D' UNION
--Pelicula 6
SELECT '87', '6', '3', '3','20220702', '19:00:00', 'Español', 500 , 1 ,'2D' UNION
SELECT '88', '6', '1', '3',  '20220702', '21:45:00', 'Español', 500 , 1,'2D' UNION
SELECT '89', '6', '2', '3',  '20220703', '23:00:00', 'Subtitulado', 600 ,1,'3D' UNION
SELECT '90', '6', '3', '3',  '20220706', '17:00:00', 'Subtitulado', 600 ,1,'3D' UNION
--Pelicula 7
SELECT '91', '7', '3', '3',  '20220710', '21:45:00', 'Español', 500 , 1,'2D' UNION
SELECT '92', '7', '1', '3',  '20220712', '18:00:00', 'Español', 500 , 1,'2D' UNION
SELECT '93', '7', '2', '3',  '20220714', '22:00:00', 'Subtitulado', 600 , 1,'3D' UNION
SELECT '94', '7', '3', '3',  '20220715', '17:00:00', 'Subtitulado', 600 , 1,'3D' UNION
--Pelicula 8
SELECT '95', '8', '3', '3',  '20220711', '20:00:00', 'Español', 500 , 1,'2D' UNION
SELECT '96', '8', '1', '3',  '20220716', '15:30:00', 'Español', 500 , 1,'2D' UNION
SELECT '97', '8', '2', '3',  '20220718', '21:30:00', 'Subtitulado', 600 , 1,'3D' UNION
SELECT '98', '8', '1', '3',  '20220719', '18:30:00', 'Subtitulado', 600 , 1,'3D' UNION
--Pelicula 9
SELECT '99', '9', '3', '3',  '20220720', '17:30:00', 'Español', 500 , 1,'2D' UNION
SELECT '100', '9', '1', '3',  '20220720', '21:45:00', 'Español', 500 , 1,'2D' UNION
SELECT '101', '9', '2', '3',  '20220721', '19:30:00', 'Subtitulado', 600 , 1,'3D' UNION
--Pelicula 10
SELECT '102', '10', '3', '3',  '20220722', '22:00:00', 'Español', 500 , 1,'2D' UNION
SELECT '103', '10', '1', '3',  '20220722', '20:30:00', 'Español', 600 , 1,'3D'
GO

-- USUARIOS
INSERT INTO Usuarios (Nombre_U,Apellido_U,DNI_U,Telefono_U,Email_U,Contraseña_U,Tipo_Usuario_U)
SELECT 'admin','admin',42123123,1122334455,'admin@gmail.com',1,1 UNION -- ADMINISTRADOR --
SELECT 'Gaspar','Ortmann',43913108,1168082459,'gasparortmann@gmail.com',1,0 UNION
SELECT 'Agustin','Rojas',45123231,1142456784,'agustinrojas@gmail.com',1,0 UNION
SELECT 'Aaron','Meza',46123509,1129847618,'aaronmeza@gmail.com',1,0 UNION
SELECT 'Gabriel','Bettiga',45123519,1130847618,'Gabriel@gmail.com',1,0
GO

----VENTAS
--INSERT INTO Ventas (ID_Usuario_V,Fecha_V,Metodo_Pago_V,Monto_Final_V)
----USUARIO 2
--SELECT 2,GETDATE(),'DEBITO',500 UNION
----USUARIO 3
--SELECT 3,GETDATE(),'CREDITO',1200
--GO

----DETALLE VENTAS
--INSERT INTO Detalle_Ventas(ID_Venta_DV,ID_Funcion_DV,ID_Sala_DV,ID_Complejo_DV,Cantidad_DV,Precio_DV)
----USUARIO 2
--SELECT '1','1','1','1',1,500 UNION
----USUARIO 3
--SELECT '2','5','2','1',2,600
--GO

----ASIENTOS COMPRADOS
--INSERT INTO AsientosComprados(ID_Complejo_AC,ID_Sala_AC,ID_Asiento_AC,ID_Venta_AC,ID_DetalleVenta_AC,ID_Funcion_AC)
----USUARIO 2
--SELECT '1','1','1','1','1','1' UNION
----USUARIO 3
--SELECT '1','2','1','2','2','5' UNION
--SELECT '1','2','2','2','2','5'
--GO
------COMPLEJO--------
CREATE PROCEDURE sp_AgregarComplejo
@IDCOMPLEJO char(5),
@NOMBRECOMPLEJO varchar(100),
@DIRECCIONCOMPLEJO varchar(100),
@TELEFONOCOMPLEJO varchar(100),
@EMAILCOMPLEJO varchar(100)
AS
	INSERT INTO Complejos (ID_Complejo_Co,Nombre_Co,Direccion_Co,Telefono_Co,Email_Co)
	VALUES (@IDCOMPLEJO,@NOMBRECOMPLEJO,@DIRECCIONCOMPLEJO,@TELEFONOCOMPLEJO,@EMAILCOMPLEJO)

GO

CREATE PROCEDURE sp_EliminarComplejo
@IDCOMPLEJO char(5)
AS
DELETE FROM Complejos
WHERE Id_Complejo_Co = @IDCOMPLEJO

GO
CREATE PROCEDURE sp_ModificarComplejo
@IDCOMPLEJO char(5),
@NOMBRECOMPLEJO varchar(100),
@DIRECCIONCOMPLEJO varchar(100),
@TELEFONOCOMPLEJO varchar(100),
@EMAILCOMPLEJO varchar(100),
@ESTADOCOMPLEJO BIT
AS
	UPDATE Complejos
	SET ID_Complejo_Co=@IDCOMPLEJO,
	Nombre_Co =@NOMBRECOMPLEJO ,
	Direccion_Co=@DIRECCIONCOMPLEJO,
	Telefono_Co=@TELEFONOCOMPLEJO,
	Email_Co=@EMAILCOMPLEJO,
	Estado_Co=@ESTADOCOMPLEJO
	WHERE ID_Complejo_Co = @IDCOMPLEJO
GO
------SALA--------
CREATE PROCEDURE sp_AgregarSala
@ID char(5),
@IDCOMPLEJO char(5),
@TOTALASIENTOS int

AS
INSERT INTO Salas (ID_Sala_S,ID_Complejo_S,Total_Asientos_S)
VALUES (@ID,@IDCOMPLEJO,@TOTALASIENTOS)
GO
CREATE PROCEDURE sp_ModificarSala
@ID char(5),
@IDCOMPLEJO char(5),
@TOTALASIENTOS int,
@ESTADO bit
AS
	UPDATE Salas
	SET Total_Asientos_S=@TOTALASIENTOS,
	Estado_S=@ESTADO
	WHERE ID_Sala_S = @ID AND ID_Complejo_S=@IDCOMPLEJO
GO
CREATE PROCEDURE sp_EliminarSala
@ID char(5),
@IDCOMPLEJO char(5)
AS
DELETE FROM Salas
WHERE ID_Sala_S = @ID AND ID_Complejo_S=@IDCOMPLEJO
GO
------FUNCIONES--------
CREATE PROCEDURE sp_AgregarFuncion
@IDFUNCION char(5),
@IDPELICULA char(5),
@IDSALA char(5),
@IDCOMPLEJO char(5),
@FECHA date,
@HORARIO time(7),
@IDIOMA varchar(100),
@PRECIO decimal(8,2),
@FORMATO char(5)
AS
	INSERT INTO Funciones (ID_Funcion_F,ID_Pelicula_F,ID_Sala_F,ID_Complejo_F,Fecha_F,Horario_F,Idioma_F,Precio_F,Formato_F)
	VALUES (@IDFUNCION,@IDPELICULA,@IDSALA,@IDCOMPLEJO,@FECHA,@HORARIO,@IDIOMA,@PRECIO,@FORMATO)

GO

CREATE PROCEDURE sp_EliminarFuncion
@IDFUNCION char(5)
AS
DELETE FROM Funciones
WHERE ID_Funcion_F = @IDFUNCION

GO
CREATE PROCEDURE sp_ModificarFuncion
@IDFUNCION char(5),
@IDPELICULA char(5),
@IDSALA char(5),
@IDCOMPLEJO char(5),
@FECHA date,
@HORARIO time(7),
@IDIOMA varchar(100),
@PRECIO decimal(8,2),
@ESTADO bit,
@FORMATO char(5)
AS
	UPDATE Funciones
	SET ID_Funcion_F=@IDFUNCION,
	ID_Pelicula_F=@IDPELICULA,
	ID_Sala_F=@IDSALA,
	ID_Complejo_F=@IDCOMPLEJO,
	Fecha_F=@FECHA,
	Horario_F=@HORARIO,
	Idioma_F=@IDIOMA,
	Precio_F=@PRECIO,
	Estado_F=@ESTADO,
	Formato_F=@FORMATO
	WHERE ID_Funcion_F = @IDFUNCION
GO

-- PROCEDIMIENTO ALMACENADO DE USUARIOS

CREATE PROCEDURE sp_AgregarUsuario
(
@NOMBREUSUARIO varchar(100),
@APELLIDOUSUARIO varchar(100),
@DNIUSUARIO varchar(100),
@TELEFONOUSUARIO varchar(100),
@EMAILUSUARIO varchar(100),
@CONTRASEÑAUSUARIO varchar(100),
@TIPOUSUARIO bit
)
AS
	INSERT INTO Usuarios(Nombre_U, Apellido_U, DNI_U, Telefono_U, Email_U, Contraseña_U, Tipo_Usuario_U)
	VALUES (@NOMBREUSUARIO,@APELLIDOUSUARIO,@DNIUSUARIO,@TELEFONOUSUARIO,@EMAILUSUARIO,@CONTRASEÑAUSUARIO,@TIPOUSUARIO)
return
go

CREATE PROCEDURE sp_ModificarUsuario
(
@IDUSUARIO int,
@NOMBREUSUARIO varchar(100),
@APELLIDOUSUARIO varchar(100),
@DNIUSUARIO varchar(100),
@TELEFONOUSUARIO varchar(100),
@EMAILUSUARIO varchar(100),
@CONTRASEÑAUSUARIO varchar(100),
@TIPOUSUARIO bit,
@ESTADOUSUARIO bit
)
AS
	UPDATE Usuarios
	SET 
	Nombre_U =@NOMBREUSUARIO ,
	Apellido_U=@APELLIDOUSUARIO,
	DNI_U = @DNIUSUARIO,
	Email_U = @EMAILUSUARIO,
	Contraseña_U = @CONTRASEÑAUSUARIO,
	Tipo_Usuario_U = @TIPOUSUARIO,
	Estado_U = @ESTADOUSUARIO
	WHERE ID_Usuario_U= @IDUSUARIO
GO

CREATE PROCEDURE sp_EliminarUsuario
(
@IDUSUARIO INT
)
AS
DELETE Usuarios
WHERE ID_Usuario_U = @IDUSUARIO
go
------ASIENTOS-----
--SP ASIENTOS
CREATE PROCEDURE sp_AgregarAsiento
@IDASIENTO char(5),
@IDSALA char(5),
@IDCOMPLEJO char(5),
@ESTADOASIENTO BIT
AS
	INSERT INTO Asientos (ID_Asiento_A,ID_Sala_A,ID_Complejo_A,Estado_A)
	VALUES (@IDASIENTO,@IDSALA,@IDCOMPLEJO,@ESTADOASIENTO)
GO

CREATE PROCEDURE sp_EliminarAsiento
@IDASIENTO char(5),
@IDSALA char(5),
@IDCOMPLEJO char(5)
AS
DELETE FROM Asientos
WHERE ID_Asiento_A = @IDASIENTO and ID_Sala_A=@IDSALA and ID_Complejo_A=@IDCOMPLEJO
GO

CREATE PROCEDURE sp_ModificarAsiento
@IDASIENTO char(5),
@IDSALA char(5),
@IDCOMPLEJO char(5),
@ESTADOASIENTO BIT
AS
	UPDATE Asientos
	SET ID_Asiento_A=@IDASIENTO,
	ID_Sala_A=@IDSALA,
	ID_Complejo_A=@IDCOMPLEJO,
	Estado_A=@ESTADOASIENTO
	WHERE ID_Asiento_A = @IDASIENTO and ID_Sala_A=@IDSALA and ID_Complejo_A=@IDCOMPLEJO
GO
-----PELICULAS------
CREATE PROCEDURE sp_AgregarPeliculas
@ID_Pelicula char(5),
@Titulo varchar(100),
@Descripcion text,
@Duracion char(5),
@Clasificacion char(5),
@Genero varchar(100),
@Portada varchar(100),
@Estado bit
AS
	INSERT INTO Peliculas (ID_Pelicula_P,Titulo_P,Descripcion_P,Duracion_P,Clasificacion_P,Genero_P,Portada_P)
	VALUES				(@ID_Pelicula,@Titulo,@Descripcion,@Duracion,@Clasificacion,@Genero,@Portada)
GO


CREATE PROCEDURE sp_EliminarPelicula
@ID_Pelicula char(5)
AS
DELETE FROM Peliculas
WHERE ID_Pelicula_P = @ID_Pelicula
GO


CREATE PROCEDURE sp_ModificarPelicula
@ID_Pelicula char(5),
@Titulo varchar(100),
@Descripcion text,
@Duracion char(5),
@Clasificacion char(5),
@Genero varchar(100),
@Portada varchar(100),
@Estado bit
AS
	UPDATE Peliculas
	SET
	ID_Pelicula_P = @ID_Pelicula,
	Titulo_P = @Titulo,
	Descripcion_P = @Descripcion,
	Duracion_P = @Duracion,
	Clasificacion_P = @Clasificacion,
	Genero_P = @Genero,
	Portada_P = @Portada,
	Estado_P = @Estado
	WHERE ID_Pelicula_P = @ID_Pelicula
	GO
----LOGIN-----
--Para saber si el usuario que quiere iniciar sesion existe.
CREATE Procedure sp_ExisteUsuario
(
@EMAIL_U VARCHAR,
@CONTRASEÑA VARCHAR
)
AS
IF EXISTS (SELECT Email_U, Contraseña_U, Estado_U FROM Usuarios
WHERE 
Email_U = @EMAIL_U AND Contraseña_U = @CONTRASEÑA AND Estado_U = 1)
BEGIN
RETURN 1 
END
ELSE
BEGIN
RETURN 0
END
GO

-- Para saber si el usuario es admin o no.
CREATE PROCEDURE sp_EsAdmin
(
@Email_U INT
)
AS
IF EXISTS ( SELECT Email_U, Tipo_Usuario_U from Usuarios
WHERE Email_U = @Email_U AND Tipo_Usuario_U = 1)
BEGIN
RETURN 1
END
ELSE
BEGIN 
RETURN 0
END
GO
------TRIGGERS--------
CREATE TRIGGER tr_NoBorrarComplejo ON Complejos
INSTEAD OF DELETE
AS
UPDATE Complejos
SET Estado_Co = 0
WHERE ID_Complejo_Co=(SELECT ID_Complejo_Co FROM DELETED)
GO
CREATE TRIGGER tr_NoBorrarSala ON Salas
INSTEAD OF DELETE
AS
UPDATE Salas
SET Estado_S = 0
WHERE ID_Sala_S=(SELECT ID_Sala_S FROM DELETED)
AND ID_Complejo_S=(SELECT ID_Complejo_S FROM DELETED)
GO
CREATE TRIGGER tr_NoBorrarAsiento ON Asientos
INSTEAD OF DELETE
AS
UPDATE Asientos
SET Estado_A = 0
WHERE ID_Asiento_A=(SELECT ID_Asiento_A FROM DELETED)
AND ID_Complejo_A=(SELECT ID_Complejo_A FROM DELETED)
AND ID_Sala_A = (SELECT ID_Sala_A FROM DELETED)
GO
CREATE TRIGGER tr_NoBorrarFuncion ON Funciones
INSTEAD OF DELETE
AS
UPDATE Funciones
SET Estado_F = 0
WHERE ID_Funcion_F=(SELECT ID_Funcion_F FROM DELETED)
GO
CREATE TRIGGER tr_NoBorrarPelicula ON Peliculas
INSTEAD OF DELETE
AS
UPDATE Peliculas
SET Estado_P = 0
WHERE ID_Pelicula_P=(SELECT ID_Pelicula_P FROM DELETED)
GO
CREATE TRIGGER tr_NoBorrarAsientosComprados ON AsientosComprados
INSTEAD OF DELETE
AS
UPDATE AsientosComprados
SET Estado_AC = 0
WHERE ID_Asiento_AC=(SELECT ID_Asiento_AC FROM DELETED)
AND ID_DetalleVenta_AC=(SELECT ID_DetalleVenta_AC FROM DELETED)
AND ID_Venta_AC=(SELECT ID_Venta_AC FROM DELETED)
AND ID_Funcion_AC=(SELECT ID_Funcion_AC FROM DELETED)
AND ID_Sala_AC=(SELECT ID_Sala_AC FROM DELETED)
AND ID_Complejo_AC=(SELECT ID_Complejo_AC FROM DELETED)
GO


CREATE TRIGGER tr_NoBorrarUsuario ON Usuarios
INSTEAD OF DELETE
AS
UPDATE Usuarios
SET Estado_U = 0
WHERE ID_Usuario_U=(SELECT ID_Usuario_U FROM DELETED)
GO
-------------ventas-------------------------------
create procedure sp_AgregarVenta 
@IDUSUARIO int,
@METODOPAGO varchar(100),
@MONTOFINAL  money
as

insert into Ventas (ID_Usuario_V,Fecha_V,Metodo_Pago_V,Monto_Final_V)
values (@IDUSUARIO,GETDATE(),@METODOPAGO,@MONTOFINAL)
GO
----------------AsientoComprados--------------------

create procedure sp_AgregarAsientoComprados
@IDASIENTO char (5),
@IDDETALLEDEVENTA int,
@IDVENTA int,
@IDFUNCION char (5),
@IDSALA char (5),
@IDCOMPLEJO char (5) 
as


insert into AsientosComprados(ID_Asiento_AC,ID_DetalleVenta_AC,ID_Venta_AC,ID_Funcion_AC,ID_Sala_AC,ID_Complejo_AC)
values (@IDASIENTO,@IDDETALLEDEVENTA,@IDVENTA,@IDFUNCION,@IDSALA,@IDCOMPLEJO)
GO
---------------detalle Ventas----------------
create procedure sp_AgrergarDetalleVentas
@IDVENTA int,
@IDFUNCION Char(5),
@IDSALA Char(5),
@IDCOMPLEJO Char(5),
@CANTIDAD int, 
@PRECIO decimal(8,2)

as

insert into Detalle_Ventas (ID_Venta_DV,ID_Funcion_DV,ID_Sala_DV,ID_Complejo_DV,Cantidad_DV,Precio_DV)
values (@IDVENTA,@IDFUNCION,@IDSALA,@IDCOMPLEJO,@CANTIDAD,@PRECIO)
GO
-------------FUNCION HIPER MEGA CONSULTA-------------------
CREATE FUNCTION GetLocacionAsientos(@IDVENTA INT, @IDUSUARIO INT) RETURNS VARCHAR(100)
AS
BEGIN
	RETURN (SELECT STUFF((SELECT ','+ID_Asiento_AC FROM AsientosComprados INNER JOIN Detalle_Ventas ON ID_Venta_AC=ID_Venta_DV and ID_DetalleVenta_DV=ID_DetalleVenta_AC INNER JOIN Ventas ON ID_Venta_V=ID_Venta_DV WHERE ID_Usuario_V=@IDUSUARIO AND ID_Venta_V=@IDVENTA FOR XML PATH('')),1,1,''))
END
GO
---------------QRVENTAS----------------
CREATE PROCEDURE sp_CodigoQR
@IDVENTA int,
@CODIGOALFANUMERICO varchar(50)
AS
UPDATE Ventas
SET CodigoAlfanumerico_V = @CODIGOALFANUMERICO,
CodigoQR_V = '/Imagenes/QR/' + @CODIGOALFANUMERICO + '.jpg'
WHERE ID_Venta_V = @IDVENTA
GO