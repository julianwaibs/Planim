using System;
using System.Collections.Generic;
using System.Text;

namespace Planim
{
    class ActividadxMadrij
    {
        private int _idaxm;
        private int _idM;
        private int _idA;

        public ActividadxMadrij()
        {

        }

        public ActividadxMadrij(int idaxm, int idM, int idA)
        {
            _idaxm = idaxm;
            _idM = idM;
            _idA = idA;
        }

        public int idActivixMadrij { get => _idaxm; set => _idaxm = value; }
        public int idMadrij { get => _idM; set => _idM = value; }
        public int idActividad { get => _idA; set => _idA = value; }
    }
}
