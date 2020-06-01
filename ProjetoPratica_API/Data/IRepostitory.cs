using System.Threading.Tasks;
using ProjetoPratica_API.Models;

namespace ProjetoPratica_API.Data
{
    public interface IRepostitory
    {
         //Métodos Genéricos
         void Add<T>(T entity) where T: class;
         void Update<T>(T entity) where T: class;
         Jogador UpdateJogador(Jogador modelo);
         void Delete<T>(T entity) where T: class;
         Task<bool> SaveChangesAsync(); 

         //Métodos GET
         Task<Jogador[]> GetAllJogadoresAsync();
         Task<Jogador> GetAllJogadoresAsyncById(int Id);
         Task<Jogador> GetAllJogadoresAsyncByUsuario(string usuario);
    }
}