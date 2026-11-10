// Decompiled with JetBrains decompiler
// Type: Terraria.WorldBuilding.WorldGenConfiguration
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Reflection;
using Terraria.IO;

#nullable disable
namespace Terraria.WorldBuilding;

public class WorldGenConfiguration : GameConfiguration
{
  private readonly JObject _biomeRoot;
  private readonly JObject _passRoot;

  public WorldGenConfiguration(JObject configurationRoot)
    : base(configurationRoot)
  {
    this._biomeRoot = (JObject) configurationRoot["Biomes"] ?? new JObject();
    this._passRoot = (JObject) configurationRoot["Passes"] ?? new JObject();
  }

  public T CreateBiome<T>() where T : MicroBiome, new() => this.CreateBiome<T>(typeof (T).Name);

  public T CreateBiome<T>(string name) where T : MicroBiome, new()
  {
    JToken jtoken;
    return this._biomeRoot.TryGetValue(name, ref jtoken) ? jtoken.ToObject<T>() : new T();
  }

  public GameConfiguration GetPassConfiguration(string name)
  {
    JToken configurationRoot;
    return this._passRoot.TryGetValue(name, ref configurationRoot) ? new GameConfiguration((JObject) configurationRoot) : new GameConfiguration(new JObject());
  }

  public static WorldGenConfiguration FromEmbeddedPath(string path)
  {
    using (Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(path))
    {
      using (StreamReader streamReader = new StreamReader(manifestResourceStream))
        return new WorldGenConfiguration(JsonConvert.DeserializeObject<JObject>(streamReader.ReadToEnd()));
    }
  }
}
