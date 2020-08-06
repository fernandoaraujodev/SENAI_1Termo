using System;

namespace Aula08Abstracao
{
    class Program
    {
        static void Main(string[] args)
        {
            CartaoCredito elo = new CartaoCredito();
            elo.limite = 1500f; 

            System.Console.WriteLine("Quanto você deseja de acrescimo para limite no cartão?");
            float acrescimo = float.Parse(Console.ReadLine ());

            elo.AumentarLimite (acrescimo);
            System.Console.WriteLine("novo limite: R$ "+elo.limite);
            
            CartaoDebito card = new CartaoDebito();
            card.titular = "Fernando Araujo";
            card.numero = "001000100-1";
            card.bandeira = "MasterCard";
            card.cvv = "123";
            card.saldo = 450f;

            System.Console.WriteLine(card.titular+" você deseja consultar o seu saldo atual?");
            bool consulta = Boolean.Parse (Console.ReadLine());

            if(consulta == true){
                Console.WriteLine ("Seu saldo atual é de R$ "+card.saldo);
            }else{
                Console.WriteLine("procura outra ação");
            }



        
        
        
        
        
        }
    }
}
