namespace AttFormLista
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
            txtTarefa = new TextBox();
            label1 = new Label();
            btnAdicionar = new Button();
            lstTarefas = new ListBox();
            btnRemover = new Button();
            lblQuantia = new Label();
            SuspendLayout();
            // 
            // txtTarefa
            // 
            txtTarefa.Anchor = AnchorStyles.None;
            txtTarefa.CharacterCasing = CharacterCasing.Lower;
            txtTarefa.Font = new Font("Montserrat", 8.999999F);
            txtTarefa.Location = new Point(175, 100);
            txtTarefa.Multiline = true;
            txtTarefa.Name = "txtTarefa";
            txtTarefa.PlaceholderText = "Digite um item da lista...";
            txtTarefa.Size = new Size(492, 32);
            txtTarefa.TabIndex = 0;
            txtTarefa.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(359, 45);
            label1.Name = "label1";
            label1.Size = new Size(129, 38);
            label1.TabIndex = 1;
            label1.Text = "Sua Lista";
            label1.Click += label1_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Font = new Font("Montserrat", 8.999999F);
            btnAdicionar.Location = new Point(175, 148);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(210, 32);
            btnAdicionar.TabIndex = 2;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += button1_Click;
            // 
            // lstTarefas
            // 
            lstTarefas.Font = new Font("Montserrat", 8.999999F);
            lstTarefas.FormattingEnabled = true;
            lstTarefas.Location = new Point(175, 203);
            lstTarefas.Name = "lstTarefas";
            lstTarefas.Size = new Size(492, 220);
            lstTarefas.TabIndex = 3;
            lstTarefas.SelectedIndexChanged += lstTarefas_SelectedIndexChanged;
            // 
            // btnRemover
            // 
            btnRemover.Font = new Font("Montserrat", 8.999999F);
            btnRemover.Location = new Point(457, 148);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(210, 32);
            btnRemover.TabIndex = 4;
            btnRemover.Text = "Remover Selecionado";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += button1_Click_1;
            // 
            // lblQuantia
            // 
            lblQuantia.AutoSize = true;
            lblQuantia.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQuantia.Location = new Point(175, 435);
            lblQuantia.Name = "lblQuantia";
            lblQuantia.Size = new Size(0, 25);
            lblQuantia.TabIndex = 5;
            lblQuantia.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 512);
            Controls.Add(lblQuantia);
            Controls.Add(btnRemover);
            Controls.Add(lstTarefas);
            Controls.Add(btnAdicionar);
            Controls.Add(label1);
            Controls.Add(txtTarefa);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTarefa;
        private Label label1;
        private Button btnAdicionar;
        private ListBox lstTarefas;
        private Button btnRemover;
        private Label lblQuantia;
    }
}
