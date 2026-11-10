// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Shaders.MoonLordScreenShaderData
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Terraria.Graphics.Shaders;

#nullable disable
namespace Terraria.GameContent.Shaders;

public class MoonLordScreenShaderData : ScreenShaderData
{
  private int _moonLordIndex = -1;
  private bool _aimAtPlayer;

  public MoonLordScreenShaderData(string passName, bool aimAtPlayer)
    : base(passName)
  {
    this._aimAtPlayer = aimAtPlayer;
  }

  private void UpdateMoonLordIndex()
  {
    if (this._aimAtPlayer || this._moonLordIndex >= 0 && Main.npc[this._moonLordIndex].active && Main.npc[this._moonLordIndex].type == 398)
      return;
    int num = -1;
    for (int index = 0; index < Main.npc.Length; ++index)
    {
      if (Main.npc[index].active && Main.npc[index].type == 398)
      {
        num = index;
        break;
      }
    }
    this._moonLordIndex = num;
  }

  public override void Apply()
  {
    this.UpdateMoonLordIndex();
    if (this._aimAtPlayer)
      this.UseTargetPosition(Main.SceneMetrics.Center);
    else if (this._moonLordIndex != -1)
      this.UseTargetPosition(Main.npc[this._moonLordIndex].Center);
    base.Apply();
  }
}
