using System;

public class Aves: Animales
{
    public int Alas { get; set; }

    public void Apodo()
    {
        Console.WriteLine(" - Pajaro Loco -");
    }
    public void Volar()
    {
        Console.WriteLine("Volando...");
    }

    public void pelaje()
    {
        Console.WriteLine("Plumoso...");
    }
}