using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using TeaTime.Common;
using TeaTime.Model.Entity;
using TeaTime.Model.RequestVM;
using TeaTime.Repository.DbFactory;
using TeaTime.Repository.Interface;
using TeaTime.Service.Interface;

namespace TeaTime.Service.Service
{
    public class GetUserInfoService : IGetUserInfoService
    {
        private readonly IGetUserInfoRepository _getUserInfoRepoSitory;

        public GetUserInfoService(IGetUserInfoRepository getUserInfoRepository)
        {
            _getUserInfoRepoSitory = getUserInfoRepository;

        }
        public async Task<ResponseVM<tUserInfo>> GetAllUser()
        {
            return await _getUserInfoRepoSitory.GetAllUser();
        }
    }
}
