using AutoMapper;
using MediatR;
using MultiShop.Order.Application.Features.CQRS.Commands.AddressCommands;
using MultiShop.Order.Application.Features.CQRS.Handlers.GenericHandler;
using MultiShop.Order.Application.Interfaces;
using MultiShop.Order.Domain.Entities;

namespace MultiShop.Order.Application.Features.CQRS.Handlers.AddressHandlers.CommandHandlers
{
    public class UpdateAddressCommandHandler : GenericHandler<Address>, IRequestHandler<UpdateAddressCommand>
    {
        public UpdateAddressCommandHandler(IRepository<Address> repository, IMapper mapper) 
            : base(repository, mapper)
        {
        }

        public async Task Handle(UpdateAddressCommand request, CancellationToken cancellationToken)
        {
            var values = _mapper.Map<Address>(request);
            await _repository.UpdateAsync(values);
        }
    }
}
