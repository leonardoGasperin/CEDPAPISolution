using Microsoft.EntityFrameworkCore;
//using System.Collections.Generic;

namespace CEDPAPI.Model
{
    public class CEdpApiContext : DbContext
    {
        public CEdpApiContext(DbContextOptions<CEdpApiContext> options) : base(options)
        {
        }

        public DbSet<RegistrationEntity> teste { get; set; }
    }
}
