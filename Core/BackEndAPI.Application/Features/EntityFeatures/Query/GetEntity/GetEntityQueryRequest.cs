using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndAPI.Application.Features.EntityFeatures.Query.GetEntity
{
    public class GetEntityQueryRequest : IRequest<GetEntityQueryResponse>
    {
        public string Name { get; set; }
    }
}
