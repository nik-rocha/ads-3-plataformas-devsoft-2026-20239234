namespace AttFormPrice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int prestacoes = int.Parse(textBoxPrestacoes.Text);
            double vValor = double.Parse(textBoxValor.Text);
            double vJuros = double.Parse(textBoxJuros.Text) / 100;
            List<Parcela> parcelas = new List<Parcela>();

            for (int i = 1; i <= prestacoes; i++)
            {
                double valor = vValor;
                double juros = valor * vJuros;
                double valorP = valor * ((Math.Pow((1 + juros), i) * juros) / (Math.Pow((1 + juros), i) - 1));
                valor = valor - (valorP - juros);

                Parcela parcela = new Parcela() { nParcela = i, juros = juros, amortizacao = valorP - juros, sDevedor = valor };
                parcelas.Add(parcela);
            }

            dataGridView1.DataSource = parcelas;
        }

        private void textBoxValor_TextChanged(object sender, EventArgs e)
        {

        }

        public class Parcela
        {
            public int nParcela { get; set; }
            public double juros { get; set; }
            public double amortizacao { get; set; }
            public double sDevedor { get; set; }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
