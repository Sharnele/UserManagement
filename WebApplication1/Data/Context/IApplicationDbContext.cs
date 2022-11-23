using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Data.Context
{
    public interface IApplicationDbContext
    {
        DbSet<ApplicationUser> ApplicationUser { set; get; }
        DbSet<Periode> Periode { set; get; }
    }
}
