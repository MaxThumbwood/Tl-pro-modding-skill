using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x020003DA RID: 986
	[Token(Token = "0x20003DA")]
	public class EffectParameterCollection : FileAPI, GUIControllerItem
	{
		// Token: 0x06001ADB RID: 6875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ADB")]
		[Address(RVA = "0xE46098", Offset = "0xE46098", VA = "0xE46098")]
		internal EffectParameterCollection(EffectParameter[] parameters)
		{
		}

		// Token: 0x06001ADC RID: 6876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ADC")]
		[Address(RVA = "0xE461F0", Offset = "0xE461F0", VA = "0xE461F0")]
		private EffectParameterCollection(EffectParameter[] parameters, Dictionary<string, int> indexLookup)
		{
		}

		// Token: 0x06001ADD RID: 6877 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ADD")]
		[Address(RVA = "0xE46214", Offset = "0xE46214", VA = "0xE46214")]
		internal EffectParameterCollection Clone()
		{
			return null;
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x06001ADE RID: 6878 RVA: 0x0000CDE0 File Offset: 0x0000AFE0
		[Token(Token = "0x170002EF")]
		public int Count
		{
			[Token(Token = "0x6001ADE")]
			[Address(RVA = "0xE463E8", Offset = "0xE463E8", VA = "0xE463E8")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x06001ADF RID: 6879 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002F0")]
		public EffectParameter Item
		{
			[Token(Token = "0x6001ADF")]
			[Address(RVA = "0xE4640C", Offset = "0xE4640C", VA = "0xE4640C")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x06001AE0 RID: 6880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002F1")]
		public EffectParameter Item
		{
			[Token(Token = "0x6001AE0")]
			[Address(RVA = "0xE46430", Offset = "0xE46430", VA = "0xE46430")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001AE1 RID: 6881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AE1")]
		[Address(RVA = "0xE464D8", Offset = "0xE464D8", VA = "0xE464D8", Slot = "4")]
		public IEnumerator<EffectParameter> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06001AE2 RID: 6882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AE2")]
		[Address(RVA = "0xE46590", Offset = "0xE46590", VA = "0xE46590", Slot = "5")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		// Token: 0x04002E29 RID: 11817
		[Token(Token = "0x4002E29")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly EffectParameterCollection Empty;

		// Token: 0x04002E2A RID: 11818
		[Token(Token = "0x4002E2A")]
		[FieldOffset(Offset = "0x8")]
		private readonly EffectParameter[] _parameters;

		// Token: 0x04002E2B RID: 11819
		[Token(Token = "0x4002E2B")]
		[FieldOffset(Offset = "0xC")]
		private readonly Dictionary<string, int> _indexLookup;
	}
}
