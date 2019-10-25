using System.Collections.Generic;
using Acelera.OO.CarRental.Models.Adicionais.Base;

namespace Acelera.OO.CarRental.Models.Veiculos.Base
{
    public abstract class VeiculoBase
    {
        public int KmAtual { get; set; }
        public decimal ValorDiaria { get; set; }
        public decimal ValorKm { get; set; }
        public List<IAdicional> Adicionais { get; set; }
    }
}