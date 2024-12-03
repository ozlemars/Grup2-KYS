using System.Configuration;


namespace KYS.DataAccess.Configuration
{
    public class DBConfiguration
    {
        private static readonly string _connectionString;

        static DBConfiguration()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["KYS"].ConnectionString;
        }

        public static string GetConnectionString()
        {
            return _connectionString;
        }
    }
}
