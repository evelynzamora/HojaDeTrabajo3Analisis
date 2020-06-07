using System;

namespace miPrograma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HOJA DE TRABAJO 3: ");

            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Evelyn\Documents\HojaDeTrabajo3\archivo1.txt");


            System.Console.WriteLine("Leer archivo = ");
            foreach (string line in lines)
            {

                Console.WriteLine("," + line);
            }


            Console.WriteLine("Presiona una tecla para salir.");
            System.Console.ReadKey();

        }
    }
}

