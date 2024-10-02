using AutoMapper;
using MediatR;
using MultiShop.Order.Application.Features.CQRS.Commands.OrderingCommands;
using MultiShop.Order.Application.Features.CQRS.Handlers.GenericHandler;
using MultiShop.Order.Application.Interfaces;
using MultiShop.Order.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Order.Application.Features.CQRS.Handlers.OrderingHandlers.OrderingCommands
{
    public class CreateOrderingCommandHandler : GenericHandler<Ordering>, IRequestHandler<CreateOrderingCommand>
    {
        public CreateOrderingCommandHandler(IRepository<Ordering> repository, IMapper mapper) 
            : base(repository, mapper)
        {
        }

        public Task Handle(CreateOrderingCommand request, CancellationToken cancellationToken)
        {
            var values = _mapper.Map<Ordering>(request);
            return _repository.CreateAsync(values);
        }
    }
}
