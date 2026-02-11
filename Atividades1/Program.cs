namespace Atividades1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Volume do Cubo");
            Console.WriteLine("Digite a área do cubo:");
            if(float.TryParse(Console.ReadLine(), out float areaCubo))
            {
                double volume = Math.Pow(areaCubo, 3);
                Console.WriteLine($"A área do seu cubo é: {volume}");
            }
            else
            {
                Console.WriteLine("Valor incorreto, tente novamente.");
            }
            */

            // Exercício 2

            /* Console.WriteLine("Área da Circunferência");
            Console.WriteLine("Digite o raio:");
            if (double.TryParse(Console.ReadLine(), out double raioCirc))
            {
                double circunferencia = Math.PI * Math.Pow(raioCirc, 2);
                Console.WriteLine($"A área da circunferência é: {circunferencia}");
            }
            else
            { 
                Console.WriteLine("Valor incorreto, tente novamente.");
            } */

            // Exercício 3

            /* Console.WriteLine("-- Conversor C -> F ---");
            Console.WriteLine("Você deseja começar com Celcius ou Fahrenheit? (C/F):");
            string? escolhaTemp = Console.ReadLine();
       
            if(escolhaTemp == "C" || escolhaTemp == "c")
            {
                Console.WriteLine("Digite a temperatura em Celsius:");
                if(float.TryParse(Console.ReadLine(), out float temp))
                {
                    float tempF = (temp * 9 / 5) + 32;
                    Console.WriteLine($"A temperatura em Fahrenheit é: {tempF}");
                }
                else
                {
                    Console.WriteLine("Valor incorreto, tende de novo.");
                }
            }
            else if (escolhaTemp == "F" || escolhaTemp == "f")
            {
                Console.WriteLine("Digite a temperatura em Fahrenheit:");
                if (float.TryParse(Console.ReadLine(), out float temp))
                {
                    float tempC = ((temp - 32) * 5) / 9;
                    Console.WriteLine($"A temperatura em Celsius é: {tempC}");
                }
                else
                {
                    Console.WriteLine("Valor incorreto, tende de novo.");
                }
            }
            else
            {
                Console.WriteLine("Essa medição não existe!");
            } */

            // Exercício 4:

            Console.WriteLine("-- Equação de 2º Grau --\n\n");

            Console.WriteLine("Digite o valor de a:");
            if (float.TryParse(Console.ReadLine(), out float a))
            {
                Console.WriteLine("Valor de a armazenado.\n");
                Console.WriteLine("Digite o valor de b:");
                if (float.TryParse(Console.ReadLine(), out float b))
                {
                    Console.WriteLine("Valor de b armazenado.\n");
                    b = -b;
                    Console.WriteLine("Digite o valor de c:");
                    if (float.TryParse(Console.ReadLine(), out float c))
                    {
                        Console.WriteLine("Valor de c armazenado.\n");
                        Console.WriteLine($"Temos: {a}x² {b}x + {c} = 0.\n");
                        double delta = Math.Pow(b, 2) - (4 * a * c);
                        Console.WriteLine($"Seu delta é: {delta}.\n\n");

                        if(delta < 0)
                        {
                            Console.WriteLine("Delta negativo, não existe raiz real.");
                            return;
                        }
                        else
                        {
                            double x1 = (Math.Pow(b, 2) + Math.Sqrt(delta)) / (2 * a);
                            double x2 = (Math.Pow(b, 2) - Math.Sqrt(delta)) / (2 * a);

                            Console.WriteLine($"Sua coleção finalizada é: ({x1}, {x2})");
                        }            
                    }
                    else
                    {
                        Console.WriteLine("Valor inválido, tente novamente.");
                    }
                }
                else
                {
                    Console.WriteLine("Valor inválido, tente novamente.");
                }
            }
            else
            {
                Console.WriteLine("Valor inválido, tente novamente.");
            }
        }
    }
}
