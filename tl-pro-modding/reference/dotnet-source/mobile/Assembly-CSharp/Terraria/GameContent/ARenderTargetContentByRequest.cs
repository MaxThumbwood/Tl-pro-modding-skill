using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent
{
	// Token: 0x0200097E RID: 2430
	[Token(Token = "0x200097E")]
	public abstract class ARenderTargetContentByRequest : FileAPI
	{
		// Token: 0x17000992 RID: 2450
		// (get) Token: 0x0600504B RID: 20555 RVA: 0x00025620 File Offset: 0x00023820
		[Token(Token = "0x17000992")]
		public bool IsReady
		{
			[Token(Token = "0x600504B")]
			[Address(RVA = "0x7698D8", Offset = "0x7698D8", VA = "0x7698D8", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600504C RID: 20556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600504C")]
		[Address(RVA = "0x7698E0", Offset = "0x7698E0", VA = "0x7698E0")]
		public void Request()
		{
		}

		// Token: 0x0600504D RID: 20557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600504D")]
		[Address(RVA = "0x7698EC", Offset = "0x7698EC", VA = "0x7698EC")]
		public RenderTarget2D GetTarget()
		{
			return null;
		}

		// Token: 0x0600504E RID: 20558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600504E")]
		[Address(RVA = "0x7698F4", Offset = "0x7698F4", VA = "0x7698F4", Slot = "5")]
		public void PrepareRenderTarget(GraphicsDevice device, SpriteBatch spriteBatch)
		{
		}

		// Token: 0x0600504F RID: 20559
		[Token(Token = "0x600504F")]
		protected abstract void HandleUseRequest(GraphicsDevice device, SpriteBatch spriteBatch);

		// Token: 0x06005050 RID: 20560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005050")]
		[Address(RVA = "0x76991C", Offset = "0x76991C", VA = "0x76991C")]
		protected void PrepareARenderTarget_AndListenToEvents(ref RenderTarget2D target, GraphicsDevice device, int neededWidth, int neededHeight, RenderTargetUsage usage)
		{
		}

		// Token: 0x06005051 RID: 20561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005051")]
		[Address(RVA = "0x769920", Offset = "0x769920", VA = "0x769920")]
		private void target_Disposing(object sender, EventArgs e)
		{
		}

		// Token: 0x06005052 RID: 20562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005052")]
		[Address(RVA = "0x769930", Offset = "0x769930", VA = "0x769930")]
		private void target_ContentLost(object sender, EventArgs e)
		{
		}

		// Token: 0x06005053 RID: 20563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005053")]
		[Address(RVA = "0x76993C", Offset = "0x76993C", VA = "0x76993C", Slot = "6")]
		public void Reset()
		{
		}

		// Token: 0x06005054 RID: 20564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005054")]
		[Address(RVA = "0x76994C", Offset = "0x76994C", VA = "0x76994C")]
		protected void PrepareARenderTarget_WithoutListeningToEvents(ref RenderTarget2D target, GraphicsDevice device, int neededWidth, int neededHeight, RenderTargetUsage usage)
		{
		}

		// Token: 0x06005055 RID: 20565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005055")]
		[Address(RVA = "0x769950", Offset = "0x769950", VA = "0x769950")]
		protected ARenderTargetContentByRequest()
		{
		}

		// Token: 0x04009431 RID: 37937
		[Token(Token = "0x4009431")]
		[FieldOffset(Offset = "0x8")]
		protected RenderTarget2D _target;

		// Token: 0x04009432 RID: 37938
		[Token(Token = "0x4009432")]
		[FieldOffset(Offset = "0xC")]
		protected bool _wasPrepared;

		// Token: 0x04009433 RID: 37939
		[Token(Token = "0x4009433")]
		[FieldOffset(Offset = "0xD")]
		private bool _wasRequested;
	}
}
