using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Terraria.Localization;

namespace Terraria.GameContent.UI
{
	// Token: 0x02000D2A RID: 3370
	[Token(Token = "0x2000D2A")]
	public class GameTipsDisplay
	{
		// Token: 0x06006427 RID: 25639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006427")]
		[Address(RVA = "0xB1DBAC", Offset = "0xB1DBAC", VA = "0xB1DBAC")]
		public GameTipsDisplay(bool characterCreation = false)
		{
		}

		// Token: 0x06006428 RID: 25640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006428")]
		[Address(RVA = "0xB1DC54", Offset = "0xB1DC54", VA = "0xB1DC54")]
		public void Update()
		{
		}

		// Token: 0x06006429 RID: 25641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006429")]
		[Address(RVA = "0xB1E650", Offset = "0xB1E650", VA = "0xB1E650")]
		public void ClearTips()
		{
		}

		// Token: 0x0600642A RID: 25642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600642A")]
		[Address(RVA = "0xB1E6D0", Offset = "0xB1E6D0", VA = "0xB1E6D0")]
		public void Draw([Optional] String_Layout layout, float MaxHeight = 0f)
		{
		}

		// Token: 0x0600642B RID: 25643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600642B")]
		[Address(RVA = "0xB1E114", Offset = "0xB1E114", VA = "0xB1E114")]
		private void AddNewTip(double currentTime)
		{
		}

		// Token: 0x0400A1A5 RID: 41381
		[Token(Token = "0x400A1A5")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private LocalizedText[] _tipsDefault;

		// Token: 0x0400A1A6 RID: 41382
		[Token(Token = "0x400A1A6")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		private LocalizedText[] _tipsGamepad;

		// Token: 0x0400A1A7 RID: 41383
		[Token(Token = "0x400A1A7")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private LocalizedText[] _tipsKeyboard;

		// Token: 0x0400A1A8 RID: 41384
		[Token(Token = "0x400A1A8")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private readonly List<GameTipsDisplay.GameTip> _currentTips;

		// Token: 0x0400A1A9 RID: 41385
		[Token(Token = "0x400A1A9")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private LocalizedText _lastTip;

		// Token: 0x0400A1AA RID: 41386
		[Token(Token = "0x400A1AA")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private int _lastTipIndex;

		// Token: 0x0400A1AB RID: 41387
		[Token(Token = "0x400A1AB")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private bool isCharacterCreationTips;

		// Token: 0x02000D2B RID: 3371
		[Token(Token = "0x2000D2B")]
		private class GameTip
		{
			// Token: 0x17000AC5 RID: 2757
			// (get) Token: 0x0600642C RID: 25644 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000AC5")]
			public string Text
			{
				[Token(Token = "0x600642C")]
				[Address(RVA = "0xB1F448", Offset = "0xB1F448", VA = "0xB1F448")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600642D RID: 25645 RVA: 0x0002DE88 File Offset: 0x0002C088
			[Token(Token = "0x600642D")]
			[Address(RVA = "0xB1F568", Offset = "0xB1F568", VA = "0xB1F568")]
			public bool IsExpired(double currentTime)
			{
				return default(bool);
			}

			// Token: 0x0600642E RID: 25646 RVA: 0x0002DEA0 File Offset: 0x0002C0A0
			[Token(Token = "0x600642E")]
			[Address(RVA = "0xB1E0E4", Offset = "0xB1E0E4", VA = "0xB1E0E4")]
			public bool IsExpiring(double currentTime)
			{
				return default(bool);
			}

			// Token: 0x0600642F RID: 25647 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600642F")]
			[Address(RVA = "0xB1F4A0", Offset = "0xB1F4A0", VA = "0xB1F4A0")]
			public GameTip(LocalizedText text, double spawnTime)
			{
			}

			// Token: 0x06006430 RID: 25648 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006430")]
			[Address(RVA = "0xB1E500", Offset = "0xB1E500", VA = "0xB1E500")]
			public void Update(double currentTime)
			{
			}

			// Token: 0x0400A1AC RID: 41388
			[Token(Token = "0x400A1AC")]
			private const float APPEAR_FROM = 2.5f;

			// Token: 0x0400A1AD RID: 41389
			[Token(Token = "0x400A1AD")]
			private const float APPEAR_TO = 0.5f;

			// Token: 0x0400A1AE RID: 41390
			[Token(Token = "0x400A1AE")]
			private const float DISAPPEAR_TO = -1.5f;

			// Token: 0x0400A1AF RID: 41391
			[Token(Token = "0x400A1AF")]
			private const float APPEAR_TIME = 0.5f;

			// Token: 0x0400A1B0 RID: 41392
			[Token(Token = "0x400A1B0")]
			private const float DISAPPEAR_TIME = 1f;

			// Token: 0x0400A1B1 RID: 41393
			[Token(Token = "0x400A1B1")]
			private const float DURATION = 11.5f;

			// Token: 0x0400A1B2 RID: 41394
			[Token(Token = "0x400A1B2")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private LocalizedText _textKey;

			// Token: 0x0400A1B3 RID: 41395
			[Token(Token = "0x400A1B3")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			private string _formattedText;

			// Token: 0x0400A1B4 RID: 41396
			[Token(Token = "0x400A1B4")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float ScreenAnchorX;

			// Token: 0x0400A1B5 RID: 41397
			[Token(Token = "0x400A1B5")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public readonly float Duration;

			// Token: 0x0400A1B6 RID: 41398
			[Token(Token = "0x400A1B6")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public readonly double SpawnTime;
		}

		// Token: 0x02000D2C RID: 3372
		[Token(Token = "0x2000D2C")]
		private sealed class <>c__DisplayClass9_0
		{
			// Token: 0x06006431 RID: 25649 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006431")]
			[Address(RVA = "0xB1E0DC", Offset = "0xB1E0DC", VA = "0xB1E0DC")]
			public <>c__DisplayClass9_0()
			{
			}

			// Token: 0x06006432 RID: 25650 RVA: 0x0002DEB8 File Offset: 0x0002C0B8
			[Token(Token = "0x6006432")]
			[Address(RVA = "0xB1F590", Offset = "0xB1F590", VA = "0xB1F590")]
			internal bool <Update>b__0(GameTipsDisplay.GameTip x)
			{
				return default(bool);
			}

			// Token: 0x0400A1B7 RID: 41399
			[Token(Token = "0x400A1B7")]
			[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public double time;
		}
	}
}
