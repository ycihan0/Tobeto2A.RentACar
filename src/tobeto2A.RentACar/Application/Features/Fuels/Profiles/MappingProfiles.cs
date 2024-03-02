using Application.Features.Fuels.Commands.Create;
using Application.Features.Fuels.Queries;
using AutoMapper;
using Domain.Entities;
using NArchitecture.Core.Application.Responses;
using NArchitecture.Core.Persistence.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Fuels.Profiles;
public class MappingProfiles:Profile
{
    public MappingProfiles()
    {
        CreateMap<Fuel, CreateModelCommand>().ReverseMap();
        CreateMap<Fuel, CreatedModelResponse>().ReverseMap();
        CreateMap<Fuel, GetListModelItemDto>().ReverseMap();
        CreateMap<IPaginate<Fuel>, GetListResponse<GetListModelItemDto>>().ReverseMap();
    }


}
