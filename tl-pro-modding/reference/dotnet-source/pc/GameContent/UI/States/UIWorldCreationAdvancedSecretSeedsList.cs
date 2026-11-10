// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.UI.States.UIWorldCreationAdvancedSecretSeedsList
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using System;
using System.Collections.Generic;
using Terraria.Audio;
using Terraria.GameContent.Drawing;
using Terraria.GameContent.UI.Elements;
using Terraria.Graphics.Renderers;
using Terraria.ID;
using Terraria.Localization;
using Terraria.UI;
using Terraria.UI.Gamepad;

#nullable disable
namespace Terraria.GameContent.UI.States;

public class UIWorldCreationAdvancedSecretSeedsList : UIState, IHaveBackButtonCommand
{
  private UIWorldCreationAdvanced _creationState;
  private UIElement _backButton;
  private UIList _worldList;
  private UIElement _containerPanel;
  private UIScrollbar _scrollbar;
  private bool _isScrollbarAttached;
  private UIWorldCreation _creationState2;
  private ParticleRenderer SeedParticleSystem = new ParticleRenderer();
  private UIDust SeedDust = new UIDust();
  private UIText _descriptionText;
  private UIGamepadHelper _helper;

  public UIWorldCreationAdvancedSecretSeedsList(
    UIWorldCreationAdvanced state,
    UIWorldCreation state2)
  {
    this._creationState = state;
    this._creationState2 = state2;
    this.BuildPage();
  }

  private void BuildPage()
  {
    this.SeedDust.Clear();
    this.SeedParticleSystem.Clear();
    this.RemoveAllChildren();
    UIElement uiElement1 = new UIElement()
    {
      Width = StyleDimension.FromPixels(500f),
      Height = StyleDimension.FromPixelsAndPercent(-200f, 1f),
      Top = StyleDimension.FromPixels(202f),
      HAlign = 0.5f,
      VAlign = 0.0f
    };
    uiElement1.MaxHeight = StyleDimension.FromPixels(400f);
    uiElement1.SetPadding(0.0f);
    this.Append(uiElement1);
    UIPanel uiPanel = new UIPanel();
    uiPanel.Width = StyleDimension.FromPercent(1f);
    uiPanel.Height = StyleDimension.FromPixelsAndPercent(-102f, 1f);
    uiPanel.BackgroundColor = new Color(33, 43, 79) * 0.8f;
    UIPanel element1 = uiPanel;
    element1.SetPadding(0.0f);
    uiElement1.Append((UIElement) element1);
    this.MakeBackAndCreatebuttons(uiElement1);
    int accumulatedHeight = 56;
    int pixels = 4;
    UIElement element2 = new UIElement()
    {
      Top = StyleDimension.FromPixelsAndPercent((float) pixels, 0.0f),
      Width = StyleDimension.FromPixelsAndPercent(-20f, 1f),
      Left = StyleDimension.FromPixelsAndPercent(2f, 0.0f),
      Height = StyleDimension.FromPixelsAndPercent((float) (-pixels - accumulatedHeight), 1f),
      HAlign = 0.5f
    };
    element2.SetPadding(0.0f);
    element2.PaddingTop = 8f;
    element2.PaddingBottom = 12f;
    element1.Append(element2);
    this._worldList = new UIList();
    this._worldList.Width.Set(0.0f, 1f);
    this._worldList.Height.Set(0.0f, 1f);
    this._worldList.ListPadding = 5f;
    element2.Append((UIElement) this._worldList);
    this._containerPanel = element2;
    this._scrollbar = new UIScrollbar();
    this._scrollbar.SetView(100f, 1000f);
    this._scrollbar.Height.Set(0.0f, 1f);
    this._scrollbar.HAlign = 1f;
    this._worldList.SetScrollbar(this._scrollbar);
    List<WorldGen.SecretSeed> seedsForInterface = SecretSeedsTracker.SeedsForInterface;
    this._worldList.ManualSortMethod = new Action<List<UIElement>>(this.CustomSort);
    int num = 0;
    foreach (WorldGen.SecretSeed option in seedsForInterface)
    {
      GroupOptionButton<WorldGen.SecretSeed> groupOptionButton1 = new GroupOptionButton<WorldGen.SecretSeed>(option, (LocalizedText) null, Language.GetText(option.Localization), Color.White, (string) null);
      groupOptionButton1.Width = StyleDimension.FromPixelsAndPercent(0.0f, 1f);
      groupOptionButton1.Height = new StyleDimension(40f, 0.0f);
      groupOptionButton1.HAlign = 0.0f;
      GroupOptionButton<WorldGen.SecretSeed> groupOptionButton2 = groupOptionButton1;
      groupOptionButton2.SetSnapPoint("Seed", num++);
      UIElement element3 = new UIElement();
      groupOptionButton2.Append(element3);
      groupOptionButton2.SetTextWithoutLocalization(option.TextThatWasUsedToUnlock, 1f, Color.White, 0.0f, 10f);
      groupOptionButton2.OnLeftMouseDown += new UIElement.MouseEvent(this.ClickSecretSeed);
      groupOptionButton2.OnMouseOver += new UIElement.MouseEvent(this.MouseOverSeed);
      groupOptionButton2.OnMouseOut += new UIElement.MouseEvent(this.MouseOutSeed);
      groupOptionButton2.SetCurrentOption(option.Enabled ? option : (WorldGen.SecretSeed) null);
      element3.OnDraw += new UIElement.DrawEvent(this.DrawGlowRing);
      this._worldList.Add((UIElement) groupOptionButton2);
    }
    UIElement uiElement2 = new UIElement()
    {
      Width = StyleDimension.FromPixelsAndPercent(-20f, 1f),
      Height = StyleDimension.FromPixelsAndPercent((float) (accumulatedHeight + pixels), 0.0f),
      HAlign = 0.5f,
      VAlign = 1f
    };
    uiElement2.SetPadding(0.0f);
    uiElement2.PaddingBottom = 12f;
    element1.Append(uiElement2);
    this.AddDescriptionPanel(uiElement2, (float) accumulatedHeight, "desc");
  }

