namespace Ejercicio44Version3.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejemplo Ciclo For");

            int sumaNumeros = 0;
            //Comienzo del ciclo
            for (int contador = 1; contador <= 5; contador++)
            {
                Console.Write($"Ingrese el {contador}º valor a sumar:");
                var nroIngresado = int.Parse(Console.ReadLine());
                //sumaNumeros = sumaNumeros + nroIngresado;
                sumaNumeros += nroIngresado;
                

            }
            Console.WriteLine($"La suma de los 5 números ingresados es {sumaNumeros}");

        }
    }
}