using System;

namespace ProjetoCelular 
{
    public class Celular
    {
        //Atributos
        public string cor;

        public string modelo;

        public float tamanhoTela;

        public bool ligado = true;

        //Metodos
        public string Ligar(){
            return "Você deve ligar o celular primeiro";
        }

        public string Desligar(){
            return "Você pode desligar o celular";
        }

        public string FazerLigacao(){
            return "Você pode fazer uma ligação";
        }

        public string EnviarMensagem(){
            return "Você pode enviar uma mensagem";
        }
        
    }
}