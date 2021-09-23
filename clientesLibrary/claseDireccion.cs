using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clientesLibrary
{
    public class claseDireccion
    {
        private string calle;
        private int numero;
        private string comuna;
        public string Comuna
        {
            get { return comuna; }
            set { comuna = value; }
        }
        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public string Calle
        {
            get { return calle; }
            set { calle = value; }
        }
    }
}
