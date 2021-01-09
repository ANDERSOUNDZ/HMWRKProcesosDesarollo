using System;

namespace OCP
{
    public class Programa
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa");

            Refactorizacion.Calculadora calculadora = new Refactorizacion.Calculadora();

            Refactorizacion.Triangulo triangulo = new Refactorizacion.Triangulo
            {
                Base = 10,
                Altura = 5
            };
            Console.WriteLine("El area de un triangulo es: {0}",calculadora.CalcularArea(triangulo));

            Refactorizacion.Cuadrado cuadrado = new Refactorizacion.Cuadrado
            {
                Lado = 6.0
            };
            Console.WriteLine("El area de un cuadrado es: {0}", calculadora.CalcularArea(cuadrado));

            Refactorizacion.Circulo circulo = new Refactorizacion.Circulo
            {
                Radio = 5.0
            };
            Console.WriteLine("El area de un circulo es : {0}", calculadora.CalcularArea(circulo));

        }
    }
}