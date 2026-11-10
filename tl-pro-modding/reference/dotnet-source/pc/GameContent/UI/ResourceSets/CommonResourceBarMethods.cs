// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.UI.ResourceSets.CommonResourceBarMethods
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.GameContent.UI.ResourceSets;

public class CommonResourceBarMethods
{
  public static void DrawLifeMouseOver()
  {
    if (Main.mouseText)
      return;
    Player localPlayer = Main.LocalPlayer;
    localPlayer.cursorItemIconEnabled = false;
    string text = $"{(object) localPlayer.statLife}/{(object) localPlayer.statLifeMax2}";
    Main.instance.MouseTextHackZoom(text);
    Main.mouseText = true;
  }

  public static void DrawManaMouseOver()
  {
    if (Main.mouseText)
      return;
    Player localPlayer = Main.LocalPlayer;
    localPlayer.cursorItemIconEnabled = false;
    string text = $"{(object) localPlayer.statMana}/{(object) localPlayer.statManaMax2}";
    Main.instance.MouseTextHackZoom(text);
    Main.mouseText = true;
  }
}
