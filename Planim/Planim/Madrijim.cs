using System;
using System.Collections.Generic;
using System.Text;

namespace Planim
{
    class Madrijim
    {
        private string nombre;
        private string apellido;
        private string mail;
        private string contraseña;
        private string institucion;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Mail { get => mail; set => mail = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public string Institucion { get => institucion; set => institucion = value; }

        public Madrijim(string nombre, string apellido, string mail, string contraseña, string institucion)
        {
            Nombre = nombre;
            Apellido = apellido;
            Mail = mail;
            Contraseña = contraseña;
            Institucion = institucion;
        }
    }
}
