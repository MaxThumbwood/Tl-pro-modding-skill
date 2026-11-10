using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;

namespace Terraria.Graphics.Shaders
{
	// Token: 0x020008C1 RID: 2241
	[Token(Token = "0x20008C1")]
	public class HairShaderDataSet
	{
		// Token: 0x06004BCC RID: 19404 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BCC")]
		public T BindShader<T>(int itemId, T shaderData) where T : HairShaderData
		{
			return null;
		}

		// Token: 0x06004BCD RID: 19405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BCD")]
		[Address(RVA = "0x6E5184", Offset = "0x6E5184", VA = "0x6E5184")]
		public void Apply(short shaderId, Player player, [Optional] DrawData? drawData)
		{
		}

		// Token: 0x06004BCE RID: 19406 RVA: 0x00023F40 File Offset: 0x00022140
		[Token(Token = "0x6004BCE")]
		[Address(RVA = "0x6E53C0", Offset = "0x6E53C0", VA = "0x6E53C0")]
		public Color GetColor(short shaderId, Player player, Color lightColor)
		{
			return default(Color);
		}

		// Token: 0x06004BCF RID: 19407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BCF")]
		[Address(RVA = "0x6E5584", Offset = "0x6E5584", VA = "0x6E5584")]
		public void GetBaseColor(short shaderId, Player player, ref Color hairColor)
		{
		}

		// Token: 0x06004BD0 RID: 19408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BD0")]
		[Address(RVA = "0x6E5690", Offset = "0x6E5690", VA = "0x6E5690")]
		public HairShaderData GetShaderFromItemId(int type)
		{
			return null;
		}

		// Token: 0x06004BD1 RID: 19409 RVA: 0x00023F58 File Offset: 0x00022158
		[Token(Token = "0x6004BD1")]
		[Address(RVA = "0x6E5788", Offset = "0x6E5788", VA = "0x6E5788")]
		public short GetShaderIdFromItemId(int type)
		{
			return 0;
		}

		// Token: 0x06004BD2 RID: 19410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BD2")]
		[Address(RVA = "0x6E4114", Offset = "0x6E4114", VA = "0x6E4114")]
		public HairShaderDataSet()
		{
		}

		// Token: 0x040090C2 RID: 37058
		[Token(Token = "0x40090C2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		protected List<HairShaderData> _shaderData;

		// Token: 0x040090C3 RID: 37059
		[Token(Token = "0x40090C3")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		protected Dictionary<int, short> _shaderLookupDictionary;

		// Token: 0x040090C4 RID: 37060
		[Token(Token = "0x40090C4")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected byte _shaderDataCount;
	}
}
