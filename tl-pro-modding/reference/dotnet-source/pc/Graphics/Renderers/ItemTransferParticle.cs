// Decompiled with JetBrains decompiler
// Type: Terraria.Graphics.Renderers.ItemTransferParticle
// Assembly: Terraria, Version=1.4.5.5, Culture=neutral, PublicKeyToken=null
// MVID: E05F637A-D25C-442B-8F99-788F39A34454
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI;

#nullable disable
namespace Terraria.Graphics.Renderers;

public class ItemTransferParticle : IPooledParticle, IParticle
{
  private Vector2 StartPosition;
  private Vector2 EndPosition;
  private Vector2 StartOffset;
  private Vector2 EndOffset;
  private Vector2 BezierHelper1;
  private Vector2 BezierHelper2;
  private bool TransitionIn;
  private bool Fullbright;
  private bool InInventory;
  private Item _itemInstance;
  private int _lifeTimeCounted;
  private int _lifeTimeTotal;

  public bool ShouldBeRemovedFromRenderer { get; private set; }

  public ItemTransferParticle() => this._itemInstance = new Item();

  public void Update(ref ParticleRendererSettings settings)
  {
    if (++this._lifeTimeCounted < this._lifeTimeTotal)
      return;
    this.ShouldBeRemovedFromRenderer = true;
  }

  public void Prepare(
    int itemType,
    int lifeTimeTotal,
    Vector2 startPosition,
    Vector2 endPosition,
    Vector2 offsetStart,
    Vector2 offsetEnd,
    bool transitionIn,
    bool fullbright,
    bool inInventory,
    int stack = 1)
  {
    this._itemInstance.SetDefaults(itemType);
    this._itemInstance.stack = stack;
    this._lifeTimeTotal = lifeTimeTotal;
    this.StartPosition = startPosition;
    this.StartOffset = offsetStart;
    this.EndPosition = endPosition;
    this.EndOffset = offsetEnd;
    this.TransitionIn = transitionIn;
    this.Fullbright = fullbright;
    this.InInventory = inInventory;
    Vector2 vector2 = (this.EndPosition - this.StartPosition).SafeNormalize(Vector2.UnitY).RotatedBy(1.5707963705062866);
    int num1 = (double) vector2.Y < 0.0 ? 1 : 0;
    bool flag = (double) vector2.Y == 0.0;
    if (num1 == 0 || flag && Main.rand.Next(2) == 0)
      vector2 *= -1f;
    vector2 = new Vector2(0.0f, -1f);
    float num2 = Vector2.Distance(this.EndPosition, this.StartPosition);
    this.BezierHelper1 = vector2 * num2 + Main.rand.NextVector2Circular(32f, 32f);
    this.BezierHelper2 = -vector2 * num2 + Main.rand.NextVector2Circular(32f, 32f);
  }

  public void Draw(ref ParticleRendererSettings settings, SpriteBatch spritebatch)
  {
    float fromValue = (float) this._lifeTimeCounted / (float) this._lifeTimeTotal;
    float toMin = Utils.Remap(fromValue, 0.1f, 0.5f, 0.0f, 0.85f);
    Vector2 result;
    Vector2.Hermite(ref this.StartPosition, ref this.BezierHelper1, ref this.EndPosition, ref this.BezierHelper2, Utils.Remap(fromValue, 0.5f, 0.9f, toMin, 1f), out result);
    Vector2 zero = Vector2.Zero;
    Vector2 vector2 = (double) fromValue > 0.15000000596046448 ? ((double) fromValue > 0.5 ? ((double) fromValue > 0.85000002384185791 ? Vector2.Lerp(this.EndOffset, Vector2.Zero, Utils.Remap(fromValue, 0.85f, 0.95f, 0.0f, 1f)) : this.EndOffset) : Vector2.Lerp(this.StartOffset, this.EndOffset, (float) (((double) fromValue - 0.15000000596046448) / 0.34999999403953552))) : Vector2.Lerp(Vector2.Zero, this.StartOffset, fromValue / 0.15f);
    Vector2 vec = result + vector2;
    float num1 = Utils.Remap(fromValue, 0.0f, 0.15f, this.TransitionIn ? 0.0f : 1f, 1f) * Utils.Remap(fromValue, 0.85f, 0.95f, 1f, 0.0f);
    Color color = this.Fullbright ? Color.White : Lighting.GetColor(vec.ToTileCoordinates());
    int context = 31 /*0x1F*/;
    int sizeLimit = 32 /*0x20*/;
    if (this.InInventory)
    {
      sizeLimit = 32 /*0x20*/;
      num1 = 1f;
      float num2 = fromValue;
      float amount = num2 * num2;
      vec = Vector2.Lerp(this.StartPosition - new Vector2(26f, 26f) * Main.inventoryScale, this.EndPosition - new Vector2(26f, 26f) * Main.inventoryScale, amount);
      context = 14;
    }
    if (this.InInventory)
    {
      ItemSlot.Draw(spritebatch, ref this._itemInstance, context, settings.AnchorPosition + vec, color);
    }
    else
    {
      double num3 = (double) ItemSlot.DrawItemIcon(this._itemInstance, context, Main.spriteBatch, settings.AnchorPosition + vec, this._itemInstance.scale * num1, (float) sizeLimit, color);
    }
  }

  public bool IsRestingInPool { get; private set; }

  public void RestInPool() => this.IsRestingInPool = true;

  public virtual void FetchFromPool()
  {
    this._lifeTimeCounted = 0;
    this._lifeTimeTotal = 0;
    this.IsRestingInPool = false;
    this.ShouldBeRemovedFromRenderer = false;
    this.StartPosition = this.EndPosition = this.BezierHelper1 = this.BezierHelper2 = Vector2.Zero;
  }
}
