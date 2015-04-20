using CeramicBarn.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeramicBarn.DataLayer.Repositories
{
    public class ProductRepository
    {
        private List<Product> _products = new List<Product>
            {
                new Product { Id = 1, Name = "Buchanan Sofa", Department = Department.Furniture,  Price = 1399.00M },
                new Product { Id = 2, Name = "Torrey All-Weather Wicker Sectional", Department = Department.Outdoor,  Price = 4694.00M },
                new Product { Id = 3, Name = "Empire Scroll Rug", Department = Department.RugsWindows,  Price = 1000.00M },
                new Product { Id = 4, Name = "Belgian Flax Linen Duvet Cover and Sham-Queen", Department = Department.Bedding,  Price = 254.00M },
                new Product { Id = 5, Name = "CB Classic 820-Gram Weight Bath Towel", Department = Department.Bath,  Price = 28.00M },
                new Product { Id = 6, Name = "Malta Lanterns Bronze Finish", Department = Department.Lighting,  Price = 79.00M },
                new Product { Id = 7, Name = "Deer Embroidered Throw Pillow Cover", Department = Department.DecorPillows,  Price = 45.00M },
                new Product { Id = 8, Name = "Beachcomber High Rectangular Basket", Department = Department.Organization,  Price = 199.00M },
                new Product { Id = 9, Name = "Cambria Dinnerwear 8 Piece Set", Department = Department.Tabletop,  Price = 115.00M },
                new Product { Id = 10, Name = "McKenna Leather Jewelry Box", Department = Department.Gifts,  Price = 99.00M }
            };

        public IEnumerable<Product> GetAll()
        {
            return _products;
        }
    }
}
