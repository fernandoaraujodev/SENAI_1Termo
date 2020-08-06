using System;
namespace Aula10Polimorfismo
{
    public class Jogador
    {
        public virtual void DriblarAdversários(){
            Console.WriteLine("Esse jogador dribla bem");
        }
        
        public virtual void FazerGols(){
            Console.WriteLine("Esse jogador sabe fazer gols");
        }

        public virtual void Correr(){
            Console.WriteLine("Esse Jogador corre demais");
        }

        public virtual void Lesionar(){
            Console.WriteLine("Esse jogador sofre com lesões");
        }
    }
}