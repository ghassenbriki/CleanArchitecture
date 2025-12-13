using AutoMapper;
using CleanArchitecture.application.Feature.productFeature.request.commands;
using CleanArchitecture.application.IRepository;
using CleanArchitecture.application.Responses;
using CleanArchitecture.domain;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.application.Feature.productFeature.handlers.commands
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, CommandResult>
    {
        private readonly IMapper _mapper;
        private readonly IproductRepository _productRepository;
        public CreateProductCommandHandler(IMapper mapper,IproductRepository productRepository)
        {
            _mapper = mapper;
            _productRepository = productRepository;
        }
        public async Task<CommandResult> Handle(CreateProductCommand command, CancellationToken ctn)
        {
            var response = new CommandResult();

            try
            {
                var product = _mapper.Map<Product>(command.productDto);

                var resProduct = await _productRepository.AddProduct(product);

                if (resProduct == null)
                {
                    response.Message = "Failed to add product.";
                    response.Errors = new List<string> { "Repository returned null." };
                    return response;
                }

                response.Message = "Product added successfully";
                response.Errors = null;

                return response;
            }
            catch (Exception ex)
            {
                return new CommandResult
                {
                    Message = "An unexpected error occurred.",
                    Errors = new List<string> { ex.Message }
                };
            }
        }
    }

}
