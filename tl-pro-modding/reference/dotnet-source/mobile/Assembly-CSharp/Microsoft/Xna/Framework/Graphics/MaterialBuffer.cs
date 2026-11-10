using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x020003EB RID: 1003
	[Token(Token = "0x20003EB")]
	public class MaterialBuffer
	{
		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06001B41 RID: 6977 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000308")]
		private static ref MaterialBuffer.MaterialPartition[] _availableMaterials
		{
			[Token(Token = "0x6001B41")]
			[Address(RVA = "0xE564F0", Offset = "0xE564F0", VA = "0xE564F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06001B42 RID: 6978 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000309")]
		private static MaterialBuffer.MaterialEntryList _usedMaterialsDefault
		{
			[Token(Token = "0x6001B42")]
			[Address(RVA = "0xE5656C", Offset = "0xE5656C", VA = "0xE5656C")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06001B43 RID: 6979 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001B44 RID: 6980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700030A")]
		private static MaterialBuffer.MaterialEntryList _usedMaterials
		{
			[Token(Token = "0x6001B43")]
			[Address(RVA = "0xE565E8", Offset = "0xE565E8", VA = "0xE565E8")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001B44")]
			[Address(RVA = "0xE56664", Offset = "0xE56664", VA = "0xE56664")]
			set
			{
			}
		}

		// Token: 0x06001B45 RID: 6981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B45")]
		[Address(RVA = "0xE523E0", Offset = "0xE523E0", VA = "0xE523E0")]
		public static void SetUsedMaterialList(MaterialBuffer.MaterialEntryList list)
		{
		}

		// Token: 0x06001B46 RID: 6982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B46")]
		[Address(RVA = "0xE566E4", Offset = "0xE566E4", VA = "0xE566E4")]
		public static void DestroyMaterials()
		{
		}

		// Token: 0x06001B47 RID: 6983 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B47")]
		[Address(RVA = "0xE50AE0", Offset = "0xE50AE0", VA = "0xE50AE0")]
		public static Material GetMaterial(EffectPass baseEffect, Texture2D t0, Texture2D t1, Texture2D t2, Texture2D t3)
		{
			return null;
		}

		// Token: 0x06001B48 RID: 6984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B48")]
		[Address(RVA = "0xE52598", Offset = "0xE52598", VA = "0xE52598")]
		public static void ClearInstances()
		{
		}

		// Token: 0x06001B49 RID: 6985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B49")]
		[Address(RVA = "0xE56BE8", Offset = "0xE56BE8", VA = "0xE56BE8")]
		public MaterialBuffer()
		{
		}

		// Token: 0x04002F3B RID: 12091
		[Token(Token = "0x4002F3B")]
		[FieldOffset(Offset = "0x0")]
		private static int MainTexId;

		// Token: 0x04002F3C RID: 12092
		[Token(Token = "0x4002F3C")]
		[FieldOffset(Offset = "0x4")]
		private static int MainAlphaTexId;

		// Token: 0x04002F3D RID: 12093
		[Token(Token = "0x4002F3D")]
		[FieldOffset(Offset = "0x8")]
		private static int MainPalTexId;

		// Token: 0x04002F3E RID: 12094
		[Token(Token = "0x4002F3E")]
		[FieldOffset(Offset = "0xC")]
		private static int PalScaleSizeId;

		// Token: 0x04002F3F RID: 12095
		[Token(Token = "0x4002F3F")]
		[FieldOffset(Offset = "0x10")]
		public static int SecTexId;

		// Token: 0x04002F40 RID: 12096
		[Token(Token = "0x4002F40")]
		[FieldOffset(Offset = "0x14")]
		private static int ThirdTexId;

		// Token: 0x04002F41 RID: 12097
		[Token(Token = "0x4002F41")]
		[FieldOffset(Offset = "0x18")]
		private static int ForthTexId;

		// Token: 0x04002F42 RID: 12098
		[Token(Token = "0x4002F42")]
		[FieldOffset(Offset = "0x1C")]
		private static int TrimMinId;

		// Token: 0x04002F43 RID: 12099
		[Token(Token = "0x4002F43")]
		[FieldOffset(Offset = "0x20")]
		private static int TrimMaxId;

		// Token: 0x020003EC RID: 1004
		[Token(Token = "0x20003EC")]
		public class MaterialEntryList
		{
			// Token: 0x06001B4B RID: 6987 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001B4B")]
			[Address(RVA = "0xE7E300", Offset = "0xE7E300", VA = "0xE7E300")]
			public MaterialBuffer.MaterialEntry GetAndRemove()
			{
				return null;
			}

			// Token: 0x06001B4C RID: 6988 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001B4C")]
			[Address(RVA = "0xE7E320", Offset = "0xE7E320", VA = "0xE7E320")]
			public void Add(MaterialBuffer.MaterialEntry entry)
			{
			}

			// Token: 0x06001B4D RID: 6989 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001B4D")]
			[Address(RVA = "0xE7E348", Offset = "0xE7E348", VA = "0xE7E348")]
			public MaterialEntryList()
			{
			}

			// Token: 0x04002F44 RID: 12100
			[Token(Token = "0x4002F44")]
			[FieldOffset(Offset = "0x8")]
			public MaterialBuffer.MaterialEntryList Next;

			// Token: 0x04002F45 RID: 12101
			[Token(Token = "0x4002F45")]
			[FieldOffset(Offset = "0xC")]
			public int BatchTextureIndex;

			// Token: 0x04002F46 RID: 12102
			[Token(Token = "0x4002F46")]
			[FieldOffset(Offset = "0x10")]
			public MaterialBuffer.MaterialEntry First;
		}

		// Token: 0x020003ED RID: 1005
		[Token(Token = "0x20003ED")]
		public class MaterialDictionary
		{
			// Token: 0x06001B4E RID: 6990 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001B4E")]
			[Address(RVA = "0xE7E350", Offset = "0xE7E350", VA = "0xE7E350")]
			public MaterialDictionary()
			{
			}

			// Token: 0x04002F47 RID: 12103
			[Token(Token = "0x4002F47")]
			public const int DictionarySize = 128;

			// Token: 0x04002F48 RID: 12104
			[Token(Token = "0x4002F48")]
			[FieldOffset(Offset = "0x8")]
			public MaterialBuffer.MaterialEntryList[] Dictionary;
		}

		// Token: 0x020003EE RID: 1006
		[Token(Token = "0x20003EE")]
		public class MaterialEntry
		{
			// Token: 0x06001B4F RID: 6991 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001B4F")]
			[Address(RVA = "0xE7E3B4", Offset = "0xE7E3B4", VA = "0xE7E3B4")]
			public MaterialEntry(MaterialBuffer.MaterialPartition materialPartition, MaterialBuffer.MaterialEntryList list, Texture2D t0, Texture2D t1, Texture2D t2, Texture2D t3)
			{
			}

			// Token: 0x06001B50 RID: 6992 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001B50")]
			[Address(RVA = "0xE7EC28", Offset = "0xE7EC28", VA = "0xE7EC28")]
			public void SetupTrimming(Vector2 min, Vector2 max)
			{
			}

			// Token: 0x06001B51 RID: 6993 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001B51")]
			[Address(RVA = "0xE7ED68", Offset = "0xE7ED68", VA = "0xE7ED68")]
			public void ClearTrimming()
			{
			}

			// Token: 0x06001B52 RID: 6994 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001B52")]
			[Address(RVA = "0xE7EDE8", Offset = "0xE7EDE8", VA = "0xE7EDE8")]
			public void Relase()
			{
			}

			// Token: 0x04002F49 RID: 12105
			[Token(Token = "0x4002F49")]
			[FieldOffset(Offset = "0x8")]
			public MaterialBuffer.MaterialEntry Next;

			// Token: 0x04002F4A RID: 12106
			[Token(Token = "0x4002F4A")]
			[FieldOffset(Offset = "0xC")]
			public readonly MaterialBuffer.MaterialEntryList MaterialList;

			// Token: 0x04002F4B RID: 12107
			[Token(Token = "0x4002F4B")]
			[FieldOffset(Offset = "0x10")]
			public readonly Texture2D T0;

			// Token: 0x04002F4C RID: 12108
			[Token(Token = "0x4002F4C")]
			[FieldOffset(Offset = "0x14")]
			public readonly Texture2D T1;

			// Token: 0x04002F4D RID: 12109
			[Token(Token = "0x4002F4D")]
			[FieldOffset(Offset = "0x18")]
			public readonly Material Material;

			// Token: 0x04002F4E RID: 12110
			[Token(Token = "0x4002F4E")]
			[FieldOffset(Offset = "0x1C")]
			private bool useTrimming;
		}

		// Token: 0x020003EF RID: 1007
		[Token(Token = "0x20003EF")]
		public class MaterialPartition : MaterialBuffer.MaterialDictionary
		{
			// Token: 0x06001B53 RID: 6995 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001B53")]
			[Address(RVA = "0xE7EE10", Offset = "0xE7EE10", VA = "0xE7EE10")]
			public MaterialPartition(Material baseMaterial)
			{
			}

			// Token: 0x06001B54 RID: 6996 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001B54")]
			[Address(RVA = "0xE7EF58", Offset = "0xE7EF58", VA = "0xE7EF58")]
			public void DestroyMaterials()
			{
			}

			// Token: 0x06001B55 RID: 6997 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001B55")]
			[Address(RVA = "0xE7F030", Offset = "0xE7F030", VA = "0xE7F030")]
			public MaterialBuffer.MaterialEntry GetMaterial(Texture2D t0, Texture2D t1, Texture2D t2, Texture2D t3)
			{
				return null;
			}

			// Token: 0x04002F4F RID: 12111
			[Token(Token = "0x4002F4F")]
			[FieldOffset(Offset = "0xC")]
			public readonly Material BaseMaterial;

			// Token: 0x04002F50 RID: 12112
			[Token(Token = "0x4002F50")]
			[FieldOffset(Offset = "0x10")]
			public readonly bool HasTexture2;

			// Token: 0x04002F51 RID: 12113
			[Token(Token = "0x4002F51")]
			[FieldOffset(Offset = "0x11")]
			public readonly bool HasTexture3;

			// Token: 0x04002F52 RID: 12114
			[Token(Token = "0x4002F52")]
			[FieldOffset(Offset = "0x12")]
			public readonly bool HasTexture4;
		}
	}
}
