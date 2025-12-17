using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    class camioneta : Vehiculo
    {
        public string capacidadCarga { get; set; }
        public string Sies4x4 { get; set; }

        public const decimal TARIFA = 1500;

        public override decimal ObtenerCostoDiario()
        {
            return TARIFA;
        }
    }
}
