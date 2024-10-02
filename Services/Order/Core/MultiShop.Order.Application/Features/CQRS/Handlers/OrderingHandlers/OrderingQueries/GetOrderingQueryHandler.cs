using AutoMapper;
using MediatR;
using MultiShop.Order.Application.Features.CQRS.Handlers.GenericHandler;
using MultiShop.Order.Application.Features.CQRS.Queries.OrderingQueries;
using MultiShop.Order.Application.Features.CQRS.Results.AddressResults;
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
    public class GetOrderingQueryHandler : GenericHandler<Ordering>, IRequestHandler<GetOrderingQuery, List<GetOrderingQueryResult>>
    {
        public GetOrderingQueryHandler(IRepository<Ordering> repository, IMapper mapper) 
            : base(repository, mapper)
        {
        }

        public async Task<List<GetOrderingQueryResult>> Handle(GetOrderingQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            var queryResult = _mapper.Map<List<GetOrderingQueryResult>>(values);
            return queryResult;
        }
    }
}
