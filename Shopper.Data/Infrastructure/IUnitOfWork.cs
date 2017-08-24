namespace Shopper.Data.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}