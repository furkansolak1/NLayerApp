namespace NLayer.Core.UnitOfWorks
{
    public interface IUnitOfWork
    {
        Task CommitAsync();// savChangesAsync
        void Commit();
    }
}
