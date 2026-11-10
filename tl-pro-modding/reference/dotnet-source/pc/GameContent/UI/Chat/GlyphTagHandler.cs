// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.UI.Chat.GlyphTagHandler
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Steamworks;
using System.Collections.Generic;
using Terraria.UI.Chat;

#nullable disable
namespace Terraria.GameContent.UI.Chat;

public class GlyphTagHandler : ITagHandler
{
  private const int GlyphsPerLine = 25;
  private const int MaxGlyphs = 26;
  public static float GlyphsScale = 1f;
  public const int DefaultGlyphStyle = -1;
  public static int GlyphStyle = -1;
  private static Dictionary<string, int> GlyphIndexes = new Dictionary<string, int>()
  {
    {
      Buttons.A.ToString(),
      0
    },
    {
      Buttons.B.ToString(),
      1
    },
    {
      Buttons.Back.ToString(),
      4
    },
    {
      Buttons.DPadDown.ToString(),
      15
    },
    {
      Buttons.DPadLeft.ToString(),
      14
    },
    {
      Buttons.DPadRight.ToString(),
      13
    },
    {
      Buttons.DPadUp.ToString(),
      16 /*0x10*/
    },
    {
      Buttons.LeftShoulder.ToString(),
      6
    },
    {
      Buttons.LeftStick.ToString(),
      10
    },
    {
      Buttons.LeftThumbstickDown.ToString(),
      20
    },
    {
      Buttons.LeftThumbstickLeft.ToString(),
      17
    },
    {
      Buttons.LeftThumbstickRight.ToString(),
      18
    },
    {
      Buttons.LeftThumbstickUp.ToString(),
      19
    },
    {
      Buttons.LeftTrigger.ToString(),
      8
    },
    {
      Buttons.RightShoulder.ToString(),
      7
    },
    {
      Buttons.RightStick.ToString(),
      11
    },
    {
      Buttons.RightThumbstickDown.ToString(),
      24
    },
    {
      Buttons.RightThumbstickLeft.ToString(),
      21
    },
    {
      Buttons.RightThumbstickRight.ToString(),
      22
    },
    {
      Buttons.RightThumbstickUp.ToString(),
      23
    },
    {
      Buttons.RightTrigger.ToString(),
      9
    },
    {
      Buttons.Start.ToString(),
      5
    },
    {
      Buttons.X.ToString(),
      2
    },
    {
      Buttons.Y.ToString(),
      3
    },
    {
      "RightStickAxis",
      12
    },
    {
      "LR",
      25
    }
  };

  public static TextSnippet GetGlyph(string keyName)
  {
    return (TextSnippet) new GlyphTagHandler.GlyphSnippet(keyName);
  }

  TextSnippet ITagHandler.Parse(string text, Color baseColor, string options)
  {
    int result;
    if (!int.TryParse(text, out result) || result >= 26)
      return new TextSnippet(text);
    GlyphTagHandler.GlyphSnippet glyphSnippet = new GlyphTagHandler.GlyphSnippet(result);
    glyphSnippet.DeleteWhole = true;
    glyphSnippet.Text = $"[g:{(object) result}]";
    return (TextSnippet) glyphSnippet;
  }

  public static string GenerateTag(int index) => $"[g:{(object) index}]";

  public static string GenerateTag(string keyname)
  {
    int index;
    return GlyphTagHandler.GlyphIndexes.TryGetValue(keyname, out index) ? GlyphTagHandler.GenerateTag(index) : keyname;
  }

  public class GlyphXboxTagHandler : ITagHandler
  {
    TextSnippet ITagHandler.Parse(string text, Color baseColor, string options)
    {
      int result;
      if (!int.TryParse(text, out result) || result >= 26)
        return new TextSnippet(text);
      GlyphTagHandler.GlyphSnippet glyphSnippet = new GlyphTagHandler.GlyphSnippet(result);
      glyphSnippet.ForcedStyle = 0;
      glyphSnippet.DeleteWhole = true;
      glyphSnippet.Text = $"[gx:{(object) result}]";
      return (TextSnippet) glyphSnippet;
    }
  }

  public class GlyphPSTagHandler : ITagHandler
  {
    TextSnippet ITagHandler.Parse(string text, Color baseColor, string options)
    {
      int result;
      if (!int.TryParse(text, out result) || result >= 26)
        return new TextSnippet(text);
      GlyphTagHandler.GlyphSnippet glyphSnippet = new GlyphTagHandler.GlyphSnippet(result);
      glyphSnippet.ForcedStyle = 1;
      glyphSnippet.DeleteWhole = true;
      glyphSnippet.Text = $"[gp:{(object) result}]";
      return (TextSnippet) glyphSnippet;
    }
  }

  public class GlyphSwitchTagHandler : ITagHandler
  {
    TextSnippet ITagHandler.Parse(string text, Color baseColor, string options)
    {
      int result;
      if (!int.TryParse(text, out result) || result >= 26)
        return new TextSnippet(text);
      GlyphTagHandler.GlyphSnippet glyphSnippet = new GlyphTagHandler.GlyphSnippet(result);
      glyphSnippet.ForcedStyle = 2;
      glyphSnippet.DeleteWhole = true;
      glyphSnippet.Text = $"[gn:{(object) result}]";
      return (TextSnippet) glyphSnippet;
    }
  }

  public class GlyphSnippet : TextSnippet
  {
    public int ForcedStyle = -1;
    private int _glyphIndex;

    public GlyphSnippet(int index)
      : base()
    {
      this._glyphIndex = index;
      this.Color = Color.White;
    }

    public GlyphSnippet(string keyName)
      : base()
    {
      GlyphTagHandler.GlyphIndexes.TryGetValue(keyName, out this._glyphIndex);
      this.Color = Color.White;
    }

    private static int GetAutoRow()
    {
      SteamInput.RunFrame(true);
      int autoRow = 0;
      InputHandle_t controllerForGamepadIndex = SteamInput.GetControllerForGamepadIndex(0);
      if (controllerForGamepadIndex.m_InputHandle != 0UL)
      {
        switch (SteamInput.GetInputTypeForHandle(controllerForGamepadIndex) - 5)
        {
          case 0:
          case 7:
          case 8:
            autoRow = 1;
            break;
          case 3:
          case 4:
          case 5:
            autoRow = 2;
            break;
        }
      }
      return autoRow;
    }

    public override bool UniqueDraw(
      bool justCheckingString,
      out Vector2 size,
      SpriteBatch spriteBatch,
      Vector2 position = default (Vector2),
      Color color = default (Color),
      float scale = 1f)
    {
      scale *= GlyphTagHandler.GlyphsScale;
      if (!justCheckingString && color != Color.Black)
      {
        int frameY = this.ForcedStyle;
        if (frameY == -1)
          frameY = GlyphTagHandler.GlyphStyle != -1 ? GlyphTagHandler.GlyphStyle : GlyphTagHandler.GlyphSnippet.GetAutoRow();
        int frameX = this._glyphIndex;
        if (this._glyphIndex == 25)
          frameX = (double) Main.GlobalTimeWrappedHourly % 0.60000002384185791 < 0.30000001192092896 ? 17 : 18;
        Texture2D texture2D = TextureAssets.TextGlyph[0].Value;
        spriteBatch.Draw(texture2D, position, new Rectangle?(texture2D.Frame(25, 3, frameX, frameY)), color, 0.0f, Vector2.Zero, scale, SpriteEffects.None, 0.0f);
      }
      size = new Vector2(26f) * scale;
      return true;
    }
  }
}
