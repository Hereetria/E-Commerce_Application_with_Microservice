using AutoMapper;
using MultiShop.Order.Application.Features.CQRS.Commands.AddressCommands;
using MultiShop.Order.Application.Features.CQRS.Commands.OrderDetailCommands;
using MultiShop.Order.Application.Features.CQRS.Commands.OrderingCommands;
using MultiShop.Order.Application.Features.CQRS.Results.AddressResults;
using MultiShop.Order.Application.Features.CQRS.Results.OrderDetailResults;
using MultiShop.Order.Application.Features.CQRS.Results.OrderingResults;
using MultiShop.Order.Application.Features.Mediator.Results.OrderingResults;
using MultiShop.Order.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Order.Application.Mapping
{
    public class GeneralMapping : Profile
    {

        public GeneralMapping()
        {
            CreateMap<Address, GetAddressQueryResult>().ReverseMap();
            CreateMap<Address, CreateAddressCommand>().ReverseMap();
            CreateMap<Address, UpdateAddressCommand>().ReverseMap();
            CreateMap<Address, GetAddressByIdQueryResult>().ReverseMap();

            CreateMap<OrderDetail, GetOrderDetailQueryResult>().ReverseMap();
            CreateMap<OrderDetail, CreateOrderDetailCommand>().ReverseMap();
            CreateMap<OrderDetail, UpdateOrderDetailCommand>().ReverseMap();
            CreateMap<OrderDetail, GetOrderDetailByIdQueryResult>().ReverseMap();

            CreateMap<Ordering, GetOrderingQueryResult>().ReverseMap();
            CreateMap<Ordering, CreateOrderingCommand>().ReverseMap();
            CreateMap<Ordering, UpdateOrderingCommand>().ReverseMap();
            CreateMap<Ordering, GetOrderingByUserIdQueryResult>().ReverseMap();
        }
    }
}
