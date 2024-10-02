using AutoMapper;
using MediatR;
using MultiShop.Order.Application.Features.CQRS.Commands.AddressCommands;
using MultiShop.Order.Application.Features.CQRS.Commands.OrderDetailCommands;
using MultiShop.Order.Application.Features.CQRS.Handlers.GenericHandler;
using MultiShop.Order.Application.Interfaces;
using MultiShop.Order.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Order.Application.Features.CQRS.Handlers.OrderDetailHandlers.CommandHandlers
{
    public class CreateOrderDetailCommandHandler : GenericHandler<OrderDetail>, IRequestHandler<CreateOrderDetailCommand>
    {
        public CreateOrderDetailCommandHandler(IRepository<OrderDetail> repository, IMapper mapper) 
            : base(repository, mapper)
        {
        }

        public async Task Handle(CreateOrderDetailCommand request, CancellationToken cancellationToken)
        {
            var values = _mapper.Map<OrderDetail>(request);
            await _repository.CreateAsync(values);
        }
    }
}
