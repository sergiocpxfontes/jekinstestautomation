using System;
using Xunit;
using Lib;
using System.Collections.Generic;

namespace xUnitText
{
    public class UnitTest1
    {
        [Fact]
        public void Teste_NomeCompleto_Verdadeiro()
        {
            Individuo obj = new Individuo();
            obj.Nome = "Sérgio";
            obj.Apelido = "Fontes";

            Assert.True(obj.GetNomeCompleto() == "Sérgio Fontes");
        }

        [Theory]
        [InlineData("João", "Silva", "João Silva")]
        [InlineData("Pedro", "Sequeira", "Pedro Sequeira")]
        public void Teste_NomeCompleto_Verdadeiro2(string nome, string apelido, string resultado)
        {
            Individuo obj = new Individuo();
            obj.Nome = nome;
            obj.Apelido = apelido;

            Assert.True(obj.GetNomeCompleto() == resultado);
        }

        public static IEnumerable<object[]> dados => new List<object[]>
        {
            new object[] { "João", "Silva", "João Silva",true },
            new object[] { "Pedro", "Sequeira", "Pedro Sequeira",true }
        };

        [Theory]
        [MemberData(nameof(dados))]
        public void Teste_NomeCompleto_Verdadeiro3(string nome, string apelido, string resultado, bool teste)
        {
            Individuo obj = new Individuo();
            obj.Nome = nome;
            obj.Apelido = apelido;

            if (teste)
            {
                Assert.True(obj.GetNomeCompleto() == resultado);
            }
            else
            {
                Assert.False(obj.GetNomeCompleto() == resultado);
            }
        }

        [Theory]
        [ClassData(typeof(TesteData))]
        public void Teste_NomeCompleto_Verdadeiro4(string nome, string apelido, string resultado, bool teste)
        {
            Individuo obj = new Individuo();
            obj.Nome = nome;
            obj.Apelido = apelido;

            if (teste)
            {
                Assert.True(obj.GetNomeCompleto() == resultado);
            }
            else
            {
                Assert.False(obj.GetNomeCompleto() == resultado);
            }
        }
    }
}
