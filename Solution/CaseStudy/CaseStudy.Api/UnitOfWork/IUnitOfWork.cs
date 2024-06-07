namespace CaseStudy.Api.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        bool Commit(bool state = true);
    }
}
