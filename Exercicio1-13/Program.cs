namespace Exercicio1_13
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite sua senha para verificar a força: ");
            
            string ?senha = Console.ReadLine();

            static bool SenhaForte(string s)
            {
                bool pass1 = false;
                bool pass2 = false;
                bool pass3 = false;
                bool pass4 = false;
                bool pass5 = false;
                bool pass6 = false;

                if (s == null || s == "")
                {
                    pass1 = false;
                }
                else
                {
                    pass1 = true;
                }

                if (!pass1)
                {
                    Console.WriteLine($"A senha {s} está vazia.");
                    return false;
                }

                if (s.Length < 8)
                {
                    pass2 = false;
                }
                else
                {
                    pass2 = true;
                }

                if (!pass2)
                {
                    Console.WriteLine($"A senha {s} deve conter pelo menos 8 dígitos.");
                    return false;
                }

                if (pass1 && pass2)
                {
                    foreach (char c in s)
                    {
                        if (Char.IsUpper(c))
                        {
                            pass3 = true;
                            break;
                        }
                        else
                        {
                            pass3 = false;
       
                        }
                    }
                }
                else
                {
                    pass3 = false;
                }

                if (!pass3)
                {
                    Console.WriteLine($"A senha {s} deve conter pelo menos 1 caractere maiúsculo.");
                    return false;
                }

                if (pass1 && pass2 && pass3)
                {
                    foreach (char c in s)
                    {
                        if (Char.IsLower(c))
                        {
                            pass4 = true;
                            break;
                        }
                        else
                        {
                            pass4 = false;
       
                        }
                    }
                }
                else
                {
                    pass4 = false;
                }

                if (!pass4)
                {
                    Console.WriteLine($"A senha {s} deve conter pelo menos 1 caractere minúsculo.");
                    return false;
                }

                if (pass1 && pass2 && pass3 && pass4)
                {
                    foreach (char c in s)
                    {
                        if (Char.IsDigit(c))
                        {
                            pass5 = true;
                            break;
                        }
                        else
                        {
                            pass5 = false;
       
                        }
                    }
                }
                else
                {
                    pass5 = false;
                }

                if (!pass5)
                {
                    Console.WriteLine($"A senha {s} deve conter pelo menos 1 número.");
                    return false;
                }

                if (pass1 && pass2 && pass3 && pass4 && pass5)
                {
                    foreach (char c in s)
                    {
                        if (!Char.IsLetterOrDigit(c))
                        {
                            pass6 = true;
                            break;
                        }
                        else
                        {
                            pass6 = false;
       
                        }
                    }
                }
                else
                {
                    pass6 = false;
                }

                if (!pass6)
                {
                    Console.WriteLine($"A senha {s} deve conter pelo menos 1 caractere especial.");
                    return false;
                }

                if (pass1 && pass2 && pass3 && pass4 && pass5 && pass6)
                {
                    Console.WriteLine($"A senha {s} é bem forte!");
                    return true;
                }
                else
                {
                    return false;
                }
            }

            SenhaForte(senha);
        }
    }
}
