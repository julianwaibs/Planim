using System;
using System.Collections.Generic;
using System.Text;

namespace Planim
{
    class ActividadxMadrij
    {
        private int _idM;
        private NuevaActividad _actividad;

        public ActividadxMadrij(int IdM, NuevaActividad Actividad)
        {
            idM = IdM;
            actividad = Actividad;
        }

        public int idM { get => _idM; set => _idM = value; }
        public NuevaActividad actividad { get => _actividad; set => _actividad = value; }
    }
}
