using CaseStudy.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;

namespace CaseStudy.Application.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        DbSet<T> Table { get; }
    }
}
