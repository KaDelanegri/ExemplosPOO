namespace ExemplosAbstracao.Models
{
    public abstract class Conta //definindo a classe como abstrata
    {
        protected double saldo;
        public abstract void Creditar(double valor); //método abstrato, não tem implementação, apenas o nome

        public void ExibirSaldo() //método não abstrato
        {
            System.Console.WriteLine("Seu saldo é: " + saldo);
        }
    }
}