using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x020003D9 RID: 985
	[Token(Token = "0x20003D9")]
	public class EffectParameter
	{
		// Token: 0x06001ACD RID: 6861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ACD")]
		[Address(RVA = "0xE45BF0", Offset = "0xE45BF0", VA = "0xE45BF0")]
		internal EffectParameter(string name)
		{
		}

		// Token: 0x06001ACE RID: 6862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ACE")]
		[Address(RVA = "0xE45C5C", Offset = "0xE45C5C", VA = "0xE45C5C")]
		internal EffectParameter(EffectParameter cloneSource)
		{
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x06001ACF RID: 6863 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001AD0 RID: 6864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002EA")]
		public string Name
		{
			[Token(Token = "0x6001ACF")]
			[Address(RVA = "0xE45D98", Offset = "0xE45D98", VA = "0xE45D98")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001AD0")]
			[Address(RVA = "0xE45DA0", Offset = "0xE45DA0", VA = "0xE45DA0")]
			private set
			{
			}
		}

		// Token: 0x06001AD1 RID: 6865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AD1")]
		[Address(RVA = "0xE45DA8", Offset = "0xE45DA8", VA = "0xE45DA8")]
		public void SetValue(Matrix value)
		{
		}

		// Token: 0x06001AD2 RID: 6866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AD2")]
		[Address(RVA = "0xE45DAC", Offset = "0xE45DAC", VA = "0xE45DAC")]
		public void SetValue(bool value)
		{
		}

		// Token: 0x06001AD3 RID: 6867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AD3")]
		[Address(RVA = "0xE45DE4", Offset = "0xE45DE4", VA = "0xE45DE4")]
		public void SetValue(float value)
		{
		}

		// Token: 0x06001AD4 RID: 6868 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AD4")]
		[Address(RVA = "0xE45E0C", Offset = "0xE45E0C", VA = "0xE45E0C")]
		public void SetValue(Vector2 value)
		{
		}

		// Token: 0x06001AD5 RID: 6869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AD5")]
		[Address(RVA = "0xE45E50", Offset = "0xE45E50", VA = "0xE45E50")]
		public void SetValue(Vector3 value)
		{
		}

		// Token: 0x06001AD6 RID: 6870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AD6")]
		[Address(RVA = "0xE45EBC", Offset = "0xE45EBC", VA = "0xE45EBC")]
		public void SetValue(Vector4 value)
		{
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x06001AD7 RID: 6871 RVA: 0x0000CD80 File Offset: 0x0000AF80
		[Token(Token = "0x170002EB")]
		public Vector4 Vector
		{
			[Token(Token = "0x6001AD7")]
			[Address(RVA = "0xE45F54", Offset = "0xE45F54", VA = "0xE45F54")]
			get
			{
				return default(Vector4);
			}
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x06001AD8 RID: 6872 RVA: 0x0000CD98 File Offset: 0x0000AF98
		[Token(Token = "0x170002EC")]
		public float Float
		{
			[Token(Token = "0x6001AD8")]
			[Address(RVA = "0xE45FD4", Offset = "0xE45FD4", VA = "0xE45FD4")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x06001AD9 RID: 6873 RVA: 0x0000CDB0 File Offset: 0x0000AFB0
		[Token(Token = "0x170002ED")]
		public bool Bool
		{
			[Token(Token = "0x6001AD9")]
			[Address(RVA = "0xE45FF8", Offset = "0xE45FF8", VA = "0xE45FF8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x06001ADA RID: 6874 RVA: 0x0000CDC8 File Offset: 0x0000AFC8
		[Token(Token = "0x170002EE")]
		public Color Color
		{
			[Token(Token = "0x6001ADA")]
			[Address(RVA = "0xE46024", Offset = "0xE46024", VA = "0xE46024")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x04002E27 RID: 11815
		[Token(Token = "0x4002E27")]
		[FieldOffset(Offset = "0x8")]
		private string <Name>k__BackingField;

		// Token: 0x04002E28 RID: 11816
		[Token(Token = "0x4002E28")]
		[FieldOffset(Offset = "0xC")]
		internal float[] Data;
	}
}
