using System.Collections.Generic;
using System.Threading.Tasks;
using DAL.Models;
using DAL.Repositories;

namespace Services
{
    public class ArtikelService : IArtikelService
    {
        private readonly IArtikelRepository _artikelRepository;

        public ArtikelService(IArtikelRepository artikelRepository)
        {
            _artikelRepository = artikelRepository;
        }

        public async Task<List<TArtikel>> GetAllArtikelAsync()
        {
            return await _artikelRepository.GetAllArtikelAsync();
        }

        public async Task<TArtikel> GetProductByIdAsync(int id)
        {
            return await _artikelRepository.GetArtikelByIdAsync(id);
        }

        public async Task<List<TArtikel>> GetAllVaterArtikelAsync()
        {
            return await _artikelRepository.GetAllVaterArtikelAsync();
        }
    }
}
