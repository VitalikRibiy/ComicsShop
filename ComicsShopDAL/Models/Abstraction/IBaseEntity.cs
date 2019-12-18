using System;
using System.Collections.Generic;
using System.Text;

namespace ComicsShopDAL.Models.Abstraction
{
    public interface IBaseEntity
    {
        int Id { get; set; }
    }
}
