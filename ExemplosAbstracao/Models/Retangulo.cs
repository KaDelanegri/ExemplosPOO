namespace ExemplosAbstracao.Models
{
    public class Retangulo
    {
        private double comprimento; //definindo as propriedades privadas, não alterada externamente, apenas pelo método DefinirMedidas que há uma validação, 
        //garantindo a integridade do código, ou seja,externamente não é necessário conhecer a aplicação dos valores, mas apenas passá-los e obter o resultado de cálculo
        private double largura;
        private bool valido;

        public void DefinirMedidas(double comprimento, double largura) //método para expor o valor publicamente e receber os dois parâmetros definidos acima
        {
            if (comprimento > 0 && largura > 0)
            {
                this.comprimento = comprimento; //definindo os valores recebidos para o private acima
                this.largura = largura;
                valido = true; //validação dos dados de entrada como verdadeiro
            }
            else
            {
                System.Console.WriteLine("Valores Inválidos");
            }
        }
        public double ObterArea()
        {
            if (valido) //se valores inseridos são válidos (verdadeiros) então o retorno será o cálculo
            {      
                return comprimento * largura;
            }
            else
            {
                System.Console.WriteLine("Preencha um valor válido"); //se os valores forem inválidos irá retornar a solicitação
                return 0;
            }
        }
    }
}