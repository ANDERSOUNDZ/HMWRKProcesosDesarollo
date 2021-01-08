using System;

namespace SRP_TAREA01APPCONSOLA_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Obra miLibroAlquilado = new Obra {
                Autor = "J.K.Rowling",
                Titulo = "Harry Potter y la piedra filosofal",
                Serial = 1254777,
                Precio = 12.25,
                Editorial = "Norma Publicaciones Ltda."
            };
            miLibroAlquilado.Describir();

            Console.WriteLine(
                " Autora: " + miLibroAlquilado.Autor + "/ Titulo: " + miLibroAlquilado.Titulo + "/ Serial: " +
                miLibroAlquilado.Serial + "/ Precio: " + miLibroAlquilado.Precio + "/ Editorial: " + miLibroAlquilado.Editorial
                );
        }
    }
}
