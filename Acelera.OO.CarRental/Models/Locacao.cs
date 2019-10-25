using System.Linq;
using Acelera.OO.CarRental.Models.Veiculos.Base;

namespace Acelera.OO.CarRental.Models
{
    public class Locacao
    {
        public Locacao(int diaria, int km, VeiculoBase veiculo)
        {
            Diaria = diaria;
            Km = km;
            Veiculo = veiculo;
        }

        public int Diaria { get;}
        public int Km { get; }
        public decimal ValorDiarias => CalcularValorDiaria();
        public decimal EstimativaKm => CalcularValorKm();
        public decimal ValoresAdicionais => CalcularValorAdicional();
        public decimal ValorTotal => CalcularValorTotal();

        public VeiculoBase Veiculo { get; }

        public decimal CalcularValorTotal() => ValoresAdicionais + EstimativaKm + ValorDiarias;
        public decimal CalcularValorDiaria() => Veiculo.ValorDiaria * Diaria;
        public decimal CalcularValorKm() => Veiculo.ValorKm * Km;
        public decimal CalcularValorAdicional() => Veiculo.Adicionais.Sum(x => x.Valor);

        public override string ToString()
        {
            return
                $"Tipo do Carro: {Veiculo.GetType()}\n" +
                $"Quantidade de Diárias: {Diaria}\n" +
                $"Valor total das diárias: {ValorDiarias}\n" +
                $"Estimativa de quilometragem em reais: {EstimativaKm}\n" +
                $"Valores de toods os adicionais: {ValoresAdicionais}\n" +
                $"Valor Total do aluguel: {ValorTotal}";
        }
    }
}