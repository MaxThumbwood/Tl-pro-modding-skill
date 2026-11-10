using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Microsoft.Xna.Framework.Input
{
	// Token: 0x020003BD RID: 957
	[Token(Token = "0x20003BD")]
	public struct KeyboardState
	{
		// Token: 0x06001992 RID: 6546 RVA: 0x0000C5A0 File Offset: 0x0000A7A0
		[Token(Token = "0x6001992")]
		[Address(RVA = "0xE28878", Offset = "0xE28878", VA = "0xE28878")]
		private bool InternalGetKey(Keys key)
		{
			return default(bool);
		}

		// Token: 0x06001993 RID: 6547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001993")]
		[Address(RVA = "0xE2892C", Offset = "0xE2892C", VA = "0xE2892C")]
		internal void InternalSetKey(Keys key)
		{
		}

		// Token: 0x06001994 RID: 6548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001994")]
		[Address(RVA = "0xE289B4", Offset = "0xE289B4", VA = "0xE289B4")]
		internal void InternalClearKey(Keys key)
		{
		}

		// Token: 0x06001995 RID: 6549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001995")]
		[Address(RVA = "0xE28A3C", Offset = "0xE28A3C", VA = "0xE28A3C")]
		internal void InternalClearAllKeys()
		{
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x06001996 RID: 6550 RVA: 0x0000C5B8 File Offset: 0x0000A7B8
		// (set) Token: 0x06001997 RID: 6551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002B3")]
		public bool CapsLock
		{
			[Token(Token = "0x6001996")]
			[Address(RVA = "0xE28A4C", Offset = "0xE28A4C", VA = "0xE28A4C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001997")]
			[Address(RVA = "0xE28A54", Offset = "0xE28A54", VA = "0xE28A54")]
			private set
			{
			}
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x06001998 RID: 6552 RVA: 0x0000C5D0 File Offset: 0x0000A7D0
		// (set) Token: 0x06001999 RID: 6553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170002B4")]
		public bool NumLock
		{
			[Token(Token = "0x6001998")]
			[Address(RVA = "0xE28A5C", Offset = "0xE28A5C", VA = "0xE28A5C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001999")]
			[Address(RVA = "0xE28A64", Offset = "0xE28A64", VA = "0xE28A64")]
			private set
			{
			}
		}

		// Token: 0x0600199A RID: 6554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600199A")]
		[Address(RVA = "0xE2833C", Offset = "0xE2833C", VA = "0xE2833C")]
		internal KeyboardState(List<Keys> keys, bool capsLock = false, bool numLock = false)
		{
		}

		// Token: 0x0600199B RID: 6555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600199B")]
		[Address(RVA = "0xE28A6C", Offset = "0xE28A6C", VA = "0xE28A6C")]
		public KeyboardState(Keys[] keys, bool capsLock = false, bool numLock = false)
		{
		}

		// Token: 0x0600199C RID: 6556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600199C")]
		[Address(RVA = "0xE28C20", Offset = "0xE28C20", VA = "0xE28C20")]
		public KeyboardState(Keys[] keys)
		{
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x0600199D RID: 6557 RVA: 0x0000C5E8 File Offset: 0x0000A7E8
		[Token(Token = "0x170002B5")]
		public KeyState Item
		{
			[Token(Token = "0x600199D")]
			[Address(RVA = "0xE28DC8", Offset = "0xE28DC8", VA = "0xE28DC8")]
			get
			{
				return KeyState.Up;
			}
		}

		// Token: 0x0600199E RID: 6558 RVA: 0x0000C600 File Offset: 0x0000A800
		[Token(Token = "0x600199E")]
		[Address(RVA = "0xE28EC8", Offset = "0xE28EC8", VA = "0xE28EC8")]
		public bool IsKeyDown(Keys key)
		{
			return default(bool);
		}

		// Token: 0x0600199F RID: 6559 RVA: 0x0000C618 File Offset: 0x0000A818
		[Token(Token = "0x600199F")]
		[Address(RVA = "0xE28FCC", Offset = "0xE28FCC", VA = "0xE28FCC")]
		public bool IsKeyUp(Keys key)
		{
			return default(bool);
		}

		// Token: 0x060019A0 RID: 6560 RVA: 0x0000C630 File Offset: 0x0000A830
		[Token(Token = "0x60019A0")]
		[Address(RVA = "0xE290D0", Offset = "0xE290D0", VA = "0xE290D0")]
		private static uint CountBits(uint v)
		{
			return 0U;
		}

		// Token: 0x060019A1 RID: 6561 RVA: 0x0000C648 File Offset: 0x0000A848
		[Token(Token = "0x60019A1")]
		[Address(RVA = "0xE29118", Offset = "0xE29118", VA = "0xE29118")]
		private static int AddKeysToArray(uint keys, int offset, Keys[] pressedKeys, int index)
		{
			return 0;
		}

		// Token: 0x060019A2 RID: 6562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60019A2")]
		[Address(RVA = "0xE29180", Offset = "0xE29180", VA = "0xE29180")]
		public Keys[] GetPressedKeys()
		{
			return null;
		}

		// Token: 0x060019A3 RID: 6563 RVA: 0x0000C660 File Offset: 0x0000A860
		[Token(Token = "0x60019A3")]
		[Address(RVA = "0xE29854", Offset = "0xE29854", VA = "0xE29854", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x060019A4 RID: 6564 RVA: 0x0000C678 File Offset: 0x0000A878
		[Token(Token = "0x60019A4")]
		[Address(RVA = "0xE29894", Offset = "0xE29894", VA = "0xE29894")]
		public static bool operator ==(KeyboardState a, KeyboardState b)
		{
			return default(bool);
		}

		// Token: 0x060019A5 RID: 6565 RVA: 0x0000C690 File Offset: 0x0000A890
		[Token(Token = "0x60019A5")]
		[Address(RVA = "0xE2990C", Offset = "0xE2990C", VA = "0xE2990C")]
		public static bool operator !=(KeyboardState a, KeyboardState b)
		{
			return default(bool);
		}

		// Token: 0x060019A6 RID: 6566 RVA: 0x0000C6A8 File Offset: 0x0000A8A8
		[Token(Token = "0x60019A6")]
		[Address(RVA = "0xE299E0", Offset = "0xE299E0", VA = "0xE299E0", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x04002BD8 RID: 11224
		[Token(Token = "0x4002BD8")]
		[FieldOffset(Offset = "0x0")]
		private static Keys[] empty;

		// Token: 0x04002BD9 RID: 11225
		[Token(Token = "0x4002BD9")]
		[FieldOffset(Offset = "0x0")]
		private uint keys0;

		// Token: 0x04002BDA RID: 11226
		[Token(Token = "0x4002BDA")]
		[FieldOffset(Offset = "0x4")]
		private uint keys1;

		// Token: 0x04002BDB RID: 11227
		[Token(Token = "0x4002BDB")]
		[FieldOffset(Offset = "0x8")]
		private uint keys2;

		// Token: 0x04002BDC RID: 11228
		[Token(Token = "0x4002BDC")]
		[FieldOffset(Offset = "0xC")]
		private uint keys3;

		// Token: 0x04002BDD RID: 11229
		[Token(Token = "0x4002BDD")]
		[FieldOffset(Offset = "0x10")]
		private uint keys4;

		// Token: 0x04002BDE RID: 11230
		[Token(Token = "0x4002BDE")]
		[FieldOffset(Offset = "0x14")]
		private uint keys5;

		// Token: 0x04002BDF RID: 11231
		[Token(Token = "0x4002BDF")]
		[FieldOffset(Offset = "0x18")]
		private uint keys6;

		// Token: 0x04002BE0 RID: 11232
		[Token(Token = "0x4002BE0")]
		[FieldOffset(Offset = "0x1C")]
		private uint keys7;

		// Token: 0x04002BE1 RID: 11233
		[Token(Token = "0x4002BE1")]
		[FieldOffset(Offset = "0x20")]
		private bool <CapsLock>k__BackingField;

		// Token: 0x04002BE2 RID: 11234
		[Token(Token = "0x4002BE2")]
		[FieldOffset(Offset = "0x21")]
		private bool <NumLock>k__BackingField;

		// Token: 0x04002BE3 RID: 11235
		[Token(Token = "0x4002BE3")]
		[FieldOffset(Offset = "0x4")]
		private static Keys[] keysArray1;

		// Token: 0x04002BE4 RID: 11236
		[Token(Token = "0x4002BE4")]
		[FieldOffset(Offset = "0x8")]
		private static Keys[] keysArray2;

		// Token: 0x04002BE5 RID: 11237
		[Token(Token = "0x4002BE5")]
		[FieldOffset(Offset = "0xC")]
		private static Keys[] keysArray3;

		// Token: 0x04002BE6 RID: 11238
		[Token(Token = "0x4002BE6")]
		[FieldOffset(Offset = "0x10")]
		private static Keys[] keysArray4;

		// Token: 0x04002BE7 RID: 11239
		[Token(Token = "0x4002BE7")]
		[FieldOffset(Offset = "0x14")]
		private static Keys[] keysArray5;

		// Token: 0x04002BE8 RID: 11240
		[Token(Token = "0x4002BE8")]
		[FieldOffset(Offset = "0x18")]
		private static Keys[] keysArray6;

		// Token: 0x04002BE9 RID: 11241
		[Token(Token = "0x4002BE9")]
		[FieldOffset(Offset = "0x1C")]
		private static Keys[] keysArray7;

		// Token: 0x04002BEA RID: 11242
		[Token(Token = "0x4002BEA")]
		[FieldOffset(Offset = "0x20")]
		private static Keys[] keysArray8;
	}
}
