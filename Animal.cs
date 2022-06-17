using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreescrituradeMetodoPractica
{
    class Animal
    {   


        // HERENCIAS

        public virtual string Comunicarse()
        {
            return " Ruido...ruido...";
        }

        public virtual string Nombre ()
        {
            return "Mi nombre es ";
        }

        public virtual string Habitat()
        {
            return "Donde viven";
        }
          
        public virtual string Domesticos ()
        {
            return "En la casa";
        }
    }
}
