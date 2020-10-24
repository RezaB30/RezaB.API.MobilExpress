using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezaB.API.MobilExpress.Request
{
    public class MobilExpressPayBillRequest : MobilExpressRequestBase
    {
        public string Email { get; set; }

        public string CustomerID { get; set; }

        public string CardToken { get; set; }

        public int POSID { get; set; }

        public decimal TotalAmount { get; set; }

        public string TransactionID
        {
            get
            {
                var guid = Guid.NewGuid().ToString("N");
                return guid.Substring(guid.Length - 20);
            }
        }
    }
}
