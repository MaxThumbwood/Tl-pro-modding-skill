using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Audio;
using ReLogic.Content.Sources;

namespace Terraria.Audio
{
	// Token: 0x020007D9 RID: 2009
	[Token(Token = "0x20007D9")]
	public class LegacyAudioSystem : FileAPI, GUIControllerItem
	{
		// Token: 0x06004532 RID: 17714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004532")]
		[Address(RVA = "0x55FD68", Offset = "0x55FD68", VA = "0x55FD68", Slot = "15")]
		public void LoadFromSources()
		{
		}

		// Token: 0x06004533 RID: 17715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004533")]
		[Address(RVA = "0x56001C", Offset = "0x56001C", VA = "0x56001C", Slot = "14")]
		public void UseSources(List<IContentSource> sourcesFromLowestToHighest)
		{
		}

		// Token: 0x06004534 RID: 17716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004534")]
		[Address(RVA = "0x560024", Offset = "0x560024", VA = "0x560024", Slot = "16")]
		public void Update()
		{
		}

		// Token: 0x06004535 RID: 17717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004535")]
		[Address(RVA = "0x560028", Offset = "0x560028", VA = "0x560028")]
		public LegacyAudioSystem()
		{
		}

		// Token: 0x06004536 RID: 17718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004536")]
		[Address(RVA = "0x5602DC", Offset = "0x5602DC", VA = "0x5602DC", Slot = "4")]
		public void LoadCue(int cueIndex, string cueName)
		{
		}

		// Token: 0x06004537 RID: 17719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004537")]
		[Address(RVA = "0x560424", Offset = "0x560424", VA = "0x560424", Slot = "7")]
		public void UpdateMisc()
		{
		}

		// Token: 0x06004538 RID: 17720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004538")]
		[Address(RVA = "0x560428", Offset = "0x560428", VA = "0x560428", Slot = "5")]
		public void PauseAll()
		{
		}

		// Token: 0x06004539 RID: 17721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004539")]
		[Address(RVA = "0x560614", Offset = "0x560614", VA = "0x560614", Slot = "6")]
		public void ResumeAll()
		{
		}

		// Token: 0x0600453A RID: 17722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600453A")]
		[Address(RVA = "0x5607CC", Offset = "0x5607CC", VA = "0x5607CC", Slot = "9")]
		public void UpdateAmbientCueState(int i, bool gameIsActive, ref float trackVolume, float systemVolume)
		{
		}

		// Token: 0x0600453B RID: 17723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600453B")]
		[Address(RVA = "0x5609BC", Offset = "0x5609BC", VA = "0x5609BC", Slot = "10")]
		public void UpdateAmbientCueTowardStopping(int i, float stoppingSpeed, ref float trackVolume, float systemVolume)
		{
		}

		// Token: 0x0600453C RID: 17724 RVA: 0x00021108 File Offset: 0x0001F308
		[Token(Token = "0x600453C")]
		[Address(RVA = "0x560AF4", Offset = "0x560AF4", VA = "0x560AF4", Slot = "13")]
		public bool IsTrackPlaying(int trackIndex)
		{
			return default(bool);
		}

		// Token: 0x0600453D RID: 17725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600453D")]
		[Address(RVA = "0x560B1C", Offset = "0x560B1C", VA = "0x560B1C", Slot = "11")]
		public void UpdateCommonTrack(bool active, int i, float totalVolume, ref float tempFade)
		{
		}

		// Token: 0x0600453E RID: 17726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600453E")]
		[Address(RVA = "0x560CE8", Offset = "0x560CE8", VA = "0x560CE8", Slot = "12")]
		public void UpdateCommonTrackTowardStopping(int i, float totalVolume, ref float tempFade, bool isMainTrackAudible)
		{
		}

		// Token: 0x0600453F RID: 17727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600453F")]
		[Address(RVA = "0x560F04", Offset = "0x560F04", VA = "0x560F04", Slot = "8")]
		public void UpdateAudioEngine()
		{
		}

		// Token: 0x06004540 RID: 17728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004540")]
		[Address(RVA = "0x560F08", Offset = "0x560F08", VA = "0x560F08", Slot = "17")]
		public void SetPlayCallback(int trackIndex, AudioTrackPlayCallback callback)
		{
		}

		// Token: 0x06004541 RID: 17729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004541")]
		[Address(RVA = "0x560F68", Offset = "0x560F68", VA = "0x560F68", Slot = "18")]
		public void Dispose()
		{
		}

		// Token: 0x04008C81 RID: 35969
		[Token(Token = "0x4008C81")]
		[FieldOffset(Offset = "0x8")]
		public Cue[] AudioTracks;

		// Token: 0x04008C82 RID: 35970
		[Token(Token = "0x4008C82")]
		[FieldOffset(Offset = "0xC")]
		public int MusicReplayDelay;

		// Token: 0x04008C83 RID: 35971
		[Token(Token = "0x4008C83")]
		[FieldOffset(Offset = "0x10")]
		public AudioEngine Engine;

		// Token: 0x04008C84 RID: 35972
		[Token(Token = "0x4008C84")]
		[FieldOffset(Offset = "0x14")]
		public SoundBank SoundBank;

		// Token: 0x04008C85 RID: 35973
		[Token(Token = "0x4008C85")]
		[FieldOffset(Offset = "0x18")]
		public WaveBank WaveBank;

		// Token: 0x04008C86 RID: 35974
		[Token(Token = "0x4008C86")]
		[FieldOffset(Offset = "0x1C")]
		public Dictionary<int, string> TrackNamesByIndex;

		// Token: 0x04008C87 RID: 35975
		[Token(Token = "0x4008C87")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<int, Cue> DefaultTrackByIndex;

		// Token: 0x04008C88 RID: 35976
		[Token(Token = "0x4008C88")]
		[FieldOffset(Offset = "0x24")]
		public List<IContentSource> FileSources;

		// Token: 0x04008C89 RID: 35977
		[Token(Token = "0x4008C89")]
		[FieldOffset(Offset = "0x28")]
		public int[] TrackLoopCounts;

		// Token: 0x04008C8A RID: 35978
		[Token(Token = "0x4008C8A")]
		[FieldOffset(Offset = "0x2C")]
		public AudioTrackPlayCallback[] PlayCallbacks;
	}
}
