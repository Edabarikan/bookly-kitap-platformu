using WebApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.Data;
using Microsoft.EntityFrameworkCore;


namespace WebApplication1.Repositories
{
    public class KategoriRepository : BaseRepository<Kategori>
    {
        public KategoriRepository(KitapDBContext context) : base(context)
        {
        }
    }
}
