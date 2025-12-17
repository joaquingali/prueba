using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    class Auto : Vehiculo
    {
        public int CantidadPuertas { get; set; }
        public string Combustible { get; set; }

        public const decimal TARIFA = 1000;

        public override decimal ObtenerCostoDiario()
        {
            return TARIFA;
        }
    }
}
