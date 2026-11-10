using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Terraria.DataStructures;

namespace Terraria
{
	// Token: 0x020004AC RID: 1196
	[Token(Token = "0x20004AC")]
	public class Animation
	{
		// Token: 0x06002EB1 RID: 11953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EB1")]
		[Address(RVA = "0x1888BC0", Offset = "0x1888BC0", VA = "0x1888BC0")]
		public static void Initialize()
		{
		}

		// Token: 0x06002EB2 RID: 11954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EB2")]
		[Address(RVA = "0x1888D6C", Offset = "0x1888D6C", VA = "0x1888D6C")]
		private void SetDefaults(int type)
		{
		}

		// Token: 0x06002EB3 RID: 11955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EB3")]
		[Address(RVA = "0x1889030", Offset = "0x1889030", VA = "0x1889030")]
		public static void NewTemporaryAnimation(int type, ushort tileType, int x, int y)
		{
		}

		// Token: 0x06002EB4 RID: 11956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EB4")]
		[Address(RVA = "0x18892EC", Offset = "0x18892EC", VA = "0x18892EC")]
		private static void RemoveTemporaryAnimation(short x, short y)
		{
		}

		// Token: 0x06002EB5 RID: 11957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EB5")]
		[Address(RVA = "0x1889478", Offset = "0x1889478", VA = "0x1889478")]
		public static void UpdateAll()
		{
		}

		// Token: 0x06002EB6 RID: 11958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EB6")]
		[Address(RVA = "0x1889948", Offset = "0x1889948", VA = "0x1889948")]
		public void Update()
		{
		}

		// Token: 0x06002EB7 RID: 11959 RVA: 0x00016578 File Offset: 0x00014778
		[Token(Token = "0x6002EB7")]
		[Address(RVA = "0x1889AE8", Offset = "0x1889AE8", VA = "0x1889AE8")]
		public static bool GetTemporaryFrame(int x, int y, out int frameData)
		{
			return default(bool);
		}

		// Token: 0x06002EB8 RID: 11960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EB8")]
		[Address(RVA = "0x18892E4", Offset = "0x18892E4", VA = "0x18892E4")]
		public Animation()
		{
		}

		// Token: 0x04003EBC RID: 16060
		[Token(Token = "0x4003EBC")]
		[FieldOffset(Offset = "0x0")]
		private static List<Animation> _animations;

		// Token: 0x04003EBD RID: 16061
		[Token(Token = "0x4003EBD")]
		[FieldOffset(Offset = "0x4")]
		private static Dictionary<Point16, Animation> _temporaryAnimations;

		// Token: 0x04003EBE RID: 16062
		[Token(Token = "0x4003EBE")]
		[FieldOffset(Offset = "0x8")]
		private static List<Point16> _awaitingRemoval;

		// Token: 0x04003EBF RID: 16063
		[Token(Token = "0x4003EBF")]
		[FieldOffset(Offset = "0xC")]
		private static List<Animation> _awaitingAddition;

		// Token: 0x04003EC0 RID: 16064
		[Token(Token = "0x4003EC0")]
		[FieldOffset(Offset = "0x8")]
		private bool _temporary;

		// Token: 0x04003EC1 RID: 16065
		[Token(Token = "0x4003EC1")]
		[FieldOffset(Offset = "0xA")]
		private Point16 _coordinates;

		// Token: 0x04003EC2 RID: 16066
		[Token(Token = "0x4003EC2")]
		[FieldOffset(Offset = "0xE")]
		private ushort _tileType;

		// Token: 0x04003EC3 RID: 16067
		[Token(Token = "0x4003EC3")]
		[FieldOffset(Offset = "0x10")]
		private int _frame;

		// Token: 0x04003EC4 RID: 16068
		[Token(Token = "0x4003EC4")]
		[FieldOffset(Offset = "0x14")]
		private int _frameMax;

		// Token: 0x04003EC5 RID: 16069
		[Token(Token = "0x4003EC5")]
		[FieldOffset(Offset = "0x18")]
		private int _frameCounter;

		// Token: 0x04003EC6 RID: 16070
		[Token(Token = "0x4003EC6")]
		[FieldOffset(Offset = "0x1C")]
		private int _frameCounterMax;

		// Token: 0x04003EC7 RID: 16071
		[Token(Token = "0x4003EC7")]
		[FieldOffset(Offset = "0x20")]
		private int[] _frameData;
	}
}
