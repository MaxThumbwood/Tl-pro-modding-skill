using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x020003DF RID: 991
	[Token(Token = "0x20003DF")]
	public class EffectTechniqueCollection : FileAPI, GUIControllerItem
	{
		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x06001AFF RID: 6911 RVA: 0x0000CE58 File Offset: 0x0000B058
		[Token(Token = "0x170002F9")]
		public int Count
		{
			[Token(Token = "0x6001AFF")]
			[Address(RVA = "0xE472D0", Offset = "0xE472D0", VA = "0xE472D0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06001B00 RID: 6912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B00")]
		[Address(RVA = "0xE472F4", Offset = "0xE472F4", VA = "0xE472F4")]
		internal EffectTechniqueCollection(EffectTechnique[] techniques)
		{
		}

		// Token: 0x06001B01 RID: 6913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B01")]
		[Address(RVA = "0xE47310", Offset = "0xE47310", VA = "0xE47310")]
		internal EffectTechniqueCollection Clone(Effect effect)
		{
			return null;
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x06001B02 RID: 6914 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002FA")]
		public EffectTechnique Item
		{
			[Token(Token = "0x6001B02")]
			[Address(RVA = "0xE474CC", Offset = "0xE474CC", VA = "0xE474CC")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x06001B03 RID: 6915 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170002FB")]
		public EffectTechnique Item
		{
			[Token(Token = "0x6001B03")]
			[Address(RVA = "0xE474F0", Offset = "0xE474F0", VA = "0xE474F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001B04 RID: 6916 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B04")]
		[Address(RVA = "0xE47564", Offset = "0xE47564", VA = "0xE47564", Slot = "4")]
		public IEnumerator<EffectTechnique> GetEnumerator()
		{
			return null;
		}

		// Token: 0x06001B05 RID: 6917 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B05")]
		[Address(RVA = "0xE4761C", Offset = "0xE4761C", VA = "0xE4761C", Slot = "5")]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return null;
		}

		// Token: 0x04002E3A RID: 11834
		[Token(Token = "0x4002E3A")]
		[FieldOffset(Offset = "0x8")]
		private readonly EffectTechnique[] _techniques;
	}
}
