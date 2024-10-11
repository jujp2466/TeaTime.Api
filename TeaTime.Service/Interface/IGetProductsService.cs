﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaTime.Model.Entity;
using TeaTime.Model.RequestVM;

namespace TeaTime.Service.Interface
{
    public interface IGetProductsService
    {
        /// <summary>
        /// 抓出所有商品
        /// </summary>
        /// <returns></returns>
        Task<ResponseVM<tProducts>> GetAllProduct();
    }
}