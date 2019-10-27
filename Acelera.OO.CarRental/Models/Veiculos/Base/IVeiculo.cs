using System.Collections.Generic;
using Acelera.OO.CarRental.Models.Adicionais.Base;

namespace Acelera.OO.CarRental.Models.Veiculos.Base
{
    public interface IVeiculo
    {
        int KmAtual { get;  }
        decimal ValorDiaria { get; }
        decimal ValorKm { get;}
        List<IAdicional> Adicionais { get; }
    }
}