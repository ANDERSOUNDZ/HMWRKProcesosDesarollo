using AndersonBiblioteca;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;

namespace AndersonTest.Features
{
    [Binding]
    public class AreaDeUnCuadradoSteps
    {
        IWebDriver driver = new FirefoxDriver();
        public AreaDeUnCuadradoSteps()
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        Calculadora calculadora = new Calculadora();

        [Given(@"que el lado de un cuadrado es (.*)")]
        public void DadoQueElLadoDeUnCuadradoEs(int lado)
        {
            //driver.Navigate().GoToUrl("https://localhost:44309/");
            calculadora.Lado = lado;
        }
        
        [When(@"calculo el area")]
        public void CuandoCalculoElArea()
        {
            calculadora.CalcularAreaCuadrado();
        }
        
        [Then(@"el resultado sera (.*)")]
        public void EntoncesElResultadoSera(int resultado)
        {
            Assert.AreEqual(resultado, calculadora.Resultado);
        }
    }
}
