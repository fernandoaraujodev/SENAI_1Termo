using System;

namespace Aula07Encapsulamento
{
    public class Cartao
    {
        //Atributo
        public string numero { get; set; }

        public string bandeira { get; set; }

        public string titular { get; set; }

        private string token = "dcjsjsckdbjkmiibggggfds";
        
        protected string cvv { get; set;} 
        
        //Metodos
        public void AprovarCompra(){
            Console.WriteLine("Compra Aprovada!");
        }

        private bool ValidarToken()
        {
            if(token != null)
            {
                return true;
            }
                return false;

        } 

        protected bool ValidarCompra(){
            return true;
        }
    
    
    
    
    }
}