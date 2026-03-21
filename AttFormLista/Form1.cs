namespace AttFormLista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTarefa.Text))
            {
                lstTarefas.Items.Add(txtTarefa.Text);
                txtTarefa.Clear();
                AtualizarLabelQuantia();
            }
            else
            {
                MessageBox.Show("Você digitou um valor vazio. Tente novamente.");
            }
        }

        private void lstTarefas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (lstTarefas.SelectedIndex != -1)
            {
                lstTarefas.Items.RemoveAt(lstTarefas.SelectedIndex);
                txtTarefa.Clear();
            }
            else
            {
                MessageBox.Show("Você digitou um valor vazio. Tente novamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void AtualizarLabelQuantia()
        {
            lblQuantia.Text = $"Quantidade de Tarefas: {lstTarefas.Items.Count}";
        }
    }
}
