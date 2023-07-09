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
                Console.WriteLine("Elija una opcion:" ); //Mostramos en consola para que elija una opcion del 1 al 6
                opciones = Convert.ToInt32(Console.ReadLine()); //Con ambos metodos se lee la informacion del usuario para asignarlo a la variable opciones
                if (opciones == 1) //Usamos la condicional if para determinar que accion realizar, en este caso la suma (opcion 1)
                {
                    Console.WriteLine("Digite un primer valor: ");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Digite un segundo valor: ");
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    int total = sumar (num1, num2); // LLamamos a la funcion sumar agregando los valores num1 y num2 para almacenarlo en la variable total
                    Console.WriteLine("Total: " + total); // Mostramos mensaje + valor calculado por la suma
                
                }
            
            
            
            
            
            
            
            
            
            
            
            }
        }
    }
}