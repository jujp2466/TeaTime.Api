using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaTime.Repository.DbFactory
{
    public class DbConnectionFactoryProvider
    {
        public enum DatabaseType
        {
            SqlServer,
            MySql
        }

        public IDbConnectionFactory GetFactory(DatabaseType databaseType, IConfiguration connectionString)
        {
            switch (databaseType)
            {
                case DatabaseType.SqlServer:
                    return new SqlServerConnectionFactory(connectionString);
                case DatabaseType.MySql:
                    return new MySqlConnectionFactory(connectionString);
                default:
                    throw new ArgumentException("Invalid database type");
            }
        }
    }
}
