using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Entidades
{
    [Serializable]
    public class Movie
    {
        [Key]
        public int IdMovie { get; set; }
        public string Link { get; set; }
        public string Photo { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }

        public Movie(int idMovie, string link, string photo, string descripcion, decimal precio)
        {
            IdMovie = idMovie;
            Link = link;
            Photo = photo;
            Descripcion = descripcion;
            Precio = precio;
        }

        public Movie()
        {
            IdMovie = 0;
            Link = string.Empty;
            Photo = string.Empty;
            Descripcion = string.Empty;
            Precio = 0;
        }
    }
}