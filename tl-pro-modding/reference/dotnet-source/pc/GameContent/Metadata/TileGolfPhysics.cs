// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Metadata.TileGolfPhysics
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Newtonsoft.Json;

#nullable disable
namespace Terraria.GameContent.Metadata;

public class TileGolfPhysics
{
  [JsonProperty]
  public float DirectImpactDampening { get; private set; }

  [JsonProperty]
  public float SideImpactDampening { get; private set; }

  [JsonProperty]
  public float ClubImpactDampening { get; private set; }

  [JsonProperty]
  public float PassThroughDampening { get; private set; }

  [JsonProperty]
  public float ImpactDampeningResistanceEfficiency { get; private set; }
}
