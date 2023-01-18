using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudoPOO
{
    public class Cisne : IAquatico
    {

        Cisne(bool viveEmTerra, bool mergulho, bool aguaDoce)
        {
            this.viveEmTerra = viveEmTerra;
            this.mergulho = mergulho;
            this.aguaDoce = aguaDoce;
        }

    }
}
