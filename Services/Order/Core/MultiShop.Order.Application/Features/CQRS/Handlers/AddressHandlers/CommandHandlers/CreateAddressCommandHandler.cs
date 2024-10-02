using AutoMapper;
using MediatR;
using MultiShop.Order.Application.Features.CQRS.Commands.AddressCommands;
using MultiShop.Order.Application.Features.CQRS.Handlers.GenericHandler;
using MultiShop.Order.Application.Interfaces;
using MultiShop.Order.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Order.Application.Features.CQRS.Handlers.AddressHandlers.CommandHandlers
{
    public class CreateAddressCommandHandler : GenericHandler<Address>, IRequestHandler<CreateAddressCommand>
    {
        public CreateAddressCommandHandler(IRepository<Address> repository, IMapper mapper)
            : base(repository, mapper)
        {
        }

        public async Task Handle(CreateAddressCommand request, CancellationToken cancellationToken)
        {
            var values = _mapper.Map<Address>(request);
            await _repository.CreateAsync(values);
        }
    }
}
