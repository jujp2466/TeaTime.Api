using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaTime.Repository.DbFactory
{
    public class SqlServerConnectionFactory : IDbConnectionFactory
    {
        private readonly IConfiguration _configuration;

        public SqlServerConnectionFactory(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IDbConnection CreateConnection()
        {
            var connectionString = _configuration.GetConnectionString("LabDbConnection");
            return new SqlConnection(connectionString);
        }

    }
}
