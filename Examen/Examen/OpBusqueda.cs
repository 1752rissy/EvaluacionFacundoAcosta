using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class OpBusqueda
    {
        //Nunca nombre interfaces todo en MAYUSCULA. Tener muy en cuenta esto por favor. 
        private readonly IBUSQUEDA _ibusqueda;

            public OpBusqueda(IBUSQUEDA opbusqueda)
        {
            _ibusqueda = opbusqueda;
        } 

        public string Busqueda()
        {
            return _ibusqueda.buscar();
        }

        public string BusquedaDni()
        {
            return _ibusqueda.buscarDni();
        }
    }
}
