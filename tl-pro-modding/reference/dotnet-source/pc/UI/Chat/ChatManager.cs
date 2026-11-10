// Decompiled with JetBrains decompiler
// Type: Terraria.UI.Chat.ChatManager
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Graphics;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Terraria.Chat;
using Terraria.GameContent.UI.Chat;
using Terraria.Localization;
using Terraria.Testing.ChatCommands;

#nullable disable
namespace Terraria.UI.Chat;

public static class ChatManager
{
  public static readonly DebugCommandProcessor DebugCommands = new DebugCommandProcessor();
  public static readonly ChatCommandProcessor Commands = new ChatCommandProcessor();
  private static ConcurrentDictionary<string, ITagHandler> _handlers = new ConcurrentDictionary<string, ITagHandler>();
  public static readonly Vector2[] ShadowDirections = new Vector2[4]
  {
    -Vector2.UnitX,
    Vector2.UnitX,
    -Vector2.UnitY,
    Vector2.UnitY
  };

  public static Color WaveColor(Color color)
  {
    float num = (float) Main.mouseTextColor / (float) byte.MaxValue;
    color = Color.Lerp(color, Color.Black, 1f - num);
    color.A = Main.mouseTextColor;
    return color;
  }

  public static void ConvertNormalSnippets(List<TextSnippet> snippets)
  {
    for (int index = 0; index < snippets.Count; ++index)
    {
      TextSnippet snippet = snippets[index];
      if (snippet.GetType() == typeof (TextSnippet))
        snippets[index] = (TextSnippet) new PlainTagHandler.PlainSnippet(snippet.Text, snippet.Color);
    }
  }

  public static void Register<T>(params string[] names) where T : ITagHandler, new()
  {
    T obj = new T();
    for (int index = 0; index < names.Length; ++index)
      ChatManager._handlers[names[index].ToLower()] = (ITagHandler) obj;
  }

  private static ITagHandler GetHandler(string tagName)
  {
    string lower = tagName.ToLower();
    return ChatManager._handlers.ContainsKey(lower) ? ChatManager._handlers[lower] : (ITagHandler) null;
  }

  public static bool MayNeedParsing(string text)
  {
    return text.IndexOf('\r') >= 0 || ChatManager.Regexes.Format.IsMatch(text);
  }

  public static List<TextSnippet> ParseMessage(string text, Color baseColor)
  {
    text = text.Replace("\r", "");
    MatchCollection matchCollection = ChatManager.Regexes.Format.Matches(text);
    List<TextSnippet> message = new List<TextSnippet>();
    int startIndex = 0;
    foreach (Match match in matchCollection)
    {
      if (match.Index > startIndex)
        message.Add(new TextSnippet(text.Substring(startIndex, match.Index - startIndex), baseColor));
      startIndex = match.Index + match.Length;
      string tagName = match.Groups["tag"].Value;
      string text1 = match.Groups[nameof (text)].Value.Replace("\\]", "]");
      string options = match.Groups["options"].Value;
      ITagHandler handler = ChatManager.GetHandler(tagName);
      if (handler != null)
      {
        message.Add(handler.Parse(text1, baseColor, options));
        message[message.Count - 1].TextOriginal = match.ToString();
      }
      else
        message.Add(new TextSnippet(text1, baseColor));
    }
    if (text.Length > startIndex)
      message.Add(new TextSnippet(text.Substring(startIndex, text.Length - startIndex), baseColor));
    return message;
  }

  public static bool AddChatText(DynamicSpriteFont font, string text, Vector2 baseScale)
  {
    int num = Main.screenWidth - 330;
    if ((double) ChatManager.GetStringSize(font, Main.chatText + text, baseScale).X > (double) num)
      return false;
    Main.chatText += text;
    return true;
  }

