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
    public class RemoveOrderDetailCommandHandler : GenericHandler<OrderDetail>, IRequestHandler<RemoveOrderDetailCommand>
    {
        public RemoveOrderDetailCommandHandler(IRepository<OrderDetail> repository, IMapper mapper) 
            : base(repository, mapper)
        {
        }

        public async Task Handle(RemoveOrderDetailCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            await _repository.DeleteAsync(value);
        }
    }
}
