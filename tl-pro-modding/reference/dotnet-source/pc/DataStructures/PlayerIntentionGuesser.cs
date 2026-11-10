// Decompiled with JetBrains decompiler
// Type: Terraria.DataStructures.PlayerIntentionGuesser
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Terraria.GameContent;

#nullable disable
namespace Terraria.DataStructures;

public class PlayerIntentionGuesser
{
  public int LastX;
  public int LastY;
  public Vector2 LastPosition;
  public Vector2 LastCenter;
  public Vector2 LastMouse;
  public int LastDirection;
  public int LastWidth;
  public GuessedPlayerIntention Intention;
  public SmartCursorHelper.SmartCursorUsageInfo UsageProxy = new SmartCursorHelper.SmartCursorUsageInfo();
  public int TimeWithIntention;
  public int PlayerActiveActionTimeLeft;

  public void Track(Player player, int x, int y, GuessedPlayerIntention intention)
  {
    if (this.PlayerActiveActionTimeLeft == 0)
      return;
    this.LastX = x;
    this.LastY = y;
    this.Intention = intention;
    this.LastPosition = player.position;
    this.LastCenter = player.Center;
    this.LastDirection = player.direction;
    this.LastWidth = player.width;
    this.LastMouse = Main.MouseWorld;
  }

  public void AllowTracking(int time = 60) => this.PlayerActiveActionTimeLeft = time;

  public void Update(Player player)
  {
    if (player.whoAmI != Main.myPlayer)
      return;
    ++this.TimeWithIntention;
    if (this.PlayerActiveActionTimeLeft > 0)
      --this.PlayerActiveActionTimeLeft;
    if (this.Intention == GuessedPlayerIntention.None)
      return;
    double num1 = (double) player.Center.Distance(this.LastCenter);
    bool flag = false;
    if (num1 > 80.0)
      flag = true;
    if (player.controlJump)
      flag = true;
    int num2 = player.UsingOrReusingItem ? 1 : 0;
    if (num2 != 0 && this.Intention == GuessedPlayerIntention.HarvestTreasure && player.HeldItem.pick <= 0)
      flag = true;
    if (num2 != 0 && this.Intention == GuessedPlayerIntention.HarvestTrees && player.HeldItem.axe <= 0)
      flag = true;
    if (this.TimeWithIntention >= 480)
      flag = true;
    if (player.dead)
      flag = true;
    if (!flag)
      return;
    this.Intention = GuessedPlayerIntention.None;
    this.TimeWithIntention = 0;
  }

  public void PrepareUsageProxy(
    Player player,
    int itemType,
    int areaInflateWidth,
    int areaInflateHeight)
  {
    this.UsageProxy.player = player;
    if (this.UsageProxy.item == null)
      this.UsageProxy.item = new Item();
    this.UsageProxy.item.SetDefaults(itemType);
    this.UsageProxy.position = this.LastPosition;
    this.UsageProxy.Center = this.LastCenter;
    this.UsageProxy.mouse = this.LastMouse;
    this.UsageProxy.screenTargetX = this.LastX;
    this.UsageProxy.screenTargetY = this.LastY;
    this.UsageProxy.screenTargetX = Utils.Clamp<int>(this.UsageProxy.screenTargetX, 10, Main.maxTilesX - 10);
    this.UsageProxy.screenTargetY = Utils.Clamp<int>(this.UsageProxy.screenTargetY, 10, Main.maxTilesY - 10);
    Rectangle rectangle1 = new Rectangle(this.LastX, this.LastY, 1, 1);
    rectangle1.Inflate(areaInflateWidth, areaInflateHeight);
    Rectangle rectangle2 = new Rectangle(0, 0, Main.maxTilesX, Main.maxTilesY);
    rectangle2.Inflate(-10, -10);
    Rectangle rectangle3 = new Rectangle();
    Rectangle rectangle4 = Rectangle.Intersect(rectangle1, rectangle2);
    this.UsageProxy.reachableStartX = rectangle4.Left;
    this.UsageProxy.reachableStartY = rectangle4.Top;
    this.UsageProxy.reachableEndX = rectangle4.Right;
    this.UsageProxy.reachableEndY = rectangle4.Bottom;
  }
}
