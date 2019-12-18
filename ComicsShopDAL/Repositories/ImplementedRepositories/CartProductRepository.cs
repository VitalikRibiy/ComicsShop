using ComicsShopDAL.Data;
using ComicsShopDAL.Models;
using ComicsShopDAL.Repositories.InterfaceRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComicsShopDAL.Repositories.ImplementedRepositories
{
    public class CartProductRepository:BaseRepository<CartProduct>,ICartProductRepository
    {
        public CartProductRepository(ApplicationDbContext context):base(context)
        {

        }
    }
}
