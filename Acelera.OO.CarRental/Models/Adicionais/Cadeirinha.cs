using Acelera.OO.CarRental.Models.Adicionais.Base;

namespace Acelera.OO.CarRental.Models.Adicionais
{
    public class Cadeirinha : AdicionalCarroBase
    {
        public Cadeirinha()
        {
            Nome = nameof(Cadeirinha);
            Valor = 25m;
        }
    }
}