using BlazorPelicula.Shared.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorPelicula.Client.Repositorios
{
    public class Repositorio : IRepositorio
    {
        public List<Pelicula> ObtenerPeliculas()
        {
         return new List<Pelicula>()
         {

            new Pelicula(){Titulo="Spiderman 3",Lanzamiento=new DateTime(2008,7,2)},
            new Pelicula(){Titulo="Los tres chanchitos ",Lanzamiento=new DateTime(2017,5,4)},
            new Pelicula(){Titulo="Django",Lanzamiento=new DateTime(2019,4,11)},
         };
        }
    }
}
