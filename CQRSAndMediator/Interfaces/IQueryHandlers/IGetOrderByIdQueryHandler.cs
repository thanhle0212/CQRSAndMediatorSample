using CQRSAndMediator.RequestModels.QueryRequestModels;
using CQRSAndMediator.ResponseModels.QueryResponseModels;

namespace CQRSAndMediator.Interfaces.IQueryHandlers
{
    public interface IGetOrderByIdQueryHandler
    {
        GetOrderByIdResponseModel GetOrderById(GetOrderByIdRequestModel requestModel);
    }
}
