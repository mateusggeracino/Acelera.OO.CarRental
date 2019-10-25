using System.Collections.Generic;
using Acelera.OO.CarRental.Models.Adicionais.Base;
using Acelera.OO.CarRental.Models.Veiculos.Base;

namespace Acelera.OO.CarRental.Models.Veiculos
{
    public class Carro : VeiculoBase
    {
        public Carro()
        {
            ValorDiaria = 50m;
            ValorKm = 0.5m;
        }
    }
}