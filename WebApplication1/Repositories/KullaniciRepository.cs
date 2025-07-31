using WebApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Data;

namespace WebApplication1.Repositories
{
    public class KullaniciRepository : BaseRepository<AppUser>
    {
        public KullaniciRepository(KitapDBContext context) : base(context)
        {
        }
    }
}
