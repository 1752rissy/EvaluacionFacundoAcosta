using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Materia: IABM
    {
        string Nombre;

        public string Alta()
        {
            return "Dando de alta esta materia";
        }

        public string Baja()
        {
            return "Dando de baja esta materia";
        }

        public string Modificar()
        {
            return "Modificando esta materia";
        }
    }
}
