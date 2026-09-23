using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class Appdb : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=HDC3-L-94S8B54;Initial catalog=db_anydbname;user id=sa;Password=Sa@12345678;TrustServerCertificate=true");
        }
    }
}
