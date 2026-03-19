Proyecto 3 – Aplicación de Gestión de Tareas

Este proyecto es una aplicación web desarrollada con ASP.NET Core MVC, con Visual Studio, que permite a los usuarios gestionar un listado de tareas. 
Los usuarios pueden crear, organizar y administrar sus actividades, así como adjuntar archivos y marcar el progreso de cada tarea.
La aplicación incluye un sistema de autenticación de usuarios y varias funcionalidades interactivas que permiten una experiencia dinámica dentro del navegador.

Tecnologías utilizadas

  ASP.NET Core MVC
  Entity Framework Core
  SQL Server
  ASP.NET Core Identity
  JavaScript
  SweetAlert2
  
Dependencias / Paquetes Nuget

  AutoMapper (versión 16.1.1)
  Microsoft.AspNetCore.Authentication.Google (versión 9.0.8)
  Microsoft.AspNetCore.Identity.EntityFrameworkCore (versión 7.0.0)
  Microsoft.EntityFrameworkCore.SqlServer (versión 9.0.12)
  Microsoft.EntityFrameworkCore.Tools (versión 9.0.12)

Funcionalidades principales

  Creación y gestión de tareas
  Formularios dentro de ventanas modales
  Sistema de usuarios
  Posibilidad de subir archivos adjuntos a las tareas
  Aplicación disponible en varios idiomas
  Interacción dinámica con JavaScript
  Peticiones HTTP desde JavaScript hacia el back-end (Web API)
  Uso de la librería SweetAlert2 para mostrar modales modernos
  Uso de callbacks en JavaScript

Base de datos

  La estructura de la base de datos se encuentra en la carpeta:
  Database/script.sql
  Tener el SQL Server instalado y en funcionamiento. 
  Ejecutar el script SQL descargado para crear la base de datos en SQL Server. (ejecutar el script en master, 
  ya que el script de sql incluye la creación de la base de datos)
  Agregar el nombre de la base de datos en el archivo appsettings.Development.json

Configuración de Google Login
  **(Si no quieres ingresar con Google, puedes usar el inicio de sesión normal y no necesitas configurar secrets para esto.)**
  Si quieres usar el inicio de sesión con Google:
  Debes ingresar a https://console.cloud.google.com/
  Crear un proyecto, y configurar el OAuth, crearla para usuarios externos
  Después debes configurar el ID de cliente de OAuth, y debes ingresar URLs de redireccionamiento autorizados el siguiente link: 
  https://localhost:7063/signin-google (deben reemplazar con su numero de localhost)
  Después debes agregar las credenciales dadas en User Secrets de Visual Studio
  Debes crear el secrets de esta forma, agregando tus credenciales:

{
  "GoogleClientId": "TU_CLIENT_ID",
  "GoogleSecretId": "TU_CLIENT_SECRET"
}

Si quieres crear un usuario admin, debes ingresar el siguiente script en SQL Server, reemplazando el UserId con el respectivo Id del usuario:
INSERT INTO [Proyecto3MVCTareas].[dbo].[AspNetUserRoles] (UserId, RoleId)
VALUES ('UserId', '55df06eb-75cf-47fe-b889-0ccfd491742c');
