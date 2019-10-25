using System.Collections.Generic;
using Acelera.OO.CarRental.Models.Adicionais.Base;
using Acelera.OO.CarRental.Models.Veiculos.Base;

namespace Acelera.OO.CarRental.Models.Veiculos
{
    public class CarroHome : VeiculoBase
    {
        public CarroHome()
        {
            ValorKm = 0.65m;
            ValorDiaria = 300m;
        }
    }
}