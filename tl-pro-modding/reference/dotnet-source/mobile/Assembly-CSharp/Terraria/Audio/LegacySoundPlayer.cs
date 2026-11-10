using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework.Audio;
using ReLogic.Content;

namespace Terraria.Audio
{
	// Token: 0x020007DA RID: 2010
	[Token(Token = "0x20007DA")]
	public class LegacySoundPlayer
	{
		// Token: 0x06004542 RID: 17730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004542")]
		[Address(RVA = "0x560F6C", Offset = "0x560F6C", VA = "0x560F6C")]
		public LegacySoundPlayer(IServiceProvider services)
		{
		}

		// Token: 0x06004543 RID: 17731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004543")]
		[Address(RVA = "0x562A98", Offset = "0x562A98", VA = "0x562A98")]
		public void Reload()
		{
		}

		// Token: 0x06004544 RID: 17732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004544")]
		[Address(RVA = "0x5612D8", Offset = "0x5612D8", VA = "0x5612D8")]
		private void LoadAll()
		{
		}

		// Token: 0x06004545 RID: 17733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004545")]
		[Address(RVA = "0x562A9C", Offset = "0x562A9C", VA = "0x562A9C")]
		public void CreateAllSoundInstances()
		{
		}

		// Token: 0x06004546 RID: 17734 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004546")]
		[Address(RVA = "0x563A7C", Offset = "0x563A7C", VA = "0x563A7C")]
		private SoundEffectInstance CreateInstance(Asset<SoundEffect> asset)
		{
			return null;
		}

		// Token: 0x06004547 RID: 17735 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004547")]
		[Address(RVA = "0x563970", Offset = "0x563970", VA = "0x563970")]
		private Asset<SoundEffect> Load(string assetName)
		{
			return null;
		}

		// Token: 0x06004548 RID: 17736 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004548")]
		[Address(RVA = "0x563B6C", Offset = "0x563B6C", VA = "0x563B6C")]
		public SoundEffectInstance PlaySound(int type, int x = -1, int y = -1, int Style = 1, float volumeScale = 1f, float pitchOffset = 0f)
		{
			return null;
		}

		// Token: 0x06004549 RID: 17737 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004549")]
		[Address(RVA = "0x56D7A0", Offset = "0x56D7A0", VA = "0x56D7A0")]
		public SoundEffect GetTrackableSoundByStyleId(int id)
		{
			return null;
		}

		// Token: 0x0600454A RID: 17738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600454A")]
		[Address(RVA = "0x56D7DC", Offset = "0x56D7DC", VA = "0x56D7DC")]
		public void StopAmbientSounds()
		{
		}

		// Token: 0x0600454B RID: 17739 RVA: 0x00021120 File Offset: 0x0001F320
		[Token(Token = "0x600454B")]
		[Address(RVA = "0x56D768", Offset = "0x56D768", VA = "0x56D768")]
		public bool DoesSoundScaleWithAmbientVolume(int soundType)
		{
			return default(bool);
		}

		// Token: 0x04008C8B RID: 35979
		[Token(Token = "0x4008C8B")]
		[FieldOffset(Offset = "0x8")]
		public Asset<SoundEffect>[] SoundDrip;

		// Token: 0x04008C8C RID: 35980
		[Token(Token = "0x4008C8C")]
		[FieldOffset(Offset = "0xC")]
		public SoundEffectInstance[] SoundInstanceDrip;

		// Token: 0x04008C8D RID: 35981
		[Token(Token = "0x4008C8D")]
		[FieldOffset(Offset = "0x10")]
		public Asset<SoundEffect>[] SoundLiquid;

		// Token: 0x04008C8E RID: 35982
		[Token(Token = "0x4008C8E")]
		[FieldOffset(Offset = "0x14")]
		public SoundEffectInstance[] SoundInstanceLiquid;

		// Token: 0x04008C8F RID: 35983
		[Token(Token = "0x4008C8F")]
		[FieldOffset(Offset = "0x18")]
		public Asset<SoundEffect>[] SoundMech;

		// Token: 0x04008C90 RID: 35984
		[Token(Token = "0x4008C90")]
		[FieldOffset(Offset = "0x1C")]
		public SoundEffectInstance[] SoundInstanceMech;

		// Token: 0x04008C91 RID: 35985
		[Token(Token = "0x4008C91")]
		[FieldOffset(Offset = "0x20")]
		public Asset<SoundEffect>[] SoundDig;

		// Token: 0x04008C92 RID: 35986
		[Token(Token = "0x4008C92")]
		[FieldOffset(Offset = "0x24")]
		public SoundEffectInstance[] SoundInstanceDig;

