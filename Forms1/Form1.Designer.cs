namespace Forms1
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
            button1 = new Button();
            textUsuario = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textSenha = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Location = new Point(43, 382);
            button1.Name = "button1";
            button1.Size = new Size(148, 33);
            button1.TabIndex = 0;
            button1.Text = "Logar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textUsuario
            // 
            textUsuario.Anchor = AnchorStyles.None;
            textUsuario.BackColor = Color.White;
            textUsuario.BorderStyle = BorderStyle.FixedSingle;
            textUsuario.Location = new Point(43, 158);
            textUsuario.Multiline = true;
            textUsuario.Name = "textUsuario";
            textUsuario.Size = new Size(492, 34);
            textUsuario.TabIndex = 1;
            textUsuario.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(43, 134);
            label1.Name = "label1";
            label1.Size = new Size(64, 21);
            label1.TabIndex = 2;
            label1.Text = "Usuário";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(43, 241);
            label2.Name = "label2";
            label2.Size = new Size(53, 21);
            label2.TabIndex = 4;
            label2.Text = "Senha";
            label2.Click += label2_Click;
            // 
            // textSenha
            // 
            textSenha.Anchor = AnchorStyles.None;
            textSenha.BackColor = Color.White;
            textSenha.BorderStyle = BorderStyle.FixedSingle;
            textSenha.Location = new Point(43, 265);
            textSenha.Multiline = true;
            textSenha.Name = "textSenha";
            textSenha.PasswordChar = '#';
            textSenha.Size = new Size(492, 34);
            textSenha.TabIndex = 3;
            textSenha.UseSystemPasswordChar = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.Location = new Point(387, 382);
            button2.Name = "button2";
            button2.Size = new Size(148, 33);
            button2.TabIndex = 5;
            button2.Text = "Fechar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(575, 521);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(textSenha);
            Controls.Add(label1);
            Controls.Add(textUsuario);
            Controls.Add(button1);
            Name = "Form1";
            Text = "formLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textUsuario;
        private Label label1;
        private Label label2;
        private TextBox textSenha;
        private Button button2;
    }
}
