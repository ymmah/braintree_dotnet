#pragma warning disable 1591

using System;
using System.Collections.Generic;
using System.Text;

namespace Braintree
{
    public class PaymentMethodOptionsRequest : Request
    {
        public Boolean? MakeDefault { get; set; }
        public Boolean? VerifyCard { get; set; }
        public Boolean? FailOnDuplicatePaymentMethod { get; set; }
        public String VerificationMerchantAccountId { get; set; }

        public override String ToXml(String root)
        {
            return BuildRequest(root).ToXml();
        }

        public override String ToQueryString(String root)
        {
            return BuildRequest(root).ToQueryString();
        }

        protected virtual RequestBuilder BuildRequest(String root)
        {
            RequestBuilder builder = new RequestBuilder(root);
            builder.AddElement("make-default", MakeDefault);
            builder.AddElement("verification-merchant-account-id", VerificationMerchantAccountId);
            builder.AddElement("verify-card", VerifyCard);
            builder.AddElement("fail-on-duplicate-payment-method", FailOnDuplicatePaymentMethod);
            return builder;
        }
    }
}
