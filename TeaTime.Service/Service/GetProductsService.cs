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
    public class GetProductsService : IGetProductsService
    {
        private readonly IGetUserInfoRepository _getUserInfoRepoSitory;

        public GetProductsService(IGetUserInfoRepository getUserInfoRepository)
        {
            _getUserInfoRepoSitory = getUserInfoRepository;

        }

        public Task<ResponseVM<tProducts>> GetAllProduct()
        {
            throw new NotImplementedException();
        }
    }
}
