using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;

namespace Terraria.GameContent
{
	// Token: 0x020009EF RID: 2543
	[Token(Token = "0x20009EF")]
	public struct VoidLensHelper
	{
		// Token: 0x060052BE RID: 21182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052BE")]
		[Address(RVA = "0x7E3C50", Offset = "0x7E3C50", VA = "0x7E3C50")]
		public VoidLensHelper(Projectile proj)
		{
		}

		// Token: 0x060052BF RID: 21183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052BF")]
		[Address(RVA = "0x7E3CD8", Offset = "0x7E3CD8", VA = "0x7E3CD8")]
		public VoidLensHelper(Vector2 worldPosition, float opacity)
		{
		}

		// Token: 0x060052C0 RID: 21184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052C0")]
		[Address(RVA = "0x7E3DE4", Offset = "0x7E3DE4", VA = "0x7E3DE4")]
		public void Update()
		{
		}

		// Token: 0x060052C1 RID: 21185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052C1")]
		[Address(RVA = "0x7E3E84", Offset = "0x7E3E84", VA = "0x7E3E84")]
		public void SpawnVoidLensDust()
		{
		}

		// Token: 0x060052C2 RID: 21186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60052C2")]
		[Address(RVA = "0x7E48C4", Offset = "0x7E48C4", VA = "0x7E48C4")]
		public void DrawToDrawData(List<DrawData> drawDataList, int selectionMode)
		{
		}

		// Token: 0x040096FD RID: 38653
		[Token(Token = "0x40096FD")]
		[FieldOffset(Offset = "0x0")]
		private readonly Vector2 _position;

		// Token: 0x040096FE RID: 38654
		[Token(Token = "0x40096FE")]
		[FieldOffset(Offset = "0x8")]
		private readonly float _opacity;

		// Token: 0x040096FF RID: 38655
		[Token(Token = "0x40096FF")]
		[FieldOffset(Offset = "0xC")]
		private readonly int _frameNumber;
	}
}
