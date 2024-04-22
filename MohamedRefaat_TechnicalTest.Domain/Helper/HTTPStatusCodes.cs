using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MohamedRefaat_TechnicalTest.Domain.Helper
{
    public enum HTTPStatusCodes
    {
        Success = 200,
        NotFound = 404,
        BadRequest = 400,
        Error = 500,
        Created = 201,
        Updated = 204
    }
}
