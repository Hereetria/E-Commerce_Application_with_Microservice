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
    public class UpdateOrderingCommandHandler : GenericHandler<Ordering>, IRequestHandler<UpdateOrderingCommand>
    {
        public UpdateOrderingCommandHandler(IRepository<Ordering> repository, IMapper mapper) 
            : base(repository, mapper)
        {
        }

        public async Task Handle(UpdateOrderingCommand request, CancellationToken cancellationToken)
        {
            var values = _mapper.Map<Ordering>(request);
            await _repository.UpdateAsync(values);
        }
    }
}
