// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.UI.States.UITextWrappingTest
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using Terraria.Audio;
using Terraria.GameContent.UI.Elements;
using Terraria.Localization;
using Terraria.UI;
using Terraria.UI.Chat;

#nullable disable
namespace Terraria.GameContent.UI.States;

public class UITextWrappingTest : UIState
{
  private static readonly float TextPadding = 12f;
  private UIList list;
  private UIText modeText;
  private UIText scaleText;
  private UIText langText;
  private UITextWrappingTest.Mode mode;
  private int scale = 100;

  public UITextWrappingTest()
  {
    UIPanel uiPanel = new UIPanel();
    uiPanel.Top = StyleDimension.FromPixels(100f);
    uiPanel.Left = StyleDimension.FromPixelsAndPercent(-400f, 0.5f);
    uiPanel.Width = StyleDimension.FromPixels(300f);
    uiPanel.Height = StyleDimension.FromPixels(40f);
    uiPanel.BackgroundColor = new Color(43, 56, 101);
    uiPanel.BorderColor = Color.Transparent;
    UIPanel element = uiPanel;
    UIText uiText1 = new UIText(this.mode.ToString(), 0.8f);
    uiText1.TextOriginX = 0.0f;
    uiText1.Width = StyleDimension.FromPercent(1f);
    uiText1.Height = StyleDimension.FromPercent(1f);
    this.modeText = uiText1;
    element.Append((UIElement) this.modeText);
    element.OnLeftClick += (UIElement.MouseEvent) ((e, sender) => this.CycleMode(1));
    element.OnRightClick += (UIElement.MouseEvent) ((e, sender) => this.CycleMode(-1));
    this.Append((UIElement) element);
    UIText uiText2 = new UIText(this.ScaleText, 0.8f);
    uiText2.TextOriginX = 0.0f;
    uiText2.Top = StyleDimension.FromPixels(150f);
    uiText2.Left = StyleDimension.FromPixelsAndPercent(-400f, 0.5f);
    uiText2.Width = StyleDimension.FromPixels(300f);
    uiText2.Height = StyleDimension.FromPixels(40f);
    this.scaleText = uiText2;
    this.Append((UIElement) this.scaleText);
    UIText uiText3 = new UIText(this.LangText, 0.8f);
    uiText3.TextOriginX = 1f;
    uiText3.HAlign = 1f;
    uiText3.Top = StyleDimension.FromPixels(150f);
    uiText3.Left = StyleDimension.FromPixelsAndPercent(400f, -0.5f);
    uiText3.Width = StyleDimension.FromPixels(300f);
    uiText3.Height = StyleDimension.FromPixels(40f);
    this.langText = uiText3;
    this.Append((UIElement) this.langText);
    UIList uiList = new UIList();
    uiList.Top = StyleDimension.FromPixels(200f);
    uiList.Left = StyleDimension.FromPixelsAndPercent(-400f, 0.5f);
    uiList.Width = StyleDimension.FromPixels(300f);
    uiList.Height = StyleDimension.FromPixelsAndPercent(-200f, 1f);
    uiList.ListPadding = 5f;
    uiList.ManualSortMethod = (Action<List<UIElement>>) (_ => { });
    this.list = uiList;
    this.list.SetPadding(0.0f);
    this.Append((UIElement) this.list);
    UIScrollbar scrollbar = new UIScrollbar();
    scrollbar.SetView(100f, 1000f);
    scrollbar.Height.Set(-20f, 1f);
    scrollbar.HAlign = 1f;
    scrollbar.VAlign = 0.5f;
    scrollbar.Left.Set(6f, 0.0f);
    this.list.SetScrollbar(scrollbar);
    this.ResetList();
  }

  private string ScaleText => $"Up/Down to change scale. Current: {(object) this.scale}%";

  private string LangText => "Current Language: " + Language.ActiveCulture.CultureInfo.DisplayName;

  private void CycleMode(int offset)
  {
    int length = Enum.GetValues(typeof (UITextWrappingTest.Mode)).Length;
    this.mode = (UITextWrappingTest.Mode) ((int) (this.mode + offset + length) % length);
    this.ResetList();
  }

