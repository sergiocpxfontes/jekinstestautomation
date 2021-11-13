using System;

namespace Lib
{
    public class Individuo
    {
        public string Nome { get; set; }
        public string Apelido { get; set; }
        public DateTime DataNascimento { get; set; }

        public string NomeCompleto { 
            get
            {
                return string.Format("{0} {1}", this.Nome, this.Apelido);
            }
        }
        public string GetNomeCompleto()
        {
            return string.Format("{0} {1}", this.Nome, this.Apelido);
        }
        public int GetIdade()
        {
            int difyears = DateTime.Now.Year - DataNascimento.Year;
            return difyears;
        }
    }
}
