using System;
using CQRSAndMediator.ResponseModels.QueryResponseModels;
using MediatR;

namespace CQRSAndMediator.RequestModels.QueryRequestModels
{
    public class GetOrderByIdRequestModel : IRequest<GetOrderByIdResponseModel>
    {
        public Guid OrderId { get; set; }
    }
}
