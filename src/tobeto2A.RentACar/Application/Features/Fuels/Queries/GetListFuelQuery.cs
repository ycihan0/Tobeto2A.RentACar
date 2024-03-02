using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using NArchitecture.Core.Application.Requests;
using NArchitecture.Core.Application.Responses;
using NArchitecture.Core.Persistence.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Fuels.Queries;
public class GetListModelQuery : IRequest<GetListResponse<GetListModelItemDto>>
{
    public PageRequest PageRequest { get; set; }
    public class GetListFuelQueryHandler : IRequestHandler<GetListModelQuery, GetListResponse<GetListModelItemDto>>
    {
        private readonly IFuelRepository _fuelRepository;
        private readonly IMapper _mapper;
        public async Task<GetListResponse<GetListModelItemDto>> Handle(GetListModelQuery request, CancellationToken cancellationToken)
        {
            IPaginate<Fuel> fuels = await _fuelRepository.GetListAsync(index: request.PageRequest.PageIndex, size: request.PageRequest.PageSize);
            GetListResponse<GetListModelItemDto> response = _mapper.Map<GetListResponse<GetListModelItemDto>>(fuels);
            return response;
        }
    }
}
