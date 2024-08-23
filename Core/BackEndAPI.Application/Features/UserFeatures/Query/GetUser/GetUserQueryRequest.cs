using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndAPI.Application.Features.UserFeatures.Query.GetUser
{
    public class GetUserQueryRequest :IRequest<GetUserQueryResponse>
    {
        public string Name { get; set; }
    }
}
