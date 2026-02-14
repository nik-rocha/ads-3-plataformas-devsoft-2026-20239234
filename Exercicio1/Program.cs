namespace Exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ex 1

            //Console.WriteLine("Digite um número: ");
            //if (int.TryParse(Console.ReadLine(), out int valor))
            //{
            //    if (valor == 0)
            //    {
            //        Console.WriteLine($"{valor} é igual a 0.");
            //    }
            //    else if (valor > 0)
            //    {
            //        Console.WriteLine($"{valor} é positivo.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{valor} é negativo.");
            //    }
            //}

            //Ex 2

            //Console.WriteLine("Digite uma idade: ");
            //string input = Console.ReadLine();
            //int idade = int.Parse(input);

            //switch(idade)
            //{
            //    case int i when i > 0 && i <= 12:
            //        Console.WriteLine("Você é uma criança");
            //        break;
            //    case int i when i > 12 && i <= 17:
            //        Console.WriteLine("Você é um adolescente");
            //        break;
            //    case int i when i > 17 && i <= 59:
            //        Console.WriteLine("Você é um adulto :(");
            //        break;
            //    case int i when i > 59:
            //        Console.WriteLine("Você é um idoso");
            //        break;
            //    default:
            //        Console.WriteLine("Idade inválida.");
            //        break;
            //}

            //Ex 3

            //Console.WriteLine("Digite um número: ");
            //if (double.TryParse(Console.ReadLine(), out double x1))
            //    {
            //        Console.WriteLine("Digite outro número: ");
            //        if (double.TryParse(Console.ReadLine(), out double x2))
            //        {
            //            Console.WriteLine("Agora digite qual operação você quer realizar (+, -, *, /):");
            //            string ?operacao = Console.ReadLine();
            //            switch(operacao)
            //            {
            //                case "+":
            //                    Console.WriteLine($"O valor de sua operação é: {x1 + x2}");
            //                    break;
            //                case "-":
            //                    Console.WriteLine($"O valor de sua operação é: {x1 - x2}");
            //                    break;
            //                case "*":
            //                    Console.WriteLine($"O valor de sua operação é: {x1 * x2}");
            //                    break;
            //                case "/":
            //                    Console.WriteLine($"O valor de sua operação é: {x1 / x2}");
            //                    break;
            //                default:
            //                    Console.WriteLine("Operação inexistente!");
            //                    break;
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("Valor inválido, tente novamente");
            //        }
            //    }
            //else
            //{
            //    Console.WriteLine("Valor inválido, tente novamente");
            //}

            //Ex 5

            Console.WriteLine("Digite o valor numérico de um dia da semana: ");
            if (int.TryParse(Console.ReadLine(), out int dia))
            {
                switch(dia)
                {
                    case 1:
                        Console.WriteLine("Domingo");
                        break;
                    case 2:
                        Console.WriteLine("Segunda");
                        break;
                    case 3:
                        Console.WriteLine("Terça");
                        break;
                    case 4:
                        Console.WriteLine("Quarta");
                        break;
                    case 5:
                        Console.WriteLine("Quinta");
                        break;
                    case 6:
                        Console.WriteLine("Sexta");
                        break;
                    case 7:
                        Console.WriteLine("Sábado");
                        break;
                    default:
                        Console.WriteLine("Esse dia não existe!");
                        break;
                }
            }
        }
    }
}
