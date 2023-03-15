using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace persona
{
    class Program
    {
        Persona[] arrayPersonas = new Persona[50];
        int contador = 0;
        public void generaPersonas()
        {
            string cadena;
            string[] cedula = {"01","02","03","04","05","06","07","08","09","10","11",
                        "12","13","14","15","16","17","18","19","20","21","22","23","24"};
            Random objRandom = new Random(Environment.TickCount);
            Console.WriteLine("Cuantas personas desea ingresar");
            contador = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < contador; i++)
            {
                arrayPersonas[i] = new Persona();
                arrayPersonas[i].Nombre = "Nombre" + i;
                arrayPersonas[i].Apellido1 = "Apellido " + i;

                cadena = Convert.ToString(objRandom.Next(10));
                for (int j = 0; j < 7; j++)
                {
                    cadena = cadena + Convert.ToString(objRandom.Next(10));

                }
                arrayPersonas[i].Cedula = cedula[objRandom.Next(24)] + cadena;
                arrayPersonas[i].Sueldo = objRandom.Next(100) + objRandom.NextDouble();
                if (objRandom.Next(2) == 0)
                {
                    arrayPersonas[i].Hijos1 = true;
                }
                else
                {
                    arrayPersonas[i].Hijos1 = false;
                }

                arrayPersonas[i].Estado1 = true;

            }

            for (int i = 0; i < contador; i++)
            {
                Console.WriteLine(arrayPersonas[i].Nombre);
                Console.WriteLine(arrayPersonas[i].Cedula);
                Console.WriteLine(Math.Truncate(100 * arrayPersonas[i].Sueldo) / 100);
                Console.WriteLine(arrayPersonas[i].Edad1);
                Console.WriteLine(arrayPersonas[i].Estado1);

            }
        }
        
        public void elimina_logica()
        {
            int busqueda;
            Console.WriteLine("Ingrese la edad de las persoas que desea eliminar ");
            busqueda = Convert.ToInt32(Console.ReadLine());
            for (int l = 0; l > arrayPersonas.Length; l++)
            {
                if((arrayPersonas[l].Edad1 > busqueda) && (arrayPersonas[l].Estado1 == true))
                {
                    Console.WriteLine(arrayPersonas[l].Nombre);
                    Console.WriteLine(arrayPersonas[l].Cedula);
                    Console.WriteLine(Math.Truncate(100 * arrayPersonas[l].Sueldo) / 100);
                    Console.WriteLine(arrayPersonas[l].Edad1);
                    Console.WriteLine(arrayPersonas[l].Estado1);
                    Console.Clear();
                    Console.WriteLine("eliminacion con exito");



                }
                else { Console.WriteLine("lo sentimos, no hay personas con esa edad"); }
            }
        }

        public void buscarPersona()
        {
            int busqueda;
            Console.WriteLine("Ingrese la edad de las persoas que desea encontrar ");
            busqueda = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < contador; i++)
            {

                if ((arrayPersonas[i].Edad1 > busqueda) && (arrayPersonas[i].Estado1 == true))
                {
                    Console.WriteLine(arrayPersonas[i].Nombre);
                    Console.WriteLine(arrayPersonas[i].Cedula);
                    Console.WriteLine(Math.Truncate(100*arrayPersonas[i].Sueldo)/100);
                    Console.WriteLine(arrayPersonas[i].Edad1);
                    Console.WriteLine(arrayPersonas[i].Estado1);
                    Console.WriteLine();
                }
                else { Console.WriteLine("lo sentimos, no hay personas con esa edad"); }
            }
        }
        static void Main(string[] args)
        {
            
            Program objPersona = new Program();
            objPersona.generaPersonas();
            objPersona.buscarPersona();
            objPersona.elimina_logica();
            
            
            
        }
    }
}
