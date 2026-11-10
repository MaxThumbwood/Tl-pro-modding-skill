using System;
using Il2CppDummyDll;

namespace Microsoft.Xna.Framework
{
	// Token: 0x020003A1 RID: 929
	[Token(Token = "0x20003A1")]
	public class GameTime
	{
		// Token: 0x0600185B RID: 6235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600185B")]
		[Address(RVA = "0xE1FF54", Offset = "0xE1FF54", VA = "0xE1FF54")]
		public GameTime()
		{
		}

		// Token: 0x0600185C RID: 6236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600185C")]
		[Address(RVA = "0xE1E85C", Offset = "0xE1E85C", VA = "0xE1E85C")]
		public GameTime(TimeSpan totalRealTime, TimeSpan elapsedRealTime, TimeSpan totalGameTime, TimeSpan elapsedGameTime)
		{
		}

		// Token: 0x0600185D RID: 6237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600185D")]
		[Address(RVA = "0xE200C8", Offset = "0xE200C8", VA = "0xE200C8")]
		public GameTime(TimeSpan totalRealTime, TimeSpan elapsedRealTime, TimeSpan totalGameTime, TimeSpan elapsedGameTime, bool isRunningSlowly)
		{
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x0600185E RID: 6238 RVA: 0x0000B850 File Offset: 0x00009A50
		// (set) Token: 0x0600185F RID: 6239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000252")]
		public TimeSpan ElapsedGameTime
		{
			[Token(Token = "0x600185E")]
			[Address(RVA = "0xE20124", Offset = "0xE20124", VA = "0xE20124")]
			get
			{
				return default(TimeSpan);
			}
			[Token(Token = "0x600185F")]
			[Address(RVA = "0xE20130", Offset = "0xE20130", VA = "0xE20130")]
			internal set
			{
			}
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x06001860 RID: 6240 RVA: 0x0000B868 File Offset: 0x00009A68
		// (set) Token: 0x06001861 RID: 6241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000253")]
		public TimeSpan ElapsedRealTime
		{
			[Token(Token = "0x6001860")]
			[Address(RVA = "0xE20140", Offset = "0xE20140", VA = "0xE20140")]
			get
			{
				return default(TimeSpan);
			}
			[Token(Token = "0x6001861")]
			[Address(RVA = "0xE2014C", Offset = "0xE2014C", VA = "0xE2014C")]
			internal set
			{
			}
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x06001862 RID: 6242 RVA: 0x0000B880 File Offset: 0x00009A80
		// (set) Token: 0x06001863 RID: 6243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000254")]
		public bool IsRunningSlowly
		{
			[Token(Token = "0x6001862")]
			[Address(RVA = "0xE2015C", Offset = "0xE2015C", VA = "0xE2015C")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001863")]
			[Address(RVA = "0xE20164", Offset = "0xE20164", VA = "0xE20164")]
			internal set
			{
			}
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x06001864 RID: 6244 RVA: 0x0000B898 File Offset: 0x00009A98
		// (set) Token: 0x06001865 RID: 6245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000255")]
		public TimeSpan TotalGameTime
		{
			[Token(Token = "0x6001864")]
			[Address(RVA = "0xE2016C", Offset = "0xE2016C", VA = "0xE2016C")]
			get
			{
				return default(TimeSpan);
			}
			[Token(Token = "0x6001865")]
			[Address(RVA = "0xE20178", Offset = "0xE20178", VA = "0xE20178")]
			internal set
			{
			}
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x06001866 RID: 6246 RVA: 0x0000B8B0 File Offset: 0x00009AB0
		// (set) Token: 0x06001867 RID: 6247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000256")]
		public TimeSpan TotalRealTime
		{
			[Token(Token = "0x6001866")]
			[Address(RVA = "0xE20188", Offset = "0xE20188", VA = "0xE20188")]
			get
			{
				return default(TimeSpan);
			}
			[Token(Token = "0x6001867")]
			[Address(RVA = "0xE20194", Offset = "0xE20194", VA = "0xE20194")]
			internal set
			{
			}
		}

		// Token: 0x04002B4D RID: 11085
		[Token(Token = "0x4002B4D")]
		[FieldOffset(Offset = "0x8")]
		private TimeSpan elapsedGameTime;

		// Token: 0x04002B4E RID: 11086
		[Token(Token = "0x4002B4E")]
		[FieldOffset(Offset = "0x10")]
		private TimeSpan elapsedRealTime;

		// Token: 0x04002B4F RID: 11087
		[Token(Token = "0x4002B4F")]
		[FieldOffset(Offset = "0x18")]
		private bool isRunningSlowly;

		// Token: 0x04002B50 RID: 11088
		[Token(Token = "0x4002B50")]
		[FieldOffset(Offset = "0x20")]
		private TimeSpan totalGameTime;

		// Token: 0x04002B51 RID: 11089
		[Token(Token = "0x4002B51")]
		[FieldOffset(Offset = "0x28")]
		private TimeSpan totalRealTime;
	}
}
