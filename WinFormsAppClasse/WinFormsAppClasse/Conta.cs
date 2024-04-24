
//nome do espaço(organiza o projeto)
namespace WinFormsAppClasse
{
    //isso aqui embaixo é uma classe(visibilidade(public), tipo(class), nome(Conta))


    public class Conta
    {
        //propriedades(visibilidade, tipo, nome)
        public int numeroConta { get; set; }
        public string nome { get; set; }
        public decimal saldo { get; set; }

        //metodo vazio
        //imagina que voce é um programador, e
        //parametro: decimal valor
        //se nao tivesse public, so podia usar aq dentro
        public void Sacar(decimal valor)
        {
            saldo -= valor;
        }

        public void Depositar(decimal valor)
        {
            saldo += valor;
        }
    }
}
