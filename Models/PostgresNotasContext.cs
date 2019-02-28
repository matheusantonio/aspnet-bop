using Microsoft.EntityFrameworkCore;

namespace ApiBop.Models
{
    public class PostgresNotasContext : DbContext
    {
        public PostgresNotasContext(DbContextOptions<PostgresNotasContext> options) :
            base(options)
            {

            }

        public DbSet<ApiBop.Models.Nota> tb_notas {get; set;}
    }
}