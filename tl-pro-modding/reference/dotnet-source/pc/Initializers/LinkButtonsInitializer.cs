// Decompiled with JetBrains decompiler
// Type: Terraria.Initializers.LinkButtonsInitializer
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using System.Collections.Generic;
using Terraria.DataStructures;

#nullable disable
namespace Terraria.Initializers;

public class LinkButtonsInitializer
{
  public static void Load()
  {
    List<TitleLinkButton> titleLinks = Main.TitleLinks;
    titleLinks.Add(LinkButtonsInitializer.MakeSimpleButton("TitleLinks.Discord", "https://discord.gg/terraria", 0));
    titleLinks.Add(LinkButtonsInitializer.MakeSimpleButton("TitleLinks.Instagram", "https://www.instagram.com/terraria_logic/", 1));
    titleLinks.Add(LinkButtonsInitializer.MakeSimpleButton("TitleLinks.Reddit", "https://www.reddit.com/r/Terraria/", 2));
    titleLinks.Add(LinkButtonsInitializer.MakeSimpleButton("TitleLinks.Twitter", "https://twitter.com/Terraria_Logic", 3));
    titleLinks.Add(LinkButtonsInitializer.MakeSimpleButton("TitleLinks.Bluesky", "https://bsky.app/profile/terraria.bsky.social", 4));
    titleLinks.Add(LinkButtonsInitializer.MakeSimpleButton("TitleLinks.Forums", "https://forums.terraria.org/index.php", 5));
    titleLinks.Add(LinkButtonsInitializer.MakeSimpleButton("TitleLinks.Merch", "https://terraria.org/store", 6));
    titleLinks.Add(LinkButtonsInitializer.MakeSimpleButton("TitleLinks.Wiki", "https://terraria.wiki.gg/", 7));
  }

  private static TitleLinkButton MakeSimpleButton(
    string textKey,
    string linkUrl,
    int horizontalFrameIndex)
  {
    Asset<Texture2D> tex = Main.Assets.Request<Texture2D>("Images/UI/TitleLinkButtons", (AssetRequestMode) 1);
    Rectangle rectangle1 = tex.Frame(8, 2, horizontalFrameIndex);
    Rectangle rectangle2 = tex.Frame(8, 2, horizontalFrameIndex, 1);
    --rectangle1.Width;
    --rectangle1.Height;
    --rectangle2.Width;
    --rectangle2.Height;
    return new TitleLinkButton()
    {
      TooltipTextKey = textKey,
      LinkUrl = linkUrl,
      FrameWehnSelected = new Rectangle?(rectangle2),
      FrameWhenNotSelected = new Rectangle?(rectangle1),
      Image = tex
    };
  }
}
