using BarCodeHelper.Models;

namespace BarCodeHelper.DataAccess.Repository.IRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        void Update(Product obj);
    }
}
