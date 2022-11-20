using Livre_Project.Models;

namespace Livre_Project.Data.Services
{
    public interface ILivresService
    {
        IEnumerable<Livre> getAll();

        Livre GetById(int id);
        void Add(Livre livre);
        Livre Update(int id, Livre newLivre);
        void Delete(int id);
    }
}
