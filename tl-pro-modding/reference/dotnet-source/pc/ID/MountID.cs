// Decompiled with JetBrains decompiler
// Type: Terraria.ID.MountID
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.ID;

public static class MountID
{
  public const int None = -1;
  public const int Rudolph = 0;
  public const int Bunny = 1;
  public const int Pigron = 2;
  public const int Slime = 3;
  public const int Turtle = 4;
  public const int Bee = 5;
  public const int Minecart = 6;
  public const int UFO = 7;
  public const int Drill = 8;
  public const int Scutlix = 9;
  public const int Unicorn = 10;
  public const int MinecartMech = 11;
  public const int CuteFishron = 12;
  public const int MinecartWood = 13;
  public const int Basilisk = 14;
  public const int DesertMinecart = 15;
  public const int FishMinecart = 16 /*0x10*/;
  public const int GolfCartSomebodySaveMe = 17;
  public const int BeeMinecart = 18;
  public const int LadybugMinecart = 19;
  public const int PigronMinecart = 20;
  public const int SunflowerMinecart = 21;
  public const int HellMinecart = 22;
  public const int WitchBroom = 23;
  public const int ShroomMinecart = 24;
  public const int AmethystMinecart = 25;
  public const int TopazMinecart = 26;
  public const int SapphireMinecart = 27;
  public const int EmeraldMinecart = 28;
  public const int RubyMinecart = 29;
  public const int DiamondMinecart = 30;
  public const int AmberMinecart = 31 /*0x1F*/;
  public const int BeetleMinecart = 32 /*0x20*/;
  public const int MeowmereMinecart = 33;
  public const int PartyMinecart = 34;
  public const int PirateMinecart = 35;
  public const int SteampunkMinecart = 36;
  public const int Flamingo = 37;
  public const int CoffinMinecart = 38;
  public const int DiggingMoleMinecart = 39;
  public const int PaintedHorse = 40;
  public const int MajesticHorse = 41;
  public const int DarkHorse = 42;
  public const int PogoStick = 43;
  public const int PirateShip = 44;
  public const int SpookyWood = 45;
  public const int Santank = 46;
  public const int WallOfFleshGoat = 47;
  public const int DarkMageBook = 48 /*0x30*/;
  public const int LavaShark = 49;
  public const int QueenSlime = 50;
  public const int FartMinecart = 51;
  public const int Wolf = 52;
  public const int TerraFartMinecart = 53;
  public const int Velociraptor = 54;
  public const int Rat = 55;
  public const int Bat = 56;
  public const int RollerSkates = 57;
  public const int RollerSkatesGreen = 58;
  public const int RollerSkatesWhite = 59;
  public const int RollerSkatesPink = 60;
  public const int Pixie = 61;
  public const int Chillet = 62;
  public const int ChilletIgnis = 63 /*0x3F*/;
  public static int Count = 64 /*0x40*/;

  public static class Sets
  {
    public static SetFactory Factory = new SetFactory(MountID.Count);
    public static bool[] CanUseHooks = MountID.Sets.Factory.CreateBoolSet(54, 57, 58, 59, 60);
    public static bool[] CanDash = MountID.Sets.Factory.CreateBoolSet(56, 57, 58, 59, 60, 61, 62, 63 /*0x3F*/);
    public static bool[] DoesNotOverrideBodyFrames = MountID.Sets.Factory.CreateBoolSet(57, 58, 59, 60);
    public static bool[] DoesNotOverrideLegFrames = MountID.Sets.Factory.CreateBoolSet(57, 58, 59, 60);
    public static bool[] DoesNotOverrideBackpackDraw = MountID.Sets.Factory.CreateBoolSet(57, 58, 59, 60);
    public static bool[] IsRollerSkates = MountID.Sets.Factory.CreateBoolSet(57, 58, 59, 60);
    public static bool[] Cart = MountID.Sets.Factory.CreateBoolSet(6, 13, 11, 15, 16 /*0x10*/, 18, 19, 20, 21, 22, 24, 25, 26, 27, 28, 29, 30, 31 /*0x1F*/, 32 /*0x20*/, 33, 34, 35, 36, 38, 39, 51, 53);
    public static bool[] IsTransformationMount = MountID.Sets.Factory.CreateBoolSet(52, 54, 55, 56, 61);
    public static bool[] PlayerIsHidden = MountID.Sets.Factory.CreateBoolSet(52, 54, 55, 56, 61);
    public static bool[] DontHoldItems = MountID.Sets.Factory.CreateBoolSet(55, 56, 61);
    public static bool[] DontDismountWhenCCed = MountID.Sets.Factory.CreateBoolSet(55, 56, 61);
  }
}
