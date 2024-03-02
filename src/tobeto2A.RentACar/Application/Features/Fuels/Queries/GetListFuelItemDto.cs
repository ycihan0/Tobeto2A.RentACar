using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Fuels.Queries;
public class GetListModelItemDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
}
