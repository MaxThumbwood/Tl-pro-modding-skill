using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Graphics.Effects
{
	// Token: 0x02000907 RID: 2311
	[Token(Token = "0x2000907")]
	public class FilterManager : EffectManager<Filter>
	{
		// Token: 0x06004D9F RID: 19871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D9F")]
		[Address(RVA = "0x723AF8", Offset = "0x723AF8", VA = "0x723AF8")]
		public FilterManager()
		{
		}

		// Token: 0x06004DA0 RID: 19872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DA0")]
		[Address(RVA = "0x723E14", Offset = "0x723E14", VA = "0x723E14", Slot = "4")]
		public override void OnActivate(Filter effect, Vector2 position)
		{
		}

		// Token: 0x06004DA1 RID: 19873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DA1")]
		[Address(RVA = "0x724094", Offset = "0x724094", VA = "0x724094")]
		public void BeginCapture(RenderTarget2D screenTarget1, Color clearColor)
		{
		}

		// Token: 0x06004DA2 RID: 19874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DA2")]
		[Address(RVA = "0x724188", Offset = "0x724188", VA = "0x724188")]
		public void Update(GameTime gameTime)
		{
		}

		// Token: 0x06004DA3 RID: 19875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DA3")]
		[Address(RVA = "0x7244A0", Offset = "0x7244A0", VA = "0x7244A0")]
		public void UpdateFilters()
		{
		}

		// Token: 0x06004DA4 RID: 19876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DA4")]
		[Address(RVA = "0x7245F8", Offset = "0x7245F8", VA = "0x7245F8")]
		public void EndCapture(RenderTarget2D finalTexture, RenderTarget2D screenTarget1, RenderTarget2D screenTarget2, Color clearColor)
		{
		}

		// Token: 0x06004DA5 RID: 19877 RVA: 0x000245B8 File Offset: 0x000227B8
		[Token(Token = "0x6004DA5")]
		[Address(RVA = "0x725538", Offset = "0x725538", VA = "0x725538")]
		public bool HasActiveFilter()
		{
			return default(bool);
		}

		// Token: 0x06004DA6 RID: 19878 RVA: 0x000245D0 File Offset: 0x000227D0
		[Token(Token = "0x6004DA6")]
		[Address(RVA = "0x725590", Offset = "0x725590", VA = "0x725590")]
		public bool CanCapture()
		{
			return default(bool);
		}

		// Token: 0x040092B0 RID: 37552
		[Token(Token = "0x40092B0")]
		private const float OPACITY_RATE = 1f;

		// Token: 0x040092B1 RID: 37553
		[Token(Token = "0x40092B1")]
		[FieldOffset(Offset = "0x10")]
		private LinkedList<Filter> _activeFilters;

		// Token: 0x040092B2 RID: 37554
		[Token(Token = "0x40092B2")]
		[FieldOffset(Offset = "0x14")]
		private int _filterLimit;

		// Token: 0x040092B3 RID: 37555
		[Token(Token = "0x40092B3")]
		[FieldOffset(Offset = "0x18")]
		private EffectPriority _priorityThreshold;

		// Token: 0x040092B4 RID: 37556
		[Token(Token = "0x40092B4")]
		[FieldOffset(Offset = "0x1C")]
		private int _activeFilterCount;

		// Token: 0x040092B5 RID: 37557
		[Token(Token = "0x40092B5")]
		[FieldOffset(Offset = "0x20")]
		private bool _captureThisFrame;
	}
}
