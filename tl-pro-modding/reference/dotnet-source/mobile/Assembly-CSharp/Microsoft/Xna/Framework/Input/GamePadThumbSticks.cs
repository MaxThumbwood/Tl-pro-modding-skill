using System;
using Il2CppDummyDll;

namespace Microsoft.Xna.Framework.Input
{
	// Token: 0x020003B3 RID: 947
	[Token(Token = "0x20003B3")]
	public struct GamePadThumbSticks
	{
		// Token: 0x1700029E RID: 670
		// (get) Token: 0x0600193B RID: 6459 RVA: 0x0000C0C0 File Offset: 0x0000A2C0
		[Token(Token = "0x1700029E")]
		public Vector2 Left
		{
			[Token(Token = "0x600193B")]
			[Address(RVA = "0xE259A8", Offset = "0xE259A8", VA = "0xE259A8")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x0600193C RID: 6460 RVA: 0x0000C0D8 File Offset: 0x0000A2D8
		[Token(Token = "0x1700029F")]
		public Vector2 Right
		{
			[Token(Token = "0x600193C")]
			[Address(RVA = "0xE259BC", Offset = "0xE259BC", VA = "0xE259BC")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x0600193D RID: 6461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600193D")]
		[Address(RVA = "0xE24400", Offset = "0xE24400", VA = "0xE24400")]
		public GamePadThumbSticks(Vector2 leftPosition, Vector2 rightPosition)
		{
		}

		// Token: 0x0600193E RID: 6462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600193E")]
		[Address(RVA = "0xE259D0", Offset = "0xE259D0", VA = "0xE259D0")]
		internal GamePadThumbSticks(Vector2 leftPosition, Vector2 rightPosition, GamePadDeadZone leftDeadZoneMode, GamePadDeadZone rightDeadZoneMode)
		{
		}

		// Token: 0x0600193F RID: 6463 RVA: 0x0000C0F0 File Offset: 0x0000A2F0
		[Token(Token = "0x600193F")]
		[Address(RVA = "0xE25B34", Offset = "0xE25B34", VA = "0xE25B34")]
		private Vector2 ApplyDeadZone(GamePadDeadZone deadZoneMode, float deadZone, Vector2 thumbstickPosition)
		{
			return default(Vector2);
		}

		// Token: 0x06001940 RID: 6464 RVA: 0x0000C108 File Offset: 0x0000A308
		[Token(Token = "0x6001940")]
		[Address(RVA = "0xE25D54", Offset = "0xE25D54", VA = "0xE25D54")]
		private Vector2 ExcludeIndependentAxesDeadZone(Vector2 value, float deadZone)
		{
			return default(Vector2);
		}

		// Token: 0x06001941 RID: 6465 RVA: 0x0000C120 File Offset: 0x0000A320
		[Token(Token = "0x6001941")]
		[Address(RVA = "0xE25F5C", Offset = "0xE25F5C", VA = "0xE25F5C")]
		private float ExcludeAxisDeadZone(float value, float deadZone)
		{
			return 0f;
		}

		// Token: 0x06001942 RID: 6466 RVA: 0x0000C138 File Offset: 0x0000A338
		[Token(Token = "0x6001942")]
		[Address(RVA = "0xE25DFC", Offset = "0xE25DFC", VA = "0xE25DFC")]
		private Vector2 ExcludeCircularDeadZone(Vector2 value, float deadZone)
		{
			return default(Vector2);
		}

		// Token: 0x06001943 RID: 6467 RVA: 0x0000C150 File Offset: 0x0000A350
		[Token(Token = "0x6001943")]
		[Address(RVA = "0xE24850", Offset = "0xE24850", VA = "0xE24850")]
		public static bool operator ==(GamePadThumbSticks left, GamePadThumbSticks right)
		{
			return default(bool);
		}

		// Token: 0x06001944 RID: 6468 RVA: 0x0000C168 File Offset: 0x0000A368
		[Token(Token = "0x6001944")]
		[Address(RVA = "0xE25FAC", Offset = "0xE25FAC", VA = "0xE25FAC")]
		public static bool operator !=(GamePadThumbSticks left, GamePadThumbSticks right)
		{
			return default(bool);
		}

		// Token: 0x06001945 RID: 6469 RVA: 0x0000C180 File Offset: 0x0000A380
		[Token(Token = "0x6001945")]
		[Address(RVA = "0xE25FF0", Offset = "0xE25FF0", VA = "0xE25FF0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06001946 RID: 6470 RVA: 0x0000C198 File Offset: 0x0000A398
		[Token(Token = "0x6001946")]
		[Address(RVA = "0xE24E54", Offset = "0xE24E54", VA = "0xE24E54", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001947 RID: 6471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001947")]
		[Address(RVA = "0xE25520", Offset = "0xE25520", VA = "0xE25520", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04002BAD RID: 11181
		[Token(Token = "0x4002BAD")]
		private const float leftThumbDeadZone = 0.24f;

		// Token: 0x04002BAE RID: 11182
		[Token(Token = "0x4002BAE")]
		private const float rightThumbDeadZone = 0.265f;

		// Token: 0x04002BAF RID: 11183
		[Token(Token = "0x4002BAF")]
		[FieldOffset(Offset = "0x0")]
		internal readonly Buttons _virtualButtons;

		// Token: 0x04002BB0 RID: 11184
		[Token(Token = "0x4002BB0")]
		[FieldOffset(Offset = "0x4")]
		private readonly Vector2 _left;

		// Token: 0x04002BB1 RID: 11185
		[Token(Token = "0x4002BB1")]
		[FieldOffset(Offset = "0xC")]
		private readonly Vector2 _right;
	}
}