  private void AddDescriptionPanel(UIElement container, float accumulatedHeight, string tagGroup)
  {
    float num = 0.0f;
    UISlicedImage uiSlicedImage = new UISlicedImage(Main.Assets.Request<Texture2D>("Images/UI/CharCreation/CategoryPanelHighlight", (AssetRequestMode) 1));
    uiSlicedImage.HAlign = 0.5f;
    uiSlicedImage.VAlign = 1f;
    uiSlicedImage.Width = StyleDimension.FromPixelsAndPercent((float) (-(double) num * 2.0), 1f);
    uiSlicedImage.Left = StyleDimension.FromPixels(-num);
    uiSlicedImage.Height = StyleDimension.FromPixelsAndPercent(accumulatedHeight, 0.0f);
    uiSlicedImage.Top = StyleDimension.FromPixels(2f);
    UISlicedImage element1 = uiSlicedImage;
    element1.SetSliceDepths(10);
    element1.Color = Color.LightGray * 0.7f;
    container.Append((UIElement) element1);
    UIText uiText = new UIText(Language.GetText("UI.WorldDescriptionDefault"), 0.7f);
    uiText.HAlign = 0.0f;
    uiText.VAlign = 0.0f;
    uiText.Width = StyleDimension.FromPixelsAndPercent(0.0f, 1f);
    uiText.Height = StyleDimension.FromPixelsAndPercent(0.0f, 1f);
    uiText.Top = StyleDimension.FromPixelsAndPercent(2f, 0.0f);
    UIText element2 = uiText;
    element2.IsWrapped = true;
    element2.PaddingLeft = 20f;
    element2.PaddingRight = 20f;
    element2.PaddingTop = 4f;
    element1.Append((UIElement) element2);
    this._descriptionText = element2;
  }

