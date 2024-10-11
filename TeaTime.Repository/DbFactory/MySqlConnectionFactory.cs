using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Microsoft.Extensions.Configuration;

namespace TeaTime.Repository.DbFactory
{
    public class MySqlConnectionFactory : IDbConnectionFactory
    {
        private readonly IConfiguration _configuration;

        public MySqlConnectionFactory(IConfiguration configuration) { _configuration = configuration; }

        public IDbConnection CreateConnection() 
        {
            var connectionString = _configuration.GetConnectionString("");
            return new MySqlConnection(connectionString);
        }
    }
}
