using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezaB.API.MobilExpress.Request
{
    public class MobilExpressGetCardsRequest : MobilExpressRequestBase
    {
        public string CustomerID { get; set; }
    }
}
