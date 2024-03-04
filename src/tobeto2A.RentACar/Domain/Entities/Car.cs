using NArchitecture.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;
public class Car : Entity<Guid>
{
    public string Name { get; set; }
    public Guid BrandId { get; set; }
    public int MyProperty { get; set; }
}
