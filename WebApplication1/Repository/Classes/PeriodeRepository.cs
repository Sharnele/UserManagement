using LoginApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data;
using WebApplication1.Data.Context;
using WebApplication1.Repository.Interfaces;

namespace WebApplication1.Repository.Classes
{
    public class PeriodeRepository : IPeriodeRepository
    {
        private readonly IApplicationDbContext _dbContext;
        public PeriodeRepository(IApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Periode> GetPeriodes() => _dbContext.Periode.ToList();

        public List<Periode> GetPeriodesPerUser(string UserId) => _dbContext.Periode.Where(p=>p.UserId == UserId).ToList();

    }
}
