using Newtonsoft.Json;

namespace EsriJson.Net
{
    [JsonObject(MemberSerialization.OptIn)]
    public abstract class EsriJsonObject
    {
        [JsonProperty(PropertyName = "spatialReference")]
        public Crs CRS { get; set; }

        [JsonProperty(PropertyName = "type")]
        public abstract string Type { get; }
    }
}
