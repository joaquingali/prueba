using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using prueba;
using Prueba;

class Program
{
    static void Main(string[] args)
    {
        Estacionamiento est = new Estacionamiento();
        int opcion;
        do
        {
            Console.WriteLine(" menu estacionamiento");
            Console.WriteLine("1. Agregar Auto");
            Console.WriteLine("2. Agregar Camioneta");
            Console.WriteLine("3. Agregar Moto");
            Console.WriteLine("4. Agregar Bicicleta");
            Console.WriteLine("5. Agregar Camion");
            Console.WriteLine("6. Listar Vehiculos");
            Console.WriteLine("7. Calcular Recaudacion Diaria");
            Console.Write("Opción");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Auto a = new Auto();
                    Console.Write("ID: ");
                    a.Id = int.Parse(Console.ReadLine());
                    Console.Write("Dueño: ");
                    a.Dueño = Console.ReadLine();
                    Console.Write("Cantidad de puertas: ");
                    a.CantidadPuertas = int.Parse(Console.ReadLine());
                    Console.Write("Combustible: ");
                    a.Combustible = Console.ReadLine();
                    est.AgregarVehiculo(a);
                    break;


                case 2:
                    camioneta c = new camioneta();
                    Console.Write("ID: ");
                    c.Id = int.Parse(Console.ReadLine());
                    Console.Write("Dueño: ");
                    c.Dueño = Console.ReadLine();
                    Console.Write("indique capacidad de carga: ");
                    c.capacidadCarga =(Console.ReadLine());
                    Console.Write("indique si es 4x4: ");
                    c.Sies4x4 = Console.ReadLine();
                    est.AgregarVehiculo(c);
                    break;


                case 3:
                    moto m = new moto();
                    Console.Write("ID: ");
                    m.Id = int.Parse(Console.ReadLine());
                    Console.Write("Dueño: ");
                    m.Dueño = Console.ReadLine();
                    Console.Write("indique el tipo: ");
                    m.tipo = (Console.ReadLine());
                    Console.Write("indique la cilindrada: ");
                    m.cilindrada = Console.ReadLine();
                    moto m1 = m;
                    est.AgregarVehiculo(m);
                    break;

                case 4:
                    bicicleta b = new bicicleta();
                    Console.Write("ID: ");
                    b.id = int.Parse(Console.ReadLine());
                    Console.Write("Dueño: ");
                    b.Dueño = Console.ReadLine();
                    Console.Write("indique el tipo: ");
                    b.tipo = (Console.ReadLine());
                    Console.Write("indique el material de cuadro: ");
                    b.Materialcuadro = Console.ReadLine();
                    est.AgregarVehiculo(b);
                    break;

                case 5:
                    camion ca = new camion();
                    Console.Write("ID: ");
                    ca.Id = int.Parse(Console.ReadLine());
                    Console.Write("Dueño: ");
                    ca.Dueño = Console.ReadLine();
                    Console.Write("indique la cantidad de ejes: ");
                    ca.cantEJES = int.Parse(Console.ReadLine());
                    Console.Write("indique la carga maxima: ");
                    ca.cargaMaxima = Console.ReadLine();
                    est.AgregarVehiculo(ca);
                    break;

                case 6:
                    est.ListarVehiculos();
                    break;

                case 7:
                    Console.WriteLine("Total recaudado : $" + est.CalcularRecaudacionDiaria());
                    break;
            }

        } while (opcion != 0);
    }
}
