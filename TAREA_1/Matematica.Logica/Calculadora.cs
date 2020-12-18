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

		public double TomarDosDecimales(double numeroConDecimales)
		{
			var numeroPaso1 = MoverLaComaALaDerecha2Veces(numeroConDecimales);
			var numeroPaso2 = TomarParteEntera(numeroPaso1);
			var numeroPaso3 = MoverLaComaALaIzquierda2Veces(numeroPaso2);
			return numeroPaso3;
        }

		private double MoverLaComaALaDerecha2Veces(double numeroConDecimales)
        {
			return numeroConDecimales*100;
		}

		private double TomarParteEntera(double numeroConDecimales)
        {
			return Math.Truncate(numeroConDecimales);
		}

		private double MoverLaComaALaIzquierda2Veces(double numero)
        {
			return numero/100;
		}
	
		public double TomarTresDecimales(double numeroConDecimales)
        {
			var numeroPaso1 = MoverLaComaALaDerecha3Veces(numeroConDecimales);
			var numeroPaso2 = TomarParteEntera(numeroPaso1);
			var numeroPaso3 = MoverLaComaALaIzquierda3Veces(numeroPaso2);
			return numeroPaso3;
		}

        private double MoverLaComaALaIzquierda3Veces(double numero)
        {
			return numero / 1000;
        }

        private double MoverLaComaALaDerecha3Veces(double numero)
        {
			return numero *1000.0;
        }

		public double TomarDecimales(double numero, int numeroDeDecimales)
        {
			if (numeroDeDecimales < 0)
				throw new ArgumentException("Un numero decimal debe ser > 0");

			var numeroPaso1 = MoverLaComaALaDerecha(numero,numeroDeDecimales);
			var numeroPaso2 = TomarParteEntera(numeroPaso1);
			var numeroPaso3 = MoverLaComaALaIzquierda(numeroPaso2, numeroDeDecimales);
			return numeroPaso3;
        }

		private double MoverLaComaALaIzquierda(double numero, int numeroDeDecimales)
		{
			//1 -> dividir 10;
			//2 -> dividir 100;
			//3 -> dividir 1000;
			//4 -> dividir 10000;
			return numero /Math.Pow(10 ,numeroDeDecimales);
        }

        private double MoverLaComaALaDerecha(double numero, int numeroDeDecimales)
        {
			return numero * Math.Pow(10, numeroDeDecimales);
		}

        public int AumentarEntero(int numeroEntero1, int numeroEntero2)
        {	
			return numeroEntero1 + (numeroEntero2); ;
		}
    }

}