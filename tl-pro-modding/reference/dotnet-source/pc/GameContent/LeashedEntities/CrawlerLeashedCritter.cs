// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.LeashedEntities.CrawlerLeashedCritter
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.GameContent.LeashedEntities;

public class CrawlerLeashedCritter : WalkerLeashedCritter
{
  public static CrawlerLeashedCritter Prototype = new CrawlerLeashedCritter();

  public CrawlerLeashedCritter()
  {
    this.anchorStyle = 1;
    this.walkingPace = 0.4f;
  }
}
