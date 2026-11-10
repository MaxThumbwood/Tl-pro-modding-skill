using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using ReLogic.Utilities;

namespace Terraria.Audio
{
	// Token: 0x020007DE RID: 2014
	[Token(Token = "0x20007DE")]
	public class SoundPlayer
	{
		// Token: 0x06004572 RID: 17778 RVA: 0x00021210 File Offset: 0x0001F410
		[Token(Token = "0x6004572")]
		[Address(RVA = "0x581010", Offset = "0x581010", VA = "0x581010")]
		public SlotId Play(SoundStyle style, Vector2 position, [Optional] SoundPlayOverrides overrides)
		{
			return default(SlotId);
		}

		// Token: 0x06004573 RID: 17779 RVA: 0x00021228 File Offset: 0x0001F428
		[Token(Token = "0x6004573")]
		[Address(RVA = "0x5813F8", Offset = "0x5813F8", VA = "0x5813F8")]
		public SlotId PlayLooped(SoundStyle style, Vector2 position, ActiveSound.LoopedPlayCondition loopingCondition, [Optional] SoundPlayOverrides overrides)
		{
			return default(SlotId);
		}

		// Token: 0x06004574 RID: 17780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004574")]
		[Address(RVA = "0x580538", Offset = "0x580538", VA = "0x580538")]
		public void Reload()
		{
		}

		// Token: 0x06004575 RID: 17781 RVA: 0x00021240 File Offset: 0x0001F440
		[Token(Token = "0x6004575")]
		[Address(RVA = "0x5817AC", Offset = "0x5817AC", VA = "0x5817AC")]
		public SlotId Play(SoundStyle style)
		{
			return default(SlotId);
		}

		// Token: 0x06004576 RID: 17782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004576")]
		[Address(RVA = "0x5809F4", Offset = "0x5809F4", VA = "0x5809F4")]
		public ActiveSound GetActiveSound(SlotId id)
		{
			return null;
		}

		// Token: 0x06004577 RID: 17783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004577")]
		[Address(RVA = "0x57F8F0", Offset = "0x57F8F0", VA = "0x57F8F0")]
		public void PauseAll()
		{
		}

		// Token: 0x06004578 RID: 17784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004578")]
		[Address(RVA = "0x57FC60", Offset = "0x57FC60", VA = "0x57FC60")]
		public void ResumeAll()
		{
		}

		// Token: 0x06004579 RID: 17785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004579")]
		[Address(RVA = "0x5819F8", Offset = "0x5819F8", VA = "0x5819F8")]
		public void StopAll()
		{
		}

		// Token: 0x0600457A RID: 17786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600457A")]
		[Address(RVA = "0x57FFD0", Offset = "0x57FFD0", VA = "0x57FFD0")]
		public void Update()
		{
		}

		// Token: 0x0600457B RID: 17787 RVA: 0x00021258 File Offset: 0x0001F458
		[Token(Token = "0x600457B")]
		[Address(RVA = "0x580C74", Offset = "0x580C74", VA = "0x580C74")]
		public int GetActiveSoundCount(SoundStyle style)
		{
			return 0;
		}

		// Token: 0x0600457C RID: 17788 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600457C")]
		[Address(RVA = "0x581F74", Offset = "0x581F74", VA = "0x581F74")]
		public ActiveSound FindActiveSound(SoundStyle style)
		{
			return null;
		}

		// Token: 0x0600457D RID: 17789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600457D")]
		[Address(RVA = "0x57F538", Offset = "0x57F538", VA = "0x57F538")]
		public SoundPlayer()
		{
		}

		// Token: 0x04008CE2 RID: 36066
		[Token(Token = "0x4008CE2")]
		[global::Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private readonly SlotVector<ActiveSound> _trackedSounds;
	}
}
