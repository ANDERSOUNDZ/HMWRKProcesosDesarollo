using Microsoft.VisualStudio.TestTools.UnitTesting;
using Telerik.JustMock;
using Telerik.JustMock.Helpers;
using Aplicante;
using Calcular;
namespace DiferenciasMockYStub
{
    [TestClass]
    public class PersonaPrueba
    {
        [TestMethod]
        public void DadoqueExisteEmpleoDisponibleCuandoEnviaCurriculumEntoncesPostulaTrabajo()
        {
            //MOCKS
            //DADO QUE:
            //Arrange - initialize
            string Area = "Programador";
            //lConfiguracion - Set Expectations- Predicciones
            var empleo = Mock.Create<Empleo>();
            empleo.Arrange(e=>e.EmpleoDisponible).Returns(Area);
            //Cuando:
            //Act - SUT - Exercicio
            Aplicante.Persona persona = new Aplicante.Persona();
            persona.EnviaCurriculum(empleo, Area);
            //Entonces
            //Assert - Afirmar- Verificar
            Assert.IsTrue(persona.PostulaTrabajo);
            empleo.Assert(e=>e.EmpleoDisponible);
        }

        [TestMethod]
        public void DadoQueUnaSumaDevuelveUnResultadoCuandoVoyASumar2NumerosEntoncesLaSumaEsCorrecta()
        {
            //STUBS
            int resultado = 4;
            var calcular = Mock.Create<Calcular.Calcular>();
            calcular.Arrange(x => x.DevolverResultado).Returns(resultado);
            //exercise
            Calcular.Persona persona = new Calcular.Persona
            {
                numero1 = 3,
                numero2 = 1
            };
            persona.Sumar(calcular);
            //verify
            Assert.IsTrue(persona.SumaCorrecta);
            calcular.Assert(x => x.DevolverResultado);
        }
    }
}
