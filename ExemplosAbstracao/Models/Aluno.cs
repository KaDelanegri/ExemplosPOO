namespace ExemplosAbstracao.Models
{
    public class Aluno : Pessoa //herdando para a classe Aluno a classe Pessoa
    {
        public int Nota { get; set; } //definindo o atributo nota
    public override void Apresentar () //método Apresentar sobrescrito override do Pessoa que foi adicionando o virtual para poder sobrescrever no programa Polimorfismo, se tornando um método da classe aluno agora
    {
        Console.WriteLine ($"Olá, meu nome é {Nome} e tenho {Idade} anos, sou estudante e minha nota média é: {Nota}");
    }
    
    }
}