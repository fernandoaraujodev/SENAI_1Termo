using System;
namespace Aula10Polimorfismo
{
    public class CristianoRonaldo : Jogador
    {
        public override void FazerGols(){
            base.FazerGols();

            Console.WriteLine("Esse jogador é o maior artilheiro de seu clube");
        }

        public override void Correr(){
            base.Correr();

            Console.WriteLine("Esse jogador corre mais rápido que um guepardo");
        }

    }
}