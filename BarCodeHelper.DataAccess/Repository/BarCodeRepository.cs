using BarCodeHelper.DataAccess.Data;
using BarCodeHelper.DataAccess.Repository.IRepository;
using BarCodeHelper.Models;

namespace BarCodeHelper.DataAccess.Repository
{
    public class BarCodeRepository : Repository<BarCode>, IBarCodeRepository
    {
        private ApplicationDbContext _db;

        public BarCodeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(BarCode barCode)
        {
            var objFromDb = _db.BarCodes.FirstOrDefault(f => f.BarCodeNumber == barCode.BarCodeNumber);

            if (objFromDb != null)
            {
                objFromDb.Product.Name = barCode.Product.Name;
                objFromDb.Product.Category = barCode.Product.Category;

                _db.BarCodes.Update(objFromDb);
            }

        }
    }
}
