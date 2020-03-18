using System;

namespace CQRSAndMediator.ResponseModels.CommandResponseModels
{
    public class MakeOrderResponseModel
    {
        public bool IsSuccess { get; set; }
        public Guid OrderId { get; set; }
    }
}
