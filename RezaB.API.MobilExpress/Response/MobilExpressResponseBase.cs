using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezaB.API.MobilExpress.Response
{
    public abstract class MobilExpressResponseBase
    {
        public string ErrorMessage { get; protected set; }

        public ResponseCodes ResponseCode { get; protected set; }

        
    }
}
