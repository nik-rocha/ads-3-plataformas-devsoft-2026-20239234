namespace Atividades2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1

            //List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var pares = numeros
            //    .Where(n => n % 2 == 0)
            //    .OrderByDescending(n => n)
            //    .Take(3);

            //foreach (var num in pares)
            //{
            //    Console.WriteLine(num);
            //}

            // 2

            //List<double> salarios = new List<double> { 800.0, 1500.0, 2000.0, 2500.0 };

            //Console.WriteLine("Soma: " + salarios.Sum());
            //Console.WriteLine("Média: " + salarios.Average());
            //Console.WriteLine("Maior: " + salarios.Max());
            //Console.WriteLine("Menor: " + salarios.Min());

            // 3

            List<string> frutas = new List<string> {"Abóbora", "Maçã", "Banana", "Manga"};

            var fruteiro = frutas
                .Select(f => new { Nome = f, Valor = f.Length })
                .Where(f => f.Valor > 5);

            foreach (var fruta in fruteiro)
            {
                Console.WriteLine(fruta);
            }
        }
    }
}
