using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class MovieCar
    {
        [Key]
        public int IdCar { get; set; }
        public decimal Total { get; set; }
        public int CantidadMovie { get; set; }

        public virtual List<MovieCarDetalle> Detalle { get; set; }

        public MovieCar(int idCar, decimal total, int cantidadMovie, List<MovieCarDetalle> detalle)
        {
            IdCar = idCar;
            Total = total;
            CantidadMovie = cantidadMovie;
            Detalle = detalle;
        }

        public MovieCar()
        {
            IdCar = 0;
            Total = 0;
            CantidadMovie = 0;
            Detalle = new List<MovieCarDetalle>();
        }
    }
}
