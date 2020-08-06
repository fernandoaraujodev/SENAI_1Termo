using System;

namespace Aula13ProjetoUberConsole
{
    public class Passageiro : Usuario
    {
        public void SolicitarMotorista(){

                Console.WriteLine("\nAonde você deseja ir?");
                localDestino = Console.ReadLine();

                Console.WriteLine("\nAonde você se encontra?");
                localInicio = Console.ReadLine(); 

                Console.WriteLine("\nProcurando motorista...");

                Console.WriteLine($"\nO motorista {motorista} esta a caminho, aguarde no local");

                Console.WriteLine("...");

                Console.WriteLine("\nChegamos ao seu destino, como deseja pagar? \n1 - Cartao | 2 - Dinheiro");
                formaPagamento = Console.ReadLine();

                if(formaPagamento == "2"){
                    Console.WriteLine("Pague em espécie");
                }else{   
                    Console.WriteLine("Adicione um cartão para pagamento!");
                }



        }

        public bool Pagar( string statusCorrida ){

            if(statusCorrida == "Finalizada"){
                
                return true;
            }

            return false;
        }


        //Agregações
        //Cartao
        private string numero { get; set;}
        private string titular { get; set; }
        private string cvv { get; set; }
        private string  bandeira { get; set; }

        public void CadastrarCartao()
        {
            Console.WriteLine("\nInsira o nome do titular do cartão");
            titular = Console.ReadLine();

            Console.WriteLine("\nInsira o numero do cartão (sem espaços)");
            numero = Console.ReadLine();

            Console.WriteLine("\nInsira o cvv do cartão");
            cvv = Console.ReadLine();

            Console.WriteLine("\nInsira a bandeira do cartão");
            bandeira = Console.ReadLine();

            Console.WriteLine($"\nTudo certo, Sr. {titular} seu cartão foi cadastrado com sucesso!");
        }

        public string ExcluirCartao(){

            return "Seu cartão foi excluido com sucesso! Você deve realizar o pagamento em dinheiro";
        }

        //Corrida
        private string localInicio {get;set;}
        private string localDestino {get;set;}
        public string statusCorrida {get;set;}
        public string motorista = "Valber";
        public string passageiro { get; set; }

        public string formaPagamento {get;set;}
        public string Cancelar(){
            return "Você cancelou a corrida! Na próxima corrida terá uma taxa de R$ 5,00 a pagar pelo seu cancelamento";
        }

        //Status
        public DateTime data {get;set;}


    }
}