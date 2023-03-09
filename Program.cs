using System;

class Program
{
    static void Main(string[] args)
    {

        bool MostrarMenu = true;

        while (MostrarMenu){
            MostrarMenu = Menu();
        }

        Concesionaria concesionaria = new Concesionaria(3);

        Automovil auto1 = new Automovil { ID = 1, Marca = "Ford", Km = 10000, Precio = 20000 };
        Automovil auto2 = new Automovil { ID = 2, Marca = "Volkswagen", Km = 5000, Precio = 50000 };
        Automovil auto3 = new Automovil { ID = 3, Marca = "Audi", Km = 3000, Precio = 500000 };

        concesionaria.AgregarAuto(auto1);
        concesionaria.AgregarAuto(auto2);
        concesionaria.AgregarAuto(auto3);

        concesionaria.MostrarAutos();

    }

    public static bool Menu(){
        
        Console.Clear;
        Console.WriteLine("Seleccione una opción");
        Console.WriteLine("1.- Agregar Automovil");
        Console.WriteLine("1.- Agregar Automovil");
        Console.WriteLine("1.- Agregar Automovil");
        Console.WriteLine("1.- Agregar Automovil");
        Console.WriteLine("1.- Agregar Automovil");
        Console.WriteLine("1.- Agregar Automovil");
        Console.WriteLine("Opción");

        switch(Console.ReadLine())
        {
             case "1":
                Console.WriteLine("Seleccionaste 1");
                Console.ReadLine();
                return true;

            case "2":
                Console.WriteLine("Seleccionaste 2");
                Console.ReadLine();
                return true;

            case "3":
                Console.WriteLine("Seleccionaste 3");
                Console.ReadLine();
                return true;

            case "4":
                Console.WriteLine("Seleccionaste 4");
                Console.ReadLine();
                return true;

            case "5":
                return false;
            default:
                return true;

        }
        



        
    }



    
}