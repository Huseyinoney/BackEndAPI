using AutoMapper;
using BackEndAPI.Application.Services;
using BackEndAPI.Application.UnitOfWorks;
using BackEndAPI.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Tensorflow;

namespace BackEndAPI.Application.Features.EntityFeatures.Query.GetEntity
{
    public class GetEntityQueryHandler : IRequestHandler<GetEntityQueryRequest, GetEntityQueryResponse>
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        private readonly IKerasEntity kerasEntity;

        public GetEntityQueryHandler(IUnitOfWork unitOfWork, IMapper mapper, IKerasEntity kerasEntity)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
            this.kerasEntity = kerasEntity;
        }
        public async Task<GetEntityQueryResponse> Handle(GetEntityQueryRequest request, CancellationToken cancellationToken)
        {
            //model will add here 
            //kerasEntity.FindEntityFromModel("imagePathWillAddHere");
            var entity = await unitOfWork.GetReadRepository<Entity>().GetAsync(x => x.Name == request.Name);
            if(entity is null)
            {
                return null;    
            }
            return mapper.Map<GetEntityQueryResponse>(entity);

        }
    }
}
