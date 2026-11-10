// Decompiled with JetBrains decompiler
// Type: Terraria.Utilities.NewRuntimeMethods
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System;
using System.Reflection;

#nullable disable
namespace Terraria.Utilities;

public static class NewRuntimeMethods
{
  private static bool IsNet45OrNewer = Type.GetType("System.Reflection.ReflectionContext", false) != (Type) null;
  private static MethodInfo _collect;

  public static void GC_Collect(int generation, GCCollectionMode mode, bool blocking)
  {
    if (!NewRuntimeMethods.IsNet45OrNewer)
      return;
    MethodInfo methodInfo = NewRuntimeMethods._collect;
    if ((object) methodInfo == null)
      methodInfo = typeof (GC).GetMethod("Collect", BindingFlags.Static | BindingFlags.Public, (Binder) null, new Type[3]
      {
        typeof (int),
        typeof (GCCollectionMode),
        typeof (bool)
      }, (ParameterModifier[]) null);
    NewRuntimeMethods._collect = methodInfo;
    NewRuntimeMethods._collect.Invoke((object) null, new object[3]
    {
      (object) generation,
      (object) mode,
      (object) blocking
    });
  }

  public static long GC_GetTotalAllocatedBytes() => 0;

  public static TimeSpan GC_GetTotalPauseDuration() => TimeSpan.Zero;
}
