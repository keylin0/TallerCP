using System.ComponentModel.Design;

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
            while (opciones != 6) //Abrimos un while para comprobar si la variable opciones es diferente de 6
            {                   //(Mientras la condicion sea verdadera, el bucle se ejecutara y continuara solicitando opciones)
                Console.WriteLine("Elija una opcion:"); //Mostramos en consola para que elija una opcion del 1 al 6
                opciones = Convert.ToInt32(Console.ReadLine()); //Con ambos metodos se lee la informacion del usuario para asignarlo a la variable opciones
                if (opciones == 1) //Usamos la condicional if para determinar que accion realizar, en este caso la suma (opcion 1)
                {
                    Console.WriteLine("Digite un primer valor: ");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite un segundo valor: ");
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    int total = sumar(num1, num2); // LLamamos a la funcion sumar agregando los valores num1 y num2 para almacenarlo en la variable total
                    Console.WriteLine("Total: " + total); // Mostramos mensaje + valor calculado por la suma
                }
                else if (opciones == 5) //Si la variable opciones es igual a 5 se limpiara la pantalla
                {
                    Console.Clear(); //Limpiamos pantalla
                }
                Console.WriteLine(menuc); // Despues de limpiar pantalla mostramos en consola el menu nuevamente
                int sumar(int num1, int num2) //Le damos valor a la funcion llamada sumar que toma 2 parametros de tipo entero
                {
                    return num1 + num2; //La funcion suma los 2 valores y devuelve el resultado como un entero
                }
                else 
                    if ( opciones == 2)
                {
                    Console.WriteLine("Ingrese primer valor: ");
                    int num1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Ingrese segundo valor: ");
                    int num2 = Convert.ToInt32(Console.ReadLine());

                    int total = (num1 - num2);
                    Console.WriteLine("Total : " + total);

                }

                else if (opciones == 3)
                {
                    Console.WriteLine("Ingrese primer valor: ");
                    int num1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Ingrese segundo valor: ");
                    int num2 = Convert.ToInt32(Console.ReadLine());

                    int total = (num1 * num2);
                    Console.WriteLine("Total: " + total);
                }
            }
        }
    }
}