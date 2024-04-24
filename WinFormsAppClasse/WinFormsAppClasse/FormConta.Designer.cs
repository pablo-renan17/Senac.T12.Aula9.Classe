namespace WinFormsAppClasse
{
    partial class FormConta
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
            btnNovaConta = new Button();
            groupBox1 = new GroupBox();
            txtValor = new TextBox();
            label1 = new Label();
            txtTitularConta = new TextBox();
            label2 = new Label();
            txtNumeroConta = new TextBox();
            num = new Label();
            listBox1 = new ListBox();
            btnDepositar = new Button();
            btnSacar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnNovaConta
            // 
            btnNovaConta.Location = new Point(12, 208);
            btnNovaConta.Name = "btnNovaConta";
            btnNovaConta.Size = new Size(119, 45);
            btnNovaConta.TabIndex = 0;
            btnNovaConta.Text = "Nova Conta";
            btnNovaConta.UseVisualStyleBackColor = true;
            btnNovaConta.Click += btnNovaConta_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtValor);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtTitularConta);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtNumeroConta);
            groupBox1.Controls.Add(num);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(399, 173);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Conta";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(19, 119);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(100, 23);
            txtValor.TabIndex = 6;
            txtValor.Validated += txtValor_Validated;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 91);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 5;
            label1.Text = "Digite o valor:";
            // 
            // txtTitularConta
            // 
            txtTitularConta.Location = new Point(155, 53);
            txtTitularConta.Name = "txtTitularConta";
            txtTitularConta.Size = new Size(100, 23);
            txtTitularConta.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(155, 35);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 3;
            label2.Text = "Titular da Conta";
            // 
            // txtNumeroConta
            // 
            txtNumeroConta.Location = new Point(19, 53);
            txtNumeroConta.Name = "txtNumeroConta";
            txtNumeroConta.Size = new Size(100, 23);
            txtNumeroConta.TabIndex = 2;
            // 
            // num
            // 
            num.AutoSize = true;
            num.Location = new Point(19, 35);
            num.Name = "num";
            num.Size = new Size(105, 15);
            num.TabIndex = 1;
            num.Text = "Número da Conta:";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 277);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(399, 109);
            listBox1.TabIndex = 2;
            // 
            // btnDepositar
            // 
            btnDepositar.Location = new Point(148, 208);
            btnDepositar.Name = "btnDepositar";
            btnDepositar.Size = new Size(119, 45);
            btnDepositar.TabIndex = 3;
            btnDepositar.Text = "Depositar";
            btnDepositar.UseVisualStyleBackColor = true;
            btnDepositar.Click += btnDepositar_Click;
            // 
            // btnSacar
            // 
            btnSacar.Location = new Point(282, 208);
            btnSacar.Name = "btnSacar";
            btnSacar.Size = new Size(119, 45);
            btnSacar.TabIndex = 4;
            btnSacar.Text = "Sacar";
            btnSacar.UseVisualStyleBackColor = true;
            btnSacar.Click += btnSacar_Click;
            // 
            // FormConta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 393);
            Controls.Add(btnSacar);
            Controls.Add(btnDepositar);
            Controls.Add(listBox1);
            Controls.Add(groupBox1);
            Controls.Add(btnNovaConta);
            Name = "FormConta";
            Text = "Cadastro de Conta";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnNovaConta;
        private GroupBox groupBox1;
        private TextBox txtTitularConta;
        private Label label2;
        private TextBox txtNumeroConta;
        private Label num;
        private ListBox listBox1;
        private Button btnDepositar;
        private Button btnSacar;
        private TextBox txtValor;
        private Label label1;
    }
}
