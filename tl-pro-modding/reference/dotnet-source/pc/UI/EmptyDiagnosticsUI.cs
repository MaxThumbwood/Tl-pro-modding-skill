// Decompiled with JetBrains decompiler
// Type: Terraria.UI.EmptyDiagnosticsUI
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework.Graphics;

#nullable disable
namespace Terraria.UI;

public class EmptyDiagnosticsUI : INetDiagnosticsUI
{
  public void Reset()
  {
  }

  public void CountReadMessage(int messageId, int messageLength)
  {
  }

  public void CountSentMessage(int messageId, int messageLength)
  {
  }

  public void CountReadModuleMessage(int moduleMessageId, int messageLength)
  {
  }

  public void CountSentModuleMessage(int moduleMessageId, int messageLength)
  {
  }

  public void Draw(SpriteBatch spriteBatch)
  {
  }

  public void RotateSendRecvCounters()
  {
  }

  public void GetLastSentRecvBytes(out int sent, out int recv)
  {
    sent = 0;
    recv = 0;
  }
}
