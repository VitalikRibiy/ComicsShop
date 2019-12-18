using System.Threading.Tasks;
using ComicsShopDAL.Models;
using ComicsShopDAL.Repositories;
using Microsoft.AspNetCore.Identity;

namespace ComicsShopDAL.UnitOfWork
{
    public interface IUnitOfWork 
    {
        public IBaseRepository<Product> ProductsRepository { get; set; }
        public IBaseRepository<Cart> CartsRepository { get; set; }
        public IBaseRepository<Order> OrdersRepository { get; set; }
        public IBaseRepository<CartProduct> CartProductsRepository { get; set; }
        public IBaseRepository<OrderProduct> OrderProductsRepository { get; set; }
        Task<int> SaveAsync();
    }
}
