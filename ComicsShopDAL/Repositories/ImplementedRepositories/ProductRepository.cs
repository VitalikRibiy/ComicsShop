using ComicsShopDAL.Data;
using ComicsShopDAL.Models;
using ComicsShopDAL.Repositories.InterfaceRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComicsShopDAL.Repositories.ImplementedRepositories
{
    public class ProductRepository:BaseRepository<Product>,IProductRepository
    {
        public ProductRepository(ApplicationDbContext context):base(context)
        {

        }
    }
}