  public void MouseOutSeed(UIMouseEvent evt, UIElement listeningElement)
  {
    this.ClearOptionDescription(evt, listeningElement);
  }

  public void MouseOverSeed(UIMouseEvent evt, UIElement listeningElement)
  {
    if (!(evt.Target is GroupOptionButton<WorldGen.SecretSeed> target))
      return;
    int num = target.IsSelected ? 1 : 0;
    if (Main.mouseLeft)
      listeningElement.LeftMouseDown(evt);
    this.ShowOptionDescription(evt, listeningElement);
  }

  public void DrawGlowRing(UIElement listeningElement, SpriteBatch spriteBatch)
  {
    GroupOptionButton<WorldGen.SecretSeed> parent = (GroupOptionButton<WorldGen.SecretSeed>) listeningElement.Parent;
    if (!parent.OptionValue.Enabled)
      return;
    Asset<Texture2D> asset = Main.Assets.Request<Texture2D>("Images/UI/WorldCreation/IconRandomSeed", (AssetRequestMode) 1);
    CalculatedStyle dimensions = parent.GetDimensions();
    Vector2 position = dimensions.ToRectangle().TopRight() + new Vector2(-22f, 22f);
    Texture2D texture2D = asset.Value;
    Rectangle r1 = new Rectangle(0, 0, 4, 4);
    Vector2 vector2 = new Vector2((float) texture2D.Width * 0.45f, (float) texture2D.Height * 0.95f);
    float num1 = 0.25f * (float) Math.Sin((double) Main.GlobalTimeWrappedHourly * 1.2999999523162842 + (double) dimensions.Position().Y);
    num1 = 0.7853982f;
    vector2 = r1.Size() / 2f;
    double num2 = 1.5 + 1.0;
    Math.Sin((double) Main.GlobalTimeWrappedHourly * 1.2999999523162842 + (double) dimensions.Position().Y * 0.0015317799989134073);
    float scale = 1f;
    float rotation = 0.0f;
    Rectangle r2 = texture2D.Frame();
    Vector2 origin = r2.Size() / 2f;
    spriteBatch.Draw(texture2D, position, new Rectangle?(r2), Color.White, rotation, origin, scale, SpriteEffects.None, 0.0f);
  }

  private void CustomSort(List<UIElement> items)
  {
    items.Sort((Comparison<UIElement>) ((a, b) =>
    {
      GroupOptionButton<WorldGen.SecretSeed> groupOptionButton1 = a as GroupOptionButton<WorldGen.SecretSeed>;
      GroupOptionButton<WorldGen.SecretSeed> groupOptionButton2 = b as GroupOptionButton<WorldGen.SecretSeed>;
      if (groupOptionButton1 != null && groupOptionButton2 == null)
        return -1;
      return groupOptionButton1 == null && groupOptionButton2 != null ? 1 : groupOptionButton1.OptionValue.TextThatWasUsedToUnlock.CompareTo(groupOptionButton2.OptionValue.TextThatWasUsedToUnlock);
    }));
  }

  private void ClickSecretSeed(UIMouseEvent evt, UIElement listeningElement)
  {
    GroupOptionButton<WorldGen.SecretSeed> element = (GroupOptionButton<WorldGen.SecretSeed>) listeningElement;
    WorldGen.SecretSeed optionValue = element.OptionValue;
    if (optionValue.Enabled)
    {
      element.SetCurrentOption((WorldGen.SecretSeed) null);
      WorldGen.SecretSeed.Disable(optionValue);
      this._creationState2.RemoveSeedFromSeedMenu(optionValue.TextThatWasUsedToUnlock);
    }
    else
    {
      element.SetCurrentOption(optionValue);
      WorldGen.SecretSeed.Enable(optionValue);
      this._creationState2.AddSeedFromSeedmenu(optionValue.TextThatWasUsedToUnlock);
      this.SpawnParticles(element);
    }
  }

