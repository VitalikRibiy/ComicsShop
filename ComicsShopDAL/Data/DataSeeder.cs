using ComicsShopDAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComicsShopDAL.Data
{
    public class DataSeeder
    {
        private ApplicationDbContext applicationDbContext;
        public DataSeeder(ApplicationDbContext context)
        {
            applicationDbContext = context;
            for (int i = 0; i < 20; i++)
            {
                var product=new Product() { Title=$"Product {i+1}",
                                ImgUrl= "https://thequestion.s3.eu-central-1.amazonaws.com/179/586242-6e7483ef.png",
                                Franchize=$"Franchize {i+1}",
                                Desctiption = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."
                };
                applicationDbContext.Products.Add(product);
            }
        }
    }
}
