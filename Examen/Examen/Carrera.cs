using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Carrera : IABM
    {
        string Nombre; //para que esta la variable ??

        //SIEMPRE LOS NOMBRES DE METODOS DEBEN SER ACCIONES . Insertar, Eliminar, Modificar. 
        public string Alta()
        {
            return "Dando de alta esta carrera";
        }

        public string Baja()
        {
            return "Dando de baja esta carrera";
        }

        public string Modificar()
        {
            return "Modificando esta Carrera";
        }
    }
}
