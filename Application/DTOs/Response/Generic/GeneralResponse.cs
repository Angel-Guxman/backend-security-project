using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Response.Generic
{
    public record GeneralResponse(bool Flag = false, string? Message = null);

}
