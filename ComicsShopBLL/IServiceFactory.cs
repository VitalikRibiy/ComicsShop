using ComicsShopBLL.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComicsShopBLL
{
    public interface IServiceFactory
    {
        public IProductService ProductService { get; set; }
    }
}
