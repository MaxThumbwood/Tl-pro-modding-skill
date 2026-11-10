// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.ITownNPCProfile
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;

#nullable disable
namespace Terraria.GameContent;

public interface ITownNPCProfile
{
  int RollVariation();

  string GetNameForVariant(NPC npc);

  Asset<Texture2D> GetTextureNPCShouldUse(NPC npc);

  int GetHeadTextureIndex(NPC npc);
}
