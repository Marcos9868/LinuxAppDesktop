using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public sealed record ProjectDTO(Guid Id, string Name);
}