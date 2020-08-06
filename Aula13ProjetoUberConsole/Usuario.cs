namespace Aula13ProjetoUberConsole
{
    public class Usuario 
    {
        //Propriedade resumida
        public string Nome { get; set; }

        //Propriedade completa
        private int idade;
        public int Idade
        {
            get { return idade; }
            set { 
                
                if(idade > 0){ 
                    idade = value; 
                }
            }
        }
        
        public string Foto { get;set; }
        private string login = "pessoa@email.com";
        private string senha = "senha123";
        public string LocalizacaoAtual { get;set; }
        public string TokenLogin { get;set; } 
        public string tipoAcesso { get;set; }

        public bool Login ( string login, string senha ){

            if(this.login == login && this.senha == senha ){
                
                TokenLogin = "ckjnsdlvhlsmdhkknvdsçgsjcbd";
                return true;
            }

            return false;
        }

        public void Logout(){
            TokenLogin = "";
        }


    }
}