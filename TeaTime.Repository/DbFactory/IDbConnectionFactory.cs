using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaTime.Repository.DbFactory
{
    public interface IDbConnectionFactory
    {
        IDbConnection CreateConnection();
    }
}
