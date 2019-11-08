using System;
using System.Collections.Generic;
using System.Text;

namespace Planim
{
    class NuevaActividad
    {
        private int _idActividad;
        private int tiempoTotal;
        private int _idPuntaje;
        private string nombre;
        private List<int> ListaId;
        private int cantNiñosRecom;
        private int edadRecom;
        private int idMadrij;
        public NuevaActividad() { }

      
        

        public NuevaActividad(int idActividad, int tiempoTotal, int idPuntaje, string nombre, List<int> listaId, int cantNiñosRecom, int edadRecom,int idm)
        {
            _idActividad = idActividad;
            this.tiempoTotal = tiempoTotal;
            _idPuntaje = idPuntaje;
            this.nombre = nombre;
            ListaId = listaId;
            this.cantNiñosRecom = cantNiñosRecom;
            this.edadRecom = edadRecom;
            idMadrij = idm;
        }

        public int idActividad { get => _idActividad; set => _idActividad = value; }
        public int TiempoTotal { get => tiempoTotal; set => tiempoTotal = value; }
        public int idPuntaje { get => _idPuntaje; set => _idPuntaje = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public List<int> listaId { get => ListaId; set => ListaId = value; }
        public int CantNiñosRecom { get => cantNiñosRecom; set => cantNiñosRecom = value; }
        public int EdadRecom { get => edadRecom; set => edadRecom = value; }
        public int IdMadrij { get => idMadrij; set => idMadrij = value; }
    }
}
