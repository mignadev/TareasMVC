Proyecto 3 – Aplicación de Gestión de Tareas

Este proyecto es una aplicación web desarrollada con ASP.NET Core MVC que permite a los usuarios gestionar un listado de tareas. 
Los usuarios pueden crear, organizar y administrar sus actividades, así como adjuntar archivos y marcar el progreso de cada tarea.
La aplicación incluye un sistema de autenticación de usuarios y varias funcionalidades interactivas que permiten una experiencia dinámica dentro del navegador.

Tecnologías utilizadas

ASP.NET Core MVC
Entity Framework Core
SQL Server
ASP.NET Core Identity
JavaScript
SweetAlert2

Funcionalidades principales

  Creación y gestión de tareas
  Formularios dentro de ventanas modales
  Sistema de usuarios y autenticación con ASP.NET Identity
  Posibilidad de subir archivos adjuntos a las tareas
  Aplicación disponible en varios idiomas
  Interacción dinámica con JavaScript
  Peticiones HTTP desde JavaScript hacia el back-end (Web API)
  Uso de la librería SweetAlert2 para mostrar modales modernos
  Uso de callbacks en JavaScript

Base de datos

  La estructura de la base de datos se encuentra en la carpeta:
  Database/script.sql

Para configurarla:

  1. Abrir SQL Server Management Studio
  2. Ejecutar el script SQL
  3. Configurar la cadena de conexión en appsettings.Developtment.json

Configuración de Google Login
  **(Si no quieres ingresar con Google, puedes usar el inicio de sesión normal y no necesitas configurar secrets para esto.)**
  Si quieres usar el inicio de sesión con Google:
  
  Debes agregar tus propias credenciales en User Secrets de Visual Studio.
  1. Haz clic derecho al proyecto
  2. Selecciona Administrar secretos de usuario

  Luego agrega algo a lo siguiente:

  "GoogleClientId":TU_CLIENT_ID
  "GoogleSecretId":TU_CLIENT_SECRET

  Se utiliza el archivo User Secrets para almacenar credenciales de correo que no deben incluirse en el repositorio por razones de seguridad.

Ejecución del proyecto

  1. Clonar el repositorio
  2. Crear la base de datos ejecutando el script SQL
3. Configurar la cadena de conexión en appsettings.Development.json
4. Configurar los User Secrets si se desea usar Google Login
5. Ejecutar la aplicación desde Visual Studio