  private void SpawnParticles(GroupOptionButton<WorldGen.SecretSeed> element)
  {
    CalculatedStyle dimensions = element.GetDimensions();
    dimensions.Center();
    this.Spawn_RainbowRodHit(new ParticleOrchestraSettings()
    {
      PositionInWorld = dimensions.Position() + new Vector2(dimensions.Width - 20f, dimensions.Height / 2f),
      MovementVector = new Vector2(0.0f, 16f) + Main.rand.NextVector2Circular(10f, 2f)
    });
    float num = 8f;
    for (int index = 0; (double) index < (double) num + 1.0; ++index)
      this.Spawn_BestReforge(new ParticleOrchestraSettings()
      {
        PositionInWorld = dimensions.Position() + new Vector2(0.0f, dimensions.Height / 2f) + new Vector2(dimensions.Width * (1f / num) * (float) index, 0.0f)
      });
  }

  private void Spawn_RainbowRodHit(ParticleOrchestraSettings settings)
  {
    float num1 = Main.rand.NextFloat() * 6.28318548f;
    float num2 = 6f;
    float num3 = Main.rand.NextFloat();
    for (float num4 = 0.0f; (double) num4 < 1.0; num4 += 1f / num2)
    {
      Vector2 vector2_1 = settings.MovementVector * Main.rand.NextFloatDirection() * 0.15f;
      Vector2 vector2_2 = new Vector2((float) ((double) Main.rand.NextFloat() * 0.40000000596046448 + 0.40000000596046448));
      float f = num1 + Main.rand.NextFloat() * 6.28318548f;
      float num5 = 1.57079637f;
      Vector2 vector2_3 = 1.5f * vector2_2;
      float num6 = 60f;
      Vector2 vector2_4 = Main.rand.NextVector2Circular(8f, 8f) * vector2_2;
      PrettySparkleParticle prettySparkleParticle1 = new PrettySparkleParticle();
      prettySparkleParticle1.Velocity = f.ToRotationVector2() * vector2_3 + vector2_1;
      prettySparkleParticle1.AccelerationPerFrame = f.ToRotationVector2() * -(vector2_3 / num6) - vector2_1 * 1f / 60f;
      prettySparkleParticle1.ColorTint = Main.hslToRgb((float) (((double) num3 + (double) Main.rand.NextFloat() * 0.33000001311302185) % 1.0), 1f, (float) (0.40000000596046448 + (double) Main.rand.NextFloat() * 0.25));
      prettySparkleParticle1.ColorTint.A = (byte) 0;
      prettySparkleParticle1.LocalPosition = settings.PositionInWorld + vector2_4;
      prettySparkleParticle1.Rotation = num5;
      prettySparkleParticle1.Scale = vector2_2;
      this.SeedParticleSystem.Add((IParticle) prettySparkleParticle1);
      PrettySparkleParticle prettySparkleParticle2 = new PrettySparkleParticle();
      prettySparkleParticle2.Velocity = f.ToRotationVector2() * vector2_3 + vector2_1;
      prettySparkleParticle2.AccelerationPerFrame = f.ToRotationVector2() * -(vector2_3 / num6) - vector2_1 * 1f / 60f;
      prettySparkleParticle2.ColorTint = new Color((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, 0);
      prettySparkleParticle2.LocalPosition = settings.PositionInWorld + vector2_4;
      prettySparkleParticle2.Rotation = num5;
      prettySparkleParticle2.Scale = vector2_2 * 0.6f;
      this.SeedParticleSystem.Add((IParticle) prettySparkleParticle2);
    }
    for (int index = 0; index < 12; ++index)
    {
      Color rgb = Main.hslToRgb((float) (((double) num3 + (double) Main.rand.NextFloat() * 0.11999999731779099) % 1.0), 1f, (float) (0.40000000596046448 + (double) Main.rand.NextFloat() * 0.25));
      Dust rf = this.SeedDust.NewDust(settings.PositionInWorld, 0, 0, 267, newColor: rgb);
      rf.velocity = Main.rand.NextVector2Circular(1f, 1f);
      rf.velocity += settings.MovementVector * Main.rand.NextFloatDirection() * 0.5f;
      rf.noGravity = true;
      rf.scale = (float) (0.60000002384185791 + (double) Main.rand.NextFloat() * 0.89999997615814209);
      rf.fadeIn = (float) (0.699999988079071 + (double) Main.rand.NextFloat() * 0.800000011920929);
      if (rf.dustIndex != 200 && rf.type != 0)
      {
        Dust dust = this.SeedDust.CloneDust(rf);
        dust.scale /= 2f;
        dust.fadeIn *= 0.75f;
        dust.color = new Color((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
      }
    }
  }

  private void Spawn_BestReforge(ParticleOrchestraSettings settings)
  {
    Vector2 vector2_1 = new Vector2(0.0f, 0.163500011f);
    Asset<Texture2D> textureAsset = Main.Assets.Request<Texture2D>("Images/UI/Creative/Research_Spark", (AssetRequestMode) 1);
    for (int index = 0; index < 2; ++index)
    {
      Vector2 vector2_2 = Main.rand.NextVector2Circular(3f, 4f);
      Vector2 vector2_3 = new Vector2(0.0f, Main.rand.NextFloatDirection() * 20f);
      this.SeedParticleSystem.Add((IParticle) new CreativeSacrificeParticle(textureAsset, new Rectangle?(), settings.MovementVector + vector2_2, settings.PositionInWorld + vector2_3)
      {
        AccelerationPerFrame = vector2_1,
        ScaleOffsetPerFrame = -0.0166666675f
      });
    }
    float num = Main.rand.NextFloat();
    for (int index = 0; index < 3; ++index)
    {
      Color rgb = Main.hslToRgb((float) (((double) num + (double) Main.rand.NextFloat() * 0.11999999731779099) % 1.0), 1f, (float) (0.40000000596046448 + (double) Main.rand.NextFloat() * 0.25));
      Dust rf = this.SeedDust.NewDust(settings.PositionInWorld, 0, 0, 267, newColor: rgb);
      rf.velocity = Main.rand.NextVector2Circular(1f, 1f);
      rf.velocity += settings.MovementVector * Main.rand.NextFloatDirection() * 0.5f;
      rf.noGravity = true;
      rf.scale = (float) (0.60000002384185791 + (double) Main.rand.NextFloat() * 0.89999997615814209);
      rf.fadeIn = (float) (0.699999988079071 + (double) Main.rand.NextFloat() * 0.800000011920929);
      Vector2 vector2_4 = new Vector2(0.0f, Main.rand.NextFloatDirection() * 20f);
      rf.position += vector2_4;
      if (rf.dustIndex != 200 && rf.type != 0)
      {
        Dust dust = this.SeedDust.CloneDust(rf);
        dust.scale /= 2f;
        dust.fadeIn *= 0.75f;
        dust.color = new Color((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
      }
    }
  }

  public override void Recalculate()
  {
    if (this._scrollbar != null)
    {
      if (this._isScrollbarAttached && !this._scrollbar.CanScroll)
      {
        this._containerPanel.RemoveChild((UIElement) this._scrollbar);
        this._isScrollbarAttached = false;
        this._worldList.Width.Set(0.0f, 1f);
      }
      else if (!this._isScrollbarAttached && this._scrollbar.CanScroll)
      {
        this._containerPanel.Append((UIElement) this._scrollbar);
        this._isScrollbarAttached = true;
        this._worldList.Width.Set(-25f, 1f);
      }
    }
    base.Recalculate();
  }

  private void MakeBackAndCreatebuttons(UIElement outerContainer)
  {
    UITextPanel<LocalizedText> uiTextPanel = new UITextPanel<LocalizedText>(Language.GetText("UI.Apply"), 0.65f, true);
    uiTextPanel.Width = StyleDimension.FromPixelsAndPercent(-10f, 0.5f);
    uiTextPanel.Height = StyleDimension.FromPixels(50f);
    uiTextPanel.VAlign = 1f;
    uiTextPanel.HAlign = 0.5f;
    uiTextPanel.Top = StyleDimension.FromPixels(-43f);
    UITextPanel<LocalizedText> element = uiTextPanel;
    element.OnMouseOver += new UIElement.MouseEvent(this.FadedMouseOver);
    element.OnMouseOut += new UIElement.MouseEvent(this.FadedMouseOut);
    element.OnLeftMouseDown += new UIElement.MouseEvent(this.Click_GoBack);
    element.SetSnapPoint("Back", 0);
    outerContainer.Append((UIElement) element);
    this._backButton = (UIElement) element;
  }

  private void Click_GoBack(UIMouseEvent evt, UIElement listeningElement) => this.GoBack();

  private void GoBack()
  {
    SoundEngine.PlaySound(11);
    Main.MenuUI.SetState((UIState) this._creationState);
    this._creationState.RefreshSecretSeedButton();
  }

  private void FadedMouseOver(UIMouseEvent evt, UIElement listeningElement)
  {
    SoundEngine.PlaySound(12);
    ((UIPanel) evt.Target).BackgroundColor = new Color(73, 94, 171);
    ((UIPanel) evt.Target).BorderColor = Colors.FancyUIFatButtonMouseOver;
    this.ShowOptionDescription(evt, listeningElement);
  }

  private void FadedMouseOut(UIMouseEvent evt, UIElement listeningElement)
  {
    ((UIPanel) evt.Target).BackgroundColor = new Color(63 /*0x3F*/, 82, 151) * 0.8f;
    ((UIPanel) evt.Target).BorderColor = Color.Black;
    this.ClearOptionDescription(evt, listeningElement);
  }

  public void HandleBackButtonUsage() => this.GoBack();

  public void ClearOptionDescription(UIMouseEvent evt, UIElement listeningElement)
  {
    this._descriptionText.SetText(Language.GetText("UI.WorldDescriptionDefault"));
  }

  public void ShowOptionDescription(UIMouseEvent evt, UIElement listeningElement)
  {
    LocalizedText text = (LocalizedText) null;
    if (listeningElement is GroupOptionButton<WorldGen.SecretSeed> groupOptionButton)
      text = groupOptionButton.Description;
    if (text == null)
      return;
    this._descriptionText.SetText(text);
  }

  public override void Draw(SpriteBatch spriteBatch)
  {
    base.Draw(spriteBatch);
    this.SetupGamepadPoints(spriteBatch);
    this.DrawSeedSystems(spriteBatch);
  }

  public void DrawSeedSystems(SpriteBatch spriteBatch)
  {
    this.SeedDust.UpdateDust();
    this.SeedDust.DrawDust();
    this.SeedParticleSystem.Update();
    this.SeedParticleSystem.Draw(spriteBatch);
  }

  private void SetupGamepadPoints(SpriteBatch spriteBatch)
  {
    UILinkPointNavigator.Shortcuts.BackButtonCommand = 7;
    int idRangeStartInclusive = 3000;
    int num = idRangeStartInclusive;
    this.GetSnapPoints();
    ref UIGamepadHelper local = ref this._helper;
    int id = num;
    int currentID = id + 1;
    UIElement backButton = this._backButton;
    UILinkPoint linkPoint = local.GetLinkPoint(id, backButton);
    List<SnapPoint> snapPoints = this._worldList.GetSnapPoints();
    UILinkPoint[,] uiLinkPointGrid = this._helper.CreateUILinkPointGrid(ref currentID, snapPoints, 1, (UILinkPoint) null, (UILinkPoint) null, (UILinkPoint) null, linkPoint);
    this._helper.PairUpDown(uiLinkPointGrid[0, uiLinkPointGrid.GetLength(1) - 1], linkPoint);
    this._helper.MoveToVisuallyClosestPoint(idRangeStartInclusive, currentID);
  }
}
