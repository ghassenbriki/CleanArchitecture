using AutoMapper;
using CleanArchitecture.application.DTO;
using CleanArchitecture.application.Feature.productFeature.request.queries;
using CleanArchitecture.application.IRepository;
using CleanArchitecture.application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.application.Feature.productFeature.handlers.queries
{
    public class GetProductRequestHandler : IRequestHandler<GetProductRequest, QueryResultObj<ProductDto>>


    {
        private readonly IMapper _mapper;
        private readonly IproductRepository _productRepository;
        public GetProductRequestHandler(IMapper mapper, IproductRepository productRepository)
        {
            _mapper = mapper;
            _productRepository = productRepository;
        }
        public async Task<QueryResultObj<ProductDto>> Handle(GetProductRequest request , CancellationToken ctn)
        {
            try
            {
                var p = await _productRepository.GetProduct(request.id);
                return new QueryResultObj<ProductDto> { Item = _mapper.Map<ProductDto>(p) };
            }
            catch (Exception ex)
            {
                return new QueryResultObj<ProductDto> { Errors = new List<string>() {ex.Message } };
            }
        }
    }
}
