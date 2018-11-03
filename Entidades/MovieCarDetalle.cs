using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [Serializable]
    public class MovieCarDetalle
    {

        [Key]
        public int IdDetalle { get; set; }
        public int IdCar { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal Importe { get; set; }

        public MovieCarDetalle(int idDetalle, int idCar, string descripcion, int cantidad, decimal precio, decimal importe)
        {
            IdDetalle = idDetalle;
            IdCar = idCar;
            Descripcion = descripcion;
            Cantidad = cantidad;
            Precio = precio;
            Importe = importe;
        }

        public MovieCarDetalle()
        {
            IdDetalle = 0;
            IdCar = 0;
           Descripcion = string.Empty;
             Cantidad = 0;
             Precio = 0;
             Importe = 0;
        }
    }
}
