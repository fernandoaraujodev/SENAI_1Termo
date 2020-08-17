using System;

namespace CalculadoraPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculadoraCientifica obj = new CalculadoraCientifica(); //instanciando classe
            Console.WriteLine("Insira sua conta abaixo \n+ para soma, - para subtração, x para multiplicação e / para divisão \nUtilize numeros inteiros");//Orientando o usuario para inserir informação válida
            string conta = Console.ReadLine(); //informação armazenada na variavel conta
            obj.ManipularCalculos(conta); 
            Console.WriteLine("Resultado é = "+ obj.resultado); //Exibição de resultado

            System.Console.WriteLine("\nDigite números separados por vírgula para calculo de média:"); //Orientando usuario para inserir formato válido
            obj.CalcularMedia( Console.ReadLine() ); //realizar o metodo 
            System.Console.WriteLine("Média: "+obj.resultado); //Exibição de resultado

        }
    }
}
