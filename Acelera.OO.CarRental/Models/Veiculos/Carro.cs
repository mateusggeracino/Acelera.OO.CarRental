using System.Collections.Generic;
using System.Linq;
using Acelera.OO.CarRental.Models.Adicionais;
using Acelera.OO.CarRental.Models.Adicionais.Base;
using CarRental.Models.Veiculos.Base;

namespace Acelera.OO.CarRental.Models.Veiculos
{
    public class Carro : VeiculoBase
    {
        public Carro()
        {
            ValorDiaria = 50m;
            ValorKm = 0.5m;
        }

        public List<AdicionalCarroBase> Adicionais { get; set; }
    }
}