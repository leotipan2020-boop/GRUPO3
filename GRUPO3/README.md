# SISTEMA DE GESTIÓN ESCOLAR - GRUPO 3

## 1. Descripción del proyecto

El Sistema de Gestión Escolar es una aplicación web desarrollada con ASP.NET Core MVC y C#, utilizando Entity Framework Core y SQL Server como base de datos.

Su finalidad es facilitar la administración de información académica mediante operaciones de registro, consulta, edición y eliminación de datos.

## 2. Objetivo

Desarrollar un sistema web que permita gestionar información escolar de forma organizada, aplicando el patrón Modelo-Vista-Controlador (MVC) y operaciones CRUD.

## 3. Tecnologías utilizadas

- Visual Studio 2026
- ASP.NET Core MVC
- Lenguaje C#
- Entity Framework Core
- SQL Server Express
- Bootstrap
- HTML y Razor
- Git y GitHub

## 4. Integrantes y responsabilidades

El proyecto está distribuido entre cinco integrantes:

| Integrante | Responsabilidad |
|------------|-----------------|
| Persona 1 | CRUD de Aulas |
| Persona 2 | CRUD de Estudiantes |
| Persona 3 | CRUD de Maestros y README.md |
| Persona 4 | CRUD de Libros |
| Persona 5 | CRUD de Asignaturas |

Los nombres de los integrantes se completarán según la distribución oficial del grupo.

## 5. Módulos del sistema

El sistema contempla los siguientes módulos:

- Aulas: administración de información de aulas.
- Estudiantes: administración de estudiantes.
- Maestros: administración de docentes y sus especialidades.
- Libros: administración de información de libros.
- Asignaturas: administración de asignaturas académicas.

Cada módulo se implementa de acuerdo con el avance y las responsabilidades de los integrantes.

## 6. Módulo de Maestros

El módulo de Maestros permite realizar las operaciones CRUD:

- Create: registrar un nuevo maestro.
- Read: consultar la lista y los detalles de maestros.
- Update: editar la información de un maestro.
- Delete: eliminar un registro de maestro.

### Campos del modelo Maestro

- Id: identificador único.
- Nombre: nombre del maestro.
- Apellido: apellido del maestro.
- Especialidad: área académica del maestro.

### Archivos principales

- Models/Maestro.cs
- Controllers/MaestrosController.cs
- Views/Maestros/Index.cshtml
- Views/Maestros/Create.cshtml
- Views/Maestros/Edit.cshtml
- Views/Maestros/Details.cshtml
- Views/Maestros/Delete.cshtml

## 7. Base de datos

El proyecto utiliza SQL Server Express.

Servidor local:
localhost\SQLEXPRESS

Base de datos:
GRUPO3Escolar

La conexión se configura en el archivo appsettings.json mediante la clave ConexionEscolar.

Entity Framework Core se utiliza para gestionar las entidades y las migraciones de la base de datos.

## 8. Instrucciones para ejecutar el proyecto

1. Clonar o descargar el repositorio de GitHub.
2. Abrir la solución GRUPO3 en Visual Studio.
3. Restaurar los paquetes NuGet.
4. Verificar que SQL Server Express esté instalado y funcionando.
5. Revisar la conexión ConexionEscolar en appsettings.json.
6. Abrir la Consola del Administrador de paquetes NuGet.
7. Seleccionar GRUPO3 como proyecto predeterminado.
8. Ejecutar el comando:

   Update-Database

9. Compilar y ejecutar el proyecto con F5.
10. Utilizar el menú de navegación para acceder a los módulos disponibles.

## 9. Pruebas realizadas

Se verificó el funcionamiento del módulo de Maestros:

- Registro de maestros: correcto.
- Listado de maestros: correcto.
- Consulta de detalles: correcto.
- Edición de maestros: correcto.
- Eliminación de maestros: correcto.
- Actualización de la base de datos: correcta.

## 10. Trabajo colaborativo

El proyecto se desarrolla de manera colaborativa mediante Git y GitHub.

Cada integrante es responsable de implementar su módulo, realizar las pruebas correspondientes y compartir los cambios con el equipo.

## 11. Conclusión

El desarrollo del Sistema de Gestión Escolar permite aplicar conocimientos de programación web, bases de datos, arquitectura MVC, Entity Framework Core y trabajo colaborativo.

El módulo de Maestros fue implementado y probado satisfactoriamente, permitiendo registrar, consultar, modificar y eliminar información de docentes.
