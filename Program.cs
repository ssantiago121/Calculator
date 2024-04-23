using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Multiplicacao();
        }

        static void Somar()
        {

            Console.Clear(); //Limpa o Terminal

            Console.WriteLine("Digite o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 + v2;

            Console.WriteLine($"O valor da Soma é {resultado}!"); // Interpolação de String

            // ------ Outras formas válidas de apresentar o resultado ------
            // Console.WriteLine("A Soma é de " + resultado); // Concatenação de String
            // Console.WriteLine("A Soma é de " + (v1 + v2)); // Soma direto na String
        }

        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Digite o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 - v2;

            Console.WriteLine($"O Valor da Subtração é de {resultado}!");

        }

        static void Divisao()
        {
            Console.Clear();
            
            Console.WriteLine("Digite o primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 / v2;

            Console.WriteLine($"O Valor da Divisão é {resultado}!");
        }

        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("Digite o primeir valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1 * v2;

            Console.WriteLine($"O Valor da Multiplicação é {resultado}!");
        }
    }
}
