using Livre_Project.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.Xml;

namespace Livre_Project.Data.Services
{
   
    public class LivresService : ILivresService
    {
        private readonly AppDbContext _context;

        public LivresService(AppDbContext context)
        {
            _context= context;
        }



        public async Task AddAsync(Livre livre)
        {
            _context.Livres.Add(livre);
            await _context.SaveChangesAsync();
        }

        public async Task AddFavoriAsync(int id)
        {
            _context.Livres_Utilisateurs.Add(new Livre_Utilisateur {LivreId = id, UtilisateurId = 1 });
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var result = await _context.Livres.FirstOrDefaultAsync(x=>x.Id== id);
            _context.Livres.Remove(result);
            await _context.SaveChangesAsync();
        }

        public async Task <IEnumerable<Livre>> GetAllAsync()
        {
            var result = await _context.Livres.ToListAsync();
            List<int> _enabled = new List<int>(new int[result.Count]);

            foreach (var item in _context.Livres_Utilisateurs)
            {
                foreach (var item2 in result)
                {
                    if (item.LivreId == item2.Id &&item.UtilisateurId==1)
                    {
                        item2.disabled = "none";
                        break;
                    }
                
                }
            }            
            
            return result;
        }

        public async Task<Livre> GetByIdAsync(int id)
        {
            var result = await _context.Livres.FirstOrDefaultAsync(x => x.Id == id);
            return result;
        }

        public async Task<List<bool>> FavoriExist(int id)
        {
            return null;
        }


        public async Task<Livre> UpdateAsync(int id, Livre newLivre)
        {
            _context.Update(newLivre);
            await _context.SaveChangesAsync();

            return newLivre;
        }
    }
}