  private void ResetList()
  {
    this.modeText.SetText(this.mode.ToString());
    this.list.Clear();
    this.list.Add(this.MakeElement("A test string in english.\nSecond line.\n\n^ Double line break\nLooooooooooooooonglinewithnospaces"));
    this.list.Add(this.MakeElement("Ends with newline\n"));
    this.list.Add(this.MakeElement("Non-breaking space: с микротранзакциями\n"));
    this.list.Add(this.MakeElement("Thin Space\nHair Space\nZero\u200BWidth\u200BSpace"));
    this.list.Add(this.NewSeparator());
    this.list.Add(this.MakeElement("せいなる スライムが がったいして できた 生き物。ごうまんで 力づよく きらめく けっしょうに おおわれている。つばさが 生える という うわさも ある。"));
    this.list.Add(this.MakeElement("정화된 슬라임들이 모두 통합되어, 눈부신 수정으로 장식된 거만하고 압도적인 힘이 되었습니다. 날개가 돋아난다는 소문도 있습니다. "));
    this.list.Add(this.MakeElement("Святые слизни объединяются в величественную всесокрушающую массу, украшенную превосходными кристаллами. Говорят, она даже может отрастить крылья."));
    this.list.Add(this.MakeElement("神圣史莱姆合并成了一种高傲的粉碎性力量，这种力量佩戴着闪耀的水晶。传说她会长出翅膀。"));
    this.list.Add(this.MakeElement("神聖史萊姆融合後，會點綴著閃耀的水晶，擁有傲視一切的粉碎性力量。傳說她會長出翅膀。"));
    this.list.Add(this.NewSeparator());
    this.list.Add(this.MakeElement("fullwidth terminators。bang！comma，fullstop。rcomma、colon：question？"));
    this.list.Add(this.MakeElement("Chinese separation〈聖聖聖聖〉《聖聖》「聖聖」『聖聖』【聖聖〔聖聖】〖聖聖〗!%),.:;?]}$100,25.24%"));
    this.list.Add(this.NewSeparator());
    this.list.Add(this.MakeElement(new LocalizedText("", "Keybind glyph support {InputTrigger_UseOrAttack} and {InputTrigger_InteractWithTile}").Value));
    this.list.Add(this.MakeElement("[c/FF0000:SomeRedText] [c/00FF00:SomeGreenText] [c/0000FF:SomeBlueText]"));
    this.list.Add(this.MakeElement("[c/FF0000:SomeRedText][c/00FF00:SomeGreenText][c/0000FF:SomeBlueText]"));
    this.list.Add(this.MakeElement("[c/0000FF:Long colored text, with escaped square brackets [\\] inside]"));
    this.list.Add(this.MakeElement("Items[i:1][i:2][i:3][i:4][i:5][i:6][i:7][i:100][i:1000]"));
    this.list.Add(this.MakeElement("ItemsOnSeparateLines\n[i:1]\n[i:2]\n[i:3]"));
    this.list.Add(this.MakeElement("Items and text [i:1] then stuff [i:2] and some more [i:3] etc"));
    this.list.Add(this.MakeElement("nospacebetweenitems[i:6]andtext[i:7]nospacebetweenitems[i:8]andtext[i:9]"));
    this.list.Add(this.MakeElement("[g:0][g:1][g:2][g:3][g:4][g:5][g:6][g:7][g:8][g:9][g:10][g:11][g:12][g:13][g:14][g:15][g:16][g:17][g:18][g:19][g:20][g:21][g:22][g:23][g:24][g:25]"));
    this.list.Add(this.MakeElement(Language.GetTextValue("Achievements.Completed", (object) "[a:TRANSMUTE_ITEM]")));
    this.list.Add(this.MakeElement("[a:TO_INFINITY_AND_BEYOND][a:PURIFY_ENTIRE_WORLD][a:TO_INFINITY_AND_BEYOND][a:TRANSMUTE_ITEM][a:OBTAIN_HAMMER][a:BENCHED][a:HEAVY_METAL][a:GET_GOLDEN_DELIGHT][a:MINER_FOR_FIRE][a:HEAD_IN_THE_CLOUDS][a:GET_TERRASPARK_BOOTS]"));
  }

