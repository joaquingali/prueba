using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    class moto : Vehiculo
    {
        public string tipo { get; set; }
        public string cilindrada { get; set; }

        public const decimal TARIFA = 600;

        public override decimal ObtenerCostoDiario()
        {
            return TARIFA;
        }
    }

}
