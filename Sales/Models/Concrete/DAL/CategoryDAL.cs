using Sales.Models.Abstract;
using Sales.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sales.Models.Concrete
{
    public class CategoryDAL : BaseRepository<Category>, ICategoryRepository
    {
        public CategoryDAL(SalesDbSabahContext context):base(context)
        {

        }
        private SalesDbSabahContext Context
        {
            get { return _context as SalesDbSabahContext; }
        }
        public List<Category> GetPopularCategories()
        {
            throw new NotImplementedException();
        }
    }
}
