using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria.DataStructures
{
	// Token: 0x020007BE RID: 1982
	[Token(Token = "0x20007BE")]
	public class SettingsForCharacterPreview
	{
		// Token: 0x06004470 RID: 17520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004470")]
		[Address(RVA = "0x5592BC", Offset = "0x5592BC", VA = "0x5592BC")]
		public void ApplyTo(Projectile proj, bool walking)
		{
		}

		// Token: 0x06004471 RID: 17521 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004471")]
		[Address(RVA = "0x55952C", Offset = "0x55952C", VA = "0x55952C")]
		public SettingsForCharacterPreview WhenSelected([Optional] int? startFrame, [Optional] int? frameCount, [Optional] int? delayPerFrame, [Optional] bool? bounceLoop)
		{
			return null;
		}

		// Token: 0x06004472 RID: 17522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004472")]
		[Address(RVA = "0x559720", Offset = "0x559720", VA = "0x559720")]
		public SettingsForCharacterPreview WhenNotSelected([Optional] int? startFrame, [Optional] int? frameCount, [Optional] int? delayPerFrame, [Optional] bool? bounceLoop)
		{
			return null;
		}

		// Token: 0x06004473 RID: 17523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004473")]
		[Address(RVA = "0x559560", Offset = "0x559560", VA = "0x559560")]
		private static void Modify(ref SettingsForCharacterPreview.SelectionBasedSettings target, int? startFrame, int? frameCount, int? delayPerFrame, bool? bounceLoop)
		{
		}

		// Token: 0x06004474 RID: 17524 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004474")]
		[Address(RVA = "0x559754", Offset = "0x559754", VA = "0x559754")]
		public SettingsForCharacterPreview WithOffset(Vector2 offset)
		{
			return null;
		}

		// Token: 0x06004475 RID: 17525 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004475")]
		[Address(RVA = "0x559760", Offset = "0x559760", VA = "0x559760")]
		public SettingsForCharacterPreview WithOffset(float x, float y)
		{
			return null;
		}

		// Token: 0x06004476 RID: 17526 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004476")]
		[Address(RVA = "0x55979C", Offset = "0x55979C", VA = "0x55979C")]
		public SettingsForCharacterPreview WithSpriteDirection(int spriteDirection)
		{
			return null;
		}

		// Token: 0x06004477 RID: 17527 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004477")]
		[Address(RVA = "0x5597A4", Offset = "0x5597A4", VA = "0x5597A4")]
		public SettingsForCharacterPreview WithCode(SettingsForCharacterPreview.CustomAnimationCode customAnimation)
		{
			return null;
		}

		// Token: 0x06004478 RID: 17528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004478")]
		[Address(RVA = "0x5597AC", Offset = "0x5597AC", VA = "0x5597AC")]
		public SettingsForCharacterPreview()
		{
		}

		// Token: 0x04008BEC RID: 35820
		[Token(Token = "0x4008BEC")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public Vector2 Offset;

		// Token: 0x04008BED RID: 35821
		[Token(Token = "0x4008BED")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public SettingsForCharacterPreview.SelectionBasedSettings Selected;

		// Token: 0x04008BEE RID: 35822
		[Token(Token = "0x4008BEE")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public SettingsForCharacterPreview.SelectionBasedSettings NotSelected;

		// Token: 0x04008BEF RID: 35823
		[Token(Token = "0x4008BEF")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int SpriteDirection;

		// Token: 0x04008BF0 RID: 35824
		[Token(Token = "0x4008BF0")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public SettingsForCharacterPreview.CustomAnimationCode CustomAnimation;

		// Token: 0x020007BF RID: 1983
		// (Invoke) Token: 0x0600447A RID: 17530
		[Token(Token = "0x20007BF")]
		public delegate void CustomAnimationCode(Projectile proj, bool walking);

		// Token: 0x020007C0 RID: 1984
		[Token(Token = "0x20007C0")]
		public struct SelectionBasedSettings
		{
			// Token: 0x0600447D RID: 17533 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600447D")]
			[Address(RVA = "0x559498", Offset = "0x559498", VA = "0x559498")]
			public void ApplyTo(Projectile proj)
			{
			}

			// Token: 0x04008BF1 RID: 35825
			[Token(Token = "0x4008BF1")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int StartFrame;

			// Token: 0x04008BF2 RID: 35826
			[Token(Token = "0x4008BF2")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public int FrameCount;

			// Token: 0x04008BF3 RID: 35827
			[Token(Token = "0x4008BF3")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public int DelayPerFrame;

			// Token: 0x04008BF4 RID: 35828
			[Token(Token = "0x4008BF4")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public bool BounceLoop;
		}
	}
}
