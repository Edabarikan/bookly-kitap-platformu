using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Repositories
{
    public class YayineviRepository : BaseRepository<Yayinevi>
    {
        public YayineviRepository(KitapDBContext context) : base(context)
        {
        }
    }
}
