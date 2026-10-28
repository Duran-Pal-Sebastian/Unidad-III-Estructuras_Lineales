using System;
namespace Proyecto3_Llamadas
{
    internal class Program
    {
        static Pila llamadas = new Pila();

        static void Main()
        {
            int opcion;

            do
            {
                Console.Clear();

                Console.WriteLine("==== SIMULADOR DE LLAMADAS ====");
                Console.WriteLine("1. Registrar llamadas");
                Console.WriteLine("2. Regresar");
                Console.WriteLine("3. Mostrar Historial");
                Console.WriteLine("0. Salir");

                Console.Write("Opcion: ");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Función: ");
                        llamadas.Apilar(Console.ReadLine());
                        break;

                    case 2:
                        string llamada = llamadas.Desapilar();
                        Console.WriteLine(
                            llamada == null
                            ? "no existen llamadas"
                            : $"Regresando de (llamada)");
                        Console.ReadKey();
                        break;
                    case 3:
                        llamadas.Mostrar();
                        Console.ReadKey();
                        break;
                }
            } while (opcion != 0);

        }
    }
}
