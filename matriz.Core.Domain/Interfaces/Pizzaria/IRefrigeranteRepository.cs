using matriz.Core.Domain.Entities;
using matriz.Core.Domain.Entities.Pizzaria;

namespace matriz.Core.Domain.Interfaces;

public interface IRefrigeranteRepository
{
    Task<IEnumerable<Refrigerante>> ObterListaRefrigeranteAsync();
    Refrigerante ObterRefrigeranteAsync(int refrigeranteId);
    Task<Refrigerante> SalvarRefrigerante(Refrigerante pizza);
    Task<Refrigerante> AlterarRefrigerante(Refrigerante pizza);
    Task<Refrigerante> ExcluirRefrigerante(int refrigeranteId);
    IEnumerable<FotoRefrigerante> ObterFotoRefrigeranteAsync(int refrigeranteId);
    Task<FotoRefrigerante> SalvarFotoRefrigerante(FotoRefrigerante fotoRefrigerante);
    Task<FotoRefrigerante> ExcluirFotoRefrigerante(int fotoRefrigeranteId);

}