  private UIElement NewSeparator()
  {
    UIHorizontalSeparator horizontalSeparator = new UIHorizontalSeparator();
    horizontalSeparator.Width = StyleDimension.FromPixelsAndPercent(0.0f, 1f);
    horizontalSeparator.Color = new Color(89, 116, 213, (int) byte.MaxValue) * 0.9f;
    return (UIElement) horizontalSeparator;
  }

  private UIElement MakeElement(string value)
  {
    UIPanel uiPanel = new UIPanel();
    uiPanel.Width = StyleDimension.FromPercent(1f);
    uiPanel.Height = StyleDimension.FromPixels((float) (50 * this.scale));
    uiPanel.BackgroundColor = new Color(43, 56, 101);
    uiPanel.BorderColor = Color.Transparent;
    UIElement container = (UIElement) uiPanel;
    container.SetPadding(UITextWrappingTest.TextPadding);
    if (this.mode == UITextWrappingTest.Mode.UIText)
    {
      UIText uiText = new UIText(value, (float) this.scale / 100f);
      uiText.TextOriginX = 0.0f;
      uiText.HAlign = 0.0f;
      uiText.VAlign = 0.0f;
      uiText.Width = StyleDimension.FromPercent(1f);
      uiText.Height = StyleDimension.FromPercent(1f);
      uiText.IsWrapped = true;
      UIText text = uiText;
      text.OnInternalTextChange += (Action) (() => container.Height = new StyleDimension(text.MinHeight.Pixels, 0.0f));
      container.Append((UIElement) text);
    }
    else
    {
      UITextWrappingTest.TestElement testElement = new UITextWrappingTest.TestElement(value, (float) this.scale / 100f, this.mode);
      testElement.Width = StyleDimension.FromPercent(1f);
      UITextWrappingTest.TestElement text = testElement;
      text.OnHeightUpdate += (Action) (() => container.Height = new StyleDimension(text.MinHeight.Pixels + container.PaddingTop + container.PaddingBottom, 0.0f));
      container.Append((UIElement) text);
    }
    return container;
  }

  public override void Draw(SpriteBatch spriteBatch)
  {
    base.Draw(spriteBatch);
    CalculatedStyle dimensions = this.list.GetDimensions();
    int x1 = (int) ((double) dimensions.X + (double) UITextWrappingTest.TextPadding);
    int x2 = (int) ((double) dimensions.X + (double) dimensions.Width - (double) UITextWrappingTest.TextPadding);
    spriteBatch.Draw(TextureAssets.MagicPixel.Value, new Rectangle(x1, (int) dimensions.Y, 1, (int) dimensions.Height), Color.Green);
    spriteBatch.Draw(TextureAssets.MagicPixel.Value, new Rectangle(x2, (int) dimensions.Y, 1, (int) dimensions.Height), Color.Green);
  }

  public override void Update(GameTime gameTime)
  {
    if (Main.keyState.IsKeyDown(Keys.Escape))
    {
      SoundEngine.PlaySound(11);
      Main.menuMode = 0;
    }
    int num = 0;
    if (Main.keyState.IsKeyDown(Keys.Down) && Main.oldKeyState.IsKeyUp(Keys.Down))
      num = -10;
    if (Main.keyState.IsKeyDown(Keys.Up) && Main.oldKeyState.IsKeyUp(Keys.Up))
      num = 10;
    if (num != 0)
    {
      this.scale = Utils.Clamp<int>(this.scale + num, 50, 150);
      this.ResetList();
      this.scaleText.SetText(this.ScaleText);
    }
    this.langText.SetText(this.LangText);
    if (Main.mouseLeft)
    {
      Point point = Main.MouseScreen.ToPoint();
      CalculatedStyle dimensions = this.list.GetDimensions();
      if ((double) point.X > (double) dimensions.X && (double) point.Y > (double) dimensions.Y)
        this.list.Width = StyleDimension.FromPixels((float) point.X - dimensions.X);
    }
    base.Update(gameTime);
  }

  private enum Mode
  {
    UIText,
    SignsAndNPCChat,
    WordwrapStringLegacy,
    DrawColorCodedStringWithShadow,
    DrawColorCodedStringLegacy,
    MultilineChat,
  }

