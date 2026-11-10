// Decompiled with JetBrains decompiler
// Type: Terraria.Social.Base.WorldWorkshopEntry
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Terraria.IO;

#nullable disable
namespace Terraria.Social.Base;

public class WorldWorkshopEntry : AWorkshopEntry
{
  public static string GetHeaderTextFor(
    WorldFileData world,
    ulong workshopEntryId,
    string[] tags,
    WorkshopItemPublicSettingId publicity,
    string previewImagePath)
  {
    return AWorkshopEntry.CreateHeaderJson("World", workshopEntryId, tags, publicity, previewImagePath);
  }
}
