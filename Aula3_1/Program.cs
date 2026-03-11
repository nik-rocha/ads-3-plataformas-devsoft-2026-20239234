namespace Aula3
{
    internal class Program2
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Digite um número para dividir 100:");

            //try
            //{
            //    int numero = int.Parse(Console.ReadLine());
            //    float resultado = 100 / numero;
            //    Console.WriteLine($"{resultado}");
            //}
            ////catch (FormatException)
            ////{
            ////    Console.WriteLine("Entrada inválida.");
            ////}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("O número deve ser diferente de zero.");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"Algo deu errado! {ex.GetType()}");
            //}
            //finally
            //{
            //    Console.WriteLine("O finally é sempre executado.");
            //}

            //Where

            //List<int> numeros = new List<int> { 10, 20, 30, 40 };
            ////Filtra números maiores que 30
            //IEnumerable<int> filtrados = numeros.Where(n => n > 30);
            //Console.WriteLine("Números maiores que 30:");
            //foreach (var num in filtrados)
            //{
            //    Console.WriteLine(num);
            //}

            //Select

            //List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };
            //// Transforma cada número em seu quadrado
            //var quadrados = numeros.Select(n => n * n);
            //Console.WriteLine("Quadrados dos números:");
            //foreach (var quadrado in quadrados)
            //{
            //    Console.WriteLine(quadrado); // 1, 4, 9, 16, 25
            //}

            //OrderBy

            //List<string> frutas = new List<string> { "Maçã", "Banana", "Laranja", "Uva" };
            //// Ordena as frutas em ordem alfabética
            //var ordenadas = frutas.OrderBy(f => f);
            //Console.WriteLine("Frutas ordenadas:");
            //foreach (var fruta in ordenadas)
            //{
            //    Console.WriteLine(fruta); // Banana, Laranja, Maçã, Uva
            //}

            //OrderByDescending

            //List<string> frutas = new List<string> { "Maçã", "Banana", "Laranja", "Uva" };
            //// Ordena as frutas em ordem alfabética
            //var ordenadas = frutas.OrderByDescending(f => f);
            //Console.WriteLine("Frutas ordenadas:");
            //foreach (var fruta in ordenadas)
            //{
            //    Console.WriteLine(fruta); // Banana, Laranja, Maçã, Uva
            //}

            //Sum, Average, Min, Max

            //List<int> numeros = new List<int> { 10, 20, 30, 40, 50 };
            //Console.WriteLine("Soma: " + numeros.Sum()); // 150
            //Console.WriteLine("Média: " + numeros.Average()); // 30
            //Console.WriteLine("Mínimo: " + numeros.Min()); // 10
            //Console.WriteLine("Máximo: " + numeros.Max()); // 50

            //Junção

            List<int> numeros = new List<int> { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

            var resultado = numeros
             .Where(n => n > 50)
             .OrderByDescending(n => n)
             .Take(3);
            Console.WriteLine("Top 3 números maiores que 50:");
            foreach (var num in resultado)
            {
                Console.WriteLine(num); // 100, 90, 80
            }
        }
    }
}
