namespace Acelera.OO.CarRental.Models.Adicionais.Base
{
    public abstract class AdicionalCarroHomeBase : IAdicional
    {
        public string Nome { get; set; }
        public decimal Valor { get; set; }
    }
}