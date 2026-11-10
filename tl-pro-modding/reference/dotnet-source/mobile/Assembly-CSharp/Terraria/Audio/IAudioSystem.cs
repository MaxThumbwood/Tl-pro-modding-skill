using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ReLogic.Content.Sources;

namespace Terraria.Audio
{
	// Token: 0x020007D8 RID: 2008
	[Token(Token = "0x20007D8")]
	public interface IAudioSystem : FileAPI
	{
		// Token: 0x06004524 RID: 17700
		[Token(Token = "0x6004524")]
		void LoadCue(int cueIndex, string cueName);

		// Token: 0x06004525 RID: 17701
		[Token(Token = "0x6004525")]
		void PauseAll();

		// Token: 0x06004526 RID: 17702
		[Token(Token = "0x6004526")]
		void ResumeAll();

		// Token: 0x06004527 RID: 17703
		[Token(Token = "0x6004527")]
		void UpdateMisc();

		// Token: 0x06004528 RID: 17704
		[Token(Token = "0x6004528")]
		void UpdateAudioEngine();

		// Token: 0x06004529 RID: 17705
		[Token(Token = "0x6004529")]
		void UpdateAmbientCueState(int i, bool gameIsActive, ref float trackVolume, float systemVolume);

		// Token: 0x0600452A RID: 17706
		[Token(Token = "0x600452A")]
		void UpdateAmbientCueTowardStopping(int i, float stoppingSpeed, ref float trackVolume, float systemVolume);

		// Token: 0x0600452B RID: 17707
		[Token(Token = "0x600452B")]
		void UpdateCommonTrack(bool active, int i, float totalVolume, ref float tempFade);

		// Token: 0x0600452C RID: 17708
		[Token(Token = "0x600452C")]
		void UpdateCommonTrackTowardStopping(int i, float totalVolume, ref float tempFade, bool isMainTrackAudible);

		// Token: 0x0600452D RID: 17709
		[Token(Token = "0x600452D")]
		bool IsTrackPlaying(int trackIndex);

		// Token: 0x0600452E RID: 17710
		[Token(Token = "0x600452E")]
		void UseSources(List<IContentSource> sources);

		// Token: 0x0600452F RID: 17711
		[Token(Token = "0x600452F")]
		void LoadFromSources();

		// Token: 0x06004530 RID: 17712
		[Token(Token = "0x6004530")]
		void Update();

		// Token: 0x06004531 RID: 17713
		[Token(Token = "0x6004531")]
		void SetPlayCallback(int trackIndex, AudioTrackPlayCallback callback);
	}
}