  private class TestElement : UIElement
  {
    private readonly string text;
    private readonly float scale;
    private readonly UITextWrappingTest.Mode mode;
    public Action OnHeightUpdate;

    public TestElement(string text, float scale, UITextWrappingTest.Mode mode)
    {
      this.text = text;
      this.scale = scale;
      this.mode = mode;
    }

    protected override void DrawSelf(SpriteBatch spriteBatch)
    {
      Vector2 position = this.GetDimensions().Position();
      float maxWidth = this.GetInnerDimensions().Width;
      if ((double) maxWidth <= 0.0)
        maxWidth = 1000f;
      switch (this.mode)
      {
        case UITextWrappingTest.Mode.SignsAndNPCChat:
          int lineAmount1;
          string[] strArray1 = Utils.WordwrapString(this.text, FontAssets.MouseText.Value, (int) ((double) maxWidth / (double) this.scale), 10, out lineAmount1);
          float num1 = 30f * this.scale;
          this.MinHeight.Set((float) lineAmount1 * num1, 0.0f);
          this.OnHeightUpdate();
          for (int index = 0; index < lineAmount1; ++index)
            Utils.DrawBorderStringFourWay(spriteBatch, FontAssets.MouseText.Value, strArray1[index], position.X, position.Y + (float) index * num1, Color.White, Color.Black, Vector2.Zero, this.scale);
          break;
        case UITextWrappingTest.Mode.WordwrapStringLegacy:
          int lineAmount2;
          string[] strArray2 = Utils.WordwrapStringLegacy(this.text, FontAssets.MouseText.Value, (int) ((double) maxWidth / (double) this.scale), 10, out lineAmount2);
          float num2 = 30f * this.scale;
          this.MinHeight.Set((float) lineAmount2 * num2, 0.0f);
          this.OnHeightUpdate();
          for (int index = 0; index < lineAmount2; ++index)
            Utils.DrawBorderStringFourWay(spriteBatch, FontAssets.MouseText.Value, strArray2[index], position.X, position.Y + (float) index * num2, Color.White, Color.Black, Vector2.Zero, this.scale);
          break;
        case UITextWrappingTest.Mode.DrawColorCodedStringWithShadow:
          ChatManager.DrawColorCodedStringWithShadow(spriteBatch, FontAssets.MouseText.Value, this.text, position, Color.White, 0.0f, Vector2.Zero, new Vector2(this.scale), maxWidth);
          this.MinHeight.Set(ChatManager.GetStringSize(FontAssets.MouseText.Value, this.text, new Vector2(this.scale), maxWidth).Y, 0.0f);
          this.OnHeightUpdate();
          break;
        case UITextWrappingTest.Mode.DrawColorCodedStringLegacy:
          ChatManager.DrawColorCodedStringShadow(spriteBatch, FontAssets.MouseText.Value, this.text, position, Color.Black, 0.0f, Vector2.Zero, new Vector2(this.scale), maxWidth);
          ChatManager.DrawColorCodedString(spriteBatch, FontAssets.MouseText.Value, this.text, position, Color.White, 0.0f, Vector2.Zero, new Vector2(this.scale), maxWidth);
          this.MinHeight.Set(ChatManager.GetStringSize(FontAssets.MouseText.Value, this.text, new Vector2(this.scale), maxWidth).Y, 0.0f);
          this.OnHeightUpdate();
          break;
        case UITextWrappingTest.Mode.MultilineChat:
          List<List<TextSnippet>> textSnippetListList = Utils.WordwrapStringSmart(this.text, Color.White, FontAssets.MouseText.Value, (float) (int) ((double) maxWidth / (double) this.scale), 10);
          float num3 = 30f * this.scale;
          this.MinHeight.Set((float) textSnippetListList.Count * num3, 0.0f);
          this.OnHeightUpdate();
          for (int index = 0; index < textSnippetListList.Count; ++index)
            ChatManager.DrawColorCodedStringWithShadow(spriteBatch, FontAssets.MouseText.Value, textSnippetListList[index].ToArray(), position + new Vector2(0.0f, (float) index * num3), 0.0f, Vector2.Zero, new Vector2(this.scale), out int _);
          break;
      }
    }
  }
}
