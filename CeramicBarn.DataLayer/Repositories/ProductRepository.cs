using CeramicBarn.DataLayer.Repositories.Interfaces;
using CeramicBarn.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeramicBarn.DataLayer.Repositories
{
    public class ProductRepository : ICrudRepository<Product, int>
    {
        public IEnumerable<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public Product GetItem(int id)
        {
            throw new NotImplementedException();
        }

        public bool CreateItem(Product newItem)
        {
            throw new NotImplementedException();
        }

        public bool UpdateItem(Product updatedItem)
        {
            throw new NotImplementedException();
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
