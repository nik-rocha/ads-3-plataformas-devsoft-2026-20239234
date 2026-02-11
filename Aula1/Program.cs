using System.Globalization;

namespace Aula1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = new CultureInfo("en-US");
            Console.WriteLine("Enre com o estoque minimo: ");

            if (float.TryParse(Console.ReadLine(), out float qntdMin))
            {
                Console.WriteLine("Enre com o estoque maximo: ");
                if (float.TryParse(Console.ReadLine(), out float qntdMax))
                {
                    double estoquemedio = (qntdMin + qntdMax) / 2;
                    Console.WriteLine($"O estoque medio é: {estoquemedio}");
                }
                else
                {
                    Console.WriteLine("Valor inválido para estoque máximo.");
                }
            }
            else
            {
                Console.WriteLine("Valor inválido para estoque mínimo.");
            }
        }
    }
}
