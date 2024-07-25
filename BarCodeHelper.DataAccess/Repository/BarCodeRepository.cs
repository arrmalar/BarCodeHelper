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

        public void Update(BarCode obj)
        {
            _db.BarCodes.Update(obj);
        }
    }
}
