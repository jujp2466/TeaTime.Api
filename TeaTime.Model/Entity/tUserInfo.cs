using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeaTime.Model.Entity
{
    public class tUserInfo
    {
        /// <summary>
        /// 員編
        /// </summary>
        [Key]
        public int EmployeeId { get; set; } 

        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 分機
        /// </summary>
        public string Ext { get; set; }

        /// <summary>
        /// 信箱
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 食物品項
        /// </summary>
        public List<string> FoodItems { get; set; }
    }
}
