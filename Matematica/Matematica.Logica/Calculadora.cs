using System;

namespace Matematica.Logica

{

	public class Calculadora
	{
		public int Sumar(int sumando1, int sumando2)
		{
			return sumando1 + sumando2;
		}

		public int Restar(int minuendo, int sustraendo)
		{
			return minuendo - sustraendo;
		}

		public int Dividir(int dividendo, int divisor)
        {
			return dividendo / divisor;
        }

		public int DividirResiduo(int dividendo, int divisor)
		{
			return dividendo % divisor;
		}

		public float DividirDecimales(float dividendo, float divisor)
        {
			return dividendo / divisor;
		}

		private static double TomarDosDecimales(double numeroConDecimales)
		{
			//var numeroPaso1 = MoverLaComaALaDerecha2Veces(numeroConDecimales);
			//var numeroPaso2 = TomarParteEntera(numeroPaso1);
			//var numeroPaso3 = MoverLaComaALaIzquierda2Veces(numeroPaso2);

			return numeroConDecimales;
        }

	}

}