using CQRSAndMediator.RequestModels.CommandRequestModels;
using CQRSAndMediator.ResponseModels.CommandResponseModels;

namespace CQRSAndMediator.Interfaces.ICommandHandlers
{
    public interface IMakeOrderCommandHandler
    {
        MakeOrderResponseModel MakeOrder(MakeOrderRequestModel requestModel);
    }
}
