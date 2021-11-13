using NUnit.Framework;
using Lib;
namespace NUnitTests
{
    public class Tests
    {
        private Individuo individuo;
        [SetUp]
        public void Setup()
        {
            individuo = new Individuo();
        }

        [Test]
        public void Teste_NomeCompleto_Verdadeiro()
        {
            individuo.Nome = "Sérgio";
            individuo.Apelido = "Fontes";

            Assert.IsTrue(individuo.GetNomeCompleto() == "Sérgio Fontes");
        }


        [Test,Category("CategoriaB")]
        [TestCase("João", "Silva", "João Silva")]
        [TestCase("Pedro", "Sequeira", "Pedro Sequeira")]
        public void Teste_NomeCompleto_Verdadeiro2(string nome, string apelido, string resultado)
        {
            Individuo obj = new Individuo();
            obj.Nome = nome;
            obj.Apelido = apelido;

            Assert.IsTrue(obj.GetNomeCompleto() == resultado);
        }
    }
}