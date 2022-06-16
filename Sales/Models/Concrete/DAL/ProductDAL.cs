using Sales.Models.Abstract;
using Sales.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sales.Models.Concrete.DAL
{
    public class ProductDAL : BaseRepository<Product>, IProductRepository
    {
        public ProductDAL(SalesDbSabahContext context) : base(context)
        {

        }
        private SalesDbSabahContext Context
        {
            get { return _context as SalesDbSabahContext; }
        }
        public List<Product> GetPopularProducts()
        {
            throw new System.NotImplementedException();
        }
    }
}
