using System;
using Il2CppDummyDll;

namespace Microsoft.Xna.Framework.Input
{
	// Token: 0x020003AD RID: 941
	[Token(Token = "0x20003AD")]
	public static class GamePad
	{
		// Token: 0x060018BB RID: 6331 RVA: 0x0000B988 File Offset: 0x00009B88
		[Token(Token = "0x60018BB")]
		[Address(RVA = "0xE216C8", Offset = "0xE216C8", VA = "0xE216C8")]
		public static GamePadCapabilities GetCapabilities(PlayerIndex playerIndex)
		{
			return default(GamePadCapabilities);
		}

		// Token: 0x060018BC RID: 6332 RVA: 0x0000B9A0 File Offset: 0x00009BA0
		[Token(Token = "0x60018BC")]
		[Address(RVA = "0xE216EC", Offset = "0xE216EC", VA = "0xE216EC")]
		public static GamePadCapabilities GetCapabilities(int index)
		{
			return default(GamePadCapabilities);
		}

		// Token: 0x060018BD RID: 6333 RVA: 0x0000B9B8 File Offset: 0x00009BB8
		[Token(Token = "0x60018BD")]
		[Address(RVA = "0xE21710", Offset = "0xE21710", VA = "0xE21710")]
		public static GamePadState GetState(PlayerIndex playerIndex)
		{
			return default(GamePadState);
		}

		// Token: 0x060018BE RID: 6334 RVA: 0x0000B9D0 File Offset: 0x00009BD0
		[Token(Token = "0x60018BE")]
		[Address(RVA = "0xE21848", Offset = "0xE21848", VA = "0xE21848")]
		public static GamePadState GetState(int index)
		{
			return default(GamePadState);
		}

		// Token: 0x060018BF RID: 6335 RVA: 0x0000B9E8 File Offset: 0x00009BE8
		[Token(Token = "0x60018BF")]
		[Address(RVA = "0xE218E4", Offset = "0xE218E4", VA = "0xE218E4")]
		public static GamePadState GetState(PlayerIndex playerIndex, GamePadDeadZone deadZoneMode)
		{
			return default(GamePadState);
		}

		// Token: 0x060018C0 RID: 6336 RVA: 0x0000BA00 File Offset: 0x00009C00
		[Token(Token = "0x60018C0")]
		[Address(RVA = "0xE217AC", Offset = "0xE217AC", VA = "0xE217AC")]
		public static GamePadState GetState(int index, GamePadDeadZone deadZoneMode)
		{
			return default(GamePadState);
		}

		// Token: 0x060018C1 RID: 6337 RVA: 0x0000BA18 File Offset: 0x00009C18
		[Token(Token = "0x60018C1")]
		[Address(RVA = "0xE21980", Offset = "0xE21980", VA = "0xE21980")]
		public static GamePadState GetState(PlayerIndex playerIndex, GamePadDeadZone leftDeadZoneMode, GamePadDeadZone rightDeadZoneMode)
		{
			return default(GamePadState);
		}

		// Token: 0x060018C2 RID: 6338 RVA: 0x0000BA30 File Offset: 0x00009C30
		[Token(Token = "0x60018C2")]
		[Address(RVA = "0xE21A1C", Offset = "0xE21A1C", VA = "0xE21A1C")]
		public static GamePadState GetState(int index, GamePadDeadZone leftDeadZoneMode, GamePadDeadZone rightDeadZoneMode)
		{
			return default(GamePadState);
		}

		// Token: 0x060018C3 RID: 6339 RVA: 0x0000BA48 File Offset: 0x00009C48
		[Token(Token = "0x60018C3")]
		[Address(RVA = "0xE21AB8", Offset = "0xE21AB8", VA = "0xE21AB8")]
		public static bool SetVibration(PlayerIndex playerIndex, float leftMotor, float rightMotor)
		{
			return default(bool);
		}

		// Token: 0x060018C4 RID: 6340 RVA: 0x0000BA60 File Offset: 0x00009C60
		[Token(Token = "0x60018C4")]
		[Address(RVA = "0xE21AC0", Offset = "0xE21AC0", VA = "0xE21AC0")]
		public static bool SetVibration(int index, float leftMotor, float rightMotor)
		{
			return default(bool);
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x060018C5 RID: 6341 RVA: 0x0000BA78 File Offset: 0x00009C78
		[Token(Token = "0x1700026C")]
		public static int MaximumGamePadCount
		{
			[Token(Token = "0x60018C5")]
			[Address(RVA = "0xE21AC8", Offset = "0xE21AC8", VA = "0xE21AC8")]
			get
			{
				return 0;
			}
		}
	}
}
