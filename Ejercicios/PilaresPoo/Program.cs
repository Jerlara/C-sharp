using System;

namespace DatosAnimales
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilidades.EnviarCorreo();

            Perro p = new Perro();
            p.Nombre = "Firulais";
            p.Patas = 4;
            p.EsDomestico = true;
            p.Comer();
            p.Caminar();
            p.Ladrar();
            p.Tamano();
            p.Comun();

            Console.WriteLine(p.Nombre);
            Console.WriteLine(p.Patas);

            Gato g = new Gato();
            g.Nombre = "Garfield";
            g.Patas = 4;
            g.Pelaje = "Peludo";
            g.Comer();
            g.Caminar();
            g.Maullar();
            
            Peces pe = new Peces();
            pe.habitad();
            pe.aletas = 2;
            pe.pelaje();
            pe.Comer();
            pe.Nadar();

            Aves a = new Aves();
            a.Apodo();
            a.Alas = 2;
            a.pelaje();
            a.Volar();
            a.Comer();
            a.Comun();

            Reptiles r = new Reptiles();
            r.Apodo();
            r.procreados();
            r.carn();
            r.Comer();

        }
    }
}