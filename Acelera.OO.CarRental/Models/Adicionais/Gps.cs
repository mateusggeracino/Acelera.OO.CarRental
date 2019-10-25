using Acelera.OO.CarRental.Models.Adicionais.Base;

namespace Acelera.OO.CarRental.Models.Adicionais
{
    public class Gps : IAdicional
    {
        public Gps()
        {
            Valor = 25m;
        }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
    }
}