using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria.Graphics.Effects
{
	// Token: 0x02000908 RID: 2312
	[Token(Token = "0x2000908")]
	public abstract class GameEffect
	{
		// Token: 0x17000960 RID: 2400
		// (get) Token: 0x06004DA7 RID: 19879 RVA: 0x000245E8 File Offset: 0x000227E8
		[Token(Token = "0x17000960")]
		public bool IsLoaded
		{
			[Token(Token = "0x6004DA7")]
			[Address(RVA = "0x7255E8", Offset = "0x7255E8", VA = "0x7255E8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000961 RID: 2401
		// (get) Token: 0x06004DA8 RID: 19880 RVA: 0x00024600 File Offset: 0x00022800
		[Token(Token = "0x17000961")]
		public EffectPriority Priority
		{
			[Token(Token = "0x6004DA8")]
			[Address(RVA = "0x7255F0", Offset = "0x7255F0", VA = "0x7255F0")]
			get
			{
				return EffectPriority.VeryLow;
			}
		}

		// Token: 0x06004DA9 RID: 19881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DA9")]
		[Address(RVA = "0x7255F8", Offset = "0x7255F8", VA = "0x7255F8")]
		public void Load()
		{
		}

		// Token: 0x06004DAA RID: 19882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DAA")]
		[Address(RVA = "0x72561C", Offset = "0x72561C", VA = "0x72561C", Slot = "4")]
		public virtual void OnLoad()
		{
		}

		// Token: 0x06004DAB RID: 19883
		[Token(Token = "0x6004DAB")]
		public abstract bool IsVisible();

		// Token: 0x06004DAC RID: 19884
		[Token(Token = "0x6004DAC")]
		public abstract void Activate(Vector2 position, object[] args);

		// Token: 0x06004DAD RID: 19885
		[Token(Token = "0x6004DAD")]
		public abstract void Deactivate(object[] args);

		// Token: 0x06004DAE RID: 19886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DAE")]
		[Address(RVA = "0x725620", Offset = "0x725620", VA = "0x725620")]
		protected GameEffect()
		{
		}

		// Token: 0x040092B6 RID: 37558
		[Token(Token = "0x40092B6")]
		[FieldOffset(Offset = "0x8")]
		public float Opacity;

		// Token: 0x040092B7 RID: 37559
		[Token(Token = "0x40092B7")]
		[FieldOffset(Offset = "0xC")]
		protected bool _isLoaded;

		// Token: 0x040092B8 RID: 37560
		[Token(Token = "0x40092B8")]
		[FieldOffset(Offset = "0x10")]
		protected EffectPriority _priority;
	}
}
