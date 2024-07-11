using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace EfCore.DatabaseFirst.DAL;

public class DbContextInitializer
{
    public static IConfigurationRoot Configuration; 
    public static DbContextOptionsBuilder<AppDbContext> OptionsBuilder;

    public static void Build()
    {
        /* json dosyasına erişim için.
         * optional:true => bu dosya olabilir de olmayabilir de
        */
        var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).
            AddJsonFile("appsettings.json", optional: true,reloadOnChange: true);
    
        Configuration = builder.Build();

        //OptionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
        //OptionsBuilder.UseSqlServer(Configuration.GetConnectionString("SqlCon"));
    }
}