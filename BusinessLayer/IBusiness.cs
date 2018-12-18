using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    interface IBusiness<TEntity>
    {
        void Add(TEntity item);

        void Remove(TEntity item);

        void Update(TEntity item);

        List<TEntity> GetAll();

        TEntity GetById(int id);
    }
}
