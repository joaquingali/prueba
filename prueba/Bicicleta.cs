using Prueba;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba
{
    class bicicleta : Vehiculo
    {
        public string tipo { get; set; }
        public string Materialcuadro { get; set; }

        public const decimal TARIFA = 200;
        internal int id;
        internal string? Dueño;

        public override decimal ObtenerCostoDiario()
        {
            return TARIFA;
        }
    }
}
