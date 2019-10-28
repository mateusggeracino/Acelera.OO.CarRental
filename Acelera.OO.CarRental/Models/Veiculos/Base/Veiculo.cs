using System.Collections.Generic;
using Acelera.OO.CarRental.Models.Adicionais.Base;

namespace Acelera.OO.CarRental.Models.Veiculos.Base
{
    public abstract class Veiculo : IVeiculo
    {
        protected Veiculo() => Adicionais = new List<IAdicional>();

        public Veiculo AdicionarAdicional<T>(decimal valor) where T : Adicional, new()
        {
            var obj = new T();
            obj.AdicionarValor(valor);

            Adicionais.Add(obj);
            return this;
        }

        public abstract string Tipo { get; }
        public abstract decimal ValorDiaria { get; }
        public abstract decimal ValorKm { get; }
        public List<IAdicional> Adicionais { get; }
    }
}