﻿namespace Ejercicio44.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejemplo Ciclo While");
            int contador = 0;
            int sumaNumeros = 0;
            //Comienzo del ciclo
            while (contador <5) {
                Console.Write($"Ingrese el {contador+1}º valor a sumar:");
                var nroIngresado=int.Parse(Console.ReadLine());
                //sumaNumeros = sumaNumeros + nroIngresado;
                sumaNumeros += nroIngresado;
                contador++;//contador=contador+1

            }
            Console.WriteLine($"La suma de los 5 números ingresados es {sumaNumeros}");

        }
    }
}