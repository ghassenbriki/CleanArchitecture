using CleanArchitecture.application.DTO;
using CleanArchitecture.application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.application.Feature.productFeature.request.queries
{
    public class GetProductRequest : IRequest<QueryResultObj<ProductDto>>
    {
        public int id {  get; set; }    
    }
}
