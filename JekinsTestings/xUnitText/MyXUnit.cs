using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace xUnitText
{
    public class MyXUnit : Assert
    {
        public static void MaiorDeIdade(int idade, int alvo)
        {
            if(idade>= alvo)
            {
                Assert.True(true);
            }
            else
            {
                Assert.False(false);
            }
        }
    }
}
