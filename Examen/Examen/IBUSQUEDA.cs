using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    //esta interfaz no cumple con lo especificado en el modelo de clases que desarrollo , revise. Ya con este error toda la solucion seria incorrecta.
    //porque las clases que la implementan no cumplen el contrato definido en dicho modelo desarrollado.
    interface IBUSQUEDA
    {
        string buscar();

        string buscarDni();

        
    }
}
