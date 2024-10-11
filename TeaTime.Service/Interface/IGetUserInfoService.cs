using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaTime.Model.Entity;
using TeaTime.Model.RequestVM;

namespace TeaTime.Service.Interface
{
    public interface IGetUserInfoService
    {
        Task<ResponseVM<tUserInfo>> GetAllUser();
    }
}
