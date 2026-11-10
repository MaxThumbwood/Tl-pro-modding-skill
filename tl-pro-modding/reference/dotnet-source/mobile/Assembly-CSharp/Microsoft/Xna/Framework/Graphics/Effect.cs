using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x020003D8 RID: 984
	[Token(Token = "0x20003D8")]
	public class Effect : GraphicsResource
	{
		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x06001AC3 RID: 6851 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001AC4 RID: 6852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002E8")]
		public EffectParameterCollection Parameters
		{
			[Token(Token = "0x6001AC3")]
			[Address(RVA = "0xE45AB4", Offset = "0xE45AB4", VA = "0xE45AB4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001AC4")]
			[Address(RVA = "0xE45ABC", Offset = "0xE45ABC", VA = "0xE45ABC")]
			protected set
			{
			}
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x06001AC5 RID: 6853 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001AC6 RID: 6854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002E9")]
		public EffectTechnique CurrentTechnique
		{
			[Token(Token = "0x6001AC5")]
			[Address(RVA = "0xE45AC4", Offset = "0xE45AC4", VA = "0xE45AC4")]
			get
			{
				return null;
			}
			[Token(Token = "0x6001AC6")]
			[Address(RVA = "0xE45ACC", Offset = "0xE45ACC", VA = "0xE45ACC")]
			protected set
			{
			}
		}

		// Token: 0x06001AC7 RID: 6855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AC7")]
		[Address(RVA = "0xE45AD4", Offset = "0xE45AD4", VA = "0xE45AD4")]
		internal Effect(GraphicsDevice graphicsDevice)
		{
		}

		// Token: 0x06001AC8 RID: 6856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AC8")]
		[Address(RVA = "0xE45AFC", Offset = "0xE45AFC", VA = "0xE45AFC")]
		protected Effect(Effect cloneSource)
		{
		}

		// Token: 0x06001AC9 RID: 6857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AC9")]
		[Address(RVA = "0xE45B44", Offset = "0xE45B44", VA = "0xE45B44", Slot = "5")]
		public virtual void ApplyValuesToMaterial(EffectPass pass, Material material)
		{
		}

		// Token: 0x06001ACA RID: 6858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ACA")]
		[Address(RVA = "0xE45B40", Offset = "0xE45B40", VA = "0xE45B40")]
		private void Clone(Effect cloneSource)
		{
		}

		// Token: 0x06001ACB RID: 6859 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ACB")]
		[Address(RVA = "0xE45B48", Offset = "0xE45B48", VA = "0xE45B48", Slot = "6")]
		public virtual Effect Clone()
		{
			return null;
		}

		// Token: 0x06001ACC RID: 6860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ACC")]
		[Address(RVA = "0xE45BEC", Offset = "0xE45BEC", VA = "0xE45BEC", Slot = "7")]
		protected internal virtual void OnApply()
		{
		}

		// Token: 0x04002E24 RID: 11812
		[Token(Token = "0x4002E24")]
		[FieldOffset(Offset = "0x18")]
		private EffectParameterCollection <Parameters>k__BackingField;

		// Token: 0x04002E25 RID: 11813
		[Token(Token = "0x4002E25")]
		[FieldOffset(Offset = "0x1C")]
		private EffectTechnique <CurrentTechnique>k__BackingField;

		// Token: 0x04002E26 RID: 11814
		[Token(Token = "0x4002E26")]
		[FieldOffset(Offset = "0x20")]
		private readonly bool _isClone;
	}
}
