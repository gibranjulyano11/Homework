using System;

namespace AplicacionConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                Console.WriteLine(args[0]);
            }
            Console.Write("Hola soy Doki, ");
            Console.WriteLine("Cúal es tu nombre?");
            string datosIngresados = Console.ReadLine();
            Console.WriteLine("Mucho gusto " + datosIngresados + "," + "¿Cómo estás?");
            string datosReceptados = Console.ReadLine();
            Console.Write("Cuídate, hasta luego ");
            Console.WriteLine(datosIngresados);
        }
    }
}
