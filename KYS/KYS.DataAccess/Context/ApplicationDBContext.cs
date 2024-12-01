using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace KYS.DataAccess.Context
{
    public class ApplicationDBContext:DbContext
    {

        // buraya aşağıdaki yorum satırı gibi entity eklemeleri yapılacak.
        // public DbSet<Product> Products { get; set; }




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // app.config'den connection string okuma
            string connectionString = ConfigurationManager.ConnectionStrings["KYS"].ConnectionString;

            // Bağlantı dizesini DbContext'e ekleme
            optionsBuilder.UseSqlServer(connectionString);
        }


    }
}
