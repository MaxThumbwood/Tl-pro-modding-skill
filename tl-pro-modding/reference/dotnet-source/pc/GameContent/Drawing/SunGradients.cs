// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Drawing.SunGradients
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using System.Collections.Generic;

#nullable disable
namespace Terraria.GameContent.Drawing;

public class SunGradients
{
  private static Color[] _Sunrise_Aluminum = new Color[15]
  {
    new Color(42, 85, 135),
    new Color(51, 86, 137),
    new Color(63 /*0x3F*/, 86, 140),
    new Color(76, 86, 143),
    new Color(91, 86, 146),
    new Color(107, 87, 150),
    new Color(123, 90, 153),
    new Color(138, 95, 155),
    new Color(152, 102, 157),
    new Color(168, 114, 157),
    new Color(185, 131, 157),
    new Color(202, 150, 157),
    new Color(219, 170, 157),
    new Color(233, 188, 157),
    new Color(246, 204, 157)
  };
  private static Color[] _Sunrise_Blue = new Color[15]
  {
    new Color(17, 35, 67),
    new Color(21, 43, 76),
    new Color(24, 55, 86),
    new Color(30, 69, 99),
    new Color(36, 87, 114),
    new Color(43, 107, (int) sbyte.MaxValue),
    new Color(55, 126, 140),
    new Color(68, 144 /*0x90*/, 149),
    new Color(84, 157, 155),
    new Color(116, 175, 156),
    new Color(154, 190, 155),
    new Color(189, 204, 156),
    new Color(218, 215, 155),
    new Color(241, 225, 154),
    new Color((int) byte.MaxValue, 230, 153)
  };
  private static Color[] _Sunrise_Violet = new Color[15]
  {
    new Color(37, 42, 58),
    new Color(43, 46, 65),
    new Color(50, 51, 77),
    new Color(58, 56, 90),
    new Color(68, 64 /*0x40*/, 104),
    new Color(81, 73, 119),
    new Color(93, 82, 131),
    new Color(106, 92, 142),
    new Color(121, 104, 151),
    new Color(145, 124, 152),
    new Color(175, 149, 157),
    new Color(201, 170, 157),
    new Color(225, 191, 158),
    new Color(243, 207, 156),
    new Color(249, 212, 156)
  };
  private static Color[] _Sunrise_Yellow = new Color[15]
  {
    new Color(15, 18, 28),
    new Color(16 /*0x10*/, 20, 32 /*0x20*/),
    new Color(20, 26, 43),
    new Color(25, 36, 58),
    new Color(33, 46, 76),
    new Color(42, 60, 91),
    new Color(53, 74, 97),
    new Color(69, 92, 102),
    new Color(90, 116, 104),
    new Color(118, 141, 106),
    new Color(148, 164, 110),
    new Color(172, 181, 115),
    new Color(195, 198, 128 /*0x80*/),
    new Color(218, 213, 142),
    new Color(233, 225, 158)
  };
  private static Color[] _Sunset_Blue = new Color[15]
  {
    new Color(67, 80 /*0x50*/, 117),
    new Color(82, 84, 120),
    new Color(98, 89, 124),
    new Color(114, 92, 125),
    new Color(129, 95, 125),
    new Color(144 /*0x90*/, 98, 125),
    new Color(158, 100, 126),
    new Color(171, 103, 125),
    new Color(182, 104, 121),
    new Color(192 /*0xC0*/, 106, 115),
    new Color(200, 109, 107),
    new Color(207, 111, 96 /*0x60*/),
    new Color(213, 112 /*0x70*/, 84),
    new Color(218, 112 /*0x70*/, 70),
    new Color(222, 111, 56)
  };
  private static Color[] _Sunset_Dark = new Color[15]
  {
    new Color(16 /*0x10*/, 15, 33),
    new Color(17, 15, 33),
    new Color(20, 16 /*0x10*/, 34),
    new Color(24, 18, 35),
    new Color(27, 19, 36),
    new Color(34, 21, 38),
    new Color(39, 22, 41),
    new Color(47, 23, 45),
    new Color(51, 25, 47),
    new Color(56, 27, 49),
    new Color(60, 29, 50),
    new Color(65, 32 /*0x20*/, 53),
    new Color(70, 33, 56),
    new Color(76, 36, 58),
    new Color(80 /*0x50*/, 39, 60)
  };
  private static Color[] _Sunset_Pink = new Color[15]
  {
    new Color(72, 48 /*0x30*/, 93),
    new Color(86, 54, 102),
    new Color(101, 61, 112 /*0x70*/),
    new Color(117, 68, 122),
    new Color(133, 74, 130),
    new Color(148, 81, 138),
    new Color(162, 87, 143),
    new Color(173, 93, 145),
    new Color(186, 99, 142),
    new Color(199, 105, 133),
    new Color(210, 111, 119),
    new Color(219, 115, 103),
    new Color(227, 119, 87),
    new Color(234, 123, 73),
    new Color(240 /*0xF0*/, 125, 63 /*0x3F*/)
  };
  private static Color[] _Sunset_Red = new Color[15]
  {
    new Color(27, 24, 39),
    new Color(28, 24, 39),
    new Color(32 /*0x20*/, 25, 40),
    new Color(38, 27, 40),
    new Color(43, 28, 41),
    new Color(50, 29, 43),
    new Color(57, 30, 44),
    new Color(64 /*0x40*/, 32 /*0x20*/, 45),
    new Color(71, 34, 46),
    new Color(79, 36, 47),
    new Color(85, 37, 48 /*0x30*/),
    new Color(93, 39, 50),
    new Color(100, 41, 50),
    new Color(109, 43, 52),
    new Color(118, 45, 53)
  };
  public static List<Color[]> Sunrises = new List<Color[]>()
  {
    SunGradients._Sunrise_Blue,
    SunGradients._Sunrise_Violet,
    SunGradients._Sunrise_Yellow,
    SunGradients._Sunrise_Aluminum
  };
  public static List<Color[]> Sunsets = new List<Color[]>()
  {
    SunGradients._Sunset_Blue,
    SunGradients._Sunset_Dark,
    SunGradients._Sunset_Pink,
    SunGradients._Sunset_Red
  };
  public static Dictionary<int, Color> BackgroundGradientColors = new Dictionary<int, Color>()
  {
    {
      58,
      new Color(220, (int) byte.MaxValue, 109)
    },
    {
      175,
      new Color(116, 191, (int) byte.MaxValue)
    },
    {
      178,
      new Color(157, 192 /*0xC0*/, (int) byte.MaxValue)
    },
    {
      247,
      new Color(184, 211, 245)
    },
    {
      262,
      new Color(169, 241, (int) byte.MaxValue)
    },
    {
      267,
      new Color(169, 241, (int) byte.MaxValue)
    },
    {
      268,
      new Color(169, 241, (int) byte.MaxValue)
    },
    {
      282,
      new Color(157, 192 /*0xC0*/, (int) byte.MaxValue)
    },
    {
      283,
      new Color(141, 232, 131)
    }
  };
  public static List<BackgroundGradientDrawer> BackgroundDrawers = new List<BackgroundGradientDrawer>()
  {
    new BackgroundGradientDrawer(new Color(116, 191, (int) byte.MaxValue), (GetBackgroundDrawWeightMethod) (() => Main.bgAlphaFrontLayer[0]), (BackgroundArrayGetterMethod) (() => (IEnumerable<int>) Main.treeBGSet1), new int[1]
    {
      176 /*0xB0*/
    }),
    new BackgroundGradientDrawer(new Color(157, 192 /*0xC0*/, (int) byte.MaxValue), (GetBackgroundDrawWeightMethod) (() => Main.bgAlphaFrontLayer[0]), (BackgroundArrayGetterMethod) (() => (IEnumerable<int>) Main.treeBGSet1), new int[1]
    {
      179
    }),
    new BackgroundGradientDrawer(new Color(116, 191, (int) byte.MaxValue), (GetBackgroundDrawWeightMethod) (() => Main.bgAlphaFrontLayer[10]), (BackgroundArrayGetterMethod) (() => (IEnumerable<int>) Main.treeBGSet2), new int[1]
    {
      176 /*0xB0*/
    }),
    new BackgroundGradientDrawer(new Color(157, 192 /*0xC0*/, (int) byte.MaxValue), (GetBackgroundDrawWeightMethod) (() => Main.bgAlphaFrontLayer[10]), (BackgroundArrayGetterMethod) (() => (IEnumerable<int>) Main.treeBGSet2), new int[1]
    {
      179
    }),
    new BackgroundGradientDrawer(new Color(116, 191, (int) byte.MaxValue), (GetBackgroundDrawWeightMethod) (() => Main.bgAlphaFrontLayer[11]), (BackgroundArrayGetterMethod) (() => (IEnumerable<int>) Main.treeBGSet3), new int[1]
    {
      176 /*0xB0*/
    }),
    new BackgroundGradientDrawer(new Color(157, 192 /*0xC0*/, (int) byte.MaxValue), (GetBackgroundDrawWeightMethod) (() => Main.bgAlphaFrontLayer[11]), (BackgroundArrayGetterMethod) (() => (IEnumerable<int>) Main.treeBGSet3), new int[1]
    {
      179
    }),
    new BackgroundGradientDrawer(new Color(116, 191, (int) byte.MaxValue), (GetBackgroundDrawWeightMethod) (() => Main.bgAlphaFrontLayer[12]), (BackgroundArrayGetterMethod) (() => (IEnumerable<int>) Main.treeBGSet4), new int[1]
    {
      176 /*0xB0*/
    }),
    new BackgroundGradientDrawer(new Color(157, 192 /*0xC0*/, (int) byte.MaxValue), (GetBackgroundDrawWeightMethod) (() => Main.bgAlphaFrontLayer[12]), (BackgroundArrayGetterMethod) (() => (IEnumerable<int>) Main.treeBGSet4), new int[1]
    {
      179
    }),
    new BackgroundGradientDrawer(new Color(184, 211, 245), (GetBackgroundDrawWeightMethod) (() => Main.bgAlphaFrontLayer[2]), (BackgroundArrayGetterMethod) (() => (IEnumerable<int>) Main.desertBackgroundSet.Pure.Backgrounds), new int[1]
    {
      248
    }),
    new BackgroundGradientDrawer(new Color(169, 241, (int) byte.MaxValue), (GetBackgroundDrawWeightMethod) (() => Main.bgAlphaFrontLayer[7]), (BackgroundArrayGetterMethod) (() => (IEnumerable<int>) Main.snowBG), new int[3]
    {
      263,
      268,
      269
    }),
    new BackgroundGradientDrawer(new Color(220, (int) byte.MaxValue, 109), (GetBackgroundDrawWeightMethod) (() => Main.bgAlphaFrontLayer[3]), (BackgroundArrayGetterMethod) (() => (IEnumerable<int>) Main.jungleBG), new int[1]
    {
      59
    }),
    new BackgroundGradientDrawer(new Color(141, 232, 131), (GetBackgroundDrawWeightMethod) (() => Main.bgAlphaFrontLayer[3]), (BackgroundArrayGetterMethod) (() => (IEnumerable<int>) Main.jungleBG), new int[1]
    {
      284
    }),
    new BackgroundGradientDrawer(new Color(157, 192 /*0xC0*/, (int) byte.MaxValue), (GetBackgroundDrawWeightMethod) (() => Main.bgAlphaFrontLayer[4]), new BackgroundArrayGetterMethod(SunGradients.Ocean), new int[1]
    {
      283
    })
  };

  private static IEnumerable<int> Ocean()
  {
    yield return Main.oceanBG;
  }
}
