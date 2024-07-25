using BarCodeHelper.DataAccess.Data;
using BarCodeHelper.DataAccess.Repository.IRepository;

namespace BarCodeHelper.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _db;

        public IProductRepository ProductRepository { get; private set; }

        public IApplicationUserRepository ApplicationUserRepository { get; private set; }

        public IBarCodeRepository BarCodeRepository { get; private set; }

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            ProductRepository = new ProductRepository(_db);
            BarCodeRepository = new BarCodeRepository(_db);
            ApplicationUserRepository = new ApplicationUserRepository(_db);
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
