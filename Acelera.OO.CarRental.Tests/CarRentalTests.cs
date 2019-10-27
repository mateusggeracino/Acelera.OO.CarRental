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
            var motorHomeAd = new List<IAdicional> { new Geladeira(250m), new Gps(35m) };
            var motorHome = new MotorHome(motorHomeAd);

            var locacao = new Locacao(new DateTime(2019, 10, 21), new DateTime(2019, 10, 23), motorHome, 850);

            Console.WriteLine(locacao.ToString());
            Console.ReadKey();
        }
    }
}
