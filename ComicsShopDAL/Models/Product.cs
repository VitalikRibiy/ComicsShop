using ComicsShopDAL.Models.Abstraction;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ComicsShopDAL.Models
{
    public partial class Product : IBaseEntity
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Desctiption { get; set; }
        public string ImgUrl { get; set; }
        public string Franchize { get; set; }
    }
}
