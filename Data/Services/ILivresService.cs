using Livre_Project.Models;

namespace Livre_Project.Data.Services
{
    public interface ILivresService
    {
        Task<IEnumerable<Livre>> GetAllAsync();
        Task<Livre> GetByIdAsync(int id);
        Task AddAsync(Livre livre);
        Task AddFavoriAsync(int id);
        Task<Livre> UpdateAsync(int id, Livre newLivre);
        Task DeleteAsync(int id);
        Task<List<bool>> FavoriExist(int id);
    }
}
