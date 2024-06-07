namespace CaseStudy.Api.UnitOfWork
{
    public interface IUnitRepository<T> where T : class
    {
        List<T> Get();
        bool Add(T model);
        bool Add<A>(A model) where A : class;
        bool Remove(T model);
        int Save();
    }
}
