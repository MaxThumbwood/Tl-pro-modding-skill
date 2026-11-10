// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.UI.Elements.AWorldListItem
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using System.Collections.Generic;
using Terraria.IO;
using Terraria.Localization;
using Terraria.UI;

#nullable disable
namespace Terraria.GameContent.UI.Elements;

public abstract class AWorldListItem : UIPanel
{
  protected WorldFileData _data;
  protected int _glitchFrameCounter;
  protected int _glitchFrame;
  protected int _glitchVariation;

  private void UpdateGlitchAnimation(UIElement affectedElement)
  {
    int glitchFrame = this._glitchFrame;
    int minValue = 3;
    int num = 3;
    if (this._glitchFrame == 0)
    {
      minValue = 15;
      num = 120;
    }
    if (++this._glitchFrameCounter >= Main.rand.Next(minValue, num + 1))
    {
      this._glitchFrameCounter = 0;
      this._glitchFrame = (this._glitchFrame + 1) % 16 /*0x10*/;
      if ((this._glitchFrame == 4 || this._glitchFrame == 8 ? 1 : (this._glitchFrame == 12 ? 1 : 0)) != 0 && Main.rand.Next(3) == 0)
        this._glitchVariation = Main.rand.Next(7);
    }
    (affectedElement as UIImageFramed).SetFrame(7, 16 /*0x10*/, this._glitchVariation, this._glitchFrame, 0, 0);
  }

  protected void GetDifficulty(out string expertText, out Color gameModeColor)
  {
    expertText = "";
    gameModeColor = Color.White;
    if (this._data.GameMode == 3)
    {
      expertText = Language.GetTextValue("UI.Creative");
      gameModeColor = Main.creativeModeColor;
    }
    else
    {
      int num = 1;
      switch (this._data.GameMode)
      {
        case 1:
          num = 2;
          break;
        case 2:
          num = 3;
          break;
      }
      if (this._data.ForTheWorthy)
        ++num;
      switch (num)
      {
        case 2:
          expertText = Language.GetTextValue("UI.Expert");
          gameModeColor = Main.mcColor;
          break;
        case 3:
          expertText = Language.GetTextValue("UI.Master");
          gameModeColor = Main.hcColor;
          break;
        case 4:
          expertText = Language.GetTextValue("UI.Legendary");
          gameModeColor = Main.legendaryModeColor;
          break;
        default:
          expertText = Language.GetTextValue("UI.Normal");
          break;
      }
    }
  }

  protected Asset<Texture2D> GetIcon()
  {
    if (this._data.ZenithWorld)
      return this.GetSeedIcon("Everything", evilVariants: false);
    if (this._data.DrunkWorld)
      return this.GetSeedIcon("CorruptionCrimson", evilVariants: false);
    if (this._data.ForTheWorthy)
      return this.GetSeedIcon("FTW");
    if (this._data.NotTheBees)
      return this.GetSeedIcon("NotTheBees");
    if (this._data.Anniversary)
      return this.GetSeedIcon("Anniversary");
    if (this._data.DontStarve)
      return this.GetSeedIcon("DontStarve");
    if (this._data.RemixWorld)
      return this.GetSeedIcon("Remix");
    if (this._data.NoTrapsWorld)
      return this.GetSeedIcon("Traps");
    return this._data.SkyblockWorld ? this.GetSeedIcon("Skyblock", false, false) : this.GetSeedIcon("");
  }

  protected List<Asset<Texture2D>> GetIcons()
  {
    List<Asset<Texture2D>> icons = new List<Asset<Texture2D>>();
    if (this._data.DrunkWorld)
      icons.Add(this.GetSeedIcon("CorruptionCrimson", evilVariants: false));
    if (this._data.ForTheWorthy)
      icons.Add(this.GetSeedIcon("FTW"));
    if (this._data.NotTheBees)
      icons.Add(this.GetSeedIcon("NotTheBees"));
    if (this._data.Anniversary)
      icons.Add(this.GetSeedIcon("Anniversary"));
    if (this._data.DontStarve)
      icons.Add(this.GetSeedIcon("DontStarve"));
    if (this._data.RemixWorld)
      icons.Add(this.GetSeedIcon("Remix"));
    if (this._data.NoTrapsWorld)
      icons.Add(this.GetSeedIcon("Traps"));
    if (this._data.SkyblockWorld)
      icons.Add(this.GetSeedIcon("Skyblock", false, false));
    if (icons.Count > 0)
      return icons;
    icons.Add(this.GetSeedIcon(""));
    return icons;
  }

  protected UIElement GetIconElement()
  {
    if (this._data.ZenithWorld)
    {
      Asset<Texture2D> asset = Main.Assets.Request<Texture2D>("Images/UI/IconEverythingAnimated", (AssetRequestMode) 1);
      UIImageFramed iconElement = new UIImageFramed(asset, asset.Frame(7, 16 /*0x10*/));
      iconElement.Left = new StyleDimension(4f, 0.0f);
      iconElement.OnUpdate += new UIElement.ElementEvent(this.UpdateGlitchAnimation);
      return (UIElement) iconElement;
    }
    UICyclingImage iconElement1 = new UICyclingImage(this.GetIcons());
    iconElement1.Left = new StyleDimension(4f, 0.0f);
    return (UIElement) iconElement1;
  }

  private Asset<Texture2D> GetSeedIcon(string seed, bool hardmodeVariants = true, bool evilVariants = true)
  {
    string str1 = "Images/UI/Icon";
    if (hardmodeVariants)
      str1 += this._data.IsHardMode ? "Hallow" : "";
    if (evilVariants)
      str1 += this._data.HasCorruption ? "Corruption" : "Crimson";
    string str2 = str1 + seed;
    return Main.Assets.Request<Texture2D>(str2, (AssetRequestMode) 1);
  }
}
