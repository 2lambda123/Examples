using OKExV5Vendor.API.REST;
using System.Reflection;

namespace OKExV5Vendor.API.Websocket.Models
{
    [Obfuscation(Exclude = true)]
    class OKExLoginRequest : OKExOperationRequest<OKExLoginArguments>
    {
        public OKExLoginRequest()
            => this.Op = "login";
    }
}
