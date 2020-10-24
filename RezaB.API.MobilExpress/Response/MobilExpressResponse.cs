using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace RezaB.API.MobilExpress.Response
{
    class MobilExpressResponse<TEnum> : MobilExpressResponseBase where TEnum : struct, IConvertible
    {
        public MobilExpressResponse(TEnum originalCode, string culture = null)
        {
            ResponseCode = CreateResponseCode(originalCode);
            ResourceManager rm = new ResourceManager(typeof(ErrorMessages));
            ErrorMessage = rm.GetString(Enum.GetName(typeof(ResponseCodes), ResponseCode), culture == null ? null: CultureInfo.CreateSpecificCulture(culture));
            if (ResponseCode == ResponseCodes.UndefinedResponseCode)
                ErrorMessage = string.Format(ErrorMessage, Enum.GetName(typeof(TEnum), originalCode));
        }

        private ResponseCodes CreateResponseCode(TEnum originalCode) 
        {
            if (!typeof(TEnum).IsEnum)
                return ResponseCodes.UndefinedResponseCode;

            ResponseCodes result;

            if (Enum.TryParse(Enum.GetName(typeof(TEnum), originalCode), out result))
                return result;

            return ResponseCodes.UndefinedResponseCode;
        }
    }
}
