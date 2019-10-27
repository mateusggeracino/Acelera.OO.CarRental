using Acelera.OO.CarRental.Models.Adicionais.Base;

namespace Acelera.OO.CarRental.Models.Adicionais
{
    public class Gps : IAdicional
    {
        public Gps(decimal valor) => Valor = valor;

        public string Nome => "GPS";
        public decimal Valor { get; }
    }
}