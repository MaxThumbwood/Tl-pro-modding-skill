// Decompiled with JetBrains decompiler
// Type: Terraria.Initializers.ChatInitializer
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Terraria.Chat.Commands;
using Terraria.GameContent.UI.Chat;
using Terraria.UI.Chat;

#nullable disable
namespace Terraria.Initializers;

public static class ChatInitializer
{
  public static void Load()
  {
    ChatManager.Register<ColorTagHandler>("c", "color");
    ChatManager.Register<ItemTagHandler>("i", "item");
    ChatManager.Register<NameTagHandler>("n", "name");
    ChatManager.Register<AchievementTagHandler>("a", "achievement");
    ChatManager.Register<GlyphTagHandler>("g", "glyph");
    ChatManager.Register<GlyphTagHandler.GlyphXboxTagHandler>("gx", "glyph");
    ChatManager.Register<GlyphTagHandler.GlyphPSTagHandler>("gp", "glyph");
    ChatManager.Register<GlyphTagHandler.GlyphSwitchTagHandler>("gn", "glyph");
    ChatManager.Commands.AddCommand<PartyChatCommand>().AddCommand<RollCommand>().AddCommand<EmoteCommand>().AddCommand<ListPlayersCommand>().AddCommand<RockPaperScissorsCommand>().AddCommand<EmojiCommand>().AddCommand<HelpCommand>().AddCommand<DeathCommand>().AddCommand<PVPDeathCommand>().AddCommand<AllDeathCommand>().AddCommand<AllPVPDeathCommand>().AddCommand<BossDamageCommand>().AddDefaultCommand<SayChatCommand>();
    ChatManager.Commands.PrepareAliases();
  }
}
