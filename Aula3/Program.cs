namespace Aula3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número para dividir 100:");

            try
            {
                int numero = int.Parse(Console.ReadLine());
                if (numero < 0)
                {
                    throw new ArgumentException($"Não aceito número negativo.");
                }
                float resultado = 100 / numero;
                Console.WriteLine($"{resultado}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Entrada inválida.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("O número deve ser diferente de zero.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Algo deu errado! {ex.GetType()}");
            }
            finally
            {
                Console.WriteLine("O finally é sempre executado.");
            }
        }
    }
}
