using System;
using System.Collections.Generic;
using System.Text;

namespace Planim
{
    class NuevoJuego
    {
        
        private int _idJuego;
        private string nombre;
        private string explicacion;
        private int _idAmbito;
        //private int _idActividad;
        private int orden;
        private int tiempo;
      //  private int _idJuegoVariante;
        private int edadRecomendada;
        private int cantNiñosRecom;

      
        public int idJuego { get => _idJuego; set => _idJuego = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Explicacion { get => explicacion; set => explicacion = value; }
        public int idAmbito { get => _idAmbito; set => _idAmbito = value; }
     //   public int idActividad { get => _idActividad; set => _idActividad = value; }
        public int Orden { get => orden; set => orden = value; }
        public int Tiempo { get => tiempo; set => tiempo = value; }
     //   public int idJuegoVariante { get => _idJuegoVariante; set => _idJuegoVariante = value; }
        public int EdadRecomendada { get => edadRecomendada; set => edadRecomendada = value; }
        public int CantNiñosRecom { get => cantNiñosRecom; set => cantNiñosRecom = value; }

        public NuevoJuego()
        {

        }
        public NuevoJuego(int idJuego, string nombre, string explicacion, int idAmbito, /*int idActividad,*/ int orden, int tiempo, /*int idJuegoVariante,
            */ int edadRecomendada, int cantNiñosRecom)
        {
            _idJuego = idJuego;
            this.nombre = nombre;
            this.explicacion = explicacion;
            _idAmbito = idAmbito;
           // _idActividad = idActividad;
            this.orden = orden;
            this.tiempo = tiempo;
          //  _idJuegoVariante = idJuegoVariante;
            this.edadRecomendada = edadRecomendada;
            this.cantNiñosRecom = cantNiñosRecom;
        }

    }
}
