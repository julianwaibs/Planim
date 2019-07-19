using System;
using System.Collections.Generic;
using System.Text;

namespace Planim
{
    public class Madrijim
    {
        private int idMadrij;
        private string nombre;
        private string apellido;
        private string mail;
        private string contrasenia;
        private string instituciones;
        private int idInstitucion;


        public Madrijim()
        {

        }

        public Madrijim(int idMadrij, string nombre, string apellido, string mail, string contrasenia, string instituciones, int idInstitucion)
        {
            this.IdMadrij = idMadrij;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Mail = mail;
            this.Contrasenia = contrasenia;
            this.Instituciones = instituciones;
            this.IdInstitucion = idInstitucion;
        }

        public int IdMadrij { get => idMadrij; set => idMadrij = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Mail { get => mail; set => mail = value; }
        public string Contrasenia { get => contrasenia; set => contrasenia = value; }
        public string Instituciones { get => instituciones; set => instituciones = value; }
        public int IdInstitucion { get => idInstitucion; set => idInstitucion = value; }
    }
}
