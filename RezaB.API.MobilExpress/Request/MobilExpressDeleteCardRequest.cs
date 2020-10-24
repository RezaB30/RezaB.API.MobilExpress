using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezaB.API.MobilExpress.Request
{
    public class MobilExpressDeleteCardRequest : MobilExpressRequestBase
    {
        public string Email { get; set; }

        public string CustomerID { get; set; }

        public string CardToken { get; set; }
    }
}
