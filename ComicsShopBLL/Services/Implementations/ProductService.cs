using AutoMapper;
using ComicsShopBLL.DTO_s;
using ComicsShopBLL.Services.Interfaces;
using ComicsShopDAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ComicsShopDAL.UnitOfWork;

namespace ComicsShopBLL.Services.Implementations
{
    public class ProductService : IProductService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public ProductService(
            IMapper mapper,
            IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        public async Task<ProductDTO> CreateAsync(ProductDTO dto)
        {
            try
            {
                Product teacher = _mapper.Map<Product>(dto);
                var res = await _unitOfWork.ProductsRepository.AddAsync(teacher);
                return _mapper.Map<Product, ProductDTO>(res);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task DeleteAsync(int id)
        {
            Product teacher = await _unitOfWork.ProductsRepository.GetByIdAsync(id);
            await _unitOfWork.ProductsRepository.RemoveAsync(teacher);
        }

        public async Task<IEnumerable<ProductDTO>> GetAllAsync()
        {
            List<Product> source = await _unitOfWork.ProductsRepository.GetAllAsync();
            List<ProductDTO> res = new List<ProductDTO>();
            source.ForEach(x => res.Add(_mapper.Map<Product, ProductDTO>(x)));
            return res;
        }

        public async Task<ProductDTO> GetAsync(int id)
        {
            var res = await _unitOfWork.ProductsRepository.GetByIdAsync(id);
            return _mapper.Map<Product, ProductDTO>(res);
        }

        public async Task<IEnumerable<ProductDTO>> GetRangeAsync(uint offset, uint amount)
        {
            List<Product> source = await _unitOfWork.ProductsRepository.GetRangeAsync(offset, amount);
            List<ProductDTO> res = new List<ProductDTO>();
            source.ForEach(x => res.Add(_mapper.Map<Product, ProductDTO>(x)));
            return res;
        }

        public Task<IEnumerable<ProductDTO>> SearchAsync(string search)
        {
            throw new NotImplementedException();
        }

        public async Task<ProductDTO> UpdateAsync(ProductDTO dto)
        {
            Product teacher = _mapper.Map<Product>(dto);
            _unitOfWork.ProductsRepository.Update(teacher);
            return _mapper.Map<Product, ProductDTO>(await _unitOfWork.ProductsRepository.GetByIdAsync(teacher.Id));
        }
    }
}
