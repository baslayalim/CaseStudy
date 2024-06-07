using CaseStudy.Application.Repositories;
using CaseStudy.Persistence.Contexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;

namespace CaseStudy.Api.UnitOfWork
{
    public class Repository<T> : ControllerBase, IUnitRepository<T>, IUnitOfWork where T : class
    {
        protected CaseStudyDbContext _companyContext;
        IDbContextTransaction transaction = null;
        public Repository(CaseStudyDbContext companyContext)
        {
            _companyContext = companyContext;
            transaction = _companyContext.Database.BeginTransaction();
        }
        [NonAction]
        public List<T> Get() => _companyContext.Set<T>().ToList();
        [NonAction]
        public bool Add(T model)
        {
            _companyContext.Set<T>().Add(model);
            return true;
        }
        [NonAction]
        public bool Add<A>(A model) where A : class
        {
            _companyContext.Set<A>().Add(model);
            return true;
        }
        [NonAction]
        public bool Remove(T model)
        {
            _companyContext.Set<T>().Remove(model);
            return true;
        }
        [NonAction]
        public int Save() => _companyContext.SaveChanges();
        [NonAction]
        public bool Commit(bool state = true)
        { 
            Save();
            if (state)
                transaction.Commit();
            else
                transaction.Rollback();

            Dispose();
            return true;
        }
        public void Dispose()
        {
            _companyContext.Dispose();
        }
    }
}
