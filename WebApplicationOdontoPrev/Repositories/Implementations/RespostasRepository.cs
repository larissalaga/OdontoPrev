using Microsoft.EntityFrameworkCore;
using WebApplicationOdontoPrev.Data;
using WebApplicationOdontoPrev.Dtos;
using WebApplicationOdontoPrev.Models;
using WebApplicationOdontoPrev.Repositories.Interfaces;

namespace WebApplicationOdontoPrev.Repositories.Implementations
{
    public class RespostasRepository : IRespostasRepository
    {
        private DataContext _context;
        public RespostasRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<Models.Respostas> Create(RespostasDtos respostas)
        {
            var newRespostas = new Models.Respostas
            {
                IdPergunta = respostas.IdPergunta,
                IdPaciente = respostas.IdPaciente,
                DsResposta = respostas.DsResposta,
                DtDataResposta = respostas.DtDataResposta
            };
            _context.Respostas.Add(newRespostas);
            await _context.SaveChangesAsync();
            return newRespostas;
        }

        public async void Delete(int id)
        {
            var getRespostas = await _context.Respostas.FirstOrDefaultAsync(x => x.IdResposta == id);
            if (getRespostas == null)
            {
                throw new Exception("Respostas não encontrada.");
            }
            else
            {
                _context.Respostas.Remove(getRespostas);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<Models.Respostas>> GetAll()
        {
            var getRespostas = await _context.Respostas.ToListAsync();
            if (getRespostas != null)
            {
                return getRespostas;
            }
            else
            {
                throw new Exception("Nenhuma resposta encontrada.");
            }
        }

        public async Task<Models.Respostas> GetById(int id)
        {
            var getRespostas = await _context.Respostas.FirstOrDefaultAsync(x => x.IdResposta == id);
            if (getRespostas == null)
            {
                throw new Exception("Respostas não encontrada.");
            }
            else
            {
                return getRespostas;
            }
        }

        public async Task<Models.Respostas> Update(int id, RespostasDtos respostas)
        {
            var getRespostas = await _context.Respostas.FirstOrDefaultAsync(x => x.IdResposta == id);
            if (getRespostas == null)
            {
                throw new Exception("Respostas não encontrada.");
            }
            else
            {
                getRespostas.IdPergunta = respostas.IdPergunta;
                getRespostas.IdPaciente = respostas.IdPaciente;
                getRespostas.DsResposta = respostas.DsResposta;
                getRespostas.DtDataResposta = respostas.DtDataResposta;
                await _context.SaveChangesAsync();
                return getRespostas;
            }
        }
    }
}
