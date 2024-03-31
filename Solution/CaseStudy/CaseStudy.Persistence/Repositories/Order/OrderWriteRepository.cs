using CaseStudy.Application.Repositories;
using CaseStudy.Domain.Entities;
using CaseStudy.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy.Persistence.Repositories
{
    public class OrderWriteRepository : WriteRepository<Order>, IOrderWriteRepository
    {
        public OrderWriteRepository(CaseStudyDbContext context) : base(context)
        {
        }
    }
}
