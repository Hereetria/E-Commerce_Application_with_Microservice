using AutoMapper;
using MediatR;
using MultiShop.Order.Application.Features.CQRS.Handlers.GenericHandler;
using MultiShop.Order.Application.Features.CQRS.Queries.AddressQueries;
using MultiShop.Order.Application.Features.CQRS.Results.AddressResults;
using MultiShop.Order.Application.Interfaces;
using MultiShop.Order.Domain.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Order.Application.Features.CQRS.Handlers.AddressHandlers
{
    public class GetAddressByIdQueryHandler : GenericHandler<Address>, IRequestHandler<GetAddressByIdQuery, GetAddressByIdQueryResult>
    {
        public GetAddressByIdQueryHandler(IRepository<Address> repository, IMapper mapper) 
            : base(repository, mapper)
        {
        }

        public async Task<GetAddressByIdQueryResult> Handle(GetAddressByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            var queryResult = _mapper.Map<GetAddressByIdQueryResult>(values);
            return queryResult;
        }
    }
}
