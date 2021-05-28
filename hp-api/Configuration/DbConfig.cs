using Microsoft.Extensions.Configuration;

namespace hp_api.Configuration
{
    public class DbConfig
    {
        public string DbString { get; set; }

        public DbConfig()
        {
            // var config = new ConfigurationBuilder()
            //     .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            //     .AddJsonFile("appsettings.json")
            //     .AddUserSecrets<Program>()
            //     .Build();
            // var conString = new DbConfig
            // {
            //     DbString = config.GetConnectionString("HPDBConnectionString")
            // };
        }
    }
}