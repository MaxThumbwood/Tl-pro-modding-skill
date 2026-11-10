// Decompiled with JetBrains decompiler
// Type: Terraria.Utilities.MessageBox
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.Utilities;

public static class MessageBox
{
  public static DialogResult Show(
    string message,
    string title,
    MessageBoxButtons buttons = MessageBoxButtons.OK,
    MessageBoxIcon icon = MessageBoxIcon.None)
  {
    return (DialogResult) System.Windows.Forms.MessageBox.Show(message, title, (System.Windows.Forms.MessageBoxButtons) buttons, (System.Windows.Forms.MessageBoxIcon) icon);
  }
}
