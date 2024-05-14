using System;

namespace vehiculos
{
    class Program
    {
        class Vehiculo
        {
            public string Marca { get; set; }
            public string Modelo { get; set; }
            public int Año { get; set; }

            public Vehiculo(string marca, string modelo, int año)
            {
                Marca = marca;
                Modelo = modelo;
                Año = año;
            }

            public virtual void MostrarInformacion()
            {
                Console.WriteLine($"Marca: {Marca}");
                Console.WriteLine($"Modelo: {Modelo}");
                Console.WriteLine($"Año: {Año}");
            }
        }

        class Bicicleta : Vehiculo 
        {
            public Bicicleta(string marca, string modelo, int año)
                : base(marca, modelo, año) 
            {
            }

            public override void MostrarInformacion()
            {
                base.MostrarInformacion(); 
            }
        }

        class Avion : Vehiculo
        {
            public Avion(string marca, string modelo, int año)
                : base(marca, modelo, año) 
            {
            }

            public override void MostrarInformacion()
            {
                base.MostrarInformacion(); 
            }
        }

        class Tren : Vehiculo
        {
            public Tren(string marca, string modelo, int año)
                : base(marca, modelo, año) 
            {
            }

            public override void MostrarInformacion()
            {
                base.MostrarInformacion(); 
            }
        }

        static void Main(string[] args)
        {
            
            Vehiculo carro = new Vehiculo("Toyota", "Corolla", 2020);
            Vehiculo bici = new Bicicleta("Trek", "Mountain Bike", 2022);
            Vehiculo avion = new Avion("Boeing", "737", 2018);
            Vehiculo tren = new Tren("Siemens", "Velaro", 2021);

            
            Console.WriteLine("\nInformación de Vehículos:");
            Console.WriteLine("------------------------");

            MostrarInformacionVehiculo(carro, "Carro");
            Console.WriteLine(); 

            MostrarInformacionVehiculo(bici, "Bicicleta");
            Console.WriteLine(); 

            MostrarInformacionVehiculo(avion, "Avión");
            Console.WriteLine(); 

            MostrarInformacionVehiculo(tren, "Tren");
            Console.WriteLine();
        }

        static void MostrarInformacionVehiculo(Vehiculo vehiculo, string tipoVehiculo)
        {
            Console.WriteLine($"**{tipoVehiculo}**");
            vehiculo.MostrarInformacion();
        }
    }
}




