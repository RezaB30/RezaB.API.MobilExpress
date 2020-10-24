using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezaB.API.MobilExpress.Response
{
    public class MobilExpressPayBillResponse : MobilExpressResponseBase
    {
        public MobilExpressPayBillResponse(MobilExpressResponseBase original, TransactionInfo paymentInfo)
        {
            ResponseCode = original.ResponseCode;
            ErrorMessage = original.ErrorMessage;
            PaymentInfo = paymentInfo;
        }

        public TransactionInfo PaymentInfo { get; set; }

        public class TransactionInfo
        {
            public string MobilExpressErrorMessage { get; set; }

            public string MobilexpressTransactionID { get; set; }

            public string BankReturnCode { get; set; }

            public string BankAuthCode { get; set; }

            public string BankTransactionID { get; set; }

            public string BankMessage { get; set; }

            public string POSID { get; set; }

            public string ThreeDRedirectURL { get; set; }

            public decimal UsedLoyaltyPoint { get; set; }

            public string BankReferenceNo { get; set; }

            public DateTime? BankHostDate { get; set; }

            public int? MobilExpressPaymentID { get; set; }
        }
    }
}
