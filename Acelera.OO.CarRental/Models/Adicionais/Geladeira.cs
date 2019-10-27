using Acelera.OO.CarRental.Models.Adicionais.Base;

namespace Acelera.OO.CarRental.Models.Adicionais
{
    public class Geladeira : IAdicional
    {
        public Geladeira(decimal valor) => Valor = valor;

        public string Nome => "Geladeira";
        public decimal Valor { get; }
    }
}