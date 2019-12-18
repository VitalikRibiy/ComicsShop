using ComicsShopDAL.Models.Abstraction;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ComicsShopDAL.Models
{
    public partial class OrderProduct : IBaseEntity
    {
        [Key]
        public int Id { get; set; }
        public int? OrderId { get; set; }
        public int? CartProductId { get; set; }
    }
}
