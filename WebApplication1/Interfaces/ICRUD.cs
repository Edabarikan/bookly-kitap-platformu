using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Interfaces
{
    public interface ICRUD<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> Listele();
        Task<TEntity> Ara(int id);
        Task Ekle(TEntity entity);
        Task Guncelle(TEntity entity);
        Task Sil(int id);

    }
}
