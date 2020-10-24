using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezaB.API.MobilExpress.Response
{
    public class MobilExpressSaveCardResponse : MobilExpressResponseBase
    {
        public string CardToken { get; protected set; }

        public MobilExpressSaveCardResponse(MobilExpressResponseBase original, string cardToken)
        {
            ResponseCode = original.ResponseCode;
            ErrorMessage = original.ErrorMessage;
            CardToken = cardToken;
        }
    }
}
