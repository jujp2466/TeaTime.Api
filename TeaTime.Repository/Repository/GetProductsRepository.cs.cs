using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TeaTime.Common;
using TeaTime.Model.Entity;
using TeaTime.Model.RequestVM;
using TeaTime.Repository.DbFactory;
using TeaTime.Repository.Interface;
using static System.Net.Mime.MediaTypeNames;


namespace TeaTime.Repository.Repository
{
    public class GetProductsRepository : IGetProductsRepository
    {
        private readonly IConfiguration _connectionString;
        private readonly DbConnectionFactoryProvider _dbConnectionFactoryProvider;
        private readonly IGenericRepository<tProducts> _tProductsRepository;

        public GetProductsRepository(IConfiguration configuration, DbConnectionFactoryProvider dbConnectionFactoryProvider, IGenericRepository<tProducts> tProductsRepository)
        {
            _connectionString = configuration;
            _dbConnectionFactoryProvider = dbConnectionFactoryProvider;
            _tProductsRepository = tProductsRepository;

        }

        public async Task<ResponseVM<tProducts>> GetAllProduct()
        {
            DbFactory.IDbConnectionFactory dbConnectionFactory = _dbConnectionFactoryProvider.GetFactory(DbConnectionFactoryProvider.DatabaseType.SqlServer, _connectionString);
            using IDbConnection connection = dbConnectionFactory.CreateConnection();
            List<tProducts> products = (await _tProductsRepository.GetAll()).ToList();
            if (products.Count > 0)
            {
                return new ResponseVM<tProducts>
                {
                    IsSuccess = products.Any(),
                    Message = products.Any() ? "成功" : "失敗",
                    ResponseCode = ResponseCode.Success,
                    DataList = products
                };
            }
            return null;
        }
    }
}