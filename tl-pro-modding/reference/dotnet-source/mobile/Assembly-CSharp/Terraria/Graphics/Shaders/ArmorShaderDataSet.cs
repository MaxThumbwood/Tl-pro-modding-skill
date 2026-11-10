using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Terraria.DataStructures;

namespace Terraria.Graphics.Shaders
{
	// Token: 0x020008BE RID: 2238
	[Token(Token = "0x20008BE")]
	public class ArmorShaderDataSet
	{
		// Token: 0x06004BB5 RID: 19381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BB5")]
		public T BindShader<T>(int itemId, T shaderData) where T : ArmorShaderData
		{
			return null;
		}

		// Token: 0x06004BB6 RID: 19382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BB6")]
		[Address(RVA = "0x6E37B0", Offset = "0x6E37B0", VA = "0x6E37B0")]
		public void Apply(int shaderId, Entity entity, [Optional] DrawData? drawData)
		{
		}

		// Token: 0x06004BB7 RID: 19383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BB7")]
		[Address(RVA = "0x6E39E8", Offset = "0x6E39E8", VA = "0x6E39E8")]
		public void ApplySecondary(int shaderId, Entity entity, [Optional] DrawData? drawData)
		{
		}

		// Token: 0x06004BB8 RID: 19384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BB8")]
		[Address(RVA = "0x6E3C48", Offset = "0x6E3C48", VA = "0x6E3C48")]
		public ArmorShaderData GetShaderFromItemId(int type)
		{
			return null;
		}

		// Token: 0x06004BB9 RID: 19385 RVA: 0x00023EF8 File Offset: 0x000220F8
		[Token(Token = "0x6004BB9")]
		[Address(RVA = "0x6E3D40", Offset = "0x6E3D40", VA = "0x6E3D40")]
		public int GetShaderIdFromItemId(int type)
		{
			return 0;
		}

		// Token: 0x06004BBA RID: 19386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004BBA")]
		[Address(RVA = "0x6E3DF8", Offset = "0x6E3DF8", VA = "0x6E3DF8")]
		public ArmorShaderData GetSecondaryShader(int id, Player player)
		{
			return null;
		}

		// Token: 0x06004BBB RID: 19387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004BBB")]
		[Address(RVA = "0x6E3ED8", Offset = "0x6E3ED8", VA = "0x6E3ED8")]
		public ArmorShaderDataSet()
		{
		}

		// Token: 0x040090B5 RID: 37045
		[Token(Token = "0x40090B5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		protected List<ArmorShaderData> _shaderData;

		// Token: 0x040090B6 RID: 37046
		[Token(Token = "0x40090B6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		protected Dictionary<int, int> _shaderLookupDictionary;

		// Token: 0x040090B7 RID: 37047
		[Token(Token = "0x40090B7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected int _shaderDataCount;
	}
}
