using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Repositories
{
    public class YorumRepository : BaseRepository<Yorum>
    {
        public YorumRepository(KitapDBContext context) : base(context)
        {
        }
    }
}
