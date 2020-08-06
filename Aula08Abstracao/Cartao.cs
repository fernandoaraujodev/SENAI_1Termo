namespace Aula08Abstracao
{
    public class Cartao : Pagamento
    {
        protected string token = "dlkjifudbfe"; //chave de acesso
        public string bandeira { get; set; }
        public string titular { get; set; }
        public string numero { get; set; }
        public string cvv { get; set; }

        public bool ValidarToken(){
            if(token != null){
                return true;
            }
            return false;
        }

        public bool ValidarCVV(){
            if(cvv != null ){
                return true;
            }
                return false;
        }



    }
}