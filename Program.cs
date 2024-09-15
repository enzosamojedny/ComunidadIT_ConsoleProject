namespace ComunidadIT_ConsoleProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Juguemos un juego. Esto es sencillo: Tenés que adivinar el número correcto.");
            Console.WriteLine("Dato: se usa el alg de Fisher-Yates, para hacer que el número sea siempre random.");
            Console.WriteLine("Para jugar, solo tenés que escribir a continuación un número del 1 al 10.");
            Random random = new Random();

            //parseo a int para poder usarlo en la comparacion más adelante
            var userInput = int.Parse(Console.ReadLine());

            //caso fuera de límites
            if (userInput > 10)
            {
                Console.WriteLine("Elegiste un número demasiado alto!");
                return;
            }
            else if (userInput < 1)
            {
                Console.WriteLine("Elegiste un número demasiado bajo!");
                return;
            }
            Console.Clear();
            //agrego el thread.sleep para que solo se limpien los writeline
            Thread.Sleep(100);

            int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] arr2 = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };

            //mergeo los arrays en uno solo
            var mergedArrays = arr1.Concat(arr2).ToArray();

            //hago un shuffle de los arrays con igual probabilidad de que toque cualquier numero
            for (int j = mergedArrays.Length - 1; j > 0; j--)
            {
                //random index entre 0 y j(inclusive)
                int k = random.Next(0, j + 1);

                // asigno el indice de j en una variable temporal
                int temp = mergedArrays[j];

                //cambio el indice de j por el indice aleatorio
                mergedArrays[j] = mergedArrays[k];

                //asigno el valor de temp (reemplazo mergedArrays[j] por el indice random K)
                //lo cual asegura que el numero sea lo mas aleatorio posible
                mergedArrays[k] = temp;
            }
            //como mergedArrays ya esta mezclado, solo selecciono el primer numero y va a ser siempre diferente
            var randomValue = mergedArrays[0];

            if (userInput == randomValue)
            {

                Console.WriteLine("¡Adivinaste!");
                Console.WriteLine($"El número era {randomValue}");
                return;
            }
            else if (userInput > randomValue)
            {
                Console.WriteLine("Tu estimación fue demasiado alta.");
                Console.WriteLine($"Tu número: {userInput}");
                Console.WriteLine("Número ganador");
                Console.WriteLine($"{randomValue}");
                return;
            }
            else if (userInput < randomValue)
            {
                Console.WriteLine("Tu estimación fue demasiado baja.");
                Console.WriteLine($"Tu número: {userInput}");
                Console.WriteLine("Número ganador");
                Console.WriteLine($"{randomValue}");
                return;
            }
            else
            {
                Console.WriteLine("Algo falló!");
                return;
            }
        }

    }
    }
