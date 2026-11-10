using System;
using Il2CppDummyDll;

namespace Terraria.GameContent
{
	// Token: 0x020009BE RID: 2494
	[Token(Token = "0x20009BE")]
	public struct PlayerEyeHelper
	{
		// Token: 0x170009A6 RID: 2470
		// (get) Token: 0x06005188 RID: 20872 RVA: 0x00025E48 File Offset: 0x00024048
		// (set) Token: 0x06005189 RID: 20873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170009A6")]
		public int EyeFrameToShow
		{
			[Token(Token = "0x6005188")]
			[Address(RVA = "0x77F4F8", Offset = "0x77F4F8", VA = "0x77F4F8")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6005189")]
			[Address(RVA = "0x77F500", Offset = "0x77F500", VA = "0x77F500")]
			private set
			{
			}
		}

		// Token: 0x0600518A RID: 20874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600518A")]
		[Address(RVA = "0x77F508", Offset = "0x77F508", VA = "0x77F508")]
		public void Update(Player player)
		{
		}

		// Token: 0x0600518B RID: 20875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600518B")]
		[Address(RVA = "0x77F73C", Offset = "0x77F73C", VA = "0x77F73C")]
		private void UpdateEyeFrameToShow(Player player)
		{
		}

		// Token: 0x0600518C RID: 20876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600518C")]
		[Address(RVA = "0x77F534", Offset = "0x77F534", VA = "0x77F534")]
		private void SetStateByPlayerInfo(Player player)
		{
		}

		// Token: 0x0600518D RID: 20877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600518D")]
		[Address(RVA = "0x77F91C", Offset = "0x77F91C", VA = "0x77F91C")]
		private void SwitchToState(PlayerEyeHelper.EyeState newState, bool resetStateTimerEvenIfAlreadyInState = false)
		{
		}

		// Token: 0x0600518E RID: 20878 RVA: 0x00025E60 File Offset: 0x00024060
		[Token(Token = "0x600518E")]
		[Address(RVA = "0x77F8C0", Offset = "0x77F8C0", VA = "0x77F8C0")]
		private bool DoesPlayerCountAsModeratelyDamaged(Player player)
		{
			return default(bool);
		}

		// Token: 0x0600518F RID: 20879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600518F")]
		[Address(RVA = "0x77F938", Offset = "0x77F938", VA = "0x77F938")]
		public void BlinkBecausePlayerGotHurt()
		{
		}

		// Token: 0x040094E9 RID: 38121
		[Token(Token = "0x40094E9")]
		[FieldOffset(Offset = "0x0")]
		private PlayerEyeHelper.EyeState _state;

		// Token: 0x040094EA RID: 38122
		[Token(Token = "0x40094EA")]
		[FieldOffset(Offset = "0x4")]
		private int _timeInState;

		// Token: 0x040094EB RID: 38123
		[Token(Token = "0x40094EB")]
		[FieldOffset(Offset = "0x8")]
		private int <EyeFrameToShow>k__BackingField;

		// Token: 0x040094EC RID: 38124
		[Token(Token = "0x40094EC")]
		private const int TimeToActDamaged = 20;

		// Token: 0x020009BF RID: 2495
		[Token(Token = "0x20009BF")]
		private enum EyeFrame
		{
			// Token: 0x040094EE RID: 38126
			[Token(Token = "0x40094EE")]
			EyeOpen,
			// Token: 0x040094EF RID: 38127
			[Token(Token = "0x40094EF")]
			EyeHalfClosed,
			// Token: 0x040094F0 RID: 38128
			[Token(Token = "0x40094F0")]
			EyeClosed
		}

		// Token: 0x020009C0 RID: 2496
		[Token(Token = "0x20009C0")]
		private enum EyeState
		{
			// Token: 0x040094F2 RID: 38130
			[Token(Token = "0x40094F2")]
			NormalBlinking,
			// Token: 0x040094F3 RID: 38131
			[Token(Token = "0x40094F3")]
			InStorm,
			// Token: 0x040094F4 RID: 38132
			[Token(Token = "0x40094F4")]
			InBed,
			// Token: 0x040094F5 RID: 38133
			[Token(Token = "0x40094F5")]
			JustTookDamage,
			// Token: 0x040094F6 RID: 38134
			[Token(Token = "0x40094F6")]
			IsModeratelyDamaged,
			// Token: 0x040094F7 RID: 38135
			[Token(Token = "0x40094F7")]
			IsBlind,
			// Token: 0x040094F8 RID: 38136
			[Token(Token = "0x40094F8")]
			IsTipsy,
			// Token: 0x040094F9 RID: 38137
			[Token(Token = "0x40094F9")]
			IsPoisoned,
			// Token: 0x040094FA RID: 38138
			[Token(Token = "0x40094FA")]
			LowMana
		}
	}
}
