using AutoMapper;
using MediatR;
using MultiShop.Order.Application.Features.CQRS.Handlers.GenericHandler;
using MultiShop.Order.Application.Features.CQRS.Queries.AddressQueries;
using MultiShop.Order.Application.Features.CQRS.Results.AddressResults;
using MultiShop.Order.Application.Interfaces;
using MultiShop.Order.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Order.Application.Features.CQRS.Handlers.AddressHandlers
{
    public class GetAddressQueryHandler : GenericHandler<Address>, IRequestHandler<GetAddressQuery,List<GetAddressQueryResult>>
    {
        public GetAddressQueryHandler(IRepository<Address> repository, IMapper mapper) 
            : base(repository, mapper)
        {
        }

        public async Task<List<GetAddressQueryResult>> Handle(GetAddressQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            var queryResult = _mapper.Map<List<GetAddressQueryResult>>(values);
            return queryResult;
        }
    }
}
