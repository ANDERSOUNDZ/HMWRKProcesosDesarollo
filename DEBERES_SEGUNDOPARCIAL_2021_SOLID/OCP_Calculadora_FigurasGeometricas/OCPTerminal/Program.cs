using System;

namespace OCPTerminal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa");

            Refactorizacion.Calculadora calculadora = new Refactorizacion.Calculadora();

            //1
            Refactorizacion.Triangulo triangulo = new Refactorizacion.Triangulo
            {
                Base = 10,
                Altura = 5
            };
            Console.WriteLine("El area de un triangulo es: {0}", calculadora.CalcularArea(triangulo));

            //2
            Refactorizacion.Cuadrado cuadrado = new Refactorizacion.Cuadrado
            {
                Lado = 6.0
            };
            Console.WriteLine("El area de un cuadrado es: {0}", calculadora.CalcularArea(cuadrado));

            //3
            Refactorizacion.Circulo circulo = new Refactorizacion.Circulo
            {
                Radio = 5.0
            };
            Console.WriteLine("El area de un circulo es : {0}", calculadora.CalcularArea(circulo));
            //4
            Refactorizacion.Cubo cubo = new Refactorizacion.Cubo
            {
                Lado = 7.0
            };
            Console.WriteLine("El area de un Cubo es : {0}", calculadora.CalcularArea(cubo));

            //---------

            //5
            Refactorizacion.Cono cono = new Refactorizacion.Cono
            {
                Base = 4.0,
                Altura = 6.0,
                Radio = 5.0
            };
            Console.WriteLine("El area de un cono es :{0}", calculadora.CalcularArea(cono));

            //6
            Refactorizacion.Pentagono pentagono = new Refactorizacion.Pentagono
            {
                LongitudLados = 6.0,
                Apotema = 8.0
            };

            Console.WriteLine("El area de un pentagono es :{0}", calculadora.CalcularArea(pentagono));

            //7
            Refactorizacion.Cilindro cilindro = new Refactorizacion.Cilindro
            {
                Altura = 8.0,
                Radio = 5.0
            };
            Console.WriteLine("El Area del cilindro es :{0}", calculadora.CalcularArea(cilindro));

            //8
            Refactorizacion.Trapecio trapecio = new Refactorizacion.Trapecio
            {
                Base1 = 4.0,
                Base2 = 4.0,
                Altura = 8.0,
                
            };
            Console.WriteLine("El Area del Trapecio es :{0}", calculadora.CalcularArea(trapecio));

            //9
            Refactorizacion.Tetraedro tetraedro = new Refactorizacion.Tetraedro
            {
                Lado = 25
            };
            Console.WriteLine("El Area del tetaedro es :{0}", calculadora.CalcularArea(tetraedro));
            //10
            Refactorizacion.Esfera esfera = new Refactorizacion.Esfera
            {
                Radio = 24
            };
            Console.WriteLine("El Area de una esfera es :{0}", calculadora.CalcularArea(esfera));

        }
    }
}