		// Token: 0x04008C93 RID: 35987
		[Token(Token = "0x4008C93")]
		[FieldOffset(Offset = "0x28")]
		private int _digLastFrame;

		// Token: 0x04008C94 RID: 35988
		[Token(Token = "0x4008C94")]
		[FieldOffset(Offset = "0x2C")]
		public int[] SoundDigPlayCount;

		// Token: 0x04008C95 RID: 35989
		[Token(Token = "0x4008C95")]
		[FieldOffset(Offset = "0x30")]
		public Asset<SoundEffect>[] SoundThunder;

		// Token: 0x04008C96 RID: 35990
		[Token(Token = "0x4008C96")]
		[FieldOffset(Offset = "0x34")]
		public SoundEffectInstance[] SoundInstanceThunder;

		// Token: 0x04008C97 RID: 35991
		[Token(Token = "0x4008C97")]
		[FieldOffset(Offset = "0x38")]
		public Asset<SoundEffect>[] SoundResearch;

		// Token: 0x04008C98 RID: 35992
		[Token(Token = "0x4008C98")]
		[FieldOffset(Offset = "0x3C")]
		public SoundEffectInstance[] SoundInstanceResearch;

		// Token: 0x04008C99 RID: 35993
		[Token(Token = "0x4008C99")]
		[FieldOffset(Offset = "0x40")]
		public Asset<SoundEffect>[] SoundTink;

		// Token: 0x04008C9A RID: 35994
		[Token(Token = "0x4008C9A")]
		[FieldOffset(Offset = "0x44")]
		public SoundEffectInstance[] SoundInstanceTink;

		// Token: 0x04008C9B RID: 35995
		[Token(Token = "0x4008C9B")]
		[FieldOffset(Offset = "0x48")]
		public Asset<SoundEffect>[] SoundCoin;

		// Token: 0x04008C9C RID: 35996
		[Token(Token = "0x4008C9C")]
		[FieldOffset(Offset = "0x4C")]
		public SoundEffectInstance[] SoundInstanceCoin;

		// Token: 0x04008C9D RID: 35997
		[Token(Token = "0x4008C9D")]
		[FieldOffset(Offset = "0x50")]
		public Asset<SoundEffect>[] SoundPlayerHit;

		// Token: 0x04008C9E RID: 35998
		[Token(Token = "0x4008C9E")]
		[FieldOffset(Offset = "0x54")]
		public SoundEffectInstance[] SoundInstancePlayerHit;

		// Token: 0x04008C9F RID: 35999
		[Token(Token = "0x4008C9F")]
		[FieldOffset(Offset = "0x58")]
		public Asset<SoundEffect>[] SoundFemaleHit;

		// Token: 0x04008CA0 RID: 36000
		[Token(Token = "0x4008CA0")]
		[FieldOffset(Offset = "0x5C")]
		public SoundEffectInstance[] SoundInstanceFemaleHit;

		// Token: 0x04008CA1 RID: 36001
		[Token(Token = "0x4008CA1")]
		[FieldOffset(Offset = "0x60")]
		public Asset<SoundEffect> SoundPlayerKilled;

		// Token: 0x04008CA2 RID: 36002
		[Token(Token = "0x4008CA2")]
		[FieldOffset(Offset = "0x64")]
		public SoundEffectInstance SoundInstancePlayerKilled;

		// Token: 0x04008CA3 RID: 36003
		[Token(Token = "0x4008CA3")]
		[FieldOffset(Offset = "0x68")]
		public Asset<SoundEffect> SoundGrass;

		// Token: 0x04008CA4 RID: 36004
		[Token(Token = "0x4008CA4")]
		[FieldOffset(Offset = "0x6C")]
		public SoundEffectInstance SoundInstanceGrass;

		// Token: 0x04008CA5 RID: 36005
		[Token(Token = "0x4008CA5")]
		[FieldOffset(Offset = "0x70")]
		public Asset<SoundEffect> SoundGrab;

		// Token: 0x04008CA6 RID: 36006
		[Token(Token = "0x4008CA6")]
		[FieldOffset(Offset = "0x74")]
		public SoundEffectInstance SoundInstanceGrab;

		// Token: 0x04008CA7 RID: 36007
		[Token(Token = "0x4008CA7")]
		[FieldOffset(Offset = "0x78")]
		public Asset<SoundEffect> SoundPixie;

		// Token: 0x04008CA8 RID: 36008
		[Token(Token = "0x4008CA8")]
		[FieldOffset(Offset = "0x7C")]
		public SoundEffectInstance SoundInstancePixie;

		// Token: 0x04008CA9 RID: 36009
		[Token(Token = "0x4008CA9")]
		[FieldOffset(Offset = "0x80")]
		public Asset<SoundEffect>[] SoundItem;

