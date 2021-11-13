using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lib;
namespace MsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod, TestCategory("CategoriaV"), Priority(1)]
        public void Teste_NomeCompleto_Verdadeiro()
        {
            Individuo obj = new Individuo();
            obj.Nome = "Sérgio";
            obj.Apelido = "Fontes";

            Assert.IsTrue(obj.GetNomeCompleto() == "Sérgio Fontes");
        }
        [TestMethod , TestCategory("CategoriaF"), Priority(1)]
        public void Teste_NomeCompleto_Falso()
        {
            Individuo obj = new Individuo();
            obj.Nome = "Sérgio";
            obj.Apelido = "Fontes";

            Assert.IsFalse(obj.GetNomeCompleto() == "Sandrio Fontes");
        }

        [TestMethod, TestCategory("CategoriaV"), Priority(2)]
        [DataRow("João","Silva","João Silva")]
        [DataRow("Pedro", "Sequeira", "Pedro Sequeira")]
        public void Teste_NomeCompleto_Verdadeiro2(string nome, string apelido,string resultado)
        {
            Individuo obj = new Individuo();
            obj.Nome = nome;
            obj.Apelido = apelido;

            Assert.IsTrue(obj.GetNomeCompleto() == resultado);
        }

        [TestMethod, TestCategory("CategoriaF"), Priority(2)]
        [DataRow("João", "Silva", "João José")]
        [DataRow("Pedro", "Sequeira", "Pedro Antunes")]
        public void Teste_NomeCompleto_Falso2(string nome, string apelido, string resultado)
        {
            Individuo obj = new Individuo();
            obj.Nome = nome;
            obj.Apelido = apelido;

            Assert.IsFalse(obj.GetNomeCompleto() == resultado);
        }
    }
}
