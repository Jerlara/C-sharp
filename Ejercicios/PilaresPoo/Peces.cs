using System;

public class Peces: Animales
{
    public int aletas { get; set; }
    public void Nadar()
    {
        Console.WriteLine("Nadando...");
    }
    public void habitad()
    {
        Console.WriteLine(" - Oceano -");
    }
    public void pelaje()
    {
        Console.WriteLine("Escamoso...");
    }
}