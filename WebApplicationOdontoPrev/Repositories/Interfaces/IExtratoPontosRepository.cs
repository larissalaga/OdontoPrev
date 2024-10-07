using WebApplicationOdontoPrev.Dtos;
using WebApplicationOdontoPrev.Models;

namespace WebApplicationOdontoPrev.Repositories.Interfaces
{
    public interface IExtratoPontosRepository
    {
        Task<ExtratoPontos> Create(ExtratoPontosDtos extratoPontos);
        public void Delete(int IdExtratoPontos);
        Task<List<ExtratoPontos>> GetAll();
        Task<ExtratoPontos> GetById(int idPaciente);
    }
}
