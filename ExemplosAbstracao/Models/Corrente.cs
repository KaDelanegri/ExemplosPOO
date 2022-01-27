namespace ExemplosAbstracao.Models
{
    public class Corrente : Conta //herdando a classe Conta
    {
        public override void Creditar(double valor) //sobrescrevendo o método abstrato
        {
            base.saldo = valor; //o base substitui o this para deixar claro que o o atributo saldo é da classe herdada, da classe conta
        }
    }
}