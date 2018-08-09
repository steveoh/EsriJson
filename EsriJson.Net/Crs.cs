using Newtonsoft.Json;

namespace EsriJson.Net
{
  [JsonObject(MemberSerialization.OptIn)]
  public class Crs
  {
      [JsonProperty(PropertyName = "wkid")]
      public int WellKnownId { get; set; }
  }
}
