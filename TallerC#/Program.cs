using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escribir mensaje 
            Console.WriteLine("Bienvenido a C#");

            //--Definir variables--
            int a, b, producto;
            
            //--Entrada datos--
            Console.WriteLine("Ingrese primer numero");
            //--Guardar un valor en la consola--
            a = Convert.ToInt32(Console.ReadLine());
            //a= int. TryParse(Console.ReadLine()); //  Boolean True or False

            //--Entrada datos--
            Console.WriteLine("Ingrese segundo numero");
            //--Guardar un valor en la consola--
            b = Convert.ToInt32(Console.ReadLine());
            //b= int. TryParse(Console.ReadLine()); //  Boolean True or False

            //-- Proceso --
            producto = a * b;

            //-- Salida datos --
            Console.WriteLine("El producto es:" + producto);
            Console.WriteLine($"El producto de {a} * {b} = {producto}");



            //Detener la pantalla para mostrar el resultado
            Console.ReadKey();
        }
    }
}
