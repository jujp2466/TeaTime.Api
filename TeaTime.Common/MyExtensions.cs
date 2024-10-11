using System.ComponentModel;
using System.Reflection;

namespace TeaTime.Common
{
    public static class MyExtensions
    {
        public static string GetEnumDescription(this Enum value)
        {
            FieldInfo fieldInfo = value.GetType().GetField(value.ToString());

            DescriptionAttribute[] attributes = (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);
            //若取不到屬性，則取名稱
            if ((attributes != null) && (attributes.Length > 0))
                return attributes[0].Description;
            else
                return value.ToString();
        }
    }
}
