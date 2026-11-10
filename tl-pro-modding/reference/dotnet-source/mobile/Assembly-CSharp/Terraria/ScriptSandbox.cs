using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria
{
	// Token: 0x020004FB RID: 1275
	[Token(Token = "0x20004FB")]
	public static class ScriptSandbox
	{
		// Token: 0x06003291 RID: 12945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003291")]
		[Address(RVA = "0x1A08BF8", Offset = "0x1A08BF8", VA = "0x1A08BF8")]
		public static void Test()
		{
		}

		// Token: 0x06003292 RID: 12946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003292")]
		[Address(RVA = "0x1A08BFC", Offset = "0x1A08BFC", VA = "0x1A08BFC")]
		public static void MethodThatTakesRef(ref Color color)
		{
		}

		// Token: 0x06003293 RID: 12947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003293")]
		[Address(RVA = "0x1A08C00", Offset = "0x1A08C00", VA = "0x1A08C00")]
		public static void MethodForNPCPortraits_CloseUp(ref Dictionary<int, Vector2> dictionary)
		{
		}

		// Token: 0x06003294 RID: 12948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003294")]
		[Address(RVA = "0x1A09838", Offset = "0x1A09838", VA = "0x1A09838")]
		public static void MethodForNPCPortraits_FullBody(ref Dictionary<int, Vector2> dictionary)
		{
		}

		// Token: 0x020004FC RID: 1276
		// (Invoke) Token: 0x06003296 RID: 12950
		[Token(Token = "0x20004FC")]
		public delegate void ScriptType(ref Color color);

		// Token: 0x020004FD RID: 1277
		// (Invoke) Token: 0x0600329A RID: 12954
		[Token(Token = "0x20004FD")]
		public delegate void ScriptTypeDictionaryIntVector2(ref Dictionary<int, Vector2> dictionary);
	}
}
