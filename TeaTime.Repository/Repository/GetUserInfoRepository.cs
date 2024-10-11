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
    public class GetUserInfoRepository : IGetUserInfoRepository
    {
        private readonly IConfiguration _connectionString;
        private readonly DbConnectionFactoryProvider _dbConnectionFactoryProvider;
        private readonly IGenericRepository<tUserInfo> _tUserInfoRepository;

        public GetUserInfoRepository(IConfiguration configuration, DbConnectionFactoryProvider dbConnectionFactoryProvider, IGenericRepository<tUserInfo> tUserInfoRepository)
        {
            _connectionString = configuration;
            _dbConnectionFactoryProvider = dbConnectionFactoryProvider;
            _tUserInfoRepository = tUserInfoRepository;

        }

        public async Task<ResponseVM<tUserInfo>> GetAllUser()
        {
            DbFactory.IDbConnectionFactory dbConnectionFactory = _dbConnectionFactoryProvider.GetFactory(DbConnectionFactoryProvider.DatabaseType.SqlServer, _connectionString);
            using IDbConnection connection = dbConnectionFactory.CreateConnection();
            List<tUserInfo> userInfos = (await _tUserInfoRepository.GetAll()).ToList();
            return new ResponseVM<tUserInfo> 
            { 
                IsSuccess = userInfos.Count != 0, 
                Message = userInfos.Count != 0 ? "成功" : "失敗", 
                ResponseCode = ResponseCode.Success, 
                DataList = userInfos 
            };
        }
    }
}