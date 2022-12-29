using System;

public class Program 
{
    static void Main() 
    {
        Console.WriteLine("Welcome to the age calculator in seconds");

        bool terminado = false;

        do
        {
             Console.Write("Por favor introduce el año a convertir: ");
            int year = Convert.ToInt32(Console.ReadLine());

            if (year % 4 == 0) {
                Console.WriteLine("Ojo este es un año bisiesto");            
                int resultadoBisiesto = (366 * 24 * 3600);
                Console.WriteLine($"El año {year} consta de: " + resultadoBisiesto + " segundos");
                Console.WriteLine("¿Quieres probar otro año? Yes = 1 / No = 0");
                int otraVez = Convert.ToInt32(Console.ReadLine());
                    if(otraVez == 0){
                        terminado = true;
                    }
            } else {
                int resultado = (365 * 24 * 3600);
                Console.WriteLine($"El año {year} consta de: " + resultado + " segundos");
                Console.WriteLine("¿Quieres probar otro año? Yes = 1 / No = 0");
                int otraVez = Convert.ToInt32(Console.ReadLine());
                    if(otraVez == 0){
                        terminado = true;
                    }        
            }
            
        } while (terminado == false);
       
        Console.WriteLine("Gracias por usar el programa");
        Console.ReadKey();
    }
}
