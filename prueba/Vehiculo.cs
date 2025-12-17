using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    abstract class Vehiculo
    {
        public int Id { get; set; }
        public string Dueño { get; set; }

        public abstract decimal ObtenerCostoDiario();
    }

}
