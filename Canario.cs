using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreescrituradeMetodoPractica
{
    class Canario : AnimalDomestico
    {

        public override string Comunicarse()
        {
            return "hago piuupiu para que puedan escucharme mis amig@s";
        }

        public override string Nombre ()
        {
            return "> Hey! Ayuda! Soy un canario y me tienen encerradoen una jaula";
        }



    }
}
