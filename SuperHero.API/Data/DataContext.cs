using Microsoft.EntityFrameworkCore;

namespace SuperHero.API.Data
{
    // DbContext Sınıf aldık Microsoft.EntityFrameworkCore; paketini yukledi(":Db Context yazdık)
    // Burda Paketleri Kurcaz Çünkü Migration ve Database işlemleri için gerekli
    // Bu paketler EntityFrameworkCore paketlerinden Core-Tool-Sql-Desing
    // Sonra Database aktarmak için conneticiton işlemini yapcaz------> app.setting.json gidiyoruz Belirtilen yere kodlarımızı yazıp donuyoruz
    public class DataContext : DbContext
    {

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

        public DbSet<SuperHeroModel> superHeroModels { get; set; }

        // Db Setlerimizi modelin için çekip bu kısma tanımladıktan sonra 
        // program.cs içersine gidip bağlantı kodlarımızı yazıyoruz.




    }

        

}