		// Token: 0x04008CAA RID: 36010
		[Token(Token = "0x4008CAA")]
		[FieldOffset(Offset = "0x84")]
		public SoundEffectInstance[] SoundInstanceItem;

		// Token: 0x04008CAB RID: 36011
		[Token(Token = "0x4008CAB")]
		[FieldOffset(Offset = "0x88")]
		public Asset<SoundEffect>[] SoundNpcHit;

		// Token: 0x04008CAC RID: 36012
		[Token(Token = "0x4008CAC")]
		[FieldOffset(Offset = "0x8C")]
		public SoundEffectInstance[] SoundInstanceNpcHit;

		// Token: 0x04008CAD RID: 36013
		[Token(Token = "0x4008CAD")]
		[FieldOffset(Offset = "0x90")]
		public Asset<SoundEffect>[] SoundNpcKilled;

		// Token: 0x04008CAE RID: 36014
		[Token(Token = "0x4008CAE")]
		[FieldOffset(Offset = "0x94")]
		public SoundEffectInstance[] SoundInstanceNpcKilled;

		// Token: 0x04008CAF RID: 36015
		[Token(Token = "0x4008CAF")]
		[FieldOffset(Offset = "0x98")]
		public SoundEffectInstance SoundInstanceMoonlordCry;

		// Token: 0x04008CB0 RID: 36016
		[Token(Token = "0x4008CB0")]
		[FieldOffset(Offset = "0x9C")]
		public Asset<SoundEffect> SoundDoorOpen;

		// Token: 0x04008CB1 RID: 36017
		[Token(Token = "0x4008CB1")]
		[FieldOffset(Offset = "0xA0")]
		public SoundEffectInstance SoundInstanceDoorOpen;

		// Token: 0x04008CB2 RID: 36018
		[Token(Token = "0x4008CB2")]
		[FieldOffset(Offset = "0xA4")]
		public Asset<SoundEffect> SoundDoorClosed;

		// Token: 0x04008CB3 RID: 36019
		[Token(Token = "0x4008CB3")]
		[FieldOffset(Offset = "0xA8")]
		public SoundEffectInstance SoundInstanceDoorClosed;

		// Token: 0x04008CB4 RID: 36020
		[Token(Token = "0x4008CB4")]
		[FieldOffset(Offset = "0xAC")]
		public Asset<SoundEffect> SoundMenuOpen;

		// Token: 0x04008CB5 RID: 36021
		[Token(Token = "0x4008CB5")]
		[FieldOffset(Offset = "0xB0")]
		public SoundEffectInstance SoundInstanceMenuOpen;

		// Token: 0x04008CB6 RID: 36022
		[Token(Token = "0x4008CB6")]
		[FieldOffset(Offset = "0xB4")]
		public Asset<SoundEffect> SoundMenuClose;

		// Token: 0x04008CB7 RID: 36023
		[Token(Token = "0x4008CB7")]
		[FieldOffset(Offset = "0xB8")]
		public SoundEffectInstance SoundInstanceMenuClose;

		// Token: 0x04008CB8 RID: 36024
		[Token(Token = "0x4008CB8")]
		[FieldOffset(Offset = "0xBC")]
		public Asset<SoundEffect> SoundMenuTick;

		// Token: 0x04008CB9 RID: 36025
		[Token(Token = "0x4008CB9")]
		[FieldOffset(Offset = "0xC0")]
		public SoundEffectInstance SoundInstanceMenuTick;

		// Token: 0x04008CBA RID: 36026
		[Token(Token = "0x4008CBA")]
		[FieldOffset(Offset = "0xC4")]
		public Asset<SoundEffect> SoundShatter;

		// Token: 0x04008CBB RID: 36027
		[Token(Token = "0x4008CBB")]
		[FieldOffset(Offset = "0xC8")]
		public SoundEffectInstance SoundInstanceShatter;

		// Token: 0x04008CBC RID: 36028
		[Token(Token = "0x4008CBC")]
		[FieldOffset(Offset = "0xCC")]
		public Asset<SoundEffect> SoundCamera;

		// Token: 0x04008CBD RID: 36029
		[Token(Token = "0x4008CBD")]
		[FieldOffset(Offset = "0xD0")]
		public SoundEffectInstance SoundInstanceCamera;

		// Token: 0x04008CBE RID: 36030
		[Token(Token = "0x4008CBE")]
		[FieldOffset(Offset = "0xD4")]
		public Asset<SoundEffect>[] SoundZombie;

		// Token: 0x04008CBF RID: 36031
		[Token(Token = "0x4008CBF")]
		[FieldOffset(Offset = "0xD8")]
		public SoundEffectInstance[] SoundInstanceZombie;

