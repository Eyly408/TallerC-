using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerC_
{
    public internal class Ejercicio1
    {

            public void areatriangulo()
        {
            //Escribir mensaje 
            Console.WriteLine("Bienvenido al desarrollo del problema");
            //--Definir variables--
            
            
            //Solicitar datos

            Console.WriteLine("Ingrese lado a");
            //Guardar datos
            var a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese lado b");
            //Guardar datos
            var b = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese lado c");
            //Guardar datos
            var c = int.Parse(Console.ReadLine());

            //Proceso
            var semiperimetro = (a + b + c) / 2; 
            var area=Math.Sqrt(semiperimetro*(semiperimetro-a)*(semiperimetro-b)*(semiperimetro-c));

            //Salida datos
            Console.WriteLine($"El area del triangulo es segun los lados a {a}, {b}, {c} es: {area} m2");

            //Detener la pantalla para mostrar el resultado
            Console.ReadKey();





        }

    }
}
