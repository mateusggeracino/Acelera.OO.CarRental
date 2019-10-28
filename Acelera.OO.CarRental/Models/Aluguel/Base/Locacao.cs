using System;
using Acelera.OO.CarRental.Models.Veiculos.Base;

namespace Acelera.OO.CarRental.Models.Aluguel.Base
{
    public abstract class Locacao : ILocacao
    {
        protected DateTime DataSaida { get; private set; }
        protected DateTime DataRetorno { get; private set; }
        public IVeiculo Veiculo { get; private set; }

        public int CalcularDiarias(DateTime dataSaida, DateTime dataRetorno)
        {
            DataSaida = dataSaida;
            DataRetorno = dataRetorno;

            return DataRetorno.Subtract(dataSaida).Days;
        }

        public void AdicionarVeiculo(IVeiculo veiculo) => Veiculo = veiculo;
    }
}