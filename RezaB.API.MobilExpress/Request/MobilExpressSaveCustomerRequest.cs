using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezaB.API.MobilExpress.Request
{
    public class MobilExpressSaveCustomerRequest : MobilExpressRequestBase
    {
        public string CustomerID { get; set; }

        public string Email { get; set; }

        public string CustomerName { get; set; }

        public string PhoneNo { get; set; }

        public string TCK_VKN { get; set; }

        public string Password { get; set; }

        public string CustomField { get; set; }

        public bool IsActive { get; set; }

        public bool IsAutoPayment { get; set; }
    }
}
