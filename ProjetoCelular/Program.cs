using System;

namespace ProjetoCelular
{
    class Program
    {
        static void Main(string[] args)
        {
            Celular nokia = new Celular();
            nokia.cor = "concreto";
            nokia.modelo = "Nokia";
            nokia.tamanhoTela = 2.6f;
            nokia.ligado = true;

            Console.WriteLine("O celular está ligado?");
            nokia.ligado = Boolean.Parse(Console.ReadLine());

            if(nokia.ligado){
                Console.WriteLine (nokia.Desligar()) ;
                Console.WriteLine (nokia.FazerLigacao()) ;
                Console.WriteLine (nokia.EnviarMensagem()) ;
                
            }else{
                Console.WriteLine (nokia.Ligar());
            }


        }
    }
}
