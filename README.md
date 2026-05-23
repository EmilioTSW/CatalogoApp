Catálogo de Videojuegos

Aplicación web desarrollada con ASP.NET Core MVC enfocada en la administración y visualización de una colección personal de videojuegos favoritos.

El proyecto utiliza una arquitectura organizada por capas siguiendo principios de desarrollo limpio y separación de responsabilidades.

Descripción del Proyecto

Esta aplicación permite explorar un catálogo de videojuegos organizados por:

Género
Consola
Año de lanzamiento

Además, el usuario puede:

Ver detalles de cada videojuego
Agregar nuevos títulos al catálogo
Navegar en una interfaz moderna estilo gamer/neón

La temática visual está inspirada en interfaces retro-futuristas y videojuegos clásicos.

Videojuegos Incluidos

Actualmente el catálogo contiene videojuegos como:

Devil May Cry
Castlevania: Symphony of the Night
NieR: Automata
Rust
Halo Reach
Arquitectura del Proyecto

El sistema está dividido en 4 capas principales:

CatalogoApp.Domain

Contiene:

Modelos del sistema
Interfaces
Entidades principales

Ejemplo:

Item.cs
IItemRepository.cs
CatalogoApp.Application

Contiene:

Servicios
Lógica de negocio

Ejemplo:

ItemService.cs
CatalogoApp.Infrastructure

Contiene:

Repositorios
Acceso a datos
Lectura de archivos JSON

Ejemplo:

JsonItemRepository.cs
CatalogoApp.Presentation

Contiene:

Controladores MVC
Vistas Razor
CSS
Interfaz visual

Ejemplo:

CatalogoController.cs
Views
site.css
Diseño de la Interfaz

La interfaz fue diseñada con estilo gamer moderno utilizando:

Efectos neón
Colores rosa y morado
Fondo oscuro
Tarjetas dinámicas
Animaciones hover
Tipografía futurista
Tecnologías Utilizadas
ASP.NET Core MVC
C#
Razor Views
HTML5
CSS3
Arquitectura en capas
JSON como almacenamiento temporal
Funcionalidades
Visualizar videojuegos
Agregar videojuegos
Ver detalles de cada juego
Interfaz moderna responsive
Filtrado por género
Arquitectura limpia y organizada
Vista Principal

La página principal incluye:

Navbar gamer
Sección de bienvenida
Explicación del proyecto
Catálogo visual de videojuegos
Autor

Jorge Emilio Batún Alcocer
TSU en Desarrollo de Software y Negocios Digitales

Profesor:
Jorge Javier Pedroza Romero

Estado del Proyecto
En desarrollo
Funcional
Mejoras visuales futuras
Sistema de autenticación
Base de datos real
Sistema de reseñas y comentarios
