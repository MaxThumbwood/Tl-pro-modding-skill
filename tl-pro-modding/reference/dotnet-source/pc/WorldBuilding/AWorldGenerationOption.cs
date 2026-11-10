// Decompiled with JetBrains decompiler
// Type: Terraria.WorldBuilding.AWorldGenerationOption
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using System;
using Terraria.GameContent.UI.Elements;
using Terraria.Localization;
using Terraria.UI;

#nullable disable
namespace Terraria.WorldBuilding;

public abstract class AWorldGenerationOption
{
  private bool _enabled;
  public bool AutoGenEnabled;

  protected static event Action<AWorldGenerationOption> OnOptionStateChanged;

  public bool Enabled
  {
    get => this._enabled;
    set
    {
      if (this._enabled == value)
        return;
      this._enabled = value;
      this.OnEnabledStateChanged();
      AWorldGenerationOption.OnOptionStateChanged(this);
    }
  }

  protected abstract string KeyName { get; }

  public abstract string ServerConfigName { get; }

  public string[] SpecialSeedNames { get; protected set; }

  public int[] SpecialSeedValues { get; protected set; }

  public LocalizedText Description { get; private set; }

  public LocalizedText Title { get; private set; }

  protected Asset<Texture2D> Texture { get; private set; }

  protected virtual void OnEnabledStateChanged()
  {
  }

  public void Load()
  {
    if (this.Texture != null)
      return;
    this.Description = Language.GetText("UI." + this.KeyName);
    this.Title = Language.GetText($"UI.{this.KeyName}_Title");
    if (Main.dedServ)
      return;
    this.Texture = Main.Assets.Request<Texture2D>("Images/UI/WorldCreation/" + this.KeyName, (AssetRequestMode) 1);
  }

  public virtual UIElement ProvideUIElement()
  {
    UIImage uiImage = new UIImage(this.Texture);
    uiImage.Left = StyleDimension.FromPixels(-1f);
    return (UIElement) uiImage;
  }
}