		// Token: 0x04008CC0 RID: 36032
		[Token(Token = "0x4008CC0")]
		[FieldOffset(Offset = "0xDC")]
		public Asset<SoundEffect>[] SoundRoar;

		// Token: 0x04008CC1 RID: 36033
		[Token(Token = "0x4008CC1")]
		[FieldOffset(Offset = "0xE0")]
		public SoundEffectInstance[] SoundInstanceRoar;

		// Token: 0x04008CC2 RID: 36034
		[Token(Token = "0x4008CC2")]
		[FieldOffset(Offset = "0xE4")]
		public Asset<SoundEffect>[] SoundSplash;

		// Token: 0x04008CC3 RID: 36035
		[Token(Token = "0x4008CC3")]
		[FieldOffset(Offset = "0xE8")]
		public SoundEffectInstance[] SoundInstanceSplash;

		// Token: 0x04008CC4 RID: 36036
		[Token(Token = "0x4008CC4")]
		[FieldOffset(Offset = "0xEC")]
		public Asset<SoundEffect> SoundDoubleJump;

		// Token: 0x04008CC5 RID: 36037
		[Token(Token = "0x4008CC5")]
		[FieldOffset(Offset = "0xF0")]
		public SoundEffectInstance SoundInstanceDoubleJump;

		// Token: 0x04008CC6 RID: 36038
		[Token(Token = "0x4008CC6")]
		[FieldOffset(Offset = "0xF4")]
		public Asset<SoundEffect> SoundRun;

		// Token: 0x04008CC7 RID: 36039
		[Token(Token = "0x4008CC7")]
		[FieldOffset(Offset = "0xF8")]
		public SoundEffectInstance SoundInstanceRun;

		// Token: 0x04008CC8 RID: 36040
		[Token(Token = "0x4008CC8")]
		[FieldOffset(Offset = "0xFC")]
		public Asset<SoundEffect> SoundCoins;

		// Token: 0x04008CC9 RID: 36041
		[Token(Token = "0x4008CC9")]
		[FieldOffset(Offset = "0x100")]
		public SoundEffectInstance SoundInstanceCoins;

		// Token: 0x04008CCA RID: 36042
		[Token(Token = "0x4008CCA")]
		[FieldOffset(Offset = "0x104")]
		public Asset<SoundEffect> SoundUnlock;

		// Token: 0x04008CCB RID: 36043
		[Token(Token = "0x4008CCB")]
		[FieldOffset(Offset = "0x108")]
		public SoundEffectInstance SoundInstanceUnlock;

		// Token: 0x04008CCC RID: 36044
		[Token(Token = "0x4008CCC")]
		[FieldOffset(Offset = "0x10C")]
		public Asset<SoundEffect> SoundChat;

		// Token: 0x04008CCD RID: 36045
		[Token(Token = "0x4008CCD")]
		[FieldOffset(Offset = "0x110")]
		public SoundEffectInstance SoundInstanceChat;

		// Token: 0x04008CCE RID: 36046
		[Token(Token = "0x4008CCE")]
		[FieldOffset(Offset = "0x114")]
		public Asset<SoundEffect> SoundMaxMana;

		// Token: 0x04008CCF RID: 36047
		[Token(Token = "0x4008CCF")]
		[FieldOffset(Offset = "0x118")]
		public SoundEffectInstance SoundInstanceMaxMana;

		// Token: 0x04008CD0 RID: 36048
		[Token(Token = "0x4008CD0")]
		[FieldOffset(Offset = "0x11C")]
		public Asset<SoundEffect> SoundDrown;

		// Token: 0x04008CD1 RID: 36049
		[Token(Token = "0x4008CD1")]
		[FieldOffset(Offset = "0x120")]
		public SoundEffectInstance SoundInstanceDrown;

		// Token: 0x04008CD2 RID: 36050
		[Token(Token = "0x4008CD2")]
		[FieldOffset(Offset = "0x124")]
		public Asset<SoundEffect>[] TrackableSounds;

		// Token: 0x04008CD3 RID: 36051
		[Token(Token = "0x4008CD3")]
		[FieldOffset(Offset = "0x128")]
		public SoundEffectInstance[] TrackableSoundInstances;

		// Token: 0x04008CD4 RID: 36052
		[Token(Token = "0x4008CD4")]
		[FieldOffset(Offset = "0x12C")]
		private readonly IServiceProvider _services;

		// Token: 0x04008CD5 RID: 36053
		[Token(Token = "0x4008CD5")]
		[FieldOffset(Offset = "0x130")]
		private List<SoundEffectInstance> _trackedInstances;

		// Token: 0x04008CD6 RID: 36054
		[Token(Token = "0x4008CD6")]
		[FieldOffset(Offset = "0x0")]
		public static readonly float SoundAttenuationDistance;
	}
}
