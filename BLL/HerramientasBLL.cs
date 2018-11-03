using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class HerramientasBLL
    {
        public static decimal CalcularImporte(int cantidad, decimal precio)
        {
            return (decimal)cantidad * precio;
        }
            

    }
}
