namespace POO1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> funcionarios = new List<Funcionario>();

            funcionarios.Add(new FuncionarioCLT("Joao", 3000));
            funcionarios.Add(new FuncionarioCLT("Maria", 5500));

            foreach (var funcionario in funcionarios)
            {
                Console.WriteLine("------ Sem Salário ------");
                funcionario.ExibirDados();
                Console.WriteLine("------ Com Salário ------");
                funcionario.ExibirDados(true);
            }
        }
    }
}
