public class Concesionaria
{
    private List<Automovil> autos;
    public int LimiteAutos { get; set; }
    public int NumeroActualAutos { get { return autos.Count; } }

    public Concesionaria(int limiteAutos)
    {
        LimiteAutos = limiteAutos;
        autos = new List<Automovil>();
    }

    public void AgregarAuto(Automovil a)
    {
        if (NumeroActualAutos < LimiteAutos)
        {
            autos.Add(a);
            Console.WriteLine($"Auto {a.ID} agregado correctamente.");
        }
        else
        {
            Console.WriteLine("La concesionaria está llena, no se puede agregar más autos.");
        }
    }

    public void MostrarAuto(Automovil a)
    {
        Console.WriteLine(a);
    }

    public void EliminarAuto(Automovil a)
    {
        if (autos.Contains(a))
        {
            autos.Remove(a);
            Console.WriteLine($"Auto {a.ID} eliminado correctamente.");
        }
        else
        {
            Console.WriteLine($"Auto {a.ID} no encontrado en la concesionaria.");
        }
    }

    public void MostrarAutos()
    {
        if (NumeroActualAutos > 0)
        {
            Console.WriteLine("Autos en la concesionaria:");
            foreach (Automovil a in autos)
            {
                Console.WriteLine(a);
            }
        }
        else
        {
            Console.WriteLine("No hay autos en la concesionaria.");
        }
    }

    public void VaciarConcesionaria()
    {
        autos.Clear();
        Console.WriteLine("La concesionaria ha sido vaciada.");
    }
}
