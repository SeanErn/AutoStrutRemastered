using SpaceWarp.API.Configuration;
using Newtonsoft.Json;

namespace AutostrutRemastered
{
    [JsonObject(MemberSerialization.OptOut)]
    [ModConfig]
    public class AutostrutRemasteredConfig
    {
         [ConfigField("pi")] [ConfigDefaultValue(3.14159)] public double pi;
    }
}