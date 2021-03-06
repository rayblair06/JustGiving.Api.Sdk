﻿using System.Collections.Generic;
using System.Runtime.Serialization;

namespace JustGiving.Api.Data.Sdk.Model.Payment.Donations
{
    [DataContract(Name = "Payment", Namespace = "")]
    public class Payment : DtoBase
    {
        public Payment()
        {
            Donations = new List<Donation>();
        }

        [DataMember(Name = "PaymentRef", Order = 0)]
        public int PaymentRef
        {
            get;
            set;
        }

        [DataMember(Name = "Donations", Order = 1)]
        public List<Donation> Donations
        {
            get;
            set;
        }
    }
}