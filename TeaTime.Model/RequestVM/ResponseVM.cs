﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaTime.Common;

namespace TeaTime.Model.RequestVM
{
    public class ResponseVM<T>
    {
        /// <summary>
        /// 執行成功與否
        /// </summary>
        public bool IsSuccess { get; set; }

        /// <summary>
        /// 狀態碼
        /// </summary>
        public ResponseCode ResponseCode { get; set; }

        /// <summary>
        /// 錯誤訊息
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// 資料本體
        /// </summary>
        public T Data { get; set; }

        /// <summary>
        /// 資料本體陣列
        /// </summary>
        public List<T> DataList { get; set; }

        public ResponseVM<T> Success()
        {
            ResponseCode = ResponseCode.Success;
            IsSuccess = true;
            Message = ResponseCode.Success.GetEnumDescription();
            return this;
        }
        public ResponseVM<T> Success(T data)
        {
            ResponseCode = ResponseCode.Success;
            IsSuccess = true;
            Message = ResponseCode.Success.GetEnumDescription();
            Data = data;
            return this;
        }

        public ResponseVM<T> Fail(ResponseCode responseCode)
        {
            ResponseCode = responseCode;
            IsSuccess = false;
            Message = responseCode.GetEnumDescription();
            return this;
        }
    }
}
