﻿using Application.Features.Brands.Constants;
using Application.Features.Brands.Rules;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;
using NArchitecture.Core.Application.Pipelines.Authorization;
using NArchitecture.Core.Application.Pipelines.Logging;
using NArchitecture.Core.Application.Pipelines.Performance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Brands.Commands.Create;
public class CreateBrandCommand:IRequest<CreatedBrandResponse>, ISecuredRequest, ILoggableRequest, IIntervalRequest
{
    //Kullanıcının vermesi gereken bilgiler
    public string Name { get; set; }
    public string Logo { get; set; }
    public string[] Roles => new string[] { BrandsOperationClaims.Write, BrandsOperationClaims.Create };
    public int Interval => 3;

    //Inner class
    public class CreateBrandCommandHandler : IRequestHandler<CreateBrandCommand ,CreatedBrandResponse>
    {
        private readonly IBrandRepository _brandRepository;
        private readonly IMapper _mapper;
        private readonly BrandBusinessRules _brandBusinessRules;

        public CreateBrandCommandHandler(IBrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }

        public async Task<CreatedBrandResponse> Handle(CreateBrandCommand request, CancellationToken cancellationToken)
        {
            await Task.Delay(5000);
            await _brandBusinessRules.CarShouldNotExistsWithSameName(request.Name);

            //Brand brand = new();
            //brand.Name = request.Name;
            //brand.Logo = request.Logo;
            Brand brand = _mapper.Map<Brand>(request);//yukarıdakilerin yerine kolayca maple

            Brand addedBrand=await _brandRepository.AddAsync(brand);

            //CreatedBrandResponse createdBrandResponse = new();
            //createdBrandResponse.Name = addedBrand.Name;
            //createdBrandResponse.Logo = addedBrand.Logo;
            //createdBrandResponse.Id = addedBrand.Id;
            CreatedBrandResponse createdBrandResponse = _mapper.Map<CreatedBrandResponse>(addedBrand);
            return createdBrandResponse;
        } 
    }
}