  public static IEnumerable<PositionedSnippet> LayoutSnippets(
    DynamicSpriteFont font,
    IEnumerable<TextSnippet> snippets,
    Vector2 scale,
    float maxWidth = -1f)
  {
    int line = 0;
    Vector2 pos = Vector2.Zero;
    float uniqueDrawScale = Math.Min(scale.X, scale.Y);
    int i = 0;
    foreach (TextSnippet snippet in snippets)
    {
      Vector2 size;
      if (snippet.UniqueDraw(true, out size, (SpriteBatch) null, scale: uniqueDrawScale))
      {
        if ((double) maxWidth >= 0.0 && (double) pos.X + (double) size.X > (double) maxWidth)
        {
          pos.X = 0.0f;
          pos.Y += (float) font.LineSpacing * scale.Y;
          ++line;
        }
        yield return new PositionedSnippet(snippet, i, line, pos, size);
        pos.X += size.X;
      }
      else
      {
        string text = font.CreateWrappedText(snippet.Text, scale.X, maxWidth, pos.X, Language.ActiveCulture.CultureInfo);
        int startIndex = 0;
        while (true)
        {
          int sep = text.IndexOf('\n', startIndex);
          int length = (sep < 0 ? text.Length : sep) - startIndex;
          if (length > 0)
          {
            string newText = text.Substring(startIndex, length);
            size = font.MeasureString(newText) * scale;
            yield return new PositionedSnippet(snippet.CopyMorph(newText), i, line, pos, size);
            pos.X += size.X;
          }
          if (sep >= 0)
          {
            pos.X = 0.0f;
            pos.Y += (float) font.LineSpacing * scale.Y;
            ++line;
            startIndex = sep + 1;
          }
          else
            break;
        }
        text = (string) null;
      }
      ++i;
      size = new Vector2();
    }
  }

  public static Vector2 GetStringSize(
    DynamicSpriteFont font,
    string text,
    Vector2 baseScale,
    float maxWidth = -1f)
  {
    return ChatManager.GetStringSize(font, (IEnumerable<TextSnippet>) ChatManager.ParseMessage(text, Color.White), baseScale, maxWidth);
  }

  public static Vector2 GetStringSize(
    DynamicSpriteFont font,
    IEnumerable<TextSnippet> snippets,
    Vector2 scale,
    float maxWidth = -1f)
  {
    return ChatManager.GetStringSize(ChatManager.LayoutSnippets(font, snippets, scale, maxWidth));
  }

  public static Vector2 GetStringSize(IEnumerable<PositionedSnippet> snippets)
  {
    Vector2 zero = Vector2.Zero;
    foreach (PositionedSnippet snippet in snippets)
    {
      zero.X = Math.Max(zero.X, snippet.Position.X + snippet.Size.X);
      zero.Y = Math.Max(zero.Y, snippet.Position.Y + snippet.Size.Y);
    }
    return zero;
  }

  public static void DrawColorCodedStringShadow(
    SpriteBatch spriteBatch,
    DynamicSpriteFont font,
    IEnumerable<TextSnippet> snippets,
    Vector2 position,
    Color shadowColor,
    float rotation,
    Vector2 origin,
    Vector2 scale,
    float maxWidth = -1f,
    float spread = 2f)
  {
    List<PositionedSnippet> list = ChatManager.LayoutSnippets(font, snippets, scale, maxWidth).ToList<PositionedSnippet>();
    ChatManager.DrawColorCodedStringShadow(spriteBatch, font, list, position, shadowColor, rotation, origin, scale, spread);
  }

  public static void DrawColorCodedStringShadow(
    SpriteBatch spriteBatch,
    DynamicSpriteFont font,
    List<PositionedSnippet> snippets,
    Vector2 position,
    Color shadowColor,
    float rotation,
    Vector2 origin,
    Vector2 scale,
    float spread = 2f)
  {
    for (int index = 0; index < ChatManager.ShadowDirections.Length; ++index)
      ChatManager.DrawColorCodedString(spriteBatch, font, (IEnumerable<PositionedSnippet>) snippets, position + ChatManager.ShadowDirections[index] * spread, rotation, origin, scale, out int _, new Color?(shadowColor));
  }

  public static void DrawColorCodedString(
    SpriteBatch spriteBatch,
    DynamicSpriteFont font,
    IEnumerable<TextSnippet> snippets,
    Vector2 position,
    Color baseColor,
    float rotation,
    Vector2 origin,
    Vector2 scale,
    out int hoveredSnippet,
    float maxWidth = -1f,
    bool ignoreColors = false)
  {
    ChatManager.DrawColorCodedString(spriteBatch, font, ChatManager.LayoutSnippets(font, snippets, scale, maxWidth), position, rotation, origin, scale, out hoveredSnippet, ignoreColors ? new Color?(baseColor) : new Color?());
  }

