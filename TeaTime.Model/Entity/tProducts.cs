namespace TeaTime.Model.Entity
{
    /// <summary>
    /// 商品表格
    /// </summary>
    public class tProducts
    {
        /// <summary>
        /// 商品編號
        /// </summary>
        public int Pid { get; set; }

        /// <summary>
        /// 商品名稱
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// 商品數量
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// 價格
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// 購買次數
        /// </summary>
        public int Frequency { get; set; }
    }
}