using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeramicBarn.DataLayer.Repositories.Interfaces
{
    public interface ICrudRepository<T, TKey>
    {
        IEnumerable<T> GetAll();
        T GetItem(TKey id);
        bool CreateItem(T newItem);
        bool UpdateItem(T updatedItem);
        int Delete(TKey id);
    }
}
