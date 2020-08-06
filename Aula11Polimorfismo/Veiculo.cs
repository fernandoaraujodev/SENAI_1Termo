using System;

namespace Aula11Polimorfismo
{
    public class Veiculo
    {
        public string CalcularPotencia(){
            return "Não há informações suficientes para calculo";
        }

        public string CalcularPotencia(int rpm){
            return "O veículo possui "+rpm+" rotações por minuto";
        }

        public string CalcularPotencia(int rpm, int torque){
            return "O veículo possui "+ (rpm*torque/5252) +" cavalos de potência";
        }

        public string CalcularPotencia( string modelo, string montadora){
            return $"Este {modelo} é fabricado pela {montadora} ";
        }
    }
}