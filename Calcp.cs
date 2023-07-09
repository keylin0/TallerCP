namespace Calculadora
{
    internal class Calcp
    {
        private static void Main(string[] args)
        {
            int opciones = 0; //Se declara una variable entera (opciones) que inicializa su valor en 0
            string menuc = " **** Calculadora Menu **** \n" + // Luego un string llamado menuc y la inicializo con un valor que representa la calculadora
                             "1 - Sumar \n" +
                             "2 - Restar \n" +
                             "3 - Multiplicar \n" +
                             "4 - Dividir \n" +
                             "5 - Limpiar \n" +
                             "6 - Salir \n";
            Console.WriteLine(menuc); //Luego imprimimos en consola el contenido de la variable
        }
    }
}