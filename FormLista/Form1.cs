namespace AttFormValores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tarefa t1 = new Tarefa() { Id = 1, Nome = "Fazer compras" };
            Tarefa t2 = new Tarefa() { Id = 2, Nome = "Limpar a casa" };
            Tarefa t3 = new Tarefa() { Id = 3, Nome = "Molhar as plantas" };
            Tarefa t4 = new Tarefa() { Id = 4, Nome = "Dar banho no Pet" };

            List<Tarefa> tarefas = new List<Tarefa>();
            tarefas.Add(t1);
            tarefas.Add(t2);
            tarefas.Add(t3);
            tarefas.Add(t4);

            dataGridView1.DataSource = tarefas;
        }

        public class Tarefa
        {
            public int Id { get; set; }
            public string? Nome { get; set; }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
