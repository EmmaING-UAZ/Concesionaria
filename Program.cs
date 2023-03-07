using System;

class Program
{
    static void Main(string[] args)
    {
        Concesionaria concesionaria = new Concesionaria(3);

        Automovil auto1 = new Automovil { ID = 1, Marca = "Ford", Km = 10000, Precio = 20000 };
        Automovil auto2 = new Automovil { ID = 2, Marca = "Volkswagen", Km = 5000, Precio = 50000 };
        Automovil auto3 = new Automovil { ID = 3, Marca = "Audi", Km = 3000, Precio = 500000 };

        concesionaria.AgregarAuto(auto1);
        concesionaria.AgregarAuto(auto2);
        concesionaria.AgregarAuto(auto3);

        concesionaria.MostrarAutos();

    }

}