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
            int qtd = int.Parse(textBoxValor.Text);
            double juros = double.Parse(textBoxJuros.Text);

            for (int i = 0; i < qtd; i++)
            {
                Parcela parcela = new Parcela() { nParcela = i, juros = };
            }
        }

        private void textBoxValor_TextChanged(object sender, EventArgs e)
        {

        }

        public class Parcela
        {
            public int nParcela { get; set; }
            public double juros { get; set; }
            public double amortizacao { get; set; }
            public int sDevedor { get; set; }
        }
    }
}
