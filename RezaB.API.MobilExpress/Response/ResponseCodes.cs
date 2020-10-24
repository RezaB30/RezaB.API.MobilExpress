using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RezaB.API.MobilExpress.Response
{
    public enum ResponseCodes
    {
        // save customer
        Success = 0,
        InvalidEmail = 1,
        InvalidCustomerID = 2,
        AuthenticationError = 3,
        // save card
        InvalidCardNum = 4,
        InvalidMonth = 5,
        InvalidYear = 6,
        InvalidClientIP = 7,
        DuplicateCard = 8,
        InvalidPhone = 9,
        NoOTPSentForVerification = 10,
        InvalidOTP = 11,
        TooLateOTPVerification = 12,
        TooMuchOTPVerificationTried = 13,
        // get card list
        CardNotFound = 14,
        CardFoundOTPRequired = 15,
        InvalidState = 16,
        // delete card
        CustomerNotFound = 17,
        InvalidCardToken = 18,
        // pay bill
        InvalidAmount = 19,
        CardExpired = 20,
        CardRefused = 21,
        CVVAndOTPRequired = 22,
        CVVRequired = 23,
        InvalidBankPosId = 24,
        InvalidInstallment = 25,
        InvalidReturnURL = 26,
        InvalidTransactionId = 27,
        OTPCouldNotSend = 28,
        OTPRequired = 29,
        RefTransactionNotFound = 30,
        ThreeDSecureURLCreated = 31,
        ThreeDValidationFailed = 32,
        TooQuickOTPSent = 33,
        // common
        ServerError = 99,
        UndefinedResponseCode = 100
    }
}
