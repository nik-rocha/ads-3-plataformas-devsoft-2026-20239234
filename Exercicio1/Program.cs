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

            //Ex 4

            //Console.WriteLine("Digite o valor numérico de um dia da semana: ");
            //if (int.TryParse(Console.ReadLine(), out int dia))
            //{
            //    switch (dia)
            //    {
            //        case 1:
            //            Console.WriteLine("Domingo");
            //            break;
            //        case 2:
            //            Console.WriteLine("Segunda");
            //            break;
            //        case 3:
            //            Console.WriteLine("Terça");
            //            break;
            //        case 4:
            //            Console.WriteLine("Quarta");
            //            break;
            //        case 5:
            //            Console.WriteLine("Quinta");
            //            break;
            //        case 6:
            //            Console.WriteLine("Sexta");
            //            break;
            //        case 7:
            //            Console.WriteLine("Sábado");
            //            break;
            //        default:
            //            Console.WriteLine("Esse dia não existe!");
            //            break;
            //    }
            //} 
            //else
            //{ 
            //    Console.WriteLine("Você não digitou um número.");
            //}

            //Ex 5

            //Console.WriteLine("Digite uma letra e verifique se ela é vogal ou consoante: ");
            //if (char.TryParse(Console.ReadLine(), out char letra))
            //{
            //    switch (letra)
            //    {
            //        case 'A':
            //        case 'a':
            //            Console.WriteLine("Vogal");
            //            break;
            //        case 'E':
            //        case 'e':
            //            Console.WriteLine("Vogal");
            //            break;
            //        case 'I':
            //        case 'i':
            //            Console.WriteLine("Vogal");
            //            break;
            //        case 'O':
            //        case 'o':
            //            Console.WriteLine("Vogal");
            //            break;
            //        case 'U':
            //        case 'u':
            //            Console.WriteLine("Vogal");
            //            break;
            //        default:
            //            Console.WriteLine("Consoante");
            //            break;
            //    }
            //} 
            //else
            //{
            //    Console.WriteLine("Você não digitou uma letra");
            //}

            // Ex 6

            //int x = 0;
            //int valor = 0;

            //while (x < 5)
            //{
            //    Console.WriteLine("Digite 5 números para a soma: ");
            //    if (int.TryParse(Console.ReadLine(), out int y))
            //    {
            //        Console.WriteLine($"Valor digitado: {y}");
            //        valor += y;
            //        x++;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Você não digitou um número!");
            //        break;
            //    }
            //}
            //Console.WriteLine(valor);

            // Ex 7

            //int mult = 1;

            //Console.WriteLine("Digite um número para iniciar sua tabuada:");
            //if (int.TryParse(Console.ReadLine(), out int valor))
            //{
            //    while (mult < 11)
            //    {
            //        Console.WriteLine($"{valor} X {mult} = {valor * mult}");
            //        mult++;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Você não digitou um número!");
            //}

            // Ex 8

            //int cont = 0;

            //Console.WriteLine("Digite um número inicial para ver os pares: ");
            //if (int.TryParse(Console.ReadLine(), out int inicio))
            //{
            //    Console.WriteLine("Digite um número final para ver os pares: ");
            //    if (int.TryParse(Console.ReadLine(), out int fim))
            //    {
            //        while (cont <= fim)
            //        {
            //            if (cont % 2 == 0)
            //            {
            //                Console.WriteLine($"{cont}");
            //            }
            //            cont++;
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Valor inválido.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Valor inválido.");
            //}

            // Ex 9

            //int cont = 0;
            //Random random = new Random();

            //Console.WriteLine("Um número aleatório será gerado! Você tem 5 tentantivas para adivinhar. \n\n");
            //int aleatorio = random.Next(101);

            //while (cont < 5)
            //{
            //    Console.WriteLine("Digite: \n");
            //    if (int.TryParse(Console.ReadLine(), out int valor))
            //    {
            //        if (valor == aleatorio)
            //        {
            //            Console.WriteLine($"Você acertou! O valor era {aleatorio}.");
            //            break;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Valor incorreto, tente novamente! \n\n");
            //            cont++;
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Você não digitou um número!");
            //    }
            //}
            
            //if (cont == 5)
            //{
            //    Console.WriteLine("Infelizmente você errou todos. Tente novamente amanhã!");
            //}

            // Ex 10


        }
    }
}
