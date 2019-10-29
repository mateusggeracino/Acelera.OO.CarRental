using Acelera.OO.CarRental.Models.Veiculos.Base;

namespace Acelera.OO.CarRental.Models.Veiculos
{
    public sealed class MotorHome : Veiculo
    {
        private MotorHome(){}

        public static MotorHome Novo() =>  new MotorHome();
        public override string Tipo => "Motor Home";
        public override decimal ValorDiaria => 300m;
        public override decimal ValorKm => 0.65m;
    }
}