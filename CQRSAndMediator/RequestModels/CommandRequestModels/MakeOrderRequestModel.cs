using System;
using CQRSAndMediator.ResponseModels.CommandResponseModels;
using MediatR;

namespace CQRSAndMediator.RequestModels.CommandRequestModels
{
    public class MakeOrderRequestModel : IRequest<MakeOrderResponseModel>
    {
        public Guid OrderId { get; set; }
        public string OrderName { get; set; }
        public DateTime DateOrder { get; set; }
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public double Amount { get; set; }
        public Guid OrderPersonId { get; set; }
    }
}
