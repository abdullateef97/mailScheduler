using MailSc.Models;
using Microsoft.EntityFrameworkCore;

namespace MailSc.Data
{
    public class MailContext : DbContext
    {
        public DbSet<Email> Emails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(
                "Server=localhost;Database=MailSc;Trusted_Connection=True;MultipleActiveResultSets=true;User ID=SA;password=Abdlatol97;integrated security=false");
        }
    }
}