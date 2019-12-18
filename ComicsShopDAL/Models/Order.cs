using ComicsShopDAL.Models.Abstraction;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ComicsShopDAL.Models
{
    public partial class Order : IBaseEntity
    {
        [Key]
        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public int? UserId { get; set; }
    }
}
