using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudoPOO
{
    public class Chacal : Mamifero
    {

        Chacal(int qtdeMamas, bool pelos, string corDoPelo)
        {
            this.qtdeMamas = qtdeMamas;
            this.pelos = pelos;
            this.corDoPelo = corDoPelo;
        }

    }
}
