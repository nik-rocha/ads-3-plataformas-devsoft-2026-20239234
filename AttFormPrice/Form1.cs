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
            int qtd = int.Parse(textBoxPrestacoes.Text);
            double vValor = double.Parse(textBoxValor.Text);
            double vJuros = double.Parse(textBoxJuros.Text) / 100;
            double prestacao = 0;
            double jurosFormatado = 0;
            double amortizacao = 0;
            double valor = vValor;
            prestacao = valor * ((Math.Pow((1 + vJuros), qtd) * vJuros) / (Math.Pow((1 + vJuros), qtd) - 1));
            List<Parcela> parcelas = new List<Parcela>();

            for (int i = 1; i <= qtd; i++)
            {
                jurosFormatado = valor * vJuros;
                amortizacao = prestacao - jurosFormatado;
                valor = valor - amortizacao;
                Parcela parcela = new Parcela() { nParcela = i, juros = jurosFormatado, amortizacao = amortizacao, sDevedor = valor };
                parcelas.Add(parcela);
            }

            dataGridView1.DataSource = parcelas;
            dataGridView1.Columns["juros"].DefaultCellStyle.Format = "C2";
            dataGridView1.Columns["amortizacao"].DefaultCellStyle.Format = "C2";
            dataGridView1.Columns["sDevedor"].DefaultCellStyle.Format = "C2";
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
