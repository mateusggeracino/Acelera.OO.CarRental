using System;
using System.Collections.Generic;
using Acelera.OO.CarRental.Models;
using Acelera.OO.CarRental.Models.Adicionais;
using Acelera.OO.CarRental.Models.Adicionais.Base;
using Acelera.OO.CarRental.Models.Aluguel;
using Acelera.OO.CarRental.Models.Veiculos;
using Acelera.OO.CarRental.Relatório;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acelera.OO.CarRental.Tests
{
    [TestClass]
    public class CarRentalTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var relatorio =
                "Tipo do Carro: Motor Home\n" +
                "Quantidade de diárias: 2\n" +
                "Valor total das diárias: R$ 600\n" +
                "Estimativa de quilometragem em reais: R$ 552.50\n" +
                "Valores de todos os adicionais: GPS: R$ 35 Geladeira: R$ 250 \n" +
                "Valor total do aluguel: R$ 1437.50";

            var motorHome =
                MotorHome.Novo()
                .AdicionarAdicional<Gps>(35m)
                .AdicionarAdicional<Geladeira>(250m);

            var dataSaida = new DateTime(2019, 10, 21);
            var dataRetorno = new DateTime(2019, 10, 23);

            var aluguel = new Aluguel(dataSaida, dataRetorno, motorHome, 850);

            var result = Relatorio.Imprimir(aluguel);

            Assert.AreEqual(result, relatorio);
        }
    }
}
