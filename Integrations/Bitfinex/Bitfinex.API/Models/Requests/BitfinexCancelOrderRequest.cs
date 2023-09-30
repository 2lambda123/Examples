// Copyright QUANTOWER LLC. © 2017-2023. All rights reserved.

using System.Runtime.Serialization;

namespace Bitfinex.API.Models.Requests;

[DataContract]
public class BitfinexCancelOrderRequest
{
    [DataMember(Name = "id")]
    public long OrderId { get; set; }
}