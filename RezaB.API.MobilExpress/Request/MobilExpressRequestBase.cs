using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezaB.API.MobilExpress.Request
{
    public abstract class MobilExpressRequestBase
    {
        public string ClientIP { get; set; }

        public string ClientUserAgent { get; set; }

        public string ResponseCulture { get; set; }
    }
}
