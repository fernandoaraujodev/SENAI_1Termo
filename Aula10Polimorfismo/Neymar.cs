using System;
namespace Aula10Polimorfismo
{
    public class Neymar : Jogador
    {
        public override void DriblarAdversários(){
            base.DriblarAdversários();

            Console.WriteLine("Esse jogador dribla todos em sua frente");
        }
public string escolha {get;set;}
        public override void Lesionar(){
            base.Lesionar();

            Console.WriteLine("Esse jogador se lesiona com frequência");
        }

        public string escolher {get;set;}
        public override void Correr(){
            base.Correr();

            Console.WriteLine("Esse jogador corre mais rápido que um guepardo");
            escolher = Console.ReadLine();
            
            Console.WriteLine("Esse jogador corre mais rápido que um guepardo");
            escolha = Console.ReadLine();
        }


        
    }
}