// Decompiled with JetBrains decompiler
// Type: Terraria.UI.CoinSlot
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent;
using Terraria.ID;

#nullable disable
namespace Terraria.UI;

public class CoinSlot
{
  private static float[] FadeAnimKeys = new float[21]
  {
    0.3f,
    0.4f,
    0.5f,
    0.6f,
    0.7f,
    0.8f,
    0.9f,
    1f,
    1f,
    1f,
    1f,
    1f,
    1f,
    1f,
    1f,
    1f,
    1f,
    1f,
    1f,
    1f,
    1f
  };
  private static float[] TextAnimKeys = new float[17]
  {
    1f,
    1.0107f,
    1.0391f,
    1.0791f,
    1.125f,
    1.1709f,
    1.2109f,
    1.2393f,
    1.25f,
    1.2393f,
    1.2109f,
    1.1709f,
    1.125f,
    1.0791f,
    1.0391f,
    1.0107f,
    1f
  };
  private static float[] JumpAnimKeys = new float[25]
  {
    0.0f,
    0.23748f,
    0.43408f,
    0.59366f,
    0.72007f,
    0.81717f,
    0.88881f,
    0.93885f,
    0.97115f,
    0.98955f,
    0.99793f,
    1f,
    1f,
    1f,
    0.99793f,
    0.98955f,
    0.97115f,
    0.93885f,
    0.88881f,
    0.81717f,
    0.72007f,
    0.59366f,
    0.43408f,
    0.23748f,
    0.0f
  };
  private static int JumpApex = 12;
  private static int JumpTrigger_TextAnimRangeStart = 9;
  private static int JumpTrigger_TextAnimRangeEnd = 13;
  private static float ItemSlotCoinJumpScale = 10f;
  private static float SavingsCoinJumpScale = 10f;
  private static int JumpAnimHoldTime = 12;
  private static int SpinAnimRangeStart = 9;
  private static int SpinAnimRangeEnd = 13;
  private static CoinSlot.CoinEntry[] Savings = new CoinSlot.CoinEntry[4];
  private static CoinSlot.CoinEntry[] ChestEntries = new CoinSlot.CoinEntry[200];
  private static CoinSlot.CoinEntry[] InventoryEntries = new CoinSlot.CoinEntry[59];

  public static void UpdateSavings(int slot, int count, out CoinSlot.CoinDrawState drawState)
  {
    CoinSlot.Savings[slot].UpdateState(71 + slot, count, CoinSlot.SavingsCoinJumpScale, out drawState);
  }

  public static float DrawItemCoin(
    SpriteBatch spriteBatch,
    Vector2 screenPositionForItemCenter,
    int coinType,
    int coinFrame,
    float scale,
    float sizeLimit,
    Color itemColor,
    float itemFade = 1f)
  {
    int index = coinType - 71;
    Texture2D texture2D = TextureAssets.Coin[index].Value;
    Rectangle r = texture2D.Frame(verticalFrames: 8, frameY: coinFrame);
    Color white1 = Color.White;
    Color white2 = Color.White;
    float num = 1f;
    if ((double) r.Width > (double) sizeLimit || (double) r.Height > (double) sizeLimit)
      num = r.Width <= r.Height ? sizeLimit / (float) r.Height : sizeLimit / (float) r.Width;
    float scale1 = scale * num;
    SpriteEffects effects = SpriteEffects.None;
    Vector2 origin = r.Size() / 2f;
    Color color = ContentSamples.ItemsByType[coinType].GetAlpha(itemColor).MultiplyRGBA(white1);
    spriteBatch.Draw(texture2D, screenPositionForItemCenter, new Rectangle?(r), color * itemFade, 0.0f, origin, scale1, effects, 0.0f);
    return scale1;
  }

  public static void UpdateSlotAnims()
  {
    for (int index = 0; index < CoinSlot.Savings.Length; ++index)
      CoinSlot.Savings[index].UpdateAnim();
    for (int index = 0; index < CoinSlot.ChestEntries.Length; ++index)
      CoinSlot.ChestEntries[index].UpdateAnim();
    for (int index = 0; index < CoinSlot.InventoryEntries.Length; ++index)
      CoinSlot.InventoryEntries[index].UpdateAnim();
  }

  public static void ForceSlotState(int slot, int context, Item item)
  {
    switch (context)
    {
      case 0:
      case 1:
      case 2:
        CoinSlot.InventoryEntries[slot].ForceState(item.type, item.stack);
        break;
      case 3:
      case 4:
        CoinSlot.ChestEntries[slot].ForceState(item.type, item.stack);
        break;
    }
  }

  public static void UpdateDrawState(
    int slot,
    int context,
    Item item,
    out CoinSlot.CoinDrawState drawState)
  {
    switch (context)
    {
      case 0:
      case 1:
      case 2:
        CoinSlot.InventoryEntries[slot].UpdateState(item.type, item.stack, CoinSlot.ItemSlotCoinJumpScale, out drawState);
        break;
      case 3:
      case 4:
        CoinSlot.ChestEntries[slot].UpdateState(item.type, item.stack, CoinSlot.ItemSlotCoinJumpScale, out drawState);
        break;
      default:
        drawState.fadeItem = 0;
        drawState.fadeScale = 1f;
        drawState.coinAnimFrame = 0;
        drawState.coinYOffset = 0.0f;
        drawState.stackTextScale = 1f;
        drawState.stackTextDrawFadeOverload = -1f;
        break;
    }
  }

  private struct CoinEntry
  {
    public int Type;
    public int Stack;
    public int TextAnimFrame;
    public int JumpAnimFrame;
    public int SpinAnimFrame;
    public int DrawActive;
    public int JumpAnimHold;
    public int FadeItemType;

    public void ForceState(int itemType, int itemStack)
    {
      this.Type = itemType;
      this.Stack = itemStack;
      this.TextAnimFrame = 0;
      this.JumpAnimFrame = 0;
      this.JumpAnimHold = 0;
      this.SpinAnimFrame = 0;
      this.FadeItemType = 0;
    }

    public void UpdateState(
      int itemType,
      int itemStack,
      float jumpScale,
      out CoinSlot.CoinDrawState drawState)
    {
      if (this.Type != itemType || this.DrawActive == 0)
      {
        bool flag = true;
        if (itemType != 0 && this.FadeItemType == itemType && this.DrawActive != 0)
          flag = false;
        this.FadeItemType = itemType != 0 || this.DrawActive == 0 || !ItemID.Sets.CommonCoin[this.Type] ? 0 : this.Type;
        if (this.FadeItemType != 0)
          flag = false;
        this.Type = itemType;
        if (this.DrawActive == 0)
          this.Stack = itemStack;
        if (flag)
        {
          this.TextAnimFrame = 0;
          this.JumpAnimFrame = 0;
          this.JumpAnimHold = 0;
          this.SpinAnimFrame = 0;
        }
      }
      this.DrawActive = 2;
      if (ItemID.Sets.CommonCoin[this.Type] || this.FadeItemType != 0)
      {
        if (this.Stack != itemStack)
        {
          this.Stack = itemStack;
          if (this.TextAnimFrame == 0)
            this.TextAnimFrame = CoinSlot.TextAnimKeys.Length - 1;
        }
        if (this.TextAnimFrame >= CoinSlot.JumpTrigger_TextAnimRangeStart && this.TextAnimFrame <= CoinSlot.JumpTrigger_TextAnimRangeEnd)
        {
          this.JumpAnimHold = CoinSlot.JumpAnimHoldTime;
          if (this.JumpAnimFrame == 0)
            this.JumpAnimFrame = CoinSlot.JumpAnimKeys.Length - 1;
        }
      }
      drawState.stackTextScale = CoinSlot.TextAnimKeys[this.TextAnimFrame];
      drawState.coinYOffset = CoinSlot.JumpAnimKeys[this.JumpAnimFrame] * jumpScale;
      drawState.coinAnimFrame = this.SpinAnimFrame / 2;
      drawState.fadeItem = this.FadeItemType;
      drawState.fadeScale = 1f;
      if (this.FadeItemType != 0)
      {
        drawState.stackTextDrawFadeOverload = this.TextAnimFrame > 0 || this.JumpAnimFrame >= CoinSlot.JumpApex || this.JumpAnimFrame >= CoinSlot.FadeAnimKeys.Length ? 1f : CoinSlot.FadeAnimKeys[this.JumpAnimFrame];
        drawState.fadeScale = drawState.stackTextDrawFadeOverload;
      }
      else if (this.Stack == 1 && (this.TextAnimFrame > 0 || this.JumpAnimFrame != 0))
      {
        if (this.TextAnimFrame > 0 || this.JumpAnimFrame >= CoinSlot.JumpApex || this.JumpAnimFrame >= CoinSlot.FadeAnimKeys.Length)
          drawState.stackTextDrawFadeOverload = 1f;
        else
          drawState.stackTextDrawFadeOverload = CoinSlot.FadeAnimKeys[this.JumpAnimFrame];
      }
      else
        drawState.stackTextDrawFadeOverload = -1f;
    }

    public void UpdateAnim()
    {
      if (this.DrawActive > 0)
        --this.DrawActive;
      if (this.FadeItemType > 0 && this.JumpAnimFrame == 0 && this.TextAnimFrame == 0)
        this.FadeItemType = 0;
      if (this.TextAnimFrame > 0)
        --this.TextAnimFrame;
      if (this.JumpAnimHold > 0)
        --this.JumpAnimHold;
      if (this.JumpAnimFrame > 0)
      {
        if (this.JumpAnimHold > 0)
        {
          if (this.JumpAnimFrame != CoinSlot.JumpApex)
          {
            if (this.JumpAnimFrame < CoinSlot.JumpApex)
              this.JumpAnimFrame = CoinSlot.JumpApex + CoinSlot.JumpApex - this.JumpAnimFrame;
            --this.JumpAnimFrame;
          }
        }
        else
          --this.JumpAnimFrame;
      }
      if (this.JumpAnimFrame >= CoinSlot.SpinAnimRangeStart && this.JumpAnimFrame <= CoinSlot.SpinAnimRangeEnd)
      {
        this.SpinAnimFrame = (this.SpinAnimFrame + 1) % 14;
      }
      else
      {
        if (this.SpinAnimFrame == 0)
          return;
        this.SpinAnimFrame = (this.SpinAnimFrame + 1) % 14;
      }
    }
  }

  public struct CoinDrawState
  {
    public int coinAnimFrame;
    public float coinYOffset;
    public float stackTextScale;
    public float stackTextDrawFadeOverload;
    public int fadeItem;
    public float fadeScale;
  }
}
