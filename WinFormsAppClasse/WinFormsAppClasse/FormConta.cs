namespace WinFormsAppClasse
{
    //: = filho
    public partial class FormConta : Form
    {
        //criado um objeto chamdo conta do tipo conta
        Conta conta = new Conta();

        public FormConta()
        {
            InitializeComponent();
            //ativar o botao sacar
            btnSacar.Enabled = false;
        }

        private void btnNovaConta_Click(object sender, EventArgs e)
        {
            conta = new Conta();
            //se usa o . para acessar propriedades da classe
            //determinei atributos do objeto conta
            conta.numeroConta = int.Parse(txtNumeroConta.Text);
            conta.nome = txtTitularConta.Text;
            conta.Depositar(100);

            string dadosConta = "Numero: " + conta.numeroConta +
                                " Titular: " + conta.nome +
                                " Saldo: " + conta.saldo;

            listBox1.Items.Add(dadosConta);

        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            //se a string txtValor esta nula ou vazia
            if (string.IsNullOrEmpty(txtValor.Text))
            {
                txtValor.Focus();
                MessageBox.Show("Preencha o valor de depósito.");
                //encerra o metodo de clique
                return;
            }

            decimal valorADepositar = decimal.Parse(txtValor.Text);
            //chama o metodo depositar da classe conta
            conta.Depositar(valorADepositar);

            //carregar o listbox com os dados da conta
            string dadosConta = "Numero: " + conta.numeroConta +
                                " Titular: " + conta.nome +
                                " Saldo: " + conta.saldo;

            listBox1.Items.Add(dadosConta);
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            decimal valorASacar = decimal.Parse(txtValor.Text);

            conta.Sacar(valorASacar);

            //carregar o listbox com os dados da conta
            string dadosConta = "Numero: " + conta.numeroConta +
                                " Titular: " + conta.nome +
                                " Saldo: " + conta.saldo;

            listBox1.Items.Add(dadosConta);
        }

        private void txtValor_Validated(object sender, EventArgs e)
        {
            // habilito o botao sacar
            if (!string.IsNullOrEmpty(txtValor.Text))
            {
                btnSacar.Enabled = true;
            }
            else
            {
                btnSacar.Enabled = false;
            }
            
        }
    }
}