  public static void DrawColorCodedString(
    SpriteBatch spriteBatch,
    DynamicSpriteFont font,
    IEnumerable<TextSnippet> snippets,
    Vector2 position,
    float rotation,
    Vector2 origin,
    Vector2 scale,
    out int hoveredSnippet,
    float maxWidth = -1f)
  {
    ChatManager.DrawColorCodedString(spriteBatch, font, ChatManager.LayoutSnippets(font, snippets, scale, maxWidth), position, rotation, origin, scale, out hoveredSnippet);
  }

  public static void DrawColorCodedString(
    SpriteBatch spriteBatch,
    DynamicSpriteFont font,
    IEnumerable<PositionedSnippet> snippets,
    Vector2 position,
    float rotation,
    Vector2 origin,
    Vector2 scale,
    out int hoveredSnippet,
    Color? colorOverride = null)
  {
    hoveredSnippet = -1;
    Vector2 vec = new Vector2((float) Main.mouseX, (float) Main.mouseY);
    float scale1 = Math.Min(scale.X, scale.Y);
    foreach (PositionedSnippet snippet1 in snippets)
    {
      Vector2 vector2 = position + snippet1.Position;
      TextSnippet snippet2 = snippet1.Snippet;
      Color color = colorOverride.HasValue ? colorOverride.Value : snippet2.GetVisibleColor();
      if (!snippet2.UniqueDraw(false, out Vector2 _, spriteBatch, vector2, color, scale1))
        DynamicSpriteFontExtensionMethods.DrawString(spriteBatch, font, snippet2.Text, vector2, color, rotation, origin, scale, SpriteEffects.None, 0.0f);
      if (vec.Between(vector2, vector2 + snippet1.Size))
        hoveredSnippet = snippet1.OrigIndex;
    }
  }

  public static void DrawColorCodedStringWithShadow(
    SpriteBatch spriteBatch,
    DynamicSpriteFont font,
    TextSnippet[] snippets,
    Vector2 position,
    float rotation,
    Vector2 origin,
    Vector2 baseScale,
    out int hoveredSnippet,
    float maxWidth = -1f,
    float spread = 2f)
  {
    ChatManager.DrawColorCodedStringShadow(spriteBatch, font, (IEnumerable<TextSnippet>) snippets, position, Color.Black, rotation, origin, baseScale, maxWidth, spread);
    ChatManager.DrawColorCodedString(spriteBatch, font, (IEnumerable<TextSnippet>) snippets, position, rotation, origin, baseScale, out hoveredSnippet, maxWidth);
  }

  public static void DrawColorCodedStringWithShadow(
    SpriteBatch spriteBatch,
    DynamicSpriteFont font,
    TextSnippet[] snippets,
    Vector2 position,
    Color color,
    float rotation,
    Vector2 origin,
    Vector2 baseScale,
    out int hoveredSnippet,
    float maxWidth = -1f,
    float spread = 2f)
  {
    ChatManager.DrawColorCodedStringShadow(spriteBatch, font, (IEnumerable<TextSnippet>) snippets, position, color.MultiplyRGBA(Color.Black), rotation, origin, baseScale, maxWidth, spread);
    ChatManager.DrawColorCodedString(spriteBatch, font, (IEnumerable<TextSnippet>) snippets, position, color, rotation, origin, baseScale, out hoveredSnippet, maxWidth, true);
  }

  public static void DrawColorCodedStringShadow(
    SpriteBatch spriteBatch,
    DynamicSpriteFont font,
    string text,
    Vector2 position,
    Color baseColor,
    float rotation,
    Vector2 origin,
    Vector2 baseScale,
    float maxWidth = -1f,
    float spread = 2f)
  {
    for (int index = 0; index < ChatManager.ShadowDirections.Length; ++index)
      ChatManager.DrawColorCodedString(spriteBatch, font, text, position + ChatManager.ShadowDirections[index] * spread, baseColor, rotation, origin, baseScale, maxWidth, true);
  }

