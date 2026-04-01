namespace AttFormPrice
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBoxValor = new TextBox();
            textBoxPrestacoes = new TextBox();
            textBoxJuros = new TextBox();
            btnCalcular = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(307, 30);
            label1.Name = "label1";
            label1.Size = new Size(328, 30);
            label1.TabIndex = 0;
            label1.Text = "Simulação de Empréstimo - Price";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            label2.Location = new Point(31, 109);
            label2.Name = "label2";
            label2.Size = new Size(55, 25);
            label2.TabIndex = 1;
            label2.Text = "Valor";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            label3.Location = new Point(254, 109);
            label3.Name = "label3";
            label3.Size = new Size(152, 25);
            label3.TabIndex = 2;
            label3.Text = "Qtde. Prestações";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            label4.Location = new Point(497, 109);
            label4.Name = "label4";
            label4.Size = new Size(152, 25);
            label4.TabIndex = 3;
            label4.Text = "Juros (% ao mês)";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            label5.Location = new Point(691, 109);
            label5.Name = "label5";
            label5.Size = new Size(0, 25);
            label5.TabIndex = 4;
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxValor
            // 
            textBoxValor.Font = new Font("Segoe UI", 12F);
            textBoxValor.Location = new Point(31, 137);
            textBoxValor.Multiline = true;
            textBoxValor.Name = "textBoxValor";
            textBoxValor.Size = new Size(151, 27);
            textBoxValor.TabIndex = 5;
            textBoxValor.TextChanged += textBoxValor_TextChanged;
            // 
            // textBoxPrestacoes
            // 
            textBoxPrestacoes.Font = new Font("Segoe UI", 12F);
            textBoxPrestacoes.Location = new Point(254, 137);
            textBoxPrestacoes.Multiline = true;
            textBoxPrestacoes.Name = "textBoxPrestacoes";
            textBoxPrestacoes.Size = new Size(151, 27);
            textBoxPrestacoes.TabIndex = 6;
            textBoxPrestacoes.TextChanged += textBox2_TextChanged;
            // 
            // textBoxJuros
            // 
            textBoxJuros.Font = new Font("Segoe UI", 12F);
            textBoxJuros.Location = new Point(498, 137);
            textBoxJuros.Multiline = true;
            textBoxJuros.Name = "textBoxJuros";
            textBoxJuros.Size = new Size(151, 27);
            textBoxJuros.TabIndex = 7;
            // 
            // btnCalcular
            // 
            btnCalcular.Anchor = AnchorStyles.None;
            btnCalcular.BackgroundImageLayout = ImageLayout.Stretch;
            btnCalcular.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcular.Location = new Point(722, 137);
            btnCalcular.Margin = new Padding(0);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(141, 27);
            btnCalcular.TabIndex = 8;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = Color.Black;
            dataGridView1.Location = new Point(31, 187);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RightToLeft = RightToLeft.No;
            dataGridView1.Size = new Size(832, 440);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(908, 640);
            Controls.Add(dataGridView1);
            Controls.Add(btnCalcular);
            Controls.Add(textBoxJuros);
            Controls.Add(textBoxPrestacoes);
            Controls.Add(textBoxValor);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBoxValor;
        private TextBox textBoxPrestacoes;
        private TextBox textBoxJuros;
        private Button btnCalcular;
        private DataGridView dataGridView1;
    }
}
