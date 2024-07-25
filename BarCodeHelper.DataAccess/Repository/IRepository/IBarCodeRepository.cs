using BarCodeHelper.Models;

namespace BarCodeHelper.DataAccess.Repository.IRepository
{
    public interface IBarCodeRepository : IRepository<BarCode>
    {
        void Update(BarCode obj);
    }
}
