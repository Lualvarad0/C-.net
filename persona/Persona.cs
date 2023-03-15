using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace persona
{
    class Persona
    {
        double sueldo;
        string nombre;
        string cedula;
        string Apellido;
        int Edad;
        Boolean Estado;
        Boolean Hijos;

        public double Sueldo { get => sueldo; set => sueldo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Cedula { get => cedula; set => cedula = value; }
        public string Apellido1 { get => Apellido; set => Apellido = value; }
        public int Edad1 { get => Edad; set => Edad = value; }
        public bool Estado1 { get => Estado; set => Estado = value; }
        public bool Hijos1 { get => Hijos; set => Hijos = value; }
    }
}
