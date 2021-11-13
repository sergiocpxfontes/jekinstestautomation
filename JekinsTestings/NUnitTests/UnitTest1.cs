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
            individuo.Nome = "S�rgio";
            individuo.Apelido = "Fontes";

            Assert.IsTrue(individuo.GetNomeCompleto() == "S�rgio Fontes");
        }


        [Test,Category("CategoriaB")]
        [TestCase("Jo�o", "Silva", "Jo�o Silva")]
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