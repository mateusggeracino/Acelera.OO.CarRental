using System.Collections.Generic;
using Acelera.OO.CarRental.Models.Adicionais.Base;
using Acelera.OO.CarRental.Models.Veiculos.Base;

namespace Acelera.OO.CarRental.Models.Veiculos
{
    public sealed class Carro : IVeiculo
    {
        public Carro(List<IAdicional> adicionais = null) => Adicionais = adicionais;
        public string Tipo => "Carro";
        public int KmAtual => 120;
        public decimal ValorDiaria => 50m;
        public decimal ValorKm => 0.5m;

        public List<IAdicional> Adicionais { get; }
    }
}