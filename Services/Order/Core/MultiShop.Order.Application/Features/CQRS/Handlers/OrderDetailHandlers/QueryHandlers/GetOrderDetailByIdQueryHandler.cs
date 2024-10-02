using AutoMapper;
using MediatR;
using MultiShop.Order.Application.Features.CQRS.Handlers.GenericHandler;
using MultiShop.Order.Application.Features.CQRS.Queries.OrderDetailQueries;
using MultiShop.Order.Application.Features.CQRS.Results.AddressResults;
using MultiShop.Order.Application.Features.CQRS.Results.OrderDetailResults;
using MultiShop.Order.Application.Interfaces;
using MultiShop.Order.Domain.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Order.Application.Features.CQRS.Handlers.OrderDetailHandlers.Queries
{
    public class GetOrderDetailByIdQueryHandler : GenericHandler<OrderDetail>, IRequestHandler<GetOrderDetailByIdQuery, GetOrderDetailByIdQueryResult>
    {
        public GetOrderDetailByIdQueryHandler(IRepository<OrderDetail> repository, IMapper mapper)
            : base(repository, mapper)
        {
        }

        public async Task<GetOrderDetailByIdQueryResult> Handle(GetOrderDetailByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            var queryResult = _mapper.Map<GetOrderDetailByIdQueryResult>(values);
            return queryResult;
        }
    }
}
