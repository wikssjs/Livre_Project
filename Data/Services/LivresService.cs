using Livre_Project.Models;

namespace Livre_Project.Data.Services
{
   
    public class LivresService : ILivresService
    {
        private readonly AppDbContext _context;

        public LivresService(AppDbContext context)
        {
            _context= context;
        }



        public void Add(Livre livre)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Livre> getAll()
        {
            var result =_context.Livres.ToList();
            return result;
        }

        public Livre GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Livre Update(int id, Livre newLivre)
        {
            throw new NotImplementedException();
        }
    }
}
