using System.ComponentModel;

namespace Acelera.OO.CarRental.Models.Adicionais.Base
{
    public abstract class AdicionalCarroBase : IAdicional
    {
        public string Nome { get; set; }
        public decimal Valor { get; set; }
    }
}