namespace Acelera.OO.CarRental.Models.Adicionais.Base
{
    public abstract class Adicional : IAdicional
    {
        public string Nome { get; private set; }
        public decimal Valor { get; private set; }

        public void AdicionarValor(decimal valor) => Valor = valor;
        public void AdicionarNome(string nome) => Nome = nome;
    }
}