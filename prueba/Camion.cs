using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba
{
    class camion : Vehiculo
    {
        public int cantEJES { get; set; }
        public string cargaMaxima { get; set; }

        public const decimal TARIFA = 2500;

        public override decimal ObtenerCostoDiario()
        {
            return TARIFA;
        }
    }
}
