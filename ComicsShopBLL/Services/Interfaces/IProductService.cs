using ComicsShopBLL.DTO_s;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ComicsShopBLL.Services.Interfaces
{
    public interface IProductService : ICrudService<ProductDTO>
    {
        public Task<IEnumerable<ProductDTO>> GetAllAsync();
    }
}