  public static Vector2 DrawColorCodedString(
    SpriteBatch spriteBatch,
    DynamicSpriteFont font,
    string text,
    Vector2 position,
    Color baseColor,
    float rotation,
    Vector2 origin,
    Vector2 baseScale,
    float maxWidth = -1f,
    bool ignoreColors = false)
  {
    Vector2 vector2_1 = position;
    Vector2 vector2_2 = vector2_1;
    string[] strArray1 = text.Split('\n');
    float x = font.MeasureString(" ").X;
    Color color = baseColor;
    float num1 = 1f;
    float num2 = 0.0f;
    foreach (string str1 in strArray1)
    {
      char[] chArray = new char[1]{ ':' };
      foreach (string str2 in str1.Split(chArray))
      {
        if (str2.StartsWith("sss"))
        {
          if (str2.StartsWith("sss1"))
          {
            if (!ignoreColors)
              color = Color.Red;
          }
          else if (str2.StartsWith("sss2"))
          {
            if (!ignoreColors)
              color = Color.Blue;
          }
          else if (str2.StartsWith("sssr") && !ignoreColors)
            color = Color.White;
        }
        else
        {
          string[] strArray2 = str2.Split(' ');
          for (int index = 0; index < strArray2.Length; ++index)
          {
            if (index != 0)
              vector2_1.X += x * baseScale.X * num1;
            if ((double) maxWidth > 0.0)
            {
              float num3 = font.MeasureString(strArray2[index]).X * baseScale.X * num1;
              if ((double) vector2_1.X - (double) position.X + (double) num3 > (double) maxWidth)
              {
                vector2_1.X = position.X;
                vector2_1.Y += (float) font.LineSpacing * num2 * baseScale.Y;
                vector2_2.Y = Math.Max(vector2_2.Y, vector2_1.Y);
                num2 = 0.0f;
              }
            }
            if ((double) num2 < (double) num1)
              num2 = num1;
            DynamicSpriteFontExtensionMethods.DrawString(spriteBatch, font, strArray2[index], vector2_1, color, rotation, origin, baseScale * num1, SpriteEffects.None, 0.0f);
            vector2_1.X += font.MeasureString(strArray2[index]).X * baseScale.X * num1;
            vector2_2.X = Math.Max(vector2_2.X, vector2_1.X);
          }
        }
      }
      vector2_1.X = position.X;
      vector2_1.Y += (float) font.LineSpacing * num2 * baseScale.Y;
      vector2_2.Y = Math.Max(vector2_2.Y, vector2_1.Y);
      num2 = 0.0f;
    }
    return vector2_2;
  }

  public static void DrawColorCodedStringWithShadow(
    SpriteBatch spriteBatch,
    DynamicSpriteFont font,
    string text,
    Vector2 position,
    Color baseColor,
    float rotation,
    Vector2 origin,
    Vector2 scale,
    float maxWidth = -1f,
    float spread = 2f)
  {
    Color shadowColor = baseColor.MultiplyRGBA(Color.Black);
    if ((double) maxWidth < 0.0 && !ChatManager.MayNeedParsing(text))
    {
      foreach (Vector2 shadowDirection in ChatManager.ShadowDirections)
        DynamicSpriteFontExtensionMethods.DrawString(spriteBatch, font, text, position + shadowDirection * spread, shadowColor, rotation, origin, scale, SpriteEffects.None, 0.0f);
      DynamicSpriteFontExtensionMethods.DrawString(spriteBatch, font, text, position, baseColor, rotation, origin, scale, SpriteEffects.None, 0.0f);
    }
    else
    {
      List<TextSnippet> message = ChatManager.ParseMessage(text, baseColor);
      ChatManager.ConvertNormalSnippets(message);
      List<PositionedSnippet> list = ChatManager.LayoutSnippets(font, (IEnumerable<TextSnippet>) message, scale, maxWidth).ToList<PositionedSnippet>();
      ChatManager.DrawColorCodedStringShadow(spriteBatch, font, list, position, shadowColor, rotation, origin, scale, spread);
      ChatManager.DrawColorCodedString(spriteBatch, font, (IEnumerable<PositionedSnippet>) list, position, rotation, origin, scale, out int _);
    }
  }

  public static class Regexes
  {
    public static readonly Regex Format = new Regex("(?<!\\\\)\\[(?<tag>[a-zA-Z]{1,10})(\\/(?<options>[^:]+))?:(?<text>.+?)(?<!\\\\)\\]", RegexOptions.Compiled | RegexOptions.Singleline);
  }
}
