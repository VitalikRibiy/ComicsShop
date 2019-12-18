using ComicsShopDAL.Models.Abstraction;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ComicsShopDAL.Models
{
    public partial class CartProduct : IBaseEntity
    {
        [Key]
        public int Id { get; set; }
        public int? CartId { get; set; }
        public int? ProductId { get; set; }
        public int? Amount { get; set; }
    }
}
