using Peliculas_Mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Peliculas_Mvc.Services
{
    public class PeliculasService
    {
        public Pelicula ObterPelicula()
        {
            return new Pelicula()
            {
                Titulo = "Cidade de Deus",
                Duracion = 115,
                Pais = "USA",
                Publicacion = new DateTime(2013, 12, 5)

            };
        }

        public List<Pelicula> ObtenerPeliculas()
        {
            var pelicula1 = new Pelicula()
            {
                Titulo = "Escape de Brasil",
                Duracion = 115,
                Pais = "USA",
                Publicacion = new DateTime(2013, 12, 5)
            };

            var pelicula2 = new Pelicula()
            {
                Titulo = "Capitan America",
                Duracion = 147,
                Pais = "USA",
                Publicacion = new DateTime(2016, 04, 29)
            };

            var pelicula3 = new Pelicula()
            {
                Titulo = "Matrix",
                Duracion = 150,
                Pais = "USA",
                Publicacion = new DateTime(2018, 12, 25)
            };
            return new List<Pelicula> { pelicula1, pelicula2, pelicula3 };
        }
    }
}