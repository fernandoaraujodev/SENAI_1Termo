namespace CalculadoraPOO
{
    public class Calculadora 
    {
        //Atributos
        public float n1 { get; set; }//primeiro valor inserido
        public float n2 { get; set; }//segundo valor inserido
        public float resultado { get; set; }//combinação entre operação e valores
        public string operacao { get; set; }//simbolo matematico, + - * /


        //Metodos
        public void Somar(){
            resultado = n1 + n2;
        }

        public void Subtrair(){
                resultado = n1 - n2;
        }

        public void Multiplicar(){
            resultado = n1 * n2;
        }

        public void Dividir(){
            resultado = n1 / n2;
        }


    }
}