CREATE DATABASE InterfacesGraficas

CREATE TABLE Usuarios (
    Id INT IDENTITY(1,1) PRIMARY KEY,  
    Usuario NVARCHAR(50) NOT NULL,      
    Contraseña NVARCHAR(50) NOT NULL    
);

INSERT INTO Usuarios (Usuario, Contraseña)
VALUES ('admin', 'admin');

CREATE TABLE Tareas (
    TareaID INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100) NOT NULL,          
    Descripcion NVARCHAR(255) NULL,         
    Estado NVARCHAR(50) NOT NULL           
);
