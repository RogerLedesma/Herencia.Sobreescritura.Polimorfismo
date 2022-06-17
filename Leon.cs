using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreescrituradeMetodoPractica
{
    class Leon : AnimalSalvaje
    {

        public override string Comunicarse ()
        {
            return "rujidos fuertes por las noches!";
        }

        public override string Nombre ()
        {
            return "> Con permiso, soy el Leon, el REY de la selva y hago";
        }
    }
}
