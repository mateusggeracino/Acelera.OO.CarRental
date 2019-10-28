using System;
using System.Linq;
using Acelera.OO.CarRental.Models.Aluguel.Base;
using Acelera.OO.CarRental.Models.Veiculos.Base;

namespace Acelera.OO.CarRental.Models.Aluguel
{
    public sealed class Aluguel : Locacao
    {
        public Aluguel(DateTime dataSaida, DateTime dataRetorno, IVeiculo veiculo, int km)
        {
            Diarias = CalcularDiarias(dataSaida, dataRetorno);
            AdicionarVeiculo(veiculo);
            Km = km;
        }

        public int Diarias { get; private set; }
        public int Km { get; private set; }

        public decimal ValorTotalAluguel => ValorTotalDiarias + ValorTotalAdicionais + ValorTotalKm;
        public decimal ValorTotalDiarias => Veiculo?.ValorDiaria * Diarias ?? 0;
        public decimal ValorTotalKm => Veiculo?.ValorKm * Km ?? 0;
        public decimal ValorTotalAdicionais => Veiculo.Adicionais?.Sum(x => x.Valor) ?? 0m;
    }
}