using System;

public abstract class Mamifero: Animales
{
    public int Patas { get; set; }

    public void Caminar()
    {
        Console.WriteLine("Caminando...");
    }
}