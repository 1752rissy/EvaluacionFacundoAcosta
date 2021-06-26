using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Profesor : IABM, IBUSQUEDA
    {
        public string Alta()
        {
            return "Dando de alta Profesor";
        }

       

        public string Baja()
        {
            return "Dando de baja profesor";
        }

        public string buscar()
        {
            return "Buscando profesor dictando materia";
        }

        public string buscarDni()
        {
            return "Buscando profesor por dni";
        }

        public string Modificar()
        {
            return "Modificando Profesor en base de datos";
        }
    }
}
