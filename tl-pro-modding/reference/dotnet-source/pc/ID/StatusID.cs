// Decompiled with JetBrains decompiler
// Type: Terraria.ID.StatusID
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using ReLogic.Reflection;

#nullable disable
namespace Terraria.ID;

public class StatusID
{
  public static readonly int Ok = 0;
  public static readonly int LaterVersion = 1;
  public static readonly int UnknownError = 2;
  public static readonly int EmptyFile = 3;
  public static readonly int DecryptionError = 4;
  public static readonly int BadSectionPointer = 5;
  public static readonly int BadFooter = 6;
  public static readonly IdDictionary Search = IdDictionary.Create<StatusID, int>();
}
