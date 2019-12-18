using System;
using System.Collections.Generic;
using System.Text;

namespace ComicsShopBLL.DTO_s
{
    public class CartProductDTO
    {
        public int Id { get; set; }
        public int? CartId { get; set; }
        public int? ProductId { get; set; }
        public int? Amount { get; set; }
    }
}
