namespace Aula08Abstracao
{
    public class Boleto : Pagamento
    {
        public string dataVencimento { get; set; }
        public string bancoEmissor { get; set; }
        public string codDeBarras { get; set; }

        public string RegistrarNoSistema(){
            return "boleto registrado com sucesso";
        }


    }
}