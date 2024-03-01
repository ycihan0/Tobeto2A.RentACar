﻿using Application.Services.Repositories;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Brands.Commands.Create;
public class CreateBrandCommand:IRequest<CreatedBrandResponse>
{
    //Kullanıcının vermesi gereken bilgiler
    public string Name { get; set; }
    public string Logo { get; set; }

    //Inner class
    public class CreateBrandCommandHandler : IRequestHandler<CreateBrandCommand ,CreatedBrandResponse>
    {
        private readonly IBrandRepository _brandRepository;

        public CreateBrandCommandHandler(IBrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }

        public async Task<CreatedBrandResponse> Handle(CreateBrandCommand request, CancellationToken cancellationToken)
        {
            Brand brand = new();
            brand.Name = request.Name;
            brand.Logo = request.Logo;
             
            Brand addedBrand=await _brandRepository.AddAsync(brand);

            CreatedBrandResponse createdBrandResponse = new();
            createdBrandResponse.Name = addedBrand.Name;
            createdBrandResponse.Logo = addedBrand.Logo;
            createdBrandResponse.Id = addedBrand.Id;
            return createdBrandResponse;
        } 
    }
}
