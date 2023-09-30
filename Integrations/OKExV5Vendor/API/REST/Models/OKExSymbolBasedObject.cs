// Copyright QUANTOWER LLC. © 2017-2023. All rights reserved.

namespace OKExV5Vendor.API.REST.Models;

internal abstract class OKExSymbolBasedObject
{
    public abstract OKExInstrumentType InstrumentType { get; set; }
    public abstract string OKExInstrumentId { get; set; }

    public string UniqueInstrumentId => this.InstrumentType == OKExInstrumentType.Spot || this.InstrumentType == OKExInstrumentType.Margin
        ? this.OKExInstrumentId + "-COMMON"
        : this.OKExInstrumentId;
}