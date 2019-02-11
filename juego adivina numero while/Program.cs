using System;

namespace juego_adivina_numero_while
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numero = new Random();

            int aleatorio = numero.Next(0, 100);

            int minumero = 101;


         Console.WriteLine($"el numero es {aleatorio}");
        
            int intentos = 0;

            Console.WriteLine("Introduce un numero de 0 a 100");

            while (aleatorio != minumero)
            {

                intentos++;

                minumero = int.Parse(Console.ReadLine());

                var mensaje = minumero > aleatorio ? "El numero es mas alto" : "El numero es mas bajo";
                Console.WriteLine(mensaje);

                /*if (minumero > aleatorio) { Console.WriteLine("El numero es mas alto"); }

                if (minumero < aleatorio) { Console.WriteLine("El numero es mas bajo"); }*/

            }
            Console.WriteLine($"has acertado, haz necesitado de {intentos} intentos.");
            Console.ReadKey();
        }

            
           
        
    }
}
