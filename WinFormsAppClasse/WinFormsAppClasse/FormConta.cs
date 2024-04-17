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
        }

        private void btnNovaConta_Click(object sender, EventArgs e)
        {
            conta = new Conta();
            //se usa o . para acessar propriedades da classe
            //determinei atributos do objeto conta
            conta.numeroConta = int.Parse(txtNumeroConta.Text);
            conta.nome = txtTitularConta.Text;
            conta.Depositar(100);

            

            conta.Depositar(100);

            string dadosConta = "Numero: " + conta.numeroConta +
                                " Titular: " + conta.nome +
                                " Saldo: " + conta.saldo;

            listBox1.Items.Add(dadosConta);

        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {

            conta.Depositar(100);

            //carregar o listbox com os dados da conta
            string dadosConta = "Numero: " + conta.numeroConta +
                                " Titular: " + conta.nome +
                                " Saldo: " + conta.saldo;

            listBox1.Items.Add(dadosConta);
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            conta.Sacar(100);

            //carregar o listbox com os dados da conta
            string dadosConta = "Numero: " + conta.numeroConta +
                                " Titular: " + conta.nome +
                                " Saldo: " + conta.saldo;

            listBox1.Items.Add(dadosConta);
        }
    }
}
