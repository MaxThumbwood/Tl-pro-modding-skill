using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Graphics;
using Terraria.IO;

namespace Terraria.GameContent.UI.BigProgressBar
{
	// Token: 0x02000DB0 RID: 3504
	[Token(Token = "0x2000DB0")]
	public class BigProgressBarSystem
	{
		// Token: 0x06006740 RID: 26432 RVA: 0x0002E8A8 File Offset: 0x0002CAA8
		[Token(Token = "0x6006740")]
		[Address(RVA = "0xB6F050", Offset = "0xB6F050", VA = "0xB6F050")]
		public bool IsTracking()
		{
			return default(bool);
		}

		// Token: 0x06006741 RID: 26433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006741")]
		[Address(RVA = "0xB6F060", Offset = "0xB6F060", VA = "0xB6F060")]
		public void Update()
		{
		}

		// Token: 0x06006742 RID: 26434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006742")]
		[Address(RVA = "0xB6F3D8", Offset = "0xB6F3D8", VA = "0xB6F3D8")]
		public void Draw(SpriteBatch spriteBatch)
		{
		}

		// Token: 0x06006743 RID: 26435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006743")]
		[Address(RVA = "0xB6F13C", Offset = "0xB6F13C", VA = "0xB6F13C")]
		private void TryFindingNPCToTrack()
		{
		}

		// Token: 0x06006744 RID: 26436 RVA: 0x0002E8C0 File Offset: 0x0002CAC0
		[Token(Token = "0x6006744")]
		[Address(RVA = "0xB6F4A0", Offset = "0xB6F4A0", VA = "0xB6F4A0")]
		public bool TryTracking(int npcIndex)
		{
			return default(bool);
		}

		// Token: 0x06006745 RID: 26437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006745")]
		[Address(RVA = "0xB6F670", Offset = "0xB6F670", VA = "0xB6F670")]
		private void Configuration_Save(Preferences obj)
		{
		}

		// Token: 0x06006746 RID: 26438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006746")]
		[Address(RVA = "0xB6F74C", Offset = "0xB6F74C", VA = "0xB6F74C")]
		private void Configuration_OnLoad(Preferences obj)
		{
		}

		// Token: 0x06006747 RID: 26439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006747")]
		[Address(RVA = "0xB6F858", Offset = "0xB6F858", VA = "0xB6F858")]
		public static void ToggleShowText()
		{
		}

		// Token: 0x06006748 RID: 26440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006748")]
		[Address(RVA = "0xB6F8C4", Offset = "0xB6F8C4", VA = "0xB6F8C4")]
		public BigProgressBarSystem()
		{
		}

		// Token: 0x0400A433 RID: 42035
		[Token(Token = "0x400A433")]
		[FieldOffset(Offset = "0x0")]
		private static TwinsBigProgressBar _twinsBar;

		// Token: 0x0400A434 RID: 42036
		[Token(Token = "0x400A434")]
		[FieldOffset(Offset = "0x4")]
		private static EaterOfWorldsProgressBar _eaterOfWorldsBar;

		// Token: 0x0400A435 RID: 42037
		[Token(Token = "0x400A435")]
		[FieldOffset(Offset = "0x8")]
		private static BrainOfCthuluBigProgressBar _brainOfCthuluBar;

		// Token: 0x0400A436 RID: 42038
		[Token(Token = "0x400A436")]
		[FieldOffset(Offset = "0xC")]
		private static GolemHeadProgressBar _golemBar;

		// Token: 0x0400A437 RID: 42039
		[Token(Token = "0x400A437")]
		[FieldOffset(Offset = "0x10")]
		private static MoonLordProgressBar _moonlordBar;

		// Token: 0x0400A438 RID: 42040
		[Token(Token = "0x400A438")]
		[FieldOffset(Offset = "0x14")]
		private static SolarFlarePillarBigProgressBar _solarPillarBar;

		// Token: 0x0400A439 RID: 42041
		[Token(Token = "0x400A439")]
		[FieldOffset(Offset = "0x18")]
		private static VortexPillarBigProgressBar _vortexPillarBar;

		// Token: 0x0400A43A RID: 42042
		[Token(Token = "0x400A43A")]
		[FieldOffset(Offset = "0x1C")]
		private static NebulaPillarBigProgressBar _nebulaPillarBar;

		// Token: 0x0400A43B RID: 42043
		[Token(Token = "0x400A43B")]
		[FieldOffset(Offset = "0x20")]
		private static StardustPillarBigProgressBar _stardustPillarBar;

		// Token: 0x0400A43C RID: 42044
		[Token(Token = "0x400A43C")]
		[FieldOffset(Offset = "0x24")]
		private static NeverValidProgressBar _neverValid;

		// Token: 0x0400A43D RID: 42045
		[Token(Token = "0x400A43D")]
		[FieldOffset(Offset = "0x28")]
		private static PirateShipBigProgressBar _pirateShipBar;

		// Token: 0x0400A43E RID: 42046
		[Token(Token = "0x400A43E")]
		[FieldOffset(Offset = "0x2C")]
		private static MartianSaucerBigProgressBar _martianSaucerBar;

		// Token: 0x0400A43F RID: 42047
		[Token(Token = "0x400A43F")]
		[FieldOffset(Offset = "0x8")]
		private IBigProgressBar _currentBar;

		// Token: 0x0400A440 RID: 42048
		[Token(Token = "0x400A440")]
		[FieldOffset(Offset = "0xC")]
		private CommonBossBigProgressBar _bossBar;

		// Token: 0x0400A441 RID: 42049
		[Token(Token = "0x400A441")]
		[FieldOffset(Offset = "0x10")]
		private BigProgressBarInfo _info;

		// Token: 0x0400A442 RID: 42050
		[Token(Token = "0x400A442")]
		[FieldOffset(Offset = "0x30")]
		private static DeerclopsBigProgressBar _deerclopsBar;

		// Token: 0x0400A443 RID: 42051
		[Token(Token = "0x400A443")]
		[FieldOffset(Offset = "0x34")]
		public static bool ShowText;

		// Token: 0x0400A444 RID: 42052
		[Token(Token = "0x400A444")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<int, IBigProgressBar> _bossBarsByNpcNetId;

		// Token: 0x0400A445 RID: 42053
		[Token(Token = "0x400A445")]
		private const string _preferencesKey = "ShowBossBarHealthText";
	}
}
