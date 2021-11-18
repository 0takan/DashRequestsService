using Newtonsoft.Json;

namespace DashRequestService.Clients.Models
{
    public class JsonRestError
    {
        [JsonProperty(PropertyName = "code")]
        public RpcErrorCode Code { get; set; }

        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }
    }
}
