using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaTime.Common
{
    public enum ResponseCode
    {
        [Description("成功")]
        Success = 200,
        [Description("查無此資料")]
        NotFound = 404,
        [Description("登入失敗")]
        LoginFail = 999,
    }
}
