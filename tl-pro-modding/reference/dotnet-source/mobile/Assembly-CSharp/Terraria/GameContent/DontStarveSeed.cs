using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.GameContent
{
	// Token: 0x0200095C RID: 2396
	[Token(Token = "0x200095C")]
	public class DontStarveSeed
	{
		// Token: 0x06004FC6 RID: 20422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FC6")]
		[Address(RVA = "0x754CE0", Offset = "0x754CE0", VA = "0x754CE0")]
		public static void ModifyNightColor(ref Color bgColorToSet, ref Color moonColor)
		{
		}

		// Token: 0x06004FC7 RID: 20423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FC7")]
		[Address(RVA = "0x754EE4", Offset = "0x754EE4", VA = "0x754EE4")]
		public static void ModifyMinimumLightColorAtNight(ref byte minimalLight)
		{
		}

		// Token: 0x06004FC8 RID: 20424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FC8")]
		[Address(RVA = "0x755090", Offset = "0x755090", VA = "0x755090")]
		public static void FixBiomeDarkness(ref Color bgColor, ref int R, ref int G, ref int B)
		{
		}

		// Token: 0x06004FC9 RID: 20425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FC9")]
		[Address(RVA = "0x75518C", Offset = "0x75518C", VA = "0x75518C")]
		public static void Initialize()
		{
		}

		// Token: 0x06004FCA RID: 20426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FCA")]
		[Address(RVA = "0x755224", Offset = "0x755224", VA = "0x755224")]
		private static void Hook_OnEnterWorld(Player player)
		{
		}

		// Token: 0x06004FCB RID: 20427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FCB")]
		[Address(RVA = "0x75524C", Offset = "0x75524C", VA = "0x75524C")]
		public DontStarveSeed()
		{
		}
	}
}
