using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba
{
    class Estacionamiento
    {
        private List<Vehiculo> vehiculos = new List<Vehiculo>();

        public void AgregarVehiculo(Vehiculo v)
        {
            vehiculos.Add(v);
        }

        public void ListarVehiculos()
        {
            Console.WriteLine(" vehiculos estacionados ");
            foreach (Vehiculo v in vehiculos)
            {
                Console.WriteLine($"ID: {v.Id} | Dueño: {v.Dueño} | Costo Diario: ${v.ObtenerCostoDiario()}");
            }
        }

        public decimal CalcularRecaudacionDiaria()
        {
            decimal total = 0;

            foreach (Vehiculo v in vehiculos)
            {
                total += v.ObtenerCostoDiario();
            }

            return total;
        }
    }

}
