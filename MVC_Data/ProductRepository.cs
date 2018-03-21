using System;
using System.Collections.Generic;
using System.Linq;

namespace MVC_Data
{
   public class ProductRepository
    {

        private StoreDemoWithCustomerProductEntities _context;

        public ProductRepository(StoreDemoWithCustomerProductEntities context)
        {
            _context = context;
        }

        public IEnumerable<Product> GetProducts()
        {
            return _context.Products.Where(x=> x.IsDiscontinued == false);
        }

        public IEnumerable<Product> GetProductById(int productId)
        {
            return _context.Products.Where(x => x.Id == productId);

        }
    }
}
