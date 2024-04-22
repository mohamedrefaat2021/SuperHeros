namespace MohamedRefaat_TechnicalTest.Domain.IRepository
{
    public interface IUnitOfWork<T> : IDisposable where T: class
    {
        IRepositoryAsync<T> Repository { get; }
       
        bool Commit();
        Task<bool> CommitAsync();
    }
}
