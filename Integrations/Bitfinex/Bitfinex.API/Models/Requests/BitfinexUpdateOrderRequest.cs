// Copyright QUANTOWER LLC. © 2017-2022. All rights reserved.

using System.Runtime.Serialization;

namespace Bitfinex.API.Models.Requests
{
    [DataContract]
    public class BitfinexUpdateOrderRequest : BitfinexOrderRequest
    {
        [DataMember(Name = "id")]
        public long OrderId { get; set; }

        [DataMember(Name = "cid_date")]
        public string ClientOrderIdDate { get; set; }
    }
}