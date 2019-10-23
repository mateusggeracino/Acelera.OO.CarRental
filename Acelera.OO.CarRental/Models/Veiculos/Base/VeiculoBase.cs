namespace CarRental.Models.Veiculos.Base
{
    public abstract class VeiculoBase
    {
        public int KmAtual { get; set; }
        public decimal ValorDiaria { get; set; }
        public decimal ValorKm { get; set; }
    }
}