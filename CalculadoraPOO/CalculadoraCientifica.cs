namespace CalculadoraPOO
{
    public class CalculadoraCientifica : Calculadora
    {
        public string[] valores {get;set;}//Array sem limite definido
        public float adicaoMedia { get; set; }//soma do valores 
        public float numeros { get; set; }

        //Metodos
        /// <summary>
        /// somar valores e tirar a media ao final
        /// </summary>
        /// <param name="txt"></param>
        public void CalcularMedia( string txt )
        {
            valores = txt.Split(",");//Split usado para separar caracteres quando identificar a ,

            for (int i = 0; i < valores.Length; i++)//For usado para varrer a split de acordo com o seu tamanho // valores.Length = quantidade de valores adicionados
            {
                numeros = float.Parse(valores[i]);
                adicaoMedia = adicaoMedia + numeros;
            }

            resultado = adicaoMedia / valores.Length; //variavel resultante dos valores somados dividido pela quantidade de valores inseridos

        }

        /// <summary>
        /// Controlar caracteres inseridos pelo usuario atraves da Split
        /// </summary>
        /// <param name="entradaUsuario">Usuario escreverá conta desejada separada por espaço: 27 + 54</param>
        public void ManipularCalculos( string entradaUsuario )//metodo usufrui do parametro para controlar dados
        {
            string[] entrada = entradaUsuario.Split(" ");//string sem definição de quantidade retonando na variavel entrada
            resultado = 0;

            n1 = float.Parse(entrada[0]); //valor n1 é entrada 0 da Split
            operacao = (entrada[1]); //operacao é entrada 1 da Split
            n2 = float.Parse(entrada[2]); //valor n2 é a entrada 2 da Split

            //laço para identificar simbolo inserido
            switch (operacao)
            {
                case "+":
                Somar();
                break;

                case "-":
                Subtrair();
                break;

                case "x":
                Multiplicar();
                break;

                case "/":
                Dividir();
                break;
            }
                
        }
    


    
    }
}