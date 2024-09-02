using PayStackTesting.Dtos;
using PayStackTesting.Dtos.RequestModel;
using PayStackTesting.Dtos.ResponseModel;

namespace PayStackTesting.Implemetation.Services
{
    public interface IPaystackService
    {
        Task<BaseResponse<InitializePaymentResponseDto>> InitializePaymentAsync(InitializePaymentRequestDto requestDto);
        Task<BaseResponse<VerifyPaymentRequestDto>> VerifyPaymentAsync(string reference);
    }
}
