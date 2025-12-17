using System;
using System.Collections.Generic;

abstract class Vehiculo
{
    public int Id { get; set; }
    public string Dueño { get; set; }

    public abstract decimal ObtenerCostoDiario();
}


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

class bicicleta: Vehiculo
{
    public string  tipo { get; set; }
    public string Materialcuadro { get; set; }

    public const decimal TARIFA = 200;

    public override decimal ObtenerCostoDiario()
    {
        return TARIFA;
    }
}

class camion : Vehiculo
{
    public int cantEJES { get; set; }
    public string cargaMaxima { get; set; }

    public const decimal TARIFA =2500;

    public override decimal ObtenerCostoDiario()
    {
        return TARIFA;
    }
}

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
                    est.AgregarVehiculo(m);
                    break;

                case 4:
                    bicicleta b = new bicicleta();
                    Console.Write("ID: ");
                    b.Id = int.Parse(Console.ReadLine());
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
