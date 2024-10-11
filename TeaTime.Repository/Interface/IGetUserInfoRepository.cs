using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaTime.Model.Entity;
using TeaTime.Model.RequestVM;

namespace TeaTime.Repository.Interface
{
    public interface IGetUserInfoRepository
    {
        Task<ResponseVM<tUserInfo>> GetAllUser();
    }
}