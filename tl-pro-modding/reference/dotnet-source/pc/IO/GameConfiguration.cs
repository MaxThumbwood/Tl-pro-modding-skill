// Decompiled with JetBrains decompiler
// Type: Terraria.IO.GameConfiguration
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Newtonsoft.Json.Linq;

#nullable disable
namespace Terraria.IO;

public class GameConfiguration
{
  private readonly JObject _root;

  public GameConfiguration(JObject configurationRoot) => this._root = configurationRoot;

  public T Get<T>(string entry) => this._root[entry].ToObject<T>();
}
