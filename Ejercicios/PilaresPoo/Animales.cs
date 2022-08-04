using System;
public abstract class Animales
{
    public string Nombre { get; set; }

    public void Comer()
    {
        Console.WriteLine("Comiendo...");
    }
    public void Comun()
    {
        Console.WriteLine("Pluricelulares");
    }
}