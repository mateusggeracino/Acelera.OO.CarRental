using System.Collections.Generic;
using Acelera.OO.CarRental.Models.Adicionais.Base;
using Acelera.OO.CarRental.Models.Veiculos.Base;

namespace Acelera.OO.CarRental.Models.Veiculos
{
    public sealed class Carro : Veiculo
    {
        public override string Tipo => "Carro";
        public override decimal ValorDiaria => 50m;
        public override decimal ValorKm => 0.5m;
    }
}