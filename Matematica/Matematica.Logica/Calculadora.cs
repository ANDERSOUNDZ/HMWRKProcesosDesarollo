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

			//numeroConDecimales=(numeroConDecimales * dato mueve coma)/10;
			//numeroConDecimales = (numeroConDecimales *10)/ 10;
			//String.Format("{0,10:0.-10}", numeroConDecimales);

			numeroConDecimales = numeroPaso2*numeroPaso1/numeroPaso3;
			return numeroConDecimales;
        }

		private double MoverLaComaALaDerecha2Veces(double numeroConDecimales)
        {
			return numeroConDecimales/0.1;
		}

		private double TomarParteEntera(double numeroPaso1)
        {
			//numeroPaso1 = 3;
			return numeroPaso1;
		}

		private double MoverLaComaALaIzquierda2Veces(double numeroPaso2)
        {
			return numeroPaso2*10;
		}

		public double DevolverNDecimales(double numeroAConvertir)
        {
			numeroAConvertir =  numeroAConvertir*0.000001/100;
			return numeroAConvertir;
		}
	}

}