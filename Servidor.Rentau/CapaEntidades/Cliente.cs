
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1_YerlinReyes
{
    public class Cliente
    {
        //atributos
        private string identificacion = "";
        private string nombre = "";
        private string primerApellido = "";
        private string segundoApellido = "";
        DateTime nacimiento = new DateTime();
        char genero = 'N';
        String generoAux;

        //metodos

        public Cliente(string identificacion, string nombre, string primerApellido, string segundoApellido, DateTime nacimiento1, char genero)
        {
            this.identificacion = identificacion;
            this.nombre = nombre;
            this.primerApellido = primerApellido;
            this.segundoApellido = segundoApellido;
            this.genero = genero;
            this.nacimiento = nacimiento1;

            trasformarGenero();
        }

        public void trasformarGenero()
        {
            if (genero =='F')
            {
                generoAux = "Femenino";
            }
            else
            {
                generoAux = "Masculino";
            }
        }
        public Cliente() { }

        public string Identificacion { get { return identificacion; } set { identificacion = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string PrimerApellido { get { return primerApellido; } set { primerApellido = value; } }
        public string SegundoApellido { get { return segundoApellido; } set { segundoApellido = value; } }
        public DateTime Nacimiento { get { return nacimiento; } set { nacimiento = value; } }
        public char Genero { get { return genero; } set { genero = value; } }
        public String Genero_ { get { return generoAux; } set { generoAux = value; } }
    }
}
