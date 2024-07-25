namespace BarCodeHelper.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        IProductRepository ProductRepository { get; }
        IBarCodeRepository BarCodeRepository { get; }
        IApplicationUserRepository ApplicationUserRepository { get; }
        void Save();
    }
}
