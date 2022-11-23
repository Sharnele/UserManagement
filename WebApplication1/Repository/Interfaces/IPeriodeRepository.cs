using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data;

namespace WebApplication1.Repository.Interfaces
{
    public interface IPeriodeRepository
    {
        List<Periode> GetPeriodes();
        List<Periode> GetPeriodesPerUser(string UserId);
    }
}
