using System.Collections.Generic;
using Acelera.OO.CarRental.Models.Adicionais.Base;
using Acelera.OO.CarRental.Models.Veiculos.Base;

namespace Acelera.OO.CarRental.Models.Veiculos
{
    public sealed class MotorHome : IVeiculo
    {
        public MotorHome(List<IAdicional> adicionais = null) => Adicionais = adicionais;

        public string Tipo => "Motor Home";
        public int KmAtual => 1200;
        public decimal ValorDiaria => 300m;
        public decimal ValorKm => 0.65m;

        public List<IAdicional> Adicionais { get; }
    }
}