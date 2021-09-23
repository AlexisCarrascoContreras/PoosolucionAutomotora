using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clientesLibrary
{
    public class claseCliente
    {
        private string rut;
        private string nombre;
        private string direccion;
        private int telefono;
        private string email;
        private string fechaNac;

        public string FechaNac
        {
            get { return fechaNac; }
            set { fechaNac = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }


        public int Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }


        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }


        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Rut
        {
            get { return rut; }
            set { rut = value; }
        }

        
    }
}
