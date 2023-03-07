using System;

class Program
{
    static void Main(string[] args)
    {
        Concesionaria concesionaria = new Concesionaria();

        // Agregar algunos autos
        Automovil auto1 = new Automovil { ID = 1, Marca = "Toyota", Km = 10000, Precio = 20000 };
        Automovil auto2 = new Automovil { ID = 2, Marca = "Ford", Km = 5000, Precio = 15000 };
        Automovil auto3 = new Automovil { ID = 3, Marca = "Chevrolet", Km = 8000, Precio = 18000 };

        concesionaria.AgregarAuto(auto1);
        concesionaria.AgregarAuto(auto2);
        concesionaria.AgregarAuto(auto3);

        // Mostrar los autos en la concesionaria
        concesionaria.MostrarAutos();

        // Eliminar un auto
        concesionaria.EliminarAuto(auto2);

        // Mostrar los autos restantes
        concesionaria.MostrarAutos();

        // Vaciar la concesionaria
        concesionaria.VaciarConcesionaria();

        // Mostrar los autos en la concesionaria (debería estar vacía)
        concesionaria.MostrarAutos();

        Console.ReadLine();
    }
}
