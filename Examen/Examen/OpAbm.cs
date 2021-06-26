using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class OpAbm
    {
        private readonly IABM _iabm;

        public OpAbm(IABM opabm1)
        {
            _iabm = opabm1;
        }

        public string Altas()
        {
            return _iabm.Alta();
        }

        public string Bajas()
        {
            return _iabm.Baja();
        }

        public string Modificaciones()
        {
            return _iabm.Modificar();

        }
    }
}
