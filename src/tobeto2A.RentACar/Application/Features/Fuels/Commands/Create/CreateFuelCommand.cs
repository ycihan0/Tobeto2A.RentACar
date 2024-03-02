using Application.Features.Fuels.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Application.Features.Fuels.Commands.Create;
public class CreateModelCommand : IRequest<CreatedModelResponse>
{
    public string Name { get; set; }

    public class CreateFuelCommandHandler : IRequestHandler<CreateModelCommand, CreatedModelResponse>
    {
        private readonly IFuelRepository _fuelRepository;
        private readonly IMapper _mapper;
        private readonly ModelBusinessRules _fuelBusinessRules;

        public CreateFuelCommandHandler(IFuelRepository fuelRepository)
        {
            _fuelRepository = fuelRepository;
        }

        public async Task<CreatedModelResponse> Handle(CreateModelCommand request, CancellationToken cancellationToken)
        {
            await _fuelBusinessRules.CarShouldNotExistsWithSameName(request.Name);
            Fuel fuel = _mapper.Map<Fuel>(request);

            Fuel addedFuel = await _fuelRepository.AddAsync(fuel);
            CreatedModelResponse createdFuelResponse = _mapper.Map<CreatedModelResponse>(addedFuel);
            return createdFuelResponse;
        }
    }
}
