using AutoMapper;
using ComicsShopBLL.DTO_s;
using ComicsShopDAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComicsShopBLL.Mappers
{
    public class CartProductProfile:Profile
    {
        public CartProductProfile()
        {
            CreateMap<CartProductDTO, CartProduct>()
                .ForMember(p => p.Id, opt => opt.MapFrom(p => p.Id))
                .ForMember(p => p.CartId, opt => opt.MapFrom(p => p.CartId))
                .ForMember(p => p.ProductId, opt => opt.MapFrom(p => p.ProductId))
                .ForMember(p => p.Amount, opt => opt.MapFrom(p => p.Amount));
            CreateMap<CartProduct, CartProductDTO>()
                .ForMember(p => p.Id, opt => opt.MapFrom(p => p.Id))
                .ForMember(p => p.CartId, opt => opt.MapFrom(p => p.CartId))
                .ForMember(p => p.ProductId, opt => opt.MapFrom(p => p.ProductId))
                .ForMember(p => p.Amount, opt => opt.MapFrom(p => p.Amount));
        }
    }
}
