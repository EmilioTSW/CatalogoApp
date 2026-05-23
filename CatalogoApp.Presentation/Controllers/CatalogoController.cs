using CatalogoApp.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Catalogo.Controllers
{
    public class CatalogoController : Controller
    {
        private static List<Item> _items = new()
        {
            new Item {
                Id = 1,
                Titulo = "Devil May Cry",
                Genero = "Hack and Slash",
                Ano = 2001,
                Consola = "PlayStation 2",
                Descripcion = "Videojuego de acción con demonios."
            },

            new Item {
                Id = 2,
                Titulo = "Rust",
                Genero = "Supervivencia",
                Ano = 2013,
                Consola = "PC",
                Descripcion = "Juego de supervivencia online."
            },

            new Item {
                Id = 3,
                Titulo = "Halo Reach",
                Genero = "Shooter",
                Ano = 2010,
                Consola = "Xbox 360",
                Descripcion = "Shooter futurista de Halo."
            }
        };

        public IActionResult Index()
        {
            return View(_items);
        }
    }
}