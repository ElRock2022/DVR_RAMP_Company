using DVR_RAMP_Company.Model;
using Microsoft.EntityFrameworkCore;

namespace DVR_RAMP_Company.Data
{
    public class ApplicationDbContext : DbContext

    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Tb_Users> Tb_Users { get; set; } //dar o nome à tabela que se cria - neste caso dei o mesmo
        public DbSet<Tb_Product> Tb_Product { get; set; } //dar o nome à tabela que se cria - neste caso dei o mesmo

    }
}
