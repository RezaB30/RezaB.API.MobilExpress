using RezaB.API.MobilExpress.MobilExpressServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezaB.API.MobilExpress.Response
{
    public class MobilExpressCardListResponse : MobilExpressResponseBase
    {
        public List<CardInfo> CardList { get; protected set; }

        public MobilExpressCardListResponse(MobilExpressResponseBase original, IEnumerable<FCCreditCard> cardlist)
        {
            cardlist = cardlist ?? Enumerable.Empty<FCCreditCard>();
            ResponseCode = original.ResponseCode;
            ErrorMessage = original.ErrorMessage;
            CardList = cardlist.Select(c => new CardInfo(c.MaskedCardNumber, c.CardToken, c.FinishPaymentRequired)).ToList();
        }

        public class CardInfo
        {
            public CardInfo(string maskedCardNumber, string cardToken, bool finishPaymentRequired)
            {
                MaskedCardNumber = maskedCardNumber;
                CardToken = cardToken;
                FinishPaymentRequired = finishPaymentRequired;
            }

            public string MaskedCardNumber { get; private set; }

            public string CardToken { get; private set; }

            public bool FinishPaymentRequired { get; private set; }
        }
    }
}
