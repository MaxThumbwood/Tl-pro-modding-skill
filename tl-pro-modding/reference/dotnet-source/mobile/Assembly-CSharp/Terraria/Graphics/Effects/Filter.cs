using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Terraria.Graphics.Shaders;

namespace Terraria.Graphics.Effects
{
	// Token: 0x02000906 RID: 2310
	[Token(Token = "0x2000906")]
	public class Filter : GameEffect
	{
		// Token: 0x06004D96 RID: 19862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D96")]
		[Address(RVA = "0x723C64", Offset = "0x723C64", VA = "0x723C64")]
		public Filter(ScreenShaderData shader, EffectPriority priority = EffectPriority.VeryLow)
		{
		}

		// Token: 0x06004D97 RID: 19863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D97")]
		[Address(RVA = "0x723C88", Offset = "0x723C88", VA = "0x723C88")]
		public void Update(GameTime gameTime)
		{
		}

		// Token: 0x06004D98 RID: 19864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D98")]
		[Address(RVA = "0x723CEC", Offset = "0x723CEC", VA = "0x723CEC")]
		public void Apply()
		{
		}

		// Token: 0x06004D99 RID: 19865 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004D99")]
		[Address(RVA = "0x723D18", Offset = "0x723D18", VA = "0x723D18")]
		public ScreenShaderData GetShader()
		{
			return null;
		}

		// Token: 0x06004D9A RID: 19866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D9A")]
		[Address(RVA = "0x723D20", Offset = "0x723D20", VA = "0x723D20", Slot = "6")]
		public override void Activate(Vector2 position, object[] args)
		{
		}

		// Token: 0x06004D9B RID: 19867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004D9B")]
		[Address(RVA = "0x723D8C", Offset = "0x723D8C", VA = "0x723D8C", Slot = "7")]
		public override void Deactivate(object[] args)
		{
		}

		// Token: 0x06004D9C RID: 19868 RVA: 0x00024570 File Offset: 0x00022770
		[Token(Token = "0x6004D9C")]
		[Address(RVA = "0x723D98", Offset = "0x723D98", VA = "0x723D98")]
		public bool IsInUse()
		{
			return default(bool);
		}

		// Token: 0x06004D9D RID: 19869 RVA: 0x00024588 File Offset: 0x00022788
		[Token(Token = "0x6004D9D")]
		[Address(RVA = "0x723DC4", Offset = "0x723DC4", VA = "0x723DC4")]
		public bool IsActive()
		{
			return default(bool);
		}

		// Token: 0x06004D9E RID: 19870 RVA: 0x000245A0 File Offset: 0x000227A0
		[Token(Token = "0x6004D9E")]
		[Address(RVA = "0x723DCC", Offset = "0x723DCC", VA = "0x723DCC", Slot = "5")]
		public override bool IsVisible()
		{
			return default(bool);
		}

		// Token: 0x040092AD RID: 37549
		[Token(Token = "0x40092AD")]
		[FieldOffset(Offset = "0x14")]
		public bool Active;

		// Token: 0x040092AE RID: 37550
		[Token(Token = "0x40092AE")]
		[FieldOffset(Offset = "0x18")]
		private ScreenShaderData _shader;

		// Token: 0x040092AF RID: 37551
		[Token(Token = "0x40092AF")]
		[FieldOffset(Offset = "0x1C")]
		public bool IsHidden;
	}
}
