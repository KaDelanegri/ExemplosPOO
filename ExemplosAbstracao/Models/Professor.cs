namespace ExemplosAbstracao.Models
{
    public class Professor : Pessoa //herdando a classe Pessoa para a classe Professor
    {
        public double Salario { get; set; } //definindo o atributo salário ao professor
        public sealed override void Apresentar() //sobrescrevendo o método apresentar de Pessoa agora com o da classe Professor
        //o método sealed travou o método Apresentar nesta classe, não sendo possível herdar nem sobrescrever este método 
        {
            Console.WriteLine ($"Olá, meu nome é {Nome} e tenho {Idade} anos, sou professor e meu salário é {Salario}"); //acrescentando a variável salário na interpolação a ser printada
        }
    
    }
}