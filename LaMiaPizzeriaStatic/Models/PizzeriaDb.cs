using Microsoft.EntityFrameworkCore;

namespace LaMiaPizzeriaStatic.Models
{
    public class PizzeriaDb : DbContext
    {
        public DbSet<Pizza> pizze {  get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=PizzeriaDb;" +
             "Integrated Security=True;TrustServerCertificate=True");
        }
    }
}
