using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria.GameInput
{
	// Token: 0x02000828 RID: 2088
	[Token(Token = "0x2000828")]
	public class SmartSelectGamepadPointer
	{
		// Token: 0x060047A3 RID: 18339 RVA: 0x00021FA8 File Offset: 0x000201A8
		[Token(Token = "0x60047A3")]
		[Address(RVA = "0x5E522C", Offset = "0x5E522C", VA = "0x5E522C")]
		public bool ShouldBeUsed()
		{
			return default(bool);
		}

		// Token: 0x060047A4 RID: 18340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047A4")]
		[Address(RVA = "0x5E530C", Offset = "0x5E530C", VA = "0x5E530C")]
		public void SmartSelectLookup_GetTargetTile(Player player, out int tX, out int tY)
		{
		}

		// Token: 0x060047A5 RID: 18341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047A5")]
		[Address(RVA = "0x5E588C", Offset = "0x5E588C", VA = "0x5E588C")]
		public void UpdateSize(Vector2 size)
		{
		}

		// Token: 0x060047A6 RID: 18342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047A6")]
		[Address(RVA = "0x5E5898", Offset = "0x5E5898", VA = "0x5E5898")]
		public void UpdateCenter(Vector2 center)
		{
		}

		// Token: 0x060047A7 RID: 18343 RVA: 0x00021FC0 File Offset: 0x000201C0
		[Token(Token = "0x60047A7")]
		[Address(RVA = "0x5E5604", Offset = "0x5E5604", VA = "0x5E5604")]
		public Vector2 GetPointerPosition()
		{
			return default(Vector2);
		}

		// Token: 0x060047A8 RID: 18344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60047A8")]
		[Address(RVA = "0x5E58A4", Offset = "0x5E58A4", VA = "0x5E58A4")]
		public SmartSelectGamepadPointer()
		{
		}

		// Token: 0x04008E26 RID: 36390
		[Token(Token = "0x4008E26")]
		[FieldOffset(Offset = "0x8")]
		private Vector2 _size;

		// Token: 0x04008E27 RID: 36391
		[Token(Token = "0x4008E27")]
		[FieldOffset(Offset = "0x10")]
		private Vector2 _center;

		// Token: 0x04008E28 RID: 36392
		[Token(Token = "0x4008E28")]
		[FieldOffset(Offset = "0x18")]
		private Vector2 _distUniform;
	}
}
