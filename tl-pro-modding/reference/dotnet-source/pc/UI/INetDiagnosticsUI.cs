// Decompiled with JetBrains decompiler
// Type: Terraria.UI.INetDiagnosticsUI
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework.Graphics;

#nullable disable
namespace Terraria.UI;

public interface INetDiagnosticsUI
{
  void Reset();

  void Draw(SpriteBatch spriteBatch);

  void CountReadMessage(int messageId, int messageLength);

  void CountSentMessage(int messageId, int messageLength);

  void CountReadModuleMessage(int moduleMessageId, int messageLength);

  void CountSentModuleMessage(int moduleMessageId, int messageLength);

  void RotateSendRecvCounters();

  void GetLastSentRecvBytes(out int sent, out int recv);
}
