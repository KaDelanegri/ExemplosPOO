namespace ExemplosAbstracao.Models
{
    public class Calculadora
    {
        public int Somar (int num1, int num2) //primeira função definida
        {
            return num1 + num2;
        }

        public int Somar (int num1, int num2, int num3) //segunda função definida com mais uma variável
        {
            return num1 + num2 + num3;
        }
    }
}