using Microsoft.VisualStudio.TestTools.UnitTesting;
using Matematica.Logica;
using System;

namespace Matematica.test
{

	[TestClass]
	public class CalculadoraTest
	{

		[TestMethod]
		public void SumaDosNumeros()
		{
			var numero1 = 7;
			var numero2 = 10;
			var respuesta = 17;

			var calculadora = new Calculadora();
			var respuestaObtenida = calculadora.Sumar(numero1, numero2);

			Assert.AreEqual(respuesta, respuestaObtenida);
		}

		[TestMethod]
		public void RestaDosNumeros()
		{
			var minuendo = 10;
			var sustraendo = 5;
			var diferencia = 5;

			var calculadora = new Calculadora();
			var respuesta = calculadora.Restar(minuendo, sustraendo);

			Assert.AreEqual(respuesta, diferencia);
		}

		[TestMethod]
		public void DivisionDosNumeros()
		{
			var dividendo = 5;
			var divisor = 2;
			var resultado = 2;

			var calculadora = new Calculadora();
			var valorObtenido = calculadora.Dividir(dividendo, divisor);

			Assert.AreEqual(resultado, valorObtenido);
		}

		[TestMethod]
		public void DivisionDevuelveResiduo()
		{
			var dividendo = 278;
			var divisor = 5;
			var residuo = 3;

			var calculadora = new Calculadora();
			var residuoObtenido = calculadora.DividirResiduo(dividendo, divisor);

			Assert.AreEqual(residuo, residuoObtenido);
		}

		[TestMethod]
		public void DivisionDividendoCero()
		{
			var dividendo = 0;
			var divisor = 20;
			var resultado = 0;

			var calculadora = new Calculadora();
			var valorCero = calculadora.Dividir(dividendo, divisor);

			Assert.AreEqual(resultado, valorCero);
		}

		[TestMethod]
		public void DivisionDecimales()
		{
			var dividendo = 50;
			var divisor = 7;
			var resultado = 7.142857074737549;

			var calculadora = new Calculadora();
			var valorObtenido = calculadora.DividirDecimales(dividendo, divisor);

			Assert.AreEqual(resultado, valorObtenido);
		}

		[TestMethod]
		[ExpectedException(typeof(DivideByZeroException))]
		public void DivisionDivisorCero()
        {
			var dividendo = 20;
			var divisor = 0;

			var calculadora = new Calculadora();
			calculadora.Dividir(dividendo, divisor);

			Assert.IsTrue(false);
		}

		[TestMethod]
		public void ObtenerNumeroDosDecimales()
        {
			var numeroPiConCincoDecimales = 3.14159;
			var numeroPiConDosDecimales = 3.14;

			var calculadora = new Calculadora();
			//var resultado = calculadora.TomarDosDecimales(numeroPiConCincoDecimales);

			//Assert.AreEqual(numeroPiConDosDecimales, resultado);
        }
	}

}