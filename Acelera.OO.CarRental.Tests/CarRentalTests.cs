using System;
using System.Collections.Generic;
using Acelera.OO.CarRental.Models;
using Acelera.OO.CarRental.Models.Adicionais;
using Acelera.OO.CarRental.Models.Adicionais.Base;
using Acelera.OO.CarRental.Models.Veiculos;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acelera.OO.CarRental.Tests
{
    [TestClass]
    public class CarRentalTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var carroHome = new CarroHome
            {
                Adicionais = new List<IAdicional>
                {
                    new Gps(),
                    new Geladeira()
                }
            };

            var locacao = new Locacao(2, 850, carroHome);

            Console.WriteLine(locacao.ToString());
            Console.ReadKey();
        }
    }
}
