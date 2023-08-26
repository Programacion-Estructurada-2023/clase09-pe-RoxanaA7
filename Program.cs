using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {

            //EJERCICIOS CON ESTRUCTURA SELECTIVA IF - ELSE

            //PROGRAMA PARA PODER CALCULAR SI ES MAYOR DE EDAD

            Console.WriteLine("\n---PROGRAMA QUE DETERMINA SI ES MAYOR DE EDAD ---\n");

            Console.WriteLine("\nIngresa tu edad: ");
            int edad=Convert.ToInt32(Console.ReadLine());

            if (edad >=18)
            {
                Console.WriteLine("Tu edad es "+edad+" eres mayor de edad ");
                
            }
            else{

                Console.WriteLine("Tu edad es "+edad+" eres menor de edad");
            }

             Console.WriteLine("\n\n---PROGRAMA QUE DETERMINA SI UN NUMERO ES PAR O IMPAR---\n");
             Console.WriteLine("\nIngresa un numero: ");
             int numero=Convert.ToInt32(Console.ReadLine());

             if (numero % 2 ==0)
             {
                Console.WriteLine("\nEl numero "+ numero + " es par");
 
             }
             else
             {
                Console.WriteLine("\nEl numero "+numero+" es impar");
                
             }

            Console.ReadKey();
            
        }
    }
}
