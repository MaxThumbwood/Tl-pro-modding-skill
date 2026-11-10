using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Graphics.Renderers
{
	// Token: 0x020008D4 RID: 2260
	[Token(Token = "0x20008D4")]
	public class ItemTransferParticle : FileAPI, GUIControllerItem
	{
		// Token: 0x1700093C RID: 2364
		// (get) Token: 0x06004C53 RID: 19539 RVA: 0x000240F0 File Offset: 0x000222F0
		// (set) Token: 0x06004C54 RID: 19540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700093C")]
		public bool ShouldBeRemovedFromRenderer
		{
			[Token(Token = "0x6004C53")]
			[Address(RVA = "0x6F2364", Offset = "0x6F2364", VA = "0x6F2364", Slot = "6")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004C54")]
			[Address(RVA = "0x6F236C", Offset = "0x6F236C", VA = "0x6F236C")]
			private set
			{
			}
		}

		// Token: 0x06004C55 RID: 19541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C55")]
		[Address(RVA = "0x6F2374", Offset = "0x6F2374", VA = "0x6F2374")]
		public ItemTransferParticle(ParticlePool pool)
		{
		}

		// Token: 0x06004C56 RID: 19542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C56")]
		[Address(RVA = "0x6F23F8", Offset = "0x6F23F8", VA = "0x6F23F8", Slot = "7")]
		public void Update(ref ParticleRendererSettings settings)
		{
		}

		// Token: 0x06004C57 RID: 19543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C57")]
		[Address(RVA = "0x6F2418", Offset = "0x6F2418", VA = "0x6F2418")]
		public void Prepare(int itemType, int lifeTimeTotal, Vector2 startPosition, Vector2 endPosition, Vector2 offsetStart, Vector2 offsetEnd, bool transitionIn, bool fullbright, bool inInventory, int stack = 1)
		{
		}

		// Token: 0x06004C58 RID: 19544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C58")]
		[Address(RVA = "0x6F287C", Offset = "0x6F287C", VA = "0x6F287C", Slot = "8")]
		public void Draw(ref ParticleRendererSettings settings, SpriteBatch spritebatch)
		{
		}

		// Token: 0x06004C59 RID: 19545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C59")]
		[Address(RVA = "0x6F3134", Offset = "0x6F3134", VA = "0x6F3134", Slot = "4")]
		public void RestInPool()
		{
		}

		// Token: 0x06004C5A RID: 19546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004C5A")]
		[Address(RVA = "0x6F319C", Offset = "0x6F319C", VA = "0x6F319C", Slot = "9")]
		public virtual void FetchFromPool()
		{
		}

		// Token: 0x0400912B RID: 37163
		[Token(Token = "0x400912B")]
		[FieldOffset(Offset = "0x8")]
		private bool <ShouldBeRemovedFromRenderer>k__BackingField;

		// Token: 0x0400912C RID: 37164
		[Token(Token = "0x400912C")]
		[FieldOffset(Offset = "0xC")]
		private Vector2 StartPosition;

		// Token: 0x0400912D RID: 37165
		[Token(Token = "0x400912D")]
		[FieldOffset(Offset = "0x14")]
		private Vector2 EndPosition;

		// Token: 0x0400912E RID: 37166
		[Token(Token = "0x400912E")]
		[FieldOffset(Offset = "0x1C")]
		private Vector2 StartOffset;

		// Token: 0x0400912F RID: 37167
		[Token(Token = "0x400912F")]
		[FieldOffset(Offset = "0x24")]
		private Vector2 EndOffset;

		// Token: 0x04009130 RID: 37168
		[Token(Token = "0x4009130")]
		[FieldOffset(Offset = "0x2C")]
		private Vector2 BezierHelper1;

		// Token: 0x04009131 RID: 37169
		[Token(Token = "0x4009131")]
		[FieldOffset(Offset = "0x34")]
		private Vector2 BezierHelper2;

		// Token: 0x04009132 RID: 37170
		[Token(Token = "0x4009132")]
		[FieldOffset(Offset = "0x3C")]
		private bool TransitionIn;

		// Token: 0x04009133 RID: 37171
		[Token(Token = "0x4009133")]
		[FieldOffset(Offset = "0x3D")]
		private bool Fullbright;

		// Token: 0x04009134 RID: 37172
		[Token(Token = "0x4009134")]
		[FieldOffset(Offset = "0x3E")]
		private bool InInventory;

		// Token: 0x04009135 RID: 37173
		[Token(Token = "0x4009135")]
		[FieldOffset(Offset = "0x40")]
		private Item _itemInstance;

		// Token: 0x04009136 RID: 37174
		[Token(Token = "0x4009136")]
		[FieldOffset(Offset = "0x44")]
		public readonly ParticlePool Pool;

		// Token: 0x04009137 RID: 37175
		[Token(Token = "0x4009137")]
		[FieldOffset(Offset = "0x48")]
		private int _lifeTimeCounted;

		// Token: 0x04009138 RID: 37176
		[Token(Token = "0x4009138")]
		[FieldOffset(Offset = "0x4C")]
		private int _lifeTimeTotal;
	}
}
