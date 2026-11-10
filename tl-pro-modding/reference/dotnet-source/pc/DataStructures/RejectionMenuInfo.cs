// Decompiled with JetBrains decompiler
// Type: Terraria.DataStructures.RejectionMenuInfo
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Terraria.Audio;

#nullable disable
namespace Terraria.DataStructures;

public class RejectionMenuInfo
{
  public ReturnFromRejectionMenuAction ExitAction;
  public string TextToShow;

  public void DefaultExitAction()
  {
    SoundEngine.PlaySound(11);
    Main.menuMode = 0;
    Main.netMode = 0;
  }
}
