// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.UI.CharacterCreationTipsProvider
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Terraria.Localization;

#nullable disable
namespace Terraria.GameContent.UI;

public class CharacterCreationTipsProvider : ITipProvider
{
  public LocalizedText RollAvailableTip()
  {
    return Language.SelectRandom(Lang.CreateDialogFilter("LoadingTips_CharacterCreation."));
  }
}
