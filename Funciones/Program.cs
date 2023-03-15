using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones
{
    class Funciones
    {
        public void Cubo()
        {
            float numero;
            Console.WriteLine("Ingrese el numero a elevar al cubo");
            numero = float.Parse(Console.ReadLine());
            Console.WriteLine("El cubo del numero " + numero + " es: " + numero * numero * numero);
            Console.ReadKey();
            

        }

        public void menor()
        {
            int a, b, mayor;

            Console.Write("Escriba un número: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Escriba otro: ");
            b = Convert.ToInt32(Console.ReadLine());

            mayor = a > b ? a : b;

            Console.WriteLine("El mayor de los números es {0}.", mayor);
            Console.ReadLine();
            /*
             * solo si la funcion no carga con el metodo de arriba
            if (a > b)
            {
                mayor = a;
                Console.WriteLine("El mayor de los números es {0}.", mayor);
            }
            else
                mayor = b;
                Console.WriteLine("El mayor de los números es {0}.", mayor);*/
        }

        public void Signo()
        {
            double numero; // Aquí guardaremos el número que el usuario escriba
            Console.WriteLine("Introduce un número: ");
            numero = Convert.ToDouble(Console.ReadLine());
            // Compararlo
            if (numero == 0)
            {
                // printf("Neutro");
                Console.WriteLine("su numero es neutro= " + numero);
            }
            else if (numero > 0)
            {
                //el numero es positivo
                Console.WriteLine("Su numero es positivo= 1"+" transformado a negativo es");
                numero *= -1;
                Console.WriteLine("El valor es " + numero);
                Console.ReadLine();
            }
            else
            {
                // Si no es neutro ni positivo, es negativo
                Console.WriteLine("Su numero es negativo= -1" + " transformado a positivo es");
                numero *= -1;
                Console.WriteLine("El valor es "+ numero);
                Console.ReadLine();
            }
        }

        public void MostrarPerimSuperfCuadrado()
        {
            //**imaginemos que el cuadrado tiene la misma base y altura
            int a,b;
            Console.Write("Ingrese la base del cuadrado: ");
            a = Convert.ToInt32(Console.ReadLine());
            b = a*4;
            a *= a;
            Console.Write("El perimetro de un cuadrado es: "+ b + " y su superficie es de "+a+ " cm cuadrados");
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            Funciones obj = new Funciones();
            //obj.Cubo();
            //obj.menor();
            //obj.MostrarPerimSuperfCuadrado();
            obj.Signo();

        }
    }
}
