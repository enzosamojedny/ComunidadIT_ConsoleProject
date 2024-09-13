namespace ComunidadIT_ConsoleProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Juguemos un juego. Esto es sencillo: Hay dos números aleatorios, del 1 al 20");
            Console.WriteLine("El programa tiene un loop que itera un máximo de 20 veces, comparando esos dos números en cada iteración.");
            Console.WriteLine("Tu objetivo es adivinar cuántas iteraciones tomará para que los dos números sean iguales.");
            Console.WriteLine("Para jugar, solo tenés que escribir a continuación un número del 1 al 20.");
            Random random = new Random();

            var userInput = int.Parse(Console.ReadLine());
            if (userInput > 20)
            {
                Console.WriteLine("Elegiste un número demasiado alto!");
            }
            else if (userInput < 1)
            {
                Console.WriteLine("Elegiste un número demasiado bajo!");
            }
            Console.Clear();
            Thread.Sleep(100);
            int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] arr2 = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };

            var mergedArrays = arr1.Concat(arr2).ToArray();
            int randomNumber = random.Next(0, mergedArrays.Length);

            for (int j = mergedArrays.Length - 1; j > 0; j--)
            {
                int k = random.Next(0, j + 1);//random index entre 0 e i
                int temp = mergedArrays[j];
                mergedArrays[j] = mergedArrays[k];
                mergedArrays[k] = temp;
            }
            var randomValue = mergedArrays[randomNumber];

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
