using AutoMapper;
using ComicsShopBLL.DTO_s;
using ComicsShopDAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComicsShopBLL.Mappers
{
    public class ProductProfile:Profile
    {
        public ProductProfile()
        {
            CreateMap<ProductDTO, Product>()
                .ForMember(p => p.Id, opt => opt.MapFrom(p => p.Id))
                .ForMember(p => p.Title, opt => opt.MapFrom(p => p.Title))
                .ForMember(p => p.Franchize, opt => opt.MapFrom(p => p.Franchize))
                .ForMember(p => p.ImgUrl, opt => opt.MapFrom(p => p.ImgUrl))
                .ForMember(p => p.Desctiption, opt => opt.MapFrom(p => p.Desctiption));
            CreateMap<Product, ProductDTO>()
                .ForMember(p => p.Id, opt => opt.MapFrom(p => p.Id))
                .ForMember(p => p.Title, opt => opt.MapFrom(p => p.Title))
                .ForMember(p => p.Franchize, opt => opt.MapFrom(p => p.Franchize))
                .ForMember(p => p.ImgUrl, opt => opt.MapFrom(p => p.ImgUrl))
                .ForMember(p => p.Desctiption, opt => opt.MapFrom(p => p.Desctiption));
        }
    }
}
