using RezaB.API.MobilExpress.Request;
using RezaB.API.MobilExpress.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RezaB.API.MobilExpress
{
    public class MobilExpressClient
    {
        private string MerchantKey { get; set; }

        private string APIPassword { get; set; }

        protected MobilExpressServiceReference.FastCheckoutServiceSoapClient InternalClient { get; set; }

        public MobilExpressClient(string merchantKey, string apiPassword)
        {
            MerchantKey = merchantKey;
            APIPassword = apiPassword;
            InternalClient = new MobilExpressServiceReference.FastCheckoutServiceSoapClient();
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
        }

        public MobilExpressResponseBase SaveCustomer(MobilExpressSaveCustomerRequest request)
        {
            var response = InternalClient.SaveCustomer(MerchantKey, APIPassword, request.Email, request.CustomerID, request.CustomerName, request.PhoneNo, request.TCK_VKN, request.Password, request.CustomField, null, null, request.IsActive, request.ClientIP);

            return new MobilExpressResponse<MobilExpressServiceReference.FCSaveCustomerResultCode>(response, request.ResponseCulture);
        }

        public MobilExpressSaveCardResponse SaveCard(MobilExpressSaveCardRequest request)
        {
            var response = InternalClient.SaveCreditCard(MerchantKey, APIPassword, request.Phone, request.Email, request.CustomerID, request.CustomerName, request.CardNumber, request.CardHolderName, request.CardMonth, request.CardYear, request.ClientIP, null, request.VerificationOTP);

            return new MobilExpressSaveCardResponse(new MobilExpressResponse<MobilExpressServiceReference.FCSaveCardResultCode>(response.ResultCode, request.ResponseCulture), response.CardToken);
        }

        public MobilExpressCardListResponse GetCards(MobilExpressGetCardsRequest request)
        {
            var response = InternalClient.GetCreditCardList(MerchantKey, APIPassword, null, request.CustomerID, request.ClientIP, request.ClientUserAgent);

            return new MobilExpressCardListResponse(new MobilExpressResponse<MobilExpressServiceReference.FCGetCreditCardListResultCode>(response.ResultCode, request.ResponseCulture), response.CardList);
        }

        public MobilExpressResponseBase DeleteCard(MobilExpressDeleteCardRequest request)
        {
            var response = InternalClient.DeleteCreditCard(MerchantKey, APIPassword, request.Email, request.CustomerID, request.CardToken);

            return new MobilExpressResponse<MobilExpressServiceReference.FCDeleteCardResult>(response, request.ResponseCulture);
        }

        public MobilExpressPayBillResponse PayBill(MobilExpressPayBillRequest request)
        {
            var response = InternalClient.ProcessPayment(MobilExpressServiceReference.FCProcessType.sales, MerchantKey, APIPassword, request.TransactionID, request.Email, request.CustomerID, request.CardToken, request.POSID, request.TotalAmount, 0, false, false, false, false, null, request.ClientIP, request.ClientUserAgent, null, null);

            return new MobilExpressPayBillResponse(new MobilExpressResponse<MobilExpressServiceReference.FCProcessPaymentResultCode>(response.ResultCode, request.ResponseCulture), new MobilExpressPayBillResponse.TransactionInfo()
            {
                BankAuthCode = response.BankAuthCode,
                BankHostDate = response.BankHostDate,
                BankMessage = response.BankMessage,
                BankReferenceNo = response.BankReferenceNo,
                BankReturnCode = response.BankReturnCode,
                BankTransactionID = response.BankReturnCode,
                MobilExpressErrorMessage = response.ErrorMessage,
                MobilExpressPaymentID = response.PaymentId,
                MobilexpressTransactionID = response.MobilexpressTransId,
                POSID = response.POSID,
                ThreeDRedirectURL = response.ThreeDRedirectURL,
                UsedLoyaltyPoint = response.UsedLoyaltyPoint
            });
        }
    }
}
