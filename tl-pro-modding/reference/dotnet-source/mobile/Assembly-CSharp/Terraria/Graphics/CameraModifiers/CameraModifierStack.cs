using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria.Graphics.CameraModifiers
{
	// Token: 0x020008F1 RID: 2289
	[Token(Token = "0x20008F1")]
	public class CameraModifierStack
	{
		// Token: 0x06004CFC RID: 19708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CFC")]
		[Address(RVA = "0x71BCDC", Offset = "0x71BCDC", VA = "0x71BCDC")]
		public void Add(ICameraModifier modifier)
		{
		}

		// Token: 0x06004CFD RID: 19709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CFD")]
		[Address(RVA = "0x71BE74", Offset = "0x71BE74", VA = "0x71BE74")]
		private void RemoveIdenticalModifiers(ICameraModifier modifier)
		{
		}

		// Token: 0x06004CFE RID: 19710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CFE")]
		[Address(RVA = "0x71C07C", Offset = "0x71C07C", VA = "0x71C07C")]
		public void ApplyTo(ref Vector2 cameraPosition)
		{
		}

		// Token: 0x06004CFF RID: 19711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CFF")]
		[Address(RVA = "0x71C34C", Offset = "0x71C34C", VA = "0x71C34C")]
		private void ClearFinishedModifiers()
		{
		}

		// Token: 0x06004D00 RID: 19712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D00")]
		[Address(RVA = "0x71C4C4", Offset = "0x71C4C4", VA = "0x71C4C4")]
		public CameraModifierStack()
		{
		}

		// Token: 0x040091F5 RID: 37365
		[Token(Token = "0x40091F5")]
		[FieldOffset(Offset = "0x8")]
		private List<ICameraModifier> _modifiers;
	}
}
