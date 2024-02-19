using Portafolio.Models;

namespace Portafolio.Servicios
{
    public interface IRepositoriosProyectos
    {
        List<Proyecto> ObtenerProyectos();
    }

    public class RepositoriosProyectos : IRepositoriosProyectos
    {
        public List<Proyecto> ObtenerProyectos()
        {
            return new List<Proyecto>() {  new Proyecto
            {
                Titulo = "Amazon",
                Description = "E-Commerce realizado en ASP-NET Core",
                Link = "https://www.amazon.com/",
                ImagenURL = "/imagenes/amazon.png"
            },
            new Proyecto
            {
                Titulo = "New York Times",
                Description = "Pagina de Noticias en React",
                Link = "https://www.nytimes.com/international/",
                ImagenURL = "/imagenes/nyt.png"
            },
            new Proyecto
            {
                Titulo = "Reddit",
                Description = "Red Social para compartir en comunidades",
                Link = "https://www.reddit.com/",
                ImagenURL = "/imagenes/reddit.png"
            },
            new Proyecto
            {
                Titulo = "Steam",
                Description = "Tienda en linea para comprar videojuegos",
                Link = "https://store.steampowered.com/",
                ImagenURL = "/imagenes/steam.png"
            }
            };
        }
    }
}
