// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Bestiary.IEntryIcon
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

#nullable disable
namespace Terraria.GameContent.Bestiary;

public interface IEntryIcon
{
  void Update(
    BestiaryUICollectionInfo providedInfo,
    Rectangle hitbox,
    EntryIconDrawSettings settings);

  void Draw(
    BestiaryUICollectionInfo providedInfo,
    SpriteBatch spriteBatch,
    EntryIconDrawSettings settings);

  bool GetUnlockState(BestiaryUICollectionInfo providedInfo);

  string GetHoverText(BestiaryUICollectionInfo providedInfo);

  IEntryIcon CreateClone();
}
