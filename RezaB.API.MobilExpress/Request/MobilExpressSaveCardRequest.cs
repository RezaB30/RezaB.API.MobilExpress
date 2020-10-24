using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezaB.API.MobilExpress.Request
{
    public class MobilExpressSaveCardRequest : MobilExpressRequestBase
    {
        public string Phone { get; set; }

        public string Email { get; set; }

        public string CustomerID { get; set; }

        public string CustomerName { get; set; }

        public string CardNumber { get; set; }

        public string CardHolderName { get; set; }

        public int CardMonth { get; set; }

        public int CardYear { get; set; }

        public string VerificationOTP { get; set; }
    }
}
