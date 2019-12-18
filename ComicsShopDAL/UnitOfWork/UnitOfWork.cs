using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using ComicsShopDAL.Data;
using ComicsShopDAL.Models;
using ComicsShopDAL.Repositories;

namespace ComicsShopDAL.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public IBaseRepository<Product> ProductsRepository { get; set ; }
        public IBaseRepository<Cart> CartsRepository { get; set; }
        public IBaseRepository<Order> OrdersRepository { get; set; }
        public IBaseRepository<CartProduct> CartProductsRepository { get; set; }
        public IBaseRepository<OrderProduct> OrderProductsRepository { get; set; }

        public Task<int> SaveAsync()
        {
            return _context.SaveChangesAsync();
        }
    }
}
