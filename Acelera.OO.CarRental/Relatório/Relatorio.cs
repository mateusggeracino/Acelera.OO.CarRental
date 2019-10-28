using System.Collections.Generic;
using System.Text;
using Acelera.OO.CarRental.Models.Adicionais.Base;
using Acelera.OO.CarRental.Models.Aluguel;

namespace Acelera.OO.CarRental.Relatório
{
    public class Relatorio
    {
        public static string Imprimir(Aluguel aluguel)
        {
            var relatorio =
                $"Tipo do Carro: {aluguel.Veiculo.Tipo}\n" +
                $"Quantidade de diárias: {aluguel.Diarias}\n" +
                $"Valor total das diárias: R$ {aluguel.ValorTotalDiarias}\n" +
                $"Estimativa de quilometragem em reais: R$ {aluguel.ValorTotalKm}\n" +
                $"Valores de todos os adicionais: {MostrarAdicionais(aluguel.Veiculo.Adicionais)}\n" +
                $"Valor total do aluguel: R$ {aluguel.ValorTotalAluguel}";

            return relatorio;
        }

        private static StringBuilder MostrarAdicionais(List<IAdicional> adicionais)
        {
            var adicionaisBuilder = new StringBuilder();

            adicionais.ForEach(x => adicionaisBuilder.Append($"{x.Nome}: R$ {x.Valor} "));

            return adicionaisBuilder;
        }
    }
}