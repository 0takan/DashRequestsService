using Newtonsoft.Json;

namespace DashRequestService.Clients.Models
{
    public class JsonRestResponse<T>
    {
        [JsonProperty(PropertyName = "result", Order = 0)]
        public T Result { get; set; }

        [JsonProperty(PropertyName = "id", Order = 1)]
        public int Id { get; set; }

        [JsonProperty(PropertyName = "error", Order = 2)]
        public JsonRestError Error { get; set; }
    }
}
