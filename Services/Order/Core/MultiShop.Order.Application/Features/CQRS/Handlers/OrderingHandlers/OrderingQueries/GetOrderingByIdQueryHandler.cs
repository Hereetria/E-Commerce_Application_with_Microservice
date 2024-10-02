using AutoMapper;
using MediatR;
using MultiShop.Order.Application.Features.CQRS.Handlers.GenericHandler;
using MultiShop.Order.Application.Features.CQRS.Queries.OrderingQueries;
using MultiShop.Order.Application.Features.CQRS.Results.OrderingResults;
using MultiShop.Order.Application.Interfaces;
using MultiShop.Order.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Order.Application.Features.CQRS.Handlers.OrderingHandlers.OrderingQueries
{
    public class GetOrderingByIdQueryHandler : GenericHandler<Ordering>, IRequestHandler<GetOrderingByIdQuery, GetOrderingByIdQueryResult>
    {
        public GetOrderingByIdQueryHandler(IRepository<Ordering> repository, IMapper mapper) 
            : base(repository, mapper)
        {
        }

        public async Task<GetOrderingByIdQueryResult> Handle(GetOrderingByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            var queryResult = _mapper.Map<GetOrderingByIdQueryResult>(values);
            return queryResult;
        }
    }
}
