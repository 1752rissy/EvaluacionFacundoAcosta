using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Alumno : IABM, IBUSQUEDA
    {
        string Nombre;
        string Apellido;
        string Dni;
        public string Alta()
        {
            return "Dando de alta al alumno";
        }

       

       

        public string Baja()
        {
            return "Dando de baja al alumno";
        }

        public string buscar()
        {
            return "Buscando Alumno cursando materia o carrera";
        }

        public string buscarDni()
        {
            return "Buscando alumno por Dni";
        }

        public string Modificar()
        {
            return "Modificando alumno en base de datos";
        }

       
        
    }
}
