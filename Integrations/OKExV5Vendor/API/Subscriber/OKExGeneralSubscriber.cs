using OKExV5Vendor.API.REST.Models;
using OKExV5Vendor.API.Websocket.Models;
using System;

namespace OKExV5Vendor.API.Subscriber
{
    class OKExGeneralSubscriber : OKExSubscriberBase<OKExTicker>
    {
        public OKExOpenInterest OpenInterest { get; internal set; }

        public OKExGeneralSubscriber(OKExSymbol symbol)
            : base(symbol) { }

        internal bool TryUpdateTicker(OKExTicker ticker, out bool isQuoteChanged)
        {
            bool needUpdateDaybar;

            if (this.LastTicker == null)
            {
                isQuoteChanged = false;
                needUpdateDaybar = true;
            }
            else
            {
                isQuoteChanged = ticker.AskPrice != this.LastTicker.AskPrice ||
                                 ticker.AskSize != this.LastTicker.AskSize ||
                                 ticker.BidPrice != this.LastTicker.BidPrice ||
                                 ticker.BidSize != this.LastTicker.BidSize;

                needUpdateDaybar = ticker.LastPrice != this.LastTicker.LastPrice ||
                                   ticker.OpenPrice24h != this.LastTicker.OpenPrice24h ||
                                   ticker.HighPrice24h != this.LastTicker.HighPrice24h ||
                                   ticker.LowPrice24h != this.LastTicker.LowPrice24h ||
                                   ticker.Volume24h != this.LastTicker.Volume24h ||
                                   ticker.VolumeCurrency24h  != this.LastTicker.VolumeCurrency24h;

            }

            this.LastTicker = ticker;
            return needUpdateDaybar;
        }

        internal bool ContainsAnyMainSubscription()
        {
            if (this.Symbol.InstrumentType == OKExInstrumentType.Spot)
                return !(this.ContainsSubscription(OKExSubscriptionType.Ticker) && this.SubscriptionCount == 1);
            else
                return !(this.ContainsSubscription(OKExSubscriptionType.Ticker) && this.ContainsSubscription(OKExSubscriptionType.OpenInterest) && this.SubscriptionCount == 2);
        }
    }
}
