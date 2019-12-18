using AutoMapper;
using ComicsShopBLL.DTO_s;
using ComicsShopDAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComicsShopBLL.Mappers
{
    public class CartProfile:Profile
    {
        public CartProfile()
        {
            CreateMap<CartDTO, Cart>()
               .ForMember(p => p.Id, opt => opt.MapFrom(p => p.Id))
               .ForMember(p => p.UserId, opt => opt.MapFrom(p => p.UserId));
        }
    }
}
