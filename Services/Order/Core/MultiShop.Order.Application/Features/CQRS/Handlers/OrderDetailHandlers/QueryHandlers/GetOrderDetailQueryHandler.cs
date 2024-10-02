using AutoMapper;
using MediatR;
using MultiShop.Order.Application.Features.CQRS.Handlers.GenericHandler;
using MultiShop.Order.Application.Features.CQRS.Queries.OrderDetailQueries;
using MultiShop.Order.Application.Features.CQRS.Results.OrderDetailResults;
using MultiShop.Order.Application.Interfaces;
using MultiShop.Order.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Order.Application.Features.CQRS.Handlers.OrderDetailHandlers.QueryHandlers
{
    public class GetOrderDetailQueryHandler : GenericHandler<OrderDetail>, IRequestHandler<GetOrderDetailQuery, List<GetOrderDetailQueryResult>>
    {
        public GetOrderDetailQueryHandler(IRepository<OrderDetail> repository, IMapper mapper) 
            : base(repository, mapper)
        {
        }

        public async Task<List<GetOrderDetailQueryResult>> Handle(GetOrderDetailQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            var queryResults = _mapper.Map<List<GetOrderDetailQueryResult>>(values);
            return queryResults;
        }
    }
}
