using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreescrituradeMetodoPractica
{
    class Gato : AnimalDomestico
    {


        public override string Comunicarse ()
        {
            return "miau miau";
        }

        public override string Nombre()
        {
            return "> Que tal! Me presento : Soy un gato, me llaman Indi y hago";
        }

    }
}
