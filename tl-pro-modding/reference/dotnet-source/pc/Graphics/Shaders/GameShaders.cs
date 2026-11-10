// Decompiled with JetBrains decompiler
// Type: Terraria.Graphics.Shaders.GameShaders
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System.Collections.Generic;

#nullable disable
namespace Terraria.Graphics.Shaders;

public class GameShaders
{
  public static ArmorShaderDataSet Armor = new ArmorShaderDataSet();
  public static HairShaderDataSet Hair = new HairShaderDataSet();
  public static Dictionary<string, MiscShaderData> Misc = new Dictionary<string, MiscShaderData>();
}
