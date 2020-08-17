namespace Aula19CodingDojoIngresso
{
    public class IngressoVip : Ingresso
    {
         public float Adicional {get;set;}
        
        public void ImprimirValorVIP(){
            float IngressoVip;
            IngressoVip = ValorIngresso + Adicional;
            System.Console.WriteLine($"O valor do ingresso Vip é R${IngressoVip}, você tem direito a refil de pipoca grátis");

        }
    }
}