namespace Aula13ProjetoUberConsole
{
    public class Motorista : Usuario
    {
        public string carro = "HB20S 1.6";
        public string placa = "GFR-4572"; 

        public void AceitarPassageiro (string nome ){

        }

        public bool ReceberPagamento ( string statusCorrida ){
            
            if(statusCorrida == "Finalizada"){
                
                return true;
            }

            return false;
        }
 

        //Conta
        public string conta = "26846246-34";
        public string agencia = "13452";

        public void CadastrarConta(){

        }

        public void ExcluirPassageiro(){
            
        }

    }
}