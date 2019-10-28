using System;
using System.Linq;
using Acelera.OO.CarRental.Models.Veiculos.Base;

namespace Acelera.OO.CarRental.Models.Aluguel
{
    public sealed class Locacao
    {
        public Locacao(DateTime dataInicio, DateTime dataFinal, IVeiculo veiculo, int km)
        {
            Diaria = dataFinal.Subtract(dataInicio).Days;
            Km = km;
            Veiculo = veiculo;
        }

        public int Diaria { get; private set; }
        public int Km { get; private set; }
        public decimal ValorDiarias { get; private set; }
        public decimal EstimativaKm { get; private set; }
        public decimal ValoresAdicionais { get; private set; }
        public decimal ValorTotal { get; private set; }

        public IVeiculo Veiculo { get; private set; }

        public Locacao CalcularValorTotal()
        {
            ValorTotal = ValoresAdicionais + EstimativaKm + ValorDiarias;
            return this;
        }
        public Locacao CalcularValorDiaria()
        {
            ValorDiarias = Veiculo.ValorDiaria * Diaria;
            return this;
        }
        public Locacao CalcularValorKm()
        {
            EstimativaKm = Veiculo.ValorKm * Km;
            return this;
        }
        public Locacao CalcularValorAdicional()
        {
            ValoresAdicionais = Veiculo.Adicionais.Sum(x => x.Valor);
            return this;
        }
    }
}