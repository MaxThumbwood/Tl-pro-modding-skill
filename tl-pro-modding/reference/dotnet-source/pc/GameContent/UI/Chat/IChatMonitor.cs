// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.UI.Chat.IChatMonitor
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;

#nullable disable
namespace Terraria.GameContent.UI.Chat;

public interface IChatMonitor
{
  void NewText(string newText, byte R = 255 /*0xFF*/, byte G = 255 /*0xFF*/, byte B = 255 /*0xFF*/);

  void NewTextMultiline(string text, bool force = false, Color c = default (Color), int WidthLimit = -1);

  void DrawChat(bool drawingPlayerChat);

  void Clear();

  void Update();

  void Offset(int linesOffset);

  void ResetOffset();
}
