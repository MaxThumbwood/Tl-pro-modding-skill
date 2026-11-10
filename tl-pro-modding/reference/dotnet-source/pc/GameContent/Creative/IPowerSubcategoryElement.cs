// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Creative.IPowerSubcategoryElement
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Terraria.GameContent.UI.Elements;

#nullable disable
namespace Terraria.GameContent.Creative;

public interface IPowerSubcategoryElement
{
  GroupOptionButton<int> GetOptionButton(
    CreativePowerUIElementRequestInfo info,
    int optionIndex,
    int currentOptionIndex);
}
