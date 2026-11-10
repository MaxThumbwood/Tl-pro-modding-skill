// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Ambience.AmbientSkyDrawCache
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.GameContent.Ambience;

public class AmbientSkyDrawCache
{
  public static AmbientSkyDrawCache Instance = new AmbientSkyDrawCache();
  public AmbientSkyDrawCache.UnderworldCache[] Underworld = new AmbientSkyDrawCache.UnderworldCache[5];
  public AmbientSkyDrawCache.OceanLineCache OceanLineInfo;

  public void SetUnderworldInfo(int drawIndex, float scale)
  {
    this.Underworld[drawIndex] = new AmbientSkyDrawCache.UnderworldCache()
    {
      Scale = scale
    };
  }

  public void SetOceanLineInfo(float yScreenPosition, float oceanOpacity)
  {
    this.OceanLineInfo = new AmbientSkyDrawCache.OceanLineCache()
    {
      YScreenPosition = yScreenPosition,
      OceanOpacity = oceanOpacity
    };
  }

  public struct UnderworldCache
  {
    public float Scale;
  }

  public struct OceanLineCache
  {
    public float YScreenPosition;
    public float OceanOpacity;
  }
}
