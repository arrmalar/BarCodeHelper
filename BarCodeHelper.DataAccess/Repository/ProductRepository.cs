using BarCodeHelper.DataAccess.Data;
using BarCodeHelper.DataAccess.Repository.IRepository;
using BarCodeHelper.Models;

namespace BarCodeHelper.DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private ApplicationDbContext _db;

        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Product obj)
        {
            _db.Products.Update(obj);
        }
    }
}
