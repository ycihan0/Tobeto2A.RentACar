using Application.Services.Repositories;
using Domain.Entities;
using NArchitecture.Core.Application.Rules;
using NArchitecture.Core.CrossCuttingConcerns.Exception.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Fuels.Rules;
public class ModelBusinessRules : BaseBusinessRules
{
    private readonly IFuelRepository _fuelRepository;

    public ModelBusinessRules(IFuelRepository fuelRepository)
    {
        _fuelRepository = fuelRepository;
    }
    public async Task CarShouldNotExistsWithSameName(string name)
    {
        Fuel? fuelWithSameName = await _fuelRepository.GetAsync(b => b.Name == name);
        if (fuelWithSameName is not null)
            throw new BusinessException("Aynı isme sahip bir marka zaten mevcuttur");
    }
}
