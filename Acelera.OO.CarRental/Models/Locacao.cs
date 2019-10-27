using System;
using System.Linq;
using Acelera.OO.CarRental.Models.Veiculos.Base;

namespace Acelera.OO.CarRental.Models
{
    public class Locacao
    {
        public Locacao(DateTime dataInicio, DateTime dataFinal, IVeiculo veiculo, int km)
        {
            Diaria = dataFinal.Subtract(dataInicio).Days;
            Km = km;
            Veiculo = veiculo;
        }

        public int Diaria { get; }
        public int Km { get; }
        public decimal ValorDiarias => CalcularValorDiaria();
        public decimal EstimativaKm => CalcularValorKm();
        public decimal ValoresAdicionais => CalcularValorAdicional();
        public decimal ValorTotal => CalcularValorTotal();

        public IVeiculo Veiculo { get; }

        public decimal CalcularValorTotal() => ValoresAdicionais + EstimativaKm + ValorDiarias;
        public decimal CalcularValorDiaria() => Veiculo.ValorDiaria * Diaria;
        public decimal CalcularValorKm() => Veiculo.ValorKm * Km;
        public decimal CalcularValorAdicional() => Veiculo.Adicionais.Sum(x => x.Valor);
    }
}