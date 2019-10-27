using Acelera.OO.CarRental.Models.Adicionais.Base;

namespace Acelera.OO.CarRental.Models.Adicionais
{
    public class Cadeirinha : IAdicional
    {
        public Cadeirinha(decimal valor) => Valor = valor;
        
        public string Nome => "Cadeirinha";
        public decimal Valor { get; }
    }
}