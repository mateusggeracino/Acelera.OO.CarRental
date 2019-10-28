using Acelera.OO.CarRental.Models.Aluguel;
using Acelera.OO.CarRental.Models.Aluguel.Base;

namespace Acelera.OO.CarRental.Relatório.Base
{
    public interface IRelatorio
    {
        string Imprimir(Aluguel aluguel);
    }
}