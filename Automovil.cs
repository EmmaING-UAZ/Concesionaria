

public class Automovil
{
    public int ID { get; set; }
    public string Marca { get; set; }
    public double Km { get; set; }
    public decimal Precio { get; set; }

    public override string ToString()
    {
        return $"ID: {ID}, Marca: {Marca}, Km: {Km}, Precio: {Precio:C}";
    }
}