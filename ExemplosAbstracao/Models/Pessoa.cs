using System; //import para poder usar a 
namespace ExemplosAbstracao.Models
{
    public class Pessoa
    {
        public string Nome { get; set;} //definindo propriedades da classe Pessoa
        public int Idade { get; set; }

        public virtual void Apresentar() //método (é a ação que irá executar) Apresentar que fará uso das propriedades Nome e Idade //adicionando o virtual para poder sobrescrever na Polimorfismo
        {
            Console.WriteLine ($"Olá, meu nome é {Nome} e tenho {Idade} anos"); //o dolar interpola o texto com o valor da variável entre chaves
        }
    }
}