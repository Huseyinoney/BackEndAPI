using AutoMapper;
using BackEndAPI.Application.UnitOfWorks;
using BackEndAPI.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEndAPI.Application.Features.EntityFeatures.Query.GetEntity
{
    public class GetEntityQueryHandler : IRequestHandler<GetEntityQueryRequest, GetEntityQueryResponse>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public GetEntityQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        public async Task<GetEntityQueryResponse> Handle(GetEntityQueryRequest request, CancellationToken cancellationToken)
        {
            var entity = await unitOfWork.GetReadRepository<Entity>().GetAsync(x => x.Name == request.Name);

            return mapper.Map<GetEntityQueryResponse>(entity);

        }
    }
}
