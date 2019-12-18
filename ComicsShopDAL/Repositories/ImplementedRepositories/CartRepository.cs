using ComicsShopDAL.Data;
using ComicsShopDAL.Models;
using ComicsShopDAL.Repositories.InterfaceRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComicsShopDAL.Repositories.ImplementedRepositories
{
    public class CartRepository:BaseRepository<Cart>,ICartRepository
    {
        public CartRepository(ApplicationDbContext context):base(context)
        {

        }
    }
}
