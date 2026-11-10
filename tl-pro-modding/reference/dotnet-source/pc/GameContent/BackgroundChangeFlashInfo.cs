// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.BackgroundChangeFlashInfo
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;

#nullable disable
namespace Terraria.GameContent;

public class BackgroundChangeFlashInfo
{
  private int[] _variations = new int[TreeTopsInfo.AreaId.Count];
  private float[] _flashPower = new float[TreeTopsInfo.AreaId.Count];

  public void UpdateCache()
  {
    this.UpdateVariation(0, WorldGen.treeBG1);
    this.UpdateVariation(1, WorldGen.treeBG2);
    this.UpdateVariation(2, WorldGen.treeBG3);
    this.UpdateVariation(3, WorldGen.treeBG4);
    this.UpdateVariation(4, WorldGen.corruptBG);
    this.UpdateVariation(5, WorldGen.jungleBG);
    this.UpdateVariation(6, WorldGen.snowBG);
    this.UpdateVariation(7, WorldGen.hallowBG);
    this.UpdateVariation(8, WorldGen.crimsonBG);
    this.UpdateVariation(9, WorldGen.desertBG);
    this.UpdateVariation(10, WorldGen.oceanBG);
    this.UpdateVariation(11, WorldGen.mushroomBG);
    this.UpdateVariation(12, WorldGen.underworldBG);
  }

  private void UpdateVariation(int areaId, int newVariationValue)
  {
    int variation = this._variations[areaId];
    this._variations[areaId] = newVariationValue;
    int num = newVariationValue;
    if (variation == num)
      return;
    this.ValueChanged(areaId);
  }

  private void ValueChanged(int areaId)
  {
    if (Main.gameMenu)
      return;
    this._flashPower[areaId] = 1f;
  }

  public void UpdateFlashValues()
  {
    for (int index = 0; index < this._flashPower.Length; ++index)
      this._flashPower[index] = MathHelper.Clamp(this._flashPower[index] - 0.05f, 0.0f, 1f);
  }

  public float GetFlashPower(int areaId) => this._flashPower[areaId];
}
