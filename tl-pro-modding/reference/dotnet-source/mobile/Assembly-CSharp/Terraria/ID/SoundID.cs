using System;
using System.Collections.Generic;
using System.Reflection;
using Il2CppDummyDll;
using Terraria.Audio;

namespace Terraria.ID
{
	// Token: 0x02000712 RID: 1810
	[Token(Token = "0x2000712")]
	public class SoundID
	{
		// Token: 0x17000816 RID: 2070
		// (get) Token: 0x060041E7 RID: 16871 RVA: 0x00020208 File Offset: 0x0001E408
		[Token(Token = "0x17000816")]
		public static int TrackableLegacySoundCount
		{
			[Token(Token = "0x60041E7")]
			[Address(RVA = "0x1F87C4C", Offset = "0x1F87C4C", VA = "0x1F87C4C")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060041E8 RID: 16872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041E8")]
		[Address(RVA = "0x1F87CD8", Offset = "0x1F87CD8", VA = "0x1F87CD8")]
		public static string GetTrackableLegacySoundPath(int id)
		{
			return null;
		}

		// Token: 0x060041E9 RID: 16873 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041E9")]
		[Address(RVA = "0x1F87D78", Offset = "0x1F87D78", VA = "0x1F87D78")]
		private static LegacySoundStyle CreateTrackable(string name, SoundID.SoundStyleDefaults defaults, int maxInstances = 0)
		{
			return null;
		}

		// Token: 0x060041EA RID: 16874 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041EA")]
		[Address(RVA = "0x1F881AC", Offset = "0x1F881AC", VA = "0x1F881AC")]
		private static LegacySoundStyle CreateTrackable(string name, int variations, SoundID.SoundStyleDefaults defaults, int maxInstances = 0)
		{
			return null;
		}

		// Token: 0x060041EB RID: 16875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041EB")]
		[Address(RVA = "0x1F88278", Offset = "0x1F88278", VA = "0x1F88278")]
		private static LegacySoundStyle CreateTrackable(string name, SoundType type = SoundType.Sound, int maxInstances = 0)
		{
			return null;
		}

		// Token: 0x060041EC RID: 16876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60041EC")]
		[Address(RVA = "0x1F87E40", Offset = "0x1F87E40", VA = "0x1F87E40")]
		private static LegacySoundStyle CreateTrackable(string name, int variations, SoundType type = SoundType.Sound, int maxInstances = 0)
		{
			return null;
		}

		// Token: 0x060041ED RID: 16877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041ED")]
		[Address(RVA = "0x1F882F8", Offset = "0x1F882F8", VA = "0x1F882F8")]
		public static void FillAccessMap()
		{
		}

		// Token: 0x060041EE RID: 16878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60041EE")]
		[Address(RVA = "0x1F8882C", Offset = "0x1F8882C", VA = "0x1F8882C")]
		public SoundID()
		{
		}

		// Token: 0x0400817B RID: 33147
		[Token(Token = "0x400817B")]
		[FieldOffset(Offset = "0x0")]
		private static readonly SoundID.SoundStyleDefaults ItemDefaults;

		// Token: 0x0400817C RID: 33148
		[Token(Token = "0x400817C")]
		public const int Dig = 0;

		// Token: 0x0400817D RID: 33149
		[Token(Token = "0x400817D")]
		public const int PlayerHit = 1;

		// Token: 0x0400817E RID: 33150
		[Token(Token = "0x400817E")]
		public const int Item = 2;

		// Token: 0x0400817F RID: 33151
		[Token(Token = "0x400817F")]
		public const int NPCHit = 3;

		// Token: 0x04008180 RID: 33152
		[Token(Token = "0x4008180")]
		public const int NPCKilled = 4;

		// Token: 0x04008181 RID: 33153
		[Token(Token = "0x4008181")]
		public const int PlayerKilled = 5;

		// Token: 0x04008182 RID: 33154
		[Token(Token = "0x4008182")]
		public const int Grass = 6;

		// Token: 0x04008183 RID: 33155
		[Token(Token = "0x4008183")]
		public const int Grab = 7;

		// Token: 0x04008184 RID: 33156
		[Token(Token = "0x4008184")]
		public const int DoorOpen = 8;

		// Token: 0x04008185 RID: 33157
		[Token(Token = "0x4008185")]
		public const int DoorClosed = 9;

		// Token: 0x04008186 RID: 33158
		[Token(Token = "0x4008186")]
		public const int MenuOpen = 10;

		// Token: 0x04008187 RID: 33159
		[Token(Token = "0x4008187")]
		public const int MenuClose = 11;

		// Token: 0x04008188 RID: 33160
		[Token(Token = "0x4008188")]
		public const int MenuTick = 12;

		// Token: 0x04008189 RID: 33161
		[Token(Token = "0x4008189")]
		public const int Shatter = 13;

		// Token: 0x0400818A RID: 33162
		[Token(Token = "0x400818A")]
		public const int ZombieMoan = 14;

		// Token: 0x0400818B RID: 33163
		[Token(Token = "0x400818B")]
		public const int Roar = 15;

		// Token: 0x0400818C RID: 33164
		[Token(Token = "0x400818C")]
		public const int DoubleJump = 16;

		// Token: 0x0400818D RID: 33165
		[Token(Token = "0x400818D")]
		public const int Run = 17;

		// Token: 0x0400818E RID: 33166
		[Token(Token = "0x400818E")]
		public const int Coins = 18;

		// Token: 0x0400818F RID: 33167
		[Token(Token = "0x400818F")]
		public const int Splash = 19;

		// Token: 0x04008190 RID: 33168
		[Token(Token = "0x4008190")]
		public const int FemaleHit = 20;

		// Token: 0x04008191 RID: 33169
		[Token(Token = "0x4008191")]
		public const int Tink = 21;

		// Token: 0x04008192 RID: 33170
		[Token(Token = "0x4008192")]
		public const int Unlock = 22;

		// Token: 0x04008193 RID: 33171
		[Token(Token = "0x4008193")]
		public const int Drown = 23;

		// Token: 0x04008194 RID: 33172
		[Token(Token = "0x4008194")]
		public const int Chat = 24;

		// Token: 0x04008195 RID: 33173
		[Token(Token = "0x4008195")]
		public const int MaxMana = 25;

		// Token: 0x04008196 RID: 33174
		[Token(Token = "0x4008196")]
		public const int Mummy = 26;

		// Token: 0x04008197 RID: 33175
		[Token(Token = "0x4008197")]
		public const int Pixie = 27;

		// Token: 0x04008198 RID: 33176
		[Token(Token = "0x4008198")]
		public const int Mech = 28;

		// Token: 0x04008199 RID: 33177
		[Token(Token = "0x4008199")]
		public const int Zombie = 29;

		// Token: 0x0400819A RID: 33178
		[Token(Token = "0x400819A")]
		public const int Duck = 30;

		// Token: 0x0400819B RID: 33179
		[Token(Token = "0x400819B")]
		public const int Frog = 31;

		// Token: 0x0400819C RID: 33180
		[Token(Token = "0x400819C")]
		public const int Bird = 32;

		// Token: 0x0400819D RID: 33181
		[Token(Token = "0x400819D")]
		public const int Critter = 33;

		// Token: 0x0400819E RID: 33182
		[Token(Token = "0x400819E")]
		public const int Waterfall = 34;

		// Token: 0x0400819F RID: 33183
		[Token(Token = "0x400819F")]
		public const int Lavafall = 35;

		// Token: 0x040081A0 RID: 33184
		[Token(Token = "0x40081A0")]
		public const int ForceRoar = 36;

		// Token: 0x040081A1 RID: 33185
		[Token(Token = "0x40081A1")]
		public const int Meowmere = 37;

		// Token: 0x040081A2 RID: 33186
		[Token(Token = "0x40081A2")]
		public const int CoinPickup = 38;

		// Token: 0x040081A3 RID: 33187
		[Token(Token = "0x40081A3")]
		public const int Drip = 39;

		// Token: 0x040081A4 RID: 33188
		[Token(Token = "0x40081A4")]
		public const int Camera = 40;

		// Token: 0x040081A5 RID: 33189
		[Token(Token = "0x40081A5")]
		public const int MoonLord = 41;

		// Token: 0x040081A6 RID: 33190
		[Token(Token = "0x40081A6")]
		public const int Trackable = 42;

		// Token: 0x040081A7 RID: 33191
		[Token(Token = "0x40081A7")]
		public const int Thunder = 43;

		// Token: 0x040081A8 RID: 33192
		[Token(Token = "0x40081A8")]
		public const int Seagull = 44;

		// Token: 0x040081A9 RID: 33193
		[Token(Token = "0x40081A9")]
		public const int Dolphin = 45;

		// Token: 0x040081AA RID: 33194
		[Token(Token = "0x40081AA")]
		public const int Owl = 46;

		// Token: 0x040081AB RID: 33195
		[Token(Token = "0x40081AB")]
		public const int GuitarC = 47;

		// Token: 0x040081AC RID: 33196
		[Token(Token = "0x40081AC")]
		public const int GuitarD = 48;

		// Token: 0x040081AD RID: 33197
		[Token(Token = "0x40081AD")]
		public const int GuitarEm = 49;

		// Token: 0x040081AE RID: 33198
		[Token(Token = "0x40081AE")]
		public const int GuitarG = 50;

		// Token: 0x040081AF RID: 33199
		[Token(Token = "0x40081AF")]
		public const int GuitarBm = 51;

		// Token: 0x040081B0 RID: 33200
		[Token(Token = "0x40081B0")]
		public const int GuitarAm = 52;

		// Token: 0x040081B1 RID: 33201
		[Token(Token = "0x40081B1")]
		public const int DrumHiHat = 53;

		// Token: 0x040081B2 RID: 33202
		[Token(Token = "0x40081B2")]
		public const int DrumTomHigh = 54;

		// Token: 0x040081B3 RID: 33203
		[Token(Token = "0x40081B3")]
		public const int DrumTomLow = 55;

		// Token: 0x040081B4 RID: 33204
		[Token(Token = "0x40081B4")]
		public const int DrumTomMid = 56;

		// Token: 0x040081B5 RID: 33205
		[Token(Token = "0x40081B5")]
		public const int DrumClosedHiHat = 57;

		// Token: 0x040081B6 RID: 33206
		[Token(Token = "0x40081B6")]
		public const int DrumCymbal1 = 58;

		// Token: 0x040081B7 RID: 33207
		[Token(Token = "0x40081B7")]
		public const int DrumCymbal2 = 59;

		// Token: 0x040081B8 RID: 33208
		[Token(Token = "0x40081B8")]
		public const int DrumKick = 60;

		// Token: 0x040081B9 RID: 33209
		[Token(Token = "0x40081B9")]
		public const int DrumTamaSnare = 61;

		// Token: 0x040081BA RID: 33210
		[Token(Token = "0x40081BA")]
		public const int DrumFloorTom = 62;

		// Token: 0x040081BB RID: 33211
		[Token(Token = "0x40081BB")]
		public const int Research = 63;

		// Token: 0x040081BC RID: 33212
		[Token(Token = "0x40081BC")]
		public const int ResearchComplete = 64;

		// Token: 0x040081BD RID: 33213
		[Token(Token = "0x40081BD")]
		public const int QueenSlime = 65;

		// Token: 0x040081BE RID: 33214
		[Token(Token = "0x40081BE")]
		public const int Clown = 66;

		// Token: 0x040081BF RID: 33215
		[Token(Token = "0x40081BF")]
		public const int Cockatiel = 67;

		// Token: 0x040081C0 RID: 33216
		[Token(Token = "0x40081C0")]
		public const int Macaw = 68;

		// Token: 0x040081C1 RID: 33217
		[Token(Token = "0x40081C1")]
		public const int Toucan = 69;

		// Token: 0x040081C2 RID: 33218
		[Token(Token = "0x40081C2")]
		[FieldOffset(Offset = "0xC")]
		public static readonly LegacySoundStyle NPCHit1;

		// Token: 0x040081C3 RID: 33219
		[Token(Token = "0x40081C3")]
		[FieldOffset(Offset = "0x10")]
		public static readonly LegacySoundStyle NPCHit2;

		// Token: 0x040081C4 RID: 33220
		[Token(Token = "0x40081C4")]
		[FieldOffset(Offset = "0x14")]
		public static readonly LegacySoundStyle NPCHit3;

		// Token: 0x040081C5 RID: 33221
		[Token(Token = "0x40081C5")]
		[FieldOffset(Offset = "0x18")]
		public static readonly LegacySoundStyle NPCHit4;

		// Token: 0x040081C6 RID: 33222
		[Token(Token = "0x40081C6")]
		[FieldOffset(Offset = "0x1C")]
		public static readonly LegacySoundStyle NPCHit5;

		// Token: 0x040081C7 RID: 33223
		[Token(Token = "0x40081C7")]
		[FieldOffset(Offset = "0x20")]
		public static readonly LegacySoundStyle NPCHit6;

		// Token: 0x040081C8 RID: 33224
		[Token(Token = "0x40081C8")]
		[FieldOffset(Offset = "0x24")]
		public static readonly LegacySoundStyle NPCHit7;

		// Token: 0x040081C9 RID: 33225
		[Token(Token = "0x40081C9")]
		[FieldOffset(Offset = "0x28")]
		public static readonly LegacySoundStyle NPCHit8;

		// Token: 0x040081CA RID: 33226
		[Token(Token = "0x40081CA")]
		[FieldOffset(Offset = "0x2C")]
		public static readonly LegacySoundStyle NPCHit9;

		// Token: 0x040081CB RID: 33227
		[Token(Token = "0x40081CB")]
		[FieldOffset(Offset = "0x30")]
		public static readonly LegacySoundStyle NPCHit10;

		// Token: 0x040081CC RID: 33228
		[Token(Token = "0x40081CC")]
		[FieldOffset(Offset = "0x34")]
		public static readonly LegacySoundStyle NPCHit11;

		// Token: 0x040081CD RID: 33229
		[Token(Token = "0x40081CD")]
		[FieldOffset(Offset = "0x38")]
		public static readonly LegacySoundStyle NPCHit12;

		// Token: 0x040081CE RID: 33230
		[Token(Token = "0x40081CE")]
		[FieldOffset(Offset = "0x3C")]
		public static readonly LegacySoundStyle NPCHit13;

		// Token: 0x040081CF RID: 33231
		[Token(Token = "0x40081CF")]
		[FieldOffset(Offset = "0x40")]
		public static readonly LegacySoundStyle NPCHit14;

		// Token: 0x040081D0 RID: 33232
		[Token(Token = "0x40081D0")]
		[FieldOffset(Offset = "0x44")]
		public static readonly LegacySoundStyle NPCHit15;

		// Token: 0x040081D1 RID: 33233
		[Token(Token = "0x40081D1")]
		[FieldOffset(Offset = "0x48")]
		public static readonly LegacySoundStyle NPCHit16;

		// Token: 0x040081D2 RID: 33234
		[Token(Token = "0x40081D2")]
		[FieldOffset(Offset = "0x4C")]
		public static readonly LegacySoundStyle NPCHit17;

		// Token: 0x040081D3 RID: 33235
		[Token(Token = "0x40081D3")]
		[FieldOffset(Offset = "0x50")]
		public static readonly LegacySoundStyle NPCHit18;

		// Token: 0x040081D4 RID: 33236
		[Token(Token = "0x40081D4")]
		[FieldOffset(Offset = "0x54")]
		public static readonly LegacySoundStyle NPCHit19;

		// Token: 0x040081D5 RID: 33237
		[Token(Token = "0x40081D5")]
		[FieldOffset(Offset = "0x58")]
		public static readonly LegacySoundStyle NPCHit20;

		// Token: 0x040081D6 RID: 33238
		[Token(Token = "0x40081D6")]
		[FieldOffset(Offset = "0x5C")]
		public static readonly LegacySoundStyle NPCHit21;

		// Token: 0x040081D7 RID: 33239
		[Token(Token = "0x40081D7")]
		[FieldOffset(Offset = "0x60")]
		public static readonly LegacySoundStyle NPCHit22;

		// Token: 0x040081D8 RID: 33240
		[Token(Token = "0x40081D8")]
		[FieldOffset(Offset = "0x64")]
		public static readonly LegacySoundStyle NPCHit23;

		// Token: 0x040081D9 RID: 33241
		[Token(Token = "0x40081D9")]
		[FieldOffset(Offset = "0x68")]
		public static readonly LegacySoundStyle NPCHit24;

		// Token: 0x040081DA RID: 33242
		[Token(Token = "0x40081DA")]
		[FieldOffset(Offset = "0x6C")]
		public static readonly LegacySoundStyle NPCHit25;

		// Token: 0x040081DB RID: 33243
		[Token(Token = "0x40081DB")]
		[FieldOffset(Offset = "0x70")]
		public static readonly LegacySoundStyle NPCHit26;

		// Token: 0x040081DC RID: 33244
		[Token(Token = "0x40081DC")]
		[FieldOffset(Offset = "0x74")]
		public static readonly LegacySoundStyle NPCHit27;

		// Token: 0x040081DD RID: 33245
		[Token(Token = "0x40081DD")]
		[FieldOffset(Offset = "0x78")]
		public static readonly LegacySoundStyle NPCHit28;

		// Token: 0x040081DE RID: 33246
		[Token(Token = "0x40081DE")]
		[FieldOffset(Offset = "0x7C")]
		public static readonly LegacySoundStyle NPCHit29;

		// Token: 0x040081DF RID: 33247
		[Token(Token = "0x40081DF")]
		[FieldOffset(Offset = "0x80")]
		public static readonly LegacySoundStyle NPCHit30;

		// Token: 0x040081E0 RID: 33248
		[Token(Token = "0x40081E0")]
		[FieldOffset(Offset = "0x84")]
		public static readonly LegacySoundStyle NPCHit31;

		// Token: 0x040081E1 RID: 33249
		[Token(Token = "0x40081E1")]
		[FieldOffset(Offset = "0x88")]
		public static readonly LegacySoundStyle NPCHit32;

		// Token: 0x040081E2 RID: 33250
		[Token(Token = "0x40081E2")]
		[FieldOffset(Offset = "0x8C")]
		public static readonly LegacySoundStyle NPCHit33;

		// Token: 0x040081E3 RID: 33251
		[Token(Token = "0x40081E3")]
		[FieldOffset(Offset = "0x90")]
		public static readonly LegacySoundStyle NPCHit34;

		// Token: 0x040081E4 RID: 33252
		[Token(Token = "0x40081E4")]
		[FieldOffset(Offset = "0x94")]
		public static readonly LegacySoundStyle NPCHit35;

		// Token: 0x040081E5 RID: 33253
		[Token(Token = "0x40081E5")]
		[FieldOffset(Offset = "0x98")]
		public static readonly LegacySoundStyle NPCHit36;

		// Token: 0x040081E6 RID: 33254
		[Token(Token = "0x40081E6")]
		[FieldOffset(Offset = "0x9C")]
		public static readonly LegacySoundStyle NPCHit37;

		// Token: 0x040081E7 RID: 33255
		[Token(Token = "0x40081E7")]
		[FieldOffset(Offset = "0xA0")]
		public static readonly LegacySoundStyle NPCHit38;

		// Token: 0x040081E8 RID: 33256
		[Token(Token = "0x40081E8")]
		[FieldOffset(Offset = "0xA4")]
		public static readonly LegacySoundStyle NPCHit39;

		// Token: 0x040081E9 RID: 33257
		[Token(Token = "0x40081E9")]
		[FieldOffset(Offset = "0xA8")]
		public static readonly LegacySoundStyle NPCHit40;

		// Token: 0x040081EA RID: 33258
		[Token(Token = "0x40081EA")]
		[FieldOffset(Offset = "0xAC")]
		public static readonly LegacySoundStyle NPCHit41;

		// Token: 0x040081EB RID: 33259
		[Token(Token = "0x40081EB")]
		[FieldOffset(Offset = "0xB0")]
		public static readonly LegacySoundStyle NPCHit42;

		// Token: 0x040081EC RID: 33260
		[Token(Token = "0x40081EC")]
		[FieldOffset(Offset = "0xB4")]
		public static readonly LegacySoundStyle NPCHit43;

		// Token: 0x040081ED RID: 33261
		[Token(Token = "0x40081ED")]
		[FieldOffset(Offset = "0xB8")]
		public static readonly LegacySoundStyle NPCHit44;

		// Token: 0x040081EE RID: 33262
		[Token(Token = "0x40081EE")]
		[FieldOffset(Offset = "0xBC")]
		public static readonly LegacySoundStyle NPCHit45;

		// Token: 0x040081EF RID: 33263
		[Token(Token = "0x40081EF")]
		[FieldOffset(Offset = "0xC0")]
		public static readonly LegacySoundStyle NPCHit46;

		// Token: 0x040081F0 RID: 33264
		[Token(Token = "0x40081F0")]
		[FieldOffset(Offset = "0xC4")]
		public static readonly LegacySoundStyle NPCHit47;

		// Token: 0x040081F1 RID: 33265
		[Token(Token = "0x40081F1")]
		[FieldOffset(Offset = "0xC8")]
		public static readonly LegacySoundStyle NPCHit48;

		// Token: 0x040081F2 RID: 33266
		[Token(Token = "0x40081F2")]
		[FieldOffset(Offset = "0xCC")]
		public static readonly LegacySoundStyle NPCHit49;

		// Token: 0x040081F3 RID: 33267
		[Token(Token = "0x40081F3")]
		[FieldOffset(Offset = "0xD0")]
		public static readonly LegacySoundStyle NPCHit50;

		// Token: 0x040081F4 RID: 33268
		[Token(Token = "0x40081F4")]
		[FieldOffset(Offset = "0xD4")]
		public static readonly LegacySoundStyle NPCHit51;

		// Token: 0x040081F5 RID: 33269
		[Token(Token = "0x40081F5")]
		[FieldOffset(Offset = "0xD8")]
		public static readonly LegacySoundStyle NPCHit52;

		// Token: 0x040081F6 RID: 33270
		[Token(Token = "0x40081F6")]
		[FieldOffset(Offset = "0xDC")]
		public static readonly LegacySoundStyle NPCHit53;

		// Token: 0x040081F7 RID: 33271
		[Token(Token = "0x40081F7")]
		[FieldOffset(Offset = "0xE0")]
		public static readonly LegacySoundStyle NPCHit54;

		// Token: 0x040081F8 RID: 33272
		[Token(Token = "0x40081F8")]
		[FieldOffset(Offset = "0xE4")]
		public static readonly LegacySoundStyle NPCHit55;

		// Token: 0x040081F9 RID: 33273
		[Token(Token = "0x40081F9")]
		[FieldOffset(Offset = "0xE8")]
		public static readonly LegacySoundStyle NPCHit56;

		// Token: 0x040081FA RID: 33274
		[Token(Token = "0x40081FA")]
		[FieldOffset(Offset = "0xEC")]
		public static readonly LegacySoundStyle NPCHit57;

		// Token: 0x040081FB RID: 33275
		[Token(Token = "0x40081FB")]
		[FieldOffset(Offset = "0xF0")]
		public static readonly LegacySoundStyle NPCHit58;

		// Token: 0x040081FC RID: 33276
		[Token(Token = "0x40081FC")]
		[FieldOffset(Offset = "0xF4")]
		public static readonly LegacySoundStyle NPCDeath1;

		// Token: 0x040081FD RID: 33277
		[Token(Token = "0x40081FD")]
		[FieldOffset(Offset = "0xF8")]
		public static readonly LegacySoundStyle NPCDeath2;

		// Token: 0x040081FE RID: 33278
		[Token(Token = "0x40081FE")]
		[FieldOffset(Offset = "0xFC")]
		public static readonly LegacySoundStyle NPCDeath3;

		// Token: 0x040081FF RID: 33279
		[Token(Token = "0x40081FF")]
		[FieldOffset(Offset = "0x100")]
		public static readonly LegacySoundStyle NPCDeath4;

		// Token: 0x04008200 RID: 33280
		[Token(Token = "0x4008200")]
		[FieldOffset(Offset = "0x104")]
		public static readonly LegacySoundStyle NPCDeath5;

		// Token: 0x04008201 RID: 33281
		[Token(Token = "0x4008201")]
		[FieldOffset(Offset = "0x108")]
		public static readonly LegacySoundStyle NPCDeath6;

		// Token: 0x04008202 RID: 33282
		[Token(Token = "0x4008202")]
		[FieldOffset(Offset = "0x10C")]
		public static readonly LegacySoundStyle NPCDeath7;

		// Token: 0x04008203 RID: 33283
		[Token(Token = "0x4008203")]
		[FieldOffset(Offset = "0x110")]
		public static readonly LegacySoundStyle NPCDeath8;

		// Token: 0x04008204 RID: 33284
		[Token(Token = "0x4008204")]
		[FieldOffset(Offset = "0x114")]
		public static readonly LegacySoundStyle NPCDeath9;

		// Token: 0x04008205 RID: 33285
		[Token(Token = "0x4008205")]
		[FieldOffset(Offset = "0x118")]
		public static readonly LegacySoundStyle NPCDeath10;

		// Token: 0x04008206 RID: 33286
		[Token(Token = "0x4008206")]
		[FieldOffset(Offset = "0x11C")]
		public static readonly LegacySoundStyle NPCDeath11;

		// Token: 0x04008207 RID: 33287
		[Token(Token = "0x4008207")]
		[FieldOffset(Offset = "0x120")]
		public static readonly LegacySoundStyle NPCDeath12;

		// Token: 0x04008208 RID: 33288
		[Token(Token = "0x4008208")]
		[FieldOffset(Offset = "0x124")]
		public static readonly LegacySoundStyle NPCDeath13;

		// Token: 0x04008209 RID: 33289
		[Token(Token = "0x4008209")]
		[FieldOffset(Offset = "0x128")]
		public static readonly LegacySoundStyle NPCDeath14;

		// Token: 0x0400820A RID: 33290
		[Token(Token = "0x400820A")]
		[FieldOffset(Offset = "0x12C")]
		public static readonly LegacySoundStyle NPCDeath15;

		// Token: 0x0400820B RID: 33291
		[Token(Token = "0x400820B")]
		[FieldOffset(Offset = "0x130")]
		public static readonly LegacySoundStyle NPCDeath16;

		// Token: 0x0400820C RID: 33292
		[Token(Token = "0x400820C")]
		[FieldOffset(Offset = "0x134")]
		public static readonly LegacySoundStyle NPCDeath17;

		// Token: 0x0400820D RID: 33293
		[Token(Token = "0x400820D")]
		[FieldOffset(Offset = "0x138")]
		public static readonly LegacySoundStyle NPCDeath18;

		// Token: 0x0400820E RID: 33294
		[Token(Token = "0x400820E")]
		[FieldOffset(Offset = "0x13C")]
		public static readonly LegacySoundStyle NPCDeath19;

		// Token: 0x0400820F RID: 33295
		[Token(Token = "0x400820F")]
		[FieldOffset(Offset = "0x140")]
		public static readonly LegacySoundStyle NPCDeath20;

		// Token: 0x04008210 RID: 33296
		[Token(Token = "0x4008210")]
		[FieldOffset(Offset = "0x144")]
		public static readonly LegacySoundStyle NPCDeath21;

		// Token: 0x04008211 RID: 33297
		[Token(Token = "0x4008211")]
		[FieldOffset(Offset = "0x148")]
		public static readonly LegacySoundStyle NPCDeath22;

		// Token: 0x04008212 RID: 33298
		[Token(Token = "0x4008212")]
		[FieldOffset(Offset = "0x14C")]
		public static readonly LegacySoundStyle NPCDeath23;

		// Token: 0x04008213 RID: 33299
		[Token(Token = "0x4008213")]
		[FieldOffset(Offset = "0x150")]
		public static readonly LegacySoundStyle NPCDeath24;

		// Token: 0x04008214 RID: 33300
		[Token(Token = "0x4008214")]
		[FieldOffset(Offset = "0x154")]
		public static readonly LegacySoundStyle NPCDeath25;

		// Token: 0x04008215 RID: 33301
		[Token(Token = "0x4008215")]
		[FieldOffset(Offset = "0x158")]
		public static readonly LegacySoundStyle NPCDeath26;

		// Token: 0x04008216 RID: 33302
		[Token(Token = "0x4008216")]
		[FieldOffset(Offset = "0x15C")]
		public static readonly LegacySoundStyle NPCDeath27;

		// Token: 0x04008217 RID: 33303
		[Token(Token = "0x4008217")]
		[FieldOffset(Offset = "0x160")]
		public static readonly LegacySoundStyle NPCDeath28;

		// Token: 0x04008218 RID: 33304
		[Token(Token = "0x4008218")]
		[FieldOffset(Offset = "0x164")]
		public static readonly LegacySoundStyle NPCDeath29;

		// Token: 0x04008219 RID: 33305
		[Token(Token = "0x4008219")]
		[FieldOffset(Offset = "0x168")]
		public static readonly LegacySoundStyle NPCDeath30;

		// Token: 0x0400821A RID: 33306
		[Token(Token = "0x400821A")]
		[FieldOffset(Offset = "0x16C")]
		public static readonly LegacySoundStyle NPCDeath31;

		// Token: 0x0400821B RID: 33307
		[Token(Token = "0x400821B")]
		[FieldOffset(Offset = "0x170")]
		public static readonly LegacySoundStyle NPCDeath32;

		// Token: 0x0400821C RID: 33308
		[Token(Token = "0x400821C")]
		[FieldOffset(Offset = "0x174")]
		public static readonly LegacySoundStyle NPCDeath33;

		// Token: 0x0400821D RID: 33309
		[Token(Token = "0x400821D")]
		[FieldOffset(Offset = "0x178")]
		public static readonly LegacySoundStyle NPCDeath34;

		// Token: 0x0400821E RID: 33310
		[Token(Token = "0x400821E")]
		[FieldOffset(Offset = "0x17C")]
		public static readonly LegacySoundStyle NPCDeath35;

		// Token: 0x0400821F RID: 33311
		[Token(Token = "0x400821F")]
		[FieldOffset(Offset = "0x180")]
		public static readonly LegacySoundStyle NPCDeath36;

		// Token: 0x04008220 RID: 33312
		[Token(Token = "0x4008220")]
		[FieldOffset(Offset = "0x184")]
		public static readonly LegacySoundStyle NPCDeath37;

		// Token: 0x04008221 RID: 33313
		[Token(Token = "0x4008221")]
		[FieldOffset(Offset = "0x188")]
		public static readonly LegacySoundStyle NPCDeath38;

		// Token: 0x04008222 RID: 33314
		[Token(Token = "0x4008222")]
		[FieldOffset(Offset = "0x18C")]
		public static readonly LegacySoundStyle NPCDeath39;

		// Token: 0x04008223 RID: 33315
		[Token(Token = "0x4008223")]
		[FieldOffset(Offset = "0x190")]
		public static readonly LegacySoundStyle NPCDeath40;

		// Token: 0x04008224 RID: 33316
		[Token(Token = "0x4008224")]
		[FieldOffset(Offset = "0x194")]
		public static readonly LegacySoundStyle NPCDeath41;

		// Token: 0x04008225 RID: 33317
		[Token(Token = "0x4008225")]
		[FieldOffset(Offset = "0x198")]
		public static readonly LegacySoundStyle NPCDeath42;

		// Token: 0x04008226 RID: 33318
		[Token(Token = "0x4008226")]
		[FieldOffset(Offset = "0x19C")]
		public static readonly LegacySoundStyle NPCDeath43;

		// Token: 0x04008227 RID: 33319
		[Token(Token = "0x4008227")]
		[FieldOffset(Offset = "0x1A0")]
		public static readonly LegacySoundStyle NPCDeath44;

		// Token: 0x04008228 RID: 33320
		[Token(Token = "0x4008228")]
		[FieldOffset(Offset = "0x1A4")]
		public static readonly LegacySoundStyle NPCDeath45;

		// Token: 0x04008229 RID: 33321
		[Token(Token = "0x4008229")]
		[FieldOffset(Offset = "0x1A8")]
		public static readonly LegacySoundStyle NPCDeath46;

		// Token: 0x0400822A RID: 33322
		[Token(Token = "0x400822A")]
		[FieldOffset(Offset = "0x1AC")]
		public static readonly LegacySoundStyle NPCDeath47;

		// Token: 0x0400822B RID: 33323
		[Token(Token = "0x400822B")]
		[FieldOffset(Offset = "0x1B0")]
		public static readonly LegacySoundStyle NPCDeath48;

		// Token: 0x0400822C RID: 33324
		[Token(Token = "0x400822C")]
		[FieldOffset(Offset = "0x1B4")]
		public static readonly LegacySoundStyle NPCDeath49;

		// Token: 0x0400822D RID: 33325
		[Token(Token = "0x400822D")]
		[FieldOffset(Offset = "0x1B8")]
		public static readonly LegacySoundStyle NPCDeath50;

		// Token: 0x0400822E RID: 33326
		[Token(Token = "0x400822E")]
		[FieldOffset(Offset = "0x1BC")]
		public static readonly LegacySoundStyle NPCDeath51;

		// Token: 0x0400822F RID: 33327
		[Token(Token = "0x400822F")]
		[FieldOffset(Offset = "0x1C0")]
		public static readonly LegacySoundStyle NPCDeath52;

		// Token: 0x04008230 RID: 33328
		[Token(Token = "0x4008230")]
		[FieldOffset(Offset = "0x1C4")]
		public static readonly LegacySoundStyle NPCDeath53;

		// Token: 0x04008231 RID: 33329
		[Token(Token = "0x4008231")]
		[FieldOffset(Offset = "0x1C8")]
		public static readonly LegacySoundStyle NPCDeath54;

		// Token: 0x04008232 RID: 33330
		[Token(Token = "0x4008232")]
		[FieldOffset(Offset = "0x1CC")]
		public static readonly LegacySoundStyle NPCDeath55;

		// Token: 0x04008233 RID: 33331
		[Token(Token = "0x4008233")]
		[FieldOffset(Offset = "0x1D0")]
		public static readonly LegacySoundStyle NPCDeath56;

		// Token: 0x04008234 RID: 33332
		[Token(Token = "0x4008234")]
		[FieldOffset(Offset = "0x1D4")]
		public static readonly LegacySoundStyle NPCDeath57;

		// Token: 0x04008235 RID: 33333
		[Token(Token = "0x4008235")]
		[FieldOffset(Offset = "0x1D8")]
		public static readonly LegacySoundStyle NPCDeath58;

		// Token: 0x04008236 RID: 33334
		[Token(Token = "0x4008236")]
		[FieldOffset(Offset = "0x1DC")]
		public static readonly LegacySoundStyle NPCDeath59;

		// Token: 0x04008237 RID: 33335
		[Token(Token = "0x4008237")]
		[FieldOffset(Offset = "0x1E0")]
		public static readonly LegacySoundStyle NPCDeath60;

		// Token: 0x04008238 RID: 33336
		[Token(Token = "0x4008238")]
		[FieldOffset(Offset = "0x1E4")]
		public static readonly LegacySoundStyle NPCDeath61;

		// Token: 0x04008239 RID: 33337
		[Token(Token = "0x4008239")]
		[FieldOffset(Offset = "0x1E8")]
		public static readonly LegacySoundStyle NPCDeath62;

		// Token: 0x0400823A RID: 33338
		[Token(Token = "0x400823A")]
		[FieldOffset(Offset = "0x1EC")]
		public static readonly LegacySoundStyle NPCDeath63;

		// Token: 0x0400823B RID: 33339
		[Token(Token = "0x400823B")]
		[FieldOffset(Offset = "0x1F0")]
		public static readonly LegacySoundStyle NPCDeath64;

		// Token: 0x0400823C RID: 33340
		[Token(Token = "0x400823C")]
		[FieldOffset(Offset = "0x1F4")]
		public static readonly LegacySoundStyle NPCDeath65;

		// Token: 0x0400823D RID: 33341
		[Token(Token = "0x400823D")]
		[FieldOffset(Offset = "0x1F8")]
		public static readonly LegacySoundStyle NPCDeath66;

		// Token: 0x0400823E RID: 33342
		[Token(Token = "0x400823E")]
		[FieldOffset(Offset = "0x1FC")]
		public static readonly LegacySoundStyle NPCDeath67;

		// Token: 0x0400823F RID: 33343
		[Token(Token = "0x400823F")]
		[FieldOffset(Offset = "0x200")]
		public static readonly LegacySoundStyle NPCDeath68;

		// Token: 0x04008240 RID: 33344
		[Token(Token = "0x4008240")]
		[FieldOffset(Offset = "0x204")]
		public static short NPCDeathCount;

		// Token: 0x04008241 RID: 33345
		[Token(Token = "0x4008241")]
		[FieldOffset(Offset = "0x208")]
		public static readonly LegacySoundStyle Item1;

		// Token: 0x04008242 RID: 33346
		[Token(Token = "0x4008242")]
		[FieldOffset(Offset = "0x20C")]
		public static readonly LegacySoundStyle Item2;

		// Token: 0x04008243 RID: 33347
		[Token(Token = "0x4008243")]
		[FieldOffset(Offset = "0x210")]
		public static readonly LegacySoundStyle Item3;

		// Token: 0x04008244 RID: 33348
		[Token(Token = "0x4008244")]
		[FieldOffset(Offset = "0x214")]
		public static readonly LegacySoundStyle Item4;

		// Token: 0x04008245 RID: 33349
		[Token(Token = "0x4008245")]
		[FieldOffset(Offset = "0x218")]
		public static readonly LegacySoundStyle Item5;

		// Token: 0x04008246 RID: 33350
		[Token(Token = "0x4008246")]
		[FieldOffset(Offset = "0x21C")]
		public static readonly LegacySoundStyle Item6;

		// Token: 0x04008247 RID: 33351
		[Token(Token = "0x4008247")]
		[FieldOffset(Offset = "0x220")]
		public static readonly LegacySoundStyle Item7;

		// Token: 0x04008248 RID: 33352
		[Token(Token = "0x4008248")]
		[FieldOffset(Offset = "0x224")]
		public static readonly LegacySoundStyle Item8;

		// Token: 0x04008249 RID: 33353
		[Token(Token = "0x4008249")]
		[FieldOffset(Offset = "0x228")]
		public static readonly LegacySoundStyle Item9;

		// Token: 0x0400824A RID: 33354
		[Token(Token = "0x400824A")]
		[FieldOffset(Offset = "0x22C")]
		public static readonly LegacySoundStyle Item10;

		// Token: 0x0400824B RID: 33355
		[Token(Token = "0x400824B")]
		[FieldOffset(Offset = "0x230")]
		public static readonly LegacySoundStyle Item11;

		// Token: 0x0400824C RID: 33356
		[Token(Token = "0x400824C")]
		[FieldOffset(Offset = "0x234")]
		public static readonly LegacySoundStyle Item12;

		// Token: 0x0400824D RID: 33357
		[Token(Token = "0x400824D")]
		[FieldOffset(Offset = "0x238")]
		public static readonly LegacySoundStyle Item13;

		// Token: 0x0400824E RID: 33358
		[Token(Token = "0x400824E")]
		[FieldOffset(Offset = "0x23C")]
		public static readonly LegacySoundStyle Item14;

		// Token: 0x0400824F RID: 33359
		[Token(Token = "0x400824F")]
		[FieldOffset(Offset = "0x240")]
		public static readonly LegacySoundStyle Item15;

		// Token: 0x04008250 RID: 33360
		[Token(Token = "0x4008250")]
		[FieldOffset(Offset = "0x244")]
		public static readonly LegacySoundStyle Item16;

		// Token: 0x04008251 RID: 33361
		[Token(Token = "0x4008251")]
		[FieldOffset(Offset = "0x248")]
		public static readonly LegacySoundStyle Item17;

		// Token: 0x04008252 RID: 33362
		[Token(Token = "0x4008252")]
		[FieldOffset(Offset = "0x24C")]
		public static readonly LegacySoundStyle Item18;

		// Token: 0x04008253 RID: 33363
		[Token(Token = "0x4008253")]
		[FieldOffset(Offset = "0x250")]
		public static readonly LegacySoundStyle Item19;

		// Token: 0x04008254 RID: 33364
		[Token(Token = "0x4008254")]
		[FieldOffset(Offset = "0x254")]
		public static readonly LegacySoundStyle Item20;

		// Token: 0x04008255 RID: 33365
		[Token(Token = "0x4008255")]
		[FieldOffset(Offset = "0x258")]
		public static readonly LegacySoundStyle Item21;

		// Token: 0x04008256 RID: 33366
		[Token(Token = "0x4008256")]
		[FieldOffset(Offset = "0x25C")]
		public static readonly LegacySoundStyle Item22;

		// Token: 0x04008257 RID: 33367
		[Token(Token = "0x4008257")]
		[FieldOffset(Offset = "0x260")]
		public static readonly LegacySoundStyle Item23;

		// Token: 0x04008258 RID: 33368
		[Token(Token = "0x4008258")]
		[FieldOffset(Offset = "0x264")]
		public static readonly LegacySoundStyle Item24;

		// Token: 0x04008259 RID: 33369
		[Token(Token = "0x4008259")]
		[FieldOffset(Offset = "0x268")]
		public static readonly LegacySoundStyle Item25;

		// Token: 0x0400825A RID: 33370
		[Token(Token = "0x400825A")]
		[FieldOffset(Offset = "0x26C")]
		public static readonly LegacySoundStyle Item26;

		// Token: 0x0400825B RID: 33371
		[Token(Token = "0x400825B")]
		[FieldOffset(Offset = "0x270")]
		public static readonly LegacySoundStyle Item27;

		// Token: 0x0400825C RID: 33372
		[Token(Token = "0x400825C")]
		[FieldOffset(Offset = "0x274")]
		public static readonly LegacySoundStyle Item28;

		// Token: 0x0400825D RID: 33373
		[Token(Token = "0x400825D")]
		[FieldOffset(Offset = "0x278")]
		public static readonly LegacySoundStyle Item29;

		// Token: 0x0400825E RID: 33374
		[Token(Token = "0x400825E")]
		[FieldOffset(Offset = "0x27C")]
		public static readonly LegacySoundStyle Item30;

		// Token: 0x0400825F RID: 33375
		[Token(Token = "0x400825F")]
		[FieldOffset(Offset = "0x280")]
		public static readonly LegacySoundStyle Item31;

		// Token: 0x04008260 RID: 33376
		[Token(Token = "0x4008260")]
		[FieldOffset(Offset = "0x284")]
		public static readonly LegacySoundStyle Item32;

		// Token: 0x04008261 RID: 33377
		[Token(Token = "0x4008261")]
		[FieldOffset(Offset = "0x288")]
		public static readonly LegacySoundStyle Item33;

		// Token: 0x04008262 RID: 33378
		[Token(Token = "0x4008262")]
		[FieldOffset(Offset = "0x28C")]
		public static readonly LegacySoundStyle Item34;

		// Token: 0x04008263 RID: 33379
		[Token(Token = "0x4008263")]
		[FieldOffset(Offset = "0x290")]
		public static readonly LegacySoundStyle Item35;

		// Token: 0x04008264 RID: 33380
		[Token(Token = "0x4008264")]
		[FieldOffset(Offset = "0x294")]
		public static readonly LegacySoundStyle Item36;

		// Token: 0x04008265 RID: 33381
		[Token(Token = "0x4008265")]
		[FieldOffset(Offset = "0x298")]
		public static readonly LegacySoundStyle Item37;

		// Token: 0x04008266 RID: 33382
		[Token(Token = "0x4008266")]
		[FieldOffset(Offset = "0x29C")]
		public static readonly LegacySoundStyle Item38;

		// Token: 0x04008267 RID: 33383
		[Token(Token = "0x4008267")]
		[FieldOffset(Offset = "0x2A0")]
		public static readonly LegacySoundStyle Item39;

		// Token: 0x04008268 RID: 33384
		[Token(Token = "0x4008268")]
		[FieldOffset(Offset = "0x2A4")]
		public static readonly LegacySoundStyle Item40;

		// Token: 0x04008269 RID: 33385
		[Token(Token = "0x4008269")]
		[FieldOffset(Offset = "0x2A8")]
		public static readonly LegacySoundStyle Item41;

		// Token: 0x0400826A RID: 33386
		[Token(Token = "0x400826A")]
		[FieldOffset(Offset = "0x2AC")]
		public static readonly LegacySoundStyle Item42;

		// Token: 0x0400826B RID: 33387
		[Token(Token = "0x400826B")]
		[FieldOffset(Offset = "0x2B0")]
		public static readonly LegacySoundStyle Item43;

		// Token: 0x0400826C RID: 33388
		[Token(Token = "0x400826C")]
		[FieldOffset(Offset = "0x2B4")]
		public static readonly LegacySoundStyle Item44;

		// Token: 0x0400826D RID: 33389
		[Token(Token = "0x400826D")]
		[FieldOffset(Offset = "0x2B8")]
		public static readonly LegacySoundStyle Item45;

		// Token: 0x0400826E RID: 33390
		[Token(Token = "0x400826E")]
		[FieldOffset(Offset = "0x2BC")]
		public static readonly LegacySoundStyle Item46;

		// Token: 0x0400826F RID: 33391
		[Token(Token = "0x400826F")]
		[FieldOffset(Offset = "0x2C0")]
		public static readonly LegacySoundStyle Item47;

		// Token: 0x04008270 RID: 33392
		[Token(Token = "0x4008270")]
		[FieldOffset(Offset = "0x2C4")]
		public static readonly LegacySoundStyle Item48;

		// Token: 0x04008271 RID: 33393
		[Token(Token = "0x4008271")]
		[FieldOffset(Offset = "0x2C8")]
		public static readonly LegacySoundStyle Item49;

		// Token: 0x04008272 RID: 33394
		[Token(Token = "0x4008272")]
		[FieldOffset(Offset = "0x2CC")]
		public static readonly LegacySoundStyle Item50;

		// Token: 0x04008273 RID: 33395
		[Token(Token = "0x4008273")]
		[FieldOffset(Offset = "0x2D0")]
		public static readonly LegacySoundStyle Item51;

		// Token: 0x04008274 RID: 33396
		[Token(Token = "0x4008274")]
		[FieldOffset(Offset = "0x2D4")]
		public static readonly LegacySoundStyle Item52;

		// Token: 0x04008275 RID: 33397
		[Token(Token = "0x4008275")]
		[FieldOffset(Offset = "0x2D8")]
		public static readonly LegacySoundStyle Item53;

		// Token: 0x04008276 RID: 33398
		[Token(Token = "0x4008276")]
		[FieldOffset(Offset = "0x2DC")]
		public static readonly LegacySoundStyle Item54;

		// Token: 0x04008277 RID: 33399
		[Token(Token = "0x4008277")]
		[FieldOffset(Offset = "0x2E0")]
		public static readonly LegacySoundStyle Item55;

		// Token: 0x04008278 RID: 33400
		[Token(Token = "0x4008278")]
		[FieldOffset(Offset = "0x2E4")]
		public static readonly LegacySoundStyle Item56;

		// Token: 0x04008279 RID: 33401
		[Token(Token = "0x4008279")]
		[FieldOffset(Offset = "0x2E8")]
		public static readonly LegacySoundStyle Item57;

		// Token: 0x0400827A RID: 33402
		[Token(Token = "0x400827A")]
		[FieldOffset(Offset = "0x2EC")]
		public static readonly LegacySoundStyle Item58;

		// Token: 0x0400827B RID: 33403
		[Token(Token = "0x400827B")]
		[FieldOffset(Offset = "0x2F0")]
		public static readonly LegacySoundStyle Item59;

		// Token: 0x0400827C RID: 33404
		[Token(Token = "0x400827C")]
		[FieldOffset(Offset = "0x2F4")]
		public static readonly LegacySoundStyle Item60;

		// Token: 0x0400827D RID: 33405
		[Token(Token = "0x400827D")]
		[FieldOffset(Offset = "0x2F8")]
		public static readonly LegacySoundStyle Item61;

		// Token: 0x0400827E RID: 33406
		[Token(Token = "0x400827E")]
		[FieldOffset(Offset = "0x2FC")]
		public static readonly LegacySoundStyle Item62;

		// Token: 0x0400827F RID: 33407
		[Token(Token = "0x400827F")]
		[FieldOffset(Offset = "0x300")]
		public static readonly LegacySoundStyle Item63;

		// Token: 0x04008280 RID: 33408
		[Token(Token = "0x4008280")]
		[FieldOffset(Offset = "0x304")]
		public static readonly LegacySoundStyle Item64;

		// Token: 0x04008281 RID: 33409
		[Token(Token = "0x4008281")]
		[FieldOffset(Offset = "0x308")]
		public static readonly LegacySoundStyle Item65;

		// Token: 0x04008282 RID: 33410
		[Token(Token = "0x4008282")]
		[FieldOffset(Offset = "0x30C")]
		public static readonly LegacySoundStyle Item66;

		// Token: 0x04008283 RID: 33411
		[Token(Token = "0x4008283")]
		[FieldOffset(Offset = "0x310")]
		public static readonly LegacySoundStyle Item67;

		// Token: 0x04008284 RID: 33412
		[Token(Token = "0x4008284")]
		[FieldOffset(Offset = "0x314")]
		public static readonly LegacySoundStyle Item68;

		// Token: 0x04008285 RID: 33413
		[Token(Token = "0x4008285")]
		[FieldOffset(Offset = "0x318")]
		public static readonly LegacySoundStyle Item69;

		// Token: 0x04008286 RID: 33414
		[Token(Token = "0x4008286")]
		[FieldOffset(Offset = "0x31C")]
		public static readonly LegacySoundStyle Item70;

		// Token: 0x04008287 RID: 33415
		[Token(Token = "0x4008287")]
		[FieldOffset(Offset = "0x320")]
		public static readonly LegacySoundStyle Item71;

		// Token: 0x04008288 RID: 33416
		[Token(Token = "0x4008288")]
		[FieldOffset(Offset = "0x324")]
		public static readonly LegacySoundStyle Item72;

		// Token: 0x04008289 RID: 33417
		[Token(Token = "0x4008289")]
		[FieldOffset(Offset = "0x328")]
		public static readonly LegacySoundStyle Item73;

		// Token: 0x0400828A RID: 33418
		[Token(Token = "0x400828A")]
		[FieldOffset(Offset = "0x32C")]
		public static readonly LegacySoundStyle Item74;

		// Token: 0x0400828B RID: 33419
		[Token(Token = "0x400828B")]
		[FieldOffset(Offset = "0x330")]
		public static readonly LegacySoundStyle Item75;

		// Token: 0x0400828C RID: 33420
		[Token(Token = "0x400828C")]
		[FieldOffset(Offset = "0x334")]
		public static readonly LegacySoundStyle Item76;

		// Token: 0x0400828D RID: 33421
		[Token(Token = "0x400828D")]
		[FieldOffset(Offset = "0x338")]
		public static readonly LegacySoundStyle Item77;

		// Token: 0x0400828E RID: 33422
		[Token(Token = "0x400828E")]
		[FieldOffset(Offset = "0x33C")]
		public static readonly LegacySoundStyle Item78;

		// Token: 0x0400828F RID: 33423
		[Token(Token = "0x400828F")]
		[FieldOffset(Offset = "0x340")]
		public static readonly LegacySoundStyle Item79;

		// Token: 0x04008290 RID: 33424
		[Token(Token = "0x4008290")]
		[FieldOffset(Offset = "0x344")]
		public static readonly LegacySoundStyle Item80;

		// Token: 0x04008291 RID: 33425
		[Token(Token = "0x4008291")]
		[FieldOffset(Offset = "0x348")]
		public static readonly LegacySoundStyle Item81;

		// Token: 0x04008292 RID: 33426
		[Token(Token = "0x4008292")]
		[FieldOffset(Offset = "0x34C")]
		public static readonly LegacySoundStyle Item82;

		// Token: 0x04008293 RID: 33427
		[Token(Token = "0x4008293")]
		[FieldOffset(Offset = "0x350")]
		public static readonly LegacySoundStyle Item83;

		// Token: 0x04008294 RID: 33428
		[Token(Token = "0x4008294")]
		[FieldOffset(Offset = "0x354")]
		public static readonly LegacySoundStyle Item84;

		// Token: 0x04008295 RID: 33429
		[Token(Token = "0x4008295")]
		[FieldOffset(Offset = "0x358")]
		public static readonly LegacySoundStyle Item85;

		// Token: 0x04008296 RID: 33430
		[Token(Token = "0x4008296")]
		[FieldOffset(Offset = "0x35C")]
		public static readonly LegacySoundStyle Item86;

		// Token: 0x04008297 RID: 33431
		[Token(Token = "0x4008297")]
		[FieldOffset(Offset = "0x360")]
		public static readonly LegacySoundStyle Item87;

		// Token: 0x04008298 RID: 33432
		[Token(Token = "0x4008298")]
		[FieldOffset(Offset = "0x364")]
		public static readonly LegacySoundStyle Item88;

		// Token: 0x04008299 RID: 33433
		[Token(Token = "0x4008299")]
		[FieldOffset(Offset = "0x368")]
		public static readonly LegacySoundStyle Item89;

		// Token: 0x0400829A RID: 33434
		[Token(Token = "0x400829A")]
		[FieldOffset(Offset = "0x36C")]
		public static readonly LegacySoundStyle Item90;

		// Token: 0x0400829B RID: 33435
		[Token(Token = "0x400829B")]
		[FieldOffset(Offset = "0x370")]
		public static readonly LegacySoundStyle Item91;

		// Token: 0x0400829C RID: 33436
		[Token(Token = "0x400829C")]
		[FieldOffset(Offset = "0x374")]
		public static readonly LegacySoundStyle Item92;

		// Token: 0x0400829D RID: 33437
		[Token(Token = "0x400829D")]
		[FieldOffset(Offset = "0x378")]
		public static readonly LegacySoundStyle Item93;

		// Token: 0x0400829E RID: 33438
		[Token(Token = "0x400829E")]
		[FieldOffset(Offset = "0x37C")]
		public static readonly LegacySoundStyle Item94;

		// Token: 0x0400829F RID: 33439
		[Token(Token = "0x400829F")]
		[FieldOffset(Offset = "0x380")]
		public static readonly LegacySoundStyle Item95;

		// Token: 0x040082A0 RID: 33440
		[Token(Token = "0x40082A0")]
		[FieldOffset(Offset = "0x384")]
		public static readonly LegacySoundStyle Item96;

		// Token: 0x040082A1 RID: 33441
		[Token(Token = "0x40082A1")]
		[FieldOffset(Offset = "0x388")]
		public static readonly LegacySoundStyle Item97;

		// Token: 0x040082A2 RID: 33442
		[Token(Token = "0x40082A2")]
		[FieldOffset(Offset = "0x38C")]
		public static readonly LegacySoundStyle Item98;

		// Token: 0x040082A3 RID: 33443
		[Token(Token = "0x40082A3")]
		[FieldOffset(Offset = "0x390")]
		public static readonly LegacySoundStyle Item99;

		// Token: 0x040082A4 RID: 33444
		[Token(Token = "0x40082A4")]
		[FieldOffset(Offset = "0x394")]
		public static readonly LegacySoundStyle Item100;

		// Token: 0x040082A5 RID: 33445
		[Token(Token = "0x40082A5")]
		[FieldOffset(Offset = "0x398")]
		public static readonly LegacySoundStyle Item101;

		// Token: 0x040082A6 RID: 33446
		[Token(Token = "0x40082A6")]
		[FieldOffset(Offset = "0x39C")]
		public static readonly LegacySoundStyle Item102;

		// Token: 0x040082A7 RID: 33447
		[Token(Token = "0x40082A7")]
		[FieldOffset(Offset = "0x3A0")]
		public static readonly LegacySoundStyle Item103;

		// Token: 0x040082A8 RID: 33448
		[Token(Token = "0x40082A8")]
		[FieldOffset(Offset = "0x3A4")]
		public static readonly LegacySoundStyle Item104;

		// Token: 0x040082A9 RID: 33449
		[Token(Token = "0x40082A9")]
		[FieldOffset(Offset = "0x3A8")]
		public static readonly LegacySoundStyle Item105;

		// Token: 0x040082AA RID: 33450
		[Token(Token = "0x40082AA")]
		[FieldOffset(Offset = "0x3AC")]
		public static readonly LegacySoundStyle Item106;

		// Token: 0x040082AB RID: 33451
		[Token(Token = "0x40082AB")]
		[FieldOffset(Offset = "0x3B0")]
		public static readonly LegacySoundStyle Item107;

		// Token: 0x040082AC RID: 33452
		[Token(Token = "0x40082AC")]
		[FieldOffset(Offset = "0x3B4")]
		public static readonly LegacySoundStyle Item108;

		// Token: 0x040082AD RID: 33453
		[Token(Token = "0x40082AD")]
		[FieldOffset(Offset = "0x3B8")]
		public static readonly LegacySoundStyle Item109;

		// Token: 0x040082AE RID: 33454
		[Token(Token = "0x40082AE")]
		[FieldOffset(Offset = "0x3BC")]
		public static readonly LegacySoundStyle Item110;

		// Token: 0x040082AF RID: 33455
		[Token(Token = "0x40082AF")]
		[FieldOffset(Offset = "0x3C0")]
		public static readonly LegacySoundStyle Item111;

		// Token: 0x040082B0 RID: 33456
		[Token(Token = "0x40082B0")]
		[FieldOffset(Offset = "0x3C4")]
		public static readonly LegacySoundStyle Item112;

		// Token: 0x040082B1 RID: 33457
		[Token(Token = "0x40082B1")]
		[FieldOffset(Offset = "0x3C8")]
		public static readonly LegacySoundStyle Item113;

		// Token: 0x040082B2 RID: 33458
		[Token(Token = "0x40082B2")]
		[FieldOffset(Offset = "0x3CC")]
		public static readonly LegacySoundStyle Item113_Quiet;

		// Token: 0x040082B3 RID: 33459
		[Token(Token = "0x40082B3")]
		[FieldOffset(Offset = "0x3D0")]
		public static readonly LegacySoundStyle Item114;

		// Token: 0x040082B4 RID: 33460
		[Token(Token = "0x40082B4")]
		[FieldOffset(Offset = "0x3D4")]
		public static readonly LegacySoundStyle Item115;

		// Token: 0x040082B5 RID: 33461
		[Token(Token = "0x40082B5")]
		[FieldOffset(Offset = "0x3D8")]
		public static readonly LegacySoundStyle Item116;

		// Token: 0x040082B6 RID: 33462
		[Token(Token = "0x40082B6")]
		[FieldOffset(Offset = "0x3DC")]
		public static readonly LegacySoundStyle Item117;

		// Token: 0x040082B7 RID: 33463
		[Token(Token = "0x40082B7")]
		[FieldOffset(Offset = "0x3E0")]
		public static readonly LegacySoundStyle Item118;

		// Token: 0x040082B8 RID: 33464
		[Token(Token = "0x40082B8")]
		[FieldOffset(Offset = "0x3E4")]
		public static readonly LegacySoundStyle Item119;

		// Token: 0x040082B9 RID: 33465
		[Token(Token = "0x40082B9")]
		[FieldOffset(Offset = "0x3E8")]
		public static readonly LegacySoundStyle Item120;

		// Token: 0x040082BA RID: 33466
		[Token(Token = "0x40082BA")]
		[FieldOffset(Offset = "0x3EC")]
		public static readonly LegacySoundStyle Item121;

		// Token: 0x040082BB RID: 33467
		[Token(Token = "0x40082BB")]
		[FieldOffset(Offset = "0x3F0")]
		public static readonly LegacySoundStyle Item122;

		// Token: 0x040082BC RID: 33468
		[Token(Token = "0x40082BC")]
		[FieldOffset(Offset = "0x3F4")]
		public static readonly LegacySoundStyle Item123;

		// Token: 0x040082BD RID: 33469
		[Token(Token = "0x40082BD")]
		[FieldOffset(Offset = "0x3F8")]
		public static readonly LegacySoundStyle Item124;

		// Token: 0x040082BE RID: 33470
		[Token(Token = "0x40082BE")]
		[FieldOffset(Offset = "0x3FC")]
		public static readonly LegacySoundStyle Item125;

		// Token: 0x040082BF RID: 33471
		[Token(Token = "0x40082BF")]
		[FieldOffset(Offset = "0x400")]
		public static readonly LegacySoundStyle Item126;

		// Token: 0x040082C0 RID: 33472
		[Token(Token = "0x40082C0")]
		[FieldOffset(Offset = "0x404")]
		public static readonly LegacySoundStyle Item127;

		// Token: 0x040082C1 RID: 33473
		[Token(Token = "0x40082C1")]
		[FieldOffset(Offset = "0x408")]
		public static readonly LegacySoundStyle Item128;

		// Token: 0x040082C2 RID: 33474
		[Token(Token = "0x40082C2")]
		[FieldOffset(Offset = "0x40C")]
		public static readonly LegacySoundStyle Item129;

		// Token: 0x040082C3 RID: 33475
		[Token(Token = "0x40082C3")]
		[FieldOffset(Offset = "0x410")]
		public static readonly LegacySoundStyle Item130;

		// Token: 0x040082C4 RID: 33476
		[Token(Token = "0x40082C4")]
		[FieldOffset(Offset = "0x414")]
		public static readonly LegacySoundStyle Item131;

		// Token: 0x040082C5 RID: 33477
		[Token(Token = "0x40082C5")]
		[FieldOffset(Offset = "0x418")]
		public static readonly LegacySoundStyle Item132;

		// Token: 0x040082C6 RID: 33478
		[Token(Token = "0x40082C6")]
		[FieldOffset(Offset = "0x41C")]
		public static readonly LegacySoundStyle Item133;

		// Token: 0x040082C7 RID: 33479
		[Token(Token = "0x40082C7")]
		[FieldOffset(Offset = "0x420")]
		public static readonly LegacySoundStyle Item134;

		// Token: 0x040082C8 RID: 33480
		[Token(Token = "0x40082C8")]
		[FieldOffset(Offset = "0x424")]
		public static readonly LegacySoundStyle Item135;

		// Token: 0x040082C9 RID: 33481
		[Token(Token = "0x40082C9")]
		[FieldOffset(Offset = "0x428")]
		public static readonly LegacySoundStyle Item136;

		// Token: 0x040082CA RID: 33482
		[Token(Token = "0x40082CA")]
		[FieldOffset(Offset = "0x42C")]
		public static readonly LegacySoundStyle Item137;

		// Token: 0x040082CB RID: 33483
		[Token(Token = "0x40082CB")]
		[FieldOffset(Offset = "0x430")]
		public static readonly LegacySoundStyle Item138;

		// Token: 0x040082CC RID: 33484
		[Token(Token = "0x40082CC")]
		[FieldOffset(Offset = "0x434")]
		public static readonly LegacySoundStyle Item139;

		// Token: 0x040082CD RID: 33485
		[Token(Token = "0x40082CD")]
		[FieldOffset(Offset = "0x438")]
		public static readonly LegacySoundStyle Item140;

		// Token: 0x040082CE RID: 33486
		[Token(Token = "0x40082CE")]
		[FieldOffset(Offset = "0x43C")]
		public static readonly LegacySoundStyle Item141;

		// Token: 0x040082CF RID: 33487
		[Token(Token = "0x40082CF")]
		[FieldOffset(Offset = "0x440")]
		public static readonly LegacySoundStyle Item142;

		// Token: 0x040082D0 RID: 33488
		[Token(Token = "0x40082D0")]
		[FieldOffset(Offset = "0x444")]
		public static readonly LegacySoundStyle Item143;

		// Token: 0x040082D1 RID: 33489
		[Token(Token = "0x40082D1")]
		[FieldOffset(Offset = "0x448")]
		public static readonly LegacySoundStyle Item144;

		// Token: 0x040082D2 RID: 33490
		[Token(Token = "0x40082D2")]
		[FieldOffset(Offset = "0x44C")]
		public static readonly LegacySoundStyle Item145;

		// Token: 0x040082D3 RID: 33491
		[Token(Token = "0x40082D3")]
		[FieldOffset(Offset = "0x450")]
		public static readonly LegacySoundStyle Item146;

		// Token: 0x040082D4 RID: 33492
		[Token(Token = "0x40082D4")]
		[FieldOffset(Offset = "0x454")]
		public static readonly LegacySoundStyle Item147;

		// Token: 0x040082D5 RID: 33493
		[Token(Token = "0x40082D5")]
		[FieldOffset(Offset = "0x458")]
		public static readonly LegacySoundStyle Item148;

		// Token: 0x040082D6 RID: 33494
		[Token(Token = "0x40082D6")]
		[FieldOffset(Offset = "0x45C")]
		public static readonly LegacySoundStyle Item149;

		// Token: 0x040082D7 RID: 33495
		[Token(Token = "0x40082D7")]
		[FieldOffset(Offset = "0x460")]
		public static readonly LegacySoundStyle Item150;

		// Token: 0x040082D8 RID: 33496
		[Token(Token = "0x40082D8")]
		[FieldOffset(Offset = "0x464")]
		public static readonly LegacySoundStyle Item151;

		// Token: 0x040082D9 RID: 33497
		[Token(Token = "0x40082D9")]
		[FieldOffset(Offset = "0x468")]
		public static readonly LegacySoundStyle Item152;

		// Token: 0x040082DA RID: 33498
		[Token(Token = "0x40082DA")]
		[FieldOffset(Offset = "0x46C")]
		public static readonly LegacySoundStyle Item153;

		// Token: 0x040082DB RID: 33499
		[Token(Token = "0x40082DB")]
		[FieldOffset(Offset = "0x470")]
		public static readonly LegacySoundStyle Item154;

		// Token: 0x040082DC RID: 33500
		[Token(Token = "0x40082DC")]
		[FieldOffset(Offset = "0x474")]
		public static readonly LegacySoundStyle Item155;

		// Token: 0x040082DD RID: 33501
		[Token(Token = "0x40082DD")]
		[FieldOffset(Offset = "0x478")]
		public static readonly LegacySoundStyle Item156;

		// Token: 0x040082DE RID: 33502
		[Token(Token = "0x40082DE")]
		[FieldOffset(Offset = "0x47C")]
		public static readonly LegacySoundStyle Item157;

		// Token: 0x040082DF RID: 33503
		[Token(Token = "0x40082DF")]
		[FieldOffset(Offset = "0x480")]
		public static readonly LegacySoundStyle Item158;

		// Token: 0x040082E0 RID: 33504
		[Token(Token = "0x40082E0")]
		[FieldOffset(Offset = "0x484")]
		public static readonly LegacySoundStyle Item159;

		// Token: 0x040082E1 RID: 33505
		[Token(Token = "0x40082E1")]
		[FieldOffset(Offset = "0x488")]
		public static readonly LegacySoundStyle Item160;

		// Token: 0x040082E2 RID: 33506
		[Token(Token = "0x40082E2")]
		[FieldOffset(Offset = "0x48C")]
		public static readonly LegacySoundStyle Item161;

		// Token: 0x040082E3 RID: 33507
		[Token(Token = "0x40082E3")]
		[FieldOffset(Offset = "0x490")]
		public static readonly LegacySoundStyle Item162;

		// Token: 0x040082E4 RID: 33508
		[Token(Token = "0x40082E4")]
		[FieldOffset(Offset = "0x494")]
		public static readonly LegacySoundStyle Item163;

		// Token: 0x040082E5 RID: 33509
		[Token(Token = "0x40082E5")]
		[FieldOffset(Offset = "0x498")]
		public static readonly LegacySoundStyle Item164;

		// Token: 0x040082E6 RID: 33510
		[Token(Token = "0x40082E6")]
		[FieldOffset(Offset = "0x49C")]
		public static readonly LegacySoundStyle Item165;

		// Token: 0x040082E7 RID: 33511
		[Token(Token = "0x40082E7")]
		[FieldOffset(Offset = "0x4A0")]
		public static readonly LegacySoundStyle Item166;

		// Token: 0x040082E8 RID: 33512
		[Token(Token = "0x40082E8")]
		[FieldOffset(Offset = "0x4A4")]
		public static readonly LegacySoundStyle Item167;

		// Token: 0x040082E9 RID: 33513
		[Token(Token = "0x40082E9")]
		[FieldOffset(Offset = "0x4A8")]
		public static readonly LegacySoundStyle Item168;

		// Token: 0x040082EA RID: 33514
		[Token(Token = "0x40082EA")]
		[FieldOffset(Offset = "0x4AC")]
		public static readonly LegacySoundStyle Item169;

		// Token: 0x040082EB RID: 33515
		[Token(Token = "0x40082EB")]
		[FieldOffset(Offset = "0x4B0")]
		public static readonly LegacySoundStyle Item170;

		// Token: 0x040082EC RID: 33516
		[Token(Token = "0x40082EC")]
		[FieldOffset(Offset = "0x4B4")]
		public static readonly LegacySoundStyle Item171;

		// Token: 0x040082ED RID: 33517
		[Token(Token = "0x40082ED")]
		[FieldOffset(Offset = "0x4B8")]
		public static readonly LegacySoundStyle Item172;

		// Token: 0x040082EE RID: 33518
		[Token(Token = "0x40082EE")]
		[FieldOffset(Offset = "0x4BC")]
		public static readonly LegacySoundStyle Item173;

		// Token: 0x040082EF RID: 33519
		[Token(Token = "0x40082EF")]
		[FieldOffset(Offset = "0x4C0")]
		public static readonly LegacySoundStyle Item174;

		// Token: 0x040082F0 RID: 33520
		[Token(Token = "0x40082F0")]
		[FieldOffset(Offset = "0x4C4")]
		public static readonly LegacySoundStyle Item175;

		// Token: 0x040082F1 RID: 33521
		[Token(Token = "0x40082F1")]
		[FieldOffset(Offset = "0x4C8")]
		public static readonly LegacySoundStyle Item176;

		// Token: 0x040082F2 RID: 33522
		[Token(Token = "0x40082F2")]
		[FieldOffset(Offset = "0x4CC")]
		public static readonly LegacySoundStyle Item177;

		// Token: 0x040082F3 RID: 33523
		[Token(Token = "0x40082F3")]
		[FieldOffset(Offset = "0x4D0")]
		public static readonly LegacySoundStyle Item178;

		// Token: 0x040082F4 RID: 33524
		[Token(Token = "0x40082F4")]
		[FieldOffset(Offset = "0x4D4")]
		public static readonly LegacySoundStyle Item179;

		// Token: 0x040082F5 RID: 33525
		[Token(Token = "0x40082F5")]
		[FieldOffset(Offset = "0x4D8")]
		public static readonly LegacySoundStyle Item180;

		// Token: 0x040082F6 RID: 33526
		[Token(Token = "0x40082F6")]
		[FieldOffset(Offset = "0x4DC")]
		public static readonly LegacySoundStyle Item181;

		// Token: 0x040082F7 RID: 33527
		[Token(Token = "0x40082F7")]
		[FieldOffset(Offset = "0x4E0")]
		public static readonly LegacySoundStyle Item182;

		// Token: 0x040082F8 RID: 33528
		[Token(Token = "0x40082F8")]
		[FieldOffset(Offset = "0x4E4")]
		public static readonly LegacySoundStyle Item183;

		// Token: 0x040082F9 RID: 33529
		[Token(Token = "0x40082F9")]
		[FieldOffset(Offset = "0x4E8")]
		public static readonly LegacySoundStyle Item184;

		// Token: 0x040082FA RID: 33530
		[Token(Token = "0x40082FA")]
		[FieldOffset(Offset = "0x4EC")]
		public static readonly LegacySoundStyle Item185;

		// Token: 0x040082FB RID: 33531
		[Token(Token = "0x40082FB")]
		[FieldOffset(Offset = "0x4F0")]
		public static readonly LegacySoundStyle Item186;

		// Token: 0x040082FC RID: 33532
		[Token(Token = "0x40082FC")]
		[FieldOffset(Offset = "0x4F4")]
		public static readonly LegacySoundStyle Item187;

		// Token: 0x040082FD RID: 33533
		[Token(Token = "0x40082FD")]
		[FieldOffset(Offset = "0x4F8")]
		public static readonly LegacySoundStyle Item188;

		// Token: 0x040082FE RID: 33534
		[Token(Token = "0x40082FE")]
		[FieldOffset(Offset = "0x4FC")]
		public static readonly LegacySoundStyle Item189;

		// Token: 0x040082FF RID: 33535
		[Token(Token = "0x40082FF")]
		[FieldOffset(Offset = "0x500")]
		public static readonly LegacySoundStyle Item190;

		// Token: 0x04008300 RID: 33536
		[Token(Token = "0x4008300")]
		[FieldOffset(Offset = "0x504")]
		public static readonly LegacySoundStyle Item191;

		// Token: 0x04008301 RID: 33537
		[Token(Token = "0x4008301")]
		[FieldOffset(Offset = "0x508")]
		public static readonly LegacySoundStyle Item192;

		// Token: 0x04008302 RID: 33538
		[Token(Token = "0x4008302")]
		[FieldOffset(Offset = "0x50C")]
		public static readonly LegacySoundStyle Item193;

		// Token: 0x04008303 RID: 33539
		[Token(Token = "0x4008303")]
		[FieldOffset(Offset = "0x510")]
		public static readonly LegacySoundStyle Item194;

		// Token: 0x04008304 RID: 33540
		[Token(Token = "0x4008304")]
		[FieldOffset(Offset = "0x514")]
		public static readonly LegacySoundStyle Item195;

		// Token: 0x04008305 RID: 33541
		[Token(Token = "0x4008305")]
		[FieldOffset(Offset = "0x518")]
		public static readonly LegacySoundStyle Item196;

		// Token: 0x04008306 RID: 33542
		[Token(Token = "0x4008306")]
		[FieldOffset(Offset = "0x51C")]
		public static readonly LegacySoundStyle Item197;

		// Token: 0x04008307 RID: 33543
		[Token(Token = "0x4008307")]
		[FieldOffset(Offset = "0x520")]
		public static readonly LegacySoundStyle Item198;

		// Token: 0x04008308 RID: 33544
		[Token(Token = "0x4008308")]
		[FieldOffset(Offset = "0x524")]
		public static readonly LegacySoundStyle Item199;

		// Token: 0x04008309 RID: 33545
		[Token(Token = "0x4008309")]
		[FieldOffset(Offset = "0x528")]
		public static readonly LegacySoundStyle MysticBloom;

		// Token: 0x0400830A RID: 33546
		[Token(Token = "0x400830A")]
		[FieldOffset(Offset = "0x52C")]
		public static readonly LegacySoundStyle GlacierFang_Muzzle;

		// Token: 0x0400830B RID: 33547
		[Token(Token = "0x400830B")]
		[FieldOffset(Offset = "0x530")]
		public static readonly LegacySoundStyle Unused;

		// Token: 0x0400830C RID: 33548
		[Token(Token = "0x400830C")]
		[FieldOffset(Offset = "0x534")]
		public static readonly LegacySoundStyle ArcSurge;

		// Token: 0x0400830D RID: 33549
		[Token(Token = "0x400830D")]
		[FieldOffset(Offset = "0x538")]
		public static readonly LegacySoundStyle LightningStrikeHit;

		// Token: 0x0400830E RID: 33550
		[Token(Token = "0x400830E")]
		[FieldOffset(Offset = "0x53C")]
		public static readonly LegacySoundStyle StackableItem8ForRubyStaff;

		// Token: 0x0400830F RID: 33551
		[Token(Token = "0x400830F")]
		[FieldOffset(Offset = "0x540")]
		public static readonly LegacySoundStyle PyroclasticStone;

		// Token: 0x04008310 RID: 33552
		[Token(Token = "0x4008310")]
		[FieldOffset(Offset = "0x544")]
		public static readonly LegacySoundStyle ArmletOfRuin;

		// Token: 0x04008311 RID: 33553
		[Token(Token = "0x4008311")]
		[FieldOffset(Offset = "0x548")]
		public static readonly LegacySoundStyle Unused2;

		// Token: 0x04008312 RID: 33554
		[Token(Token = "0x4008312")]
		[FieldOffset(Offset = "0x54C")]
		public static readonly LegacySoundStyle Unused3;

		// Token: 0x04008313 RID: 33555
		[Token(Token = "0x4008313")]
		[FieldOffset(Offset = "0x550")]
		public static readonly LegacySoundStyle GlacierFang_Charging;

		// Token: 0x04008314 RID: 33556
		[Token(Token = "0x4008314")]
		[FieldOffset(Offset = "0x554")]
		public static short ItemSoundCount;

		// Token: 0x04008315 RID: 33557
		[Token(Token = "0x4008315")]
		[FieldOffset(Offset = "0x558")]
		public static readonly LegacySoundStyle DD2_GoblinBomb;

		// Token: 0x04008316 RID: 33558
		[Token(Token = "0x4008316")]
		[FieldOffset(Offset = "0x55C")]
		public static readonly LegacySoundStyle AchievementComplete;

		// Token: 0x04008317 RID: 33559
		[Token(Token = "0x4008317")]
		[FieldOffset(Offset = "0x560")]
		public static readonly LegacySoundStyle BlizzardInsideBuildingLoop;

		// Token: 0x04008318 RID: 33560
		[Token(Token = "0x4008318")]
		[FieldOffset(Offset = "0x564")]
		public static readonly LegacySoundStyle BlizzardStrongLoop;

		// Token: 0x04008319 RID: 33561
		[Token(Token = "0x4008319")]
		[FieldOffset(Offset = "0x568")]
		public static readonly LegacySoundStyle LiquidsHoneyWater;

		// Token: 0x0400831A RID: 33562
		[Token(Token = "0x400831A")]
		[FieldOffset(Offset = "0x56C")]
		public static readonly LegacySoundStyle LiquidsHoneyLava;

		// Token: 0x0400831B RID: 33563
		[Token(Token = "0x400831B")]
		[FieldOffset(Offset = "0x570")]
		public static readonly LegacySoundStyle LiquidsWaterLava;

		// Token: 0x0400831C RID: 33564
		[Token(Token = "0x400831C")]
		[FieldOffset(Offset = "0x574")]
		public static readonly LegacySoundStyle DD2_BallistaTowerShot;

		// Token: 0x0400831D RID: 33565
		[Token(Token = "0x400831D")]
		[FieldOffset(Offset = "0x578")]
		public static readonly LegacySoundStyle DD2_ExplosiveTrapExplode;

		// Token: 0x0400831E RID: 33566
		[Token(Token = "0x400831E")]
		[FieldOffset(Offset = "0x57C")]
		public static readonly LegacySoundStyle DD2_FlameburstTowerShot;

		// Token: 0x0400831F RID: 33567
		[Token(Token = "0x400831F")]
		[FieldOffset(Offset = "0x580")]
		public static readonly LegacySoundStyle DD2_LightningAuraZap;

		// Token: 0x04008320 RID: 33568
		[Token(Token = "0x4008320")]
		[FieldOffset(Offset = "0x584")]
		public static readonly LegacySoundStyle DD2_DefenseTowerSpawn;

		// Token: 0x04008321 RID: 33569
		[Token(Token = "0x4008321")]
		[FieldOffset(Offset = "0x588")]
		public static readonly LegacySoundStyle DD2_BetsyDeath;

		// Token: 0x04008322 RID: 33570
		[Token(Token = "0x4008322")]
		[FieldOffset(Offset = "0x58C")]
		public static readonly LegacySoundStyle DD2_BetsyFireballShot;

		// Token: 0x04008323 RID: 33571
		[Token(Token = "0x4008323")]
		[FieldOffset(Offset = "0x590")]
		public static readonly LegacySoundStyle DD2_BetsyFireballImpact;

		// Token: 0x04008324 RID: 33572
		[Token(Token = "0x4008324")]
		[FieldOffset(Offset = "0x594")]
		public static readonly LegacySoundStyle DD2_BetsyFlameBreath;

		// Token: 0x04008325 RID: 33573
		[Token(Token = "0x4008325")]
		[FieldOffset(Offset = "0x598")]
		public static readonly LegacySoundStyle DD2_BetsyFlyingCircleAttack;

		// Token: 0x04008326 RID: 33574
		[Token(Token = "0x4008326")]
		[FieldOffset(Offset = "0x59C")]
		public static readonly LegacySoundStyle DD2_BetsyHurt;

		// Token: 0x04008327 RID: 33575
		[Token(Token = "0x4008327")]
		[FieldOffset(Offset = "0x5A0")]
		public static readonly LegacySoundStyle DD2_BetsyScream;

		// Token: 0x04008328 RID: 33576
		[Token(Token = "0x4008328")]
		[FieldOffset(Offset = "0x5A4")]
		public static readonly LegacySoundStyle DD2_BetsySummon;

		// Token: 0x04008329 RID: 33577
		[Token(Token = "0x4008329")]
		[FieldOffset(Offset = "0x5A8")]
		public static readonly LegacySoundStyle DD2_BetsyWindAttack;

		// Token: 0x0400832A RID: 33578
		[Token(Token = "0x400832A")]
		[FieldOffset(Offset = "0x5AC")]
		public static readonly LegacySoundStyle DD2_DarkMageAttack;

		// Token: 0x0400832B RID: 33579
		[Token(Token = "0x400832B")]
		[FieldOffset(Offset = "0x5B0")]
		public static readonly LegacySoundStyle DD2_DarkMageCastHeal;

		// Token: 0x0400832C RID: 33580
		[Token(Token = "0x400832C")]
		[FieldOffset(Offset = "0x5B4")]
		public static readonly LegacySoundStyle DD2_DarkMageDeath;

		// Token: 0x0400832D RID: 33581
		[Token(Token = "0x400832D")]
		[FieldOffset(Offset = "0x5B8")]
		public static readonly LegacySoundStyle DD2_DarkMageHealImpact;

		// Token: 0x0400832E RID: 33582
		[Token(Token = "0x400832E")]
		[FieldOffset(Offset = "0x5BC")]
		public static readonly LegacySoundStyle DD2_DarkMageHurt;

		// Token: 0x0400832F RID: 33583
		[Token(Token = "0x400832F")]
		[FieldOffset(Offset = "0x5C0")]
		public static readonly LegacySoundStyle DD2_DarkMageSummonSkeleton;

		// Token: 0x04008330 RID: 33584
		[Token(Token = "0x4008330")]
		[FieldOffset(Offset = "0x5C4")]
		public static readonly LegacySoundStyle DD2_DrakinBreathIn;

		// Token: 0x04008331 RID: 33585
		[Token(Token = "0x4008331")]
		[FieldOffset(Offset = "0x5C8")]
		public static readonly LegacySoundStyle DD2_DrakinDeath;

		// Token: 0x04008332 RID: 33586
		[Token(Token = "0x4008332")]
		[FieldOffset(Offset = "0x5CC")]
		public static readonly LegacySoundStyle DD2_DrakinHurt;

		// Token: 0x04008333 RID: 33587
		[Token(Token = "0x4008333")]
		[FieldOffset(Offset = "0x5D0")]
		public static readonly LegacySoundStyle DD2_DrakinShot;

		// Token: 0x04008334 RID: 33588
		[Token(Token = "0x4008334")]
		[FieldOffset(Offset = "0x5D4")]
		public static readonly LegacySoundStyle DD2_GoblinDeath;

		// Token: 0x04008335 RID: 33589
		[Token(Token = "0x4008335")]
		[FieldOffset(Offset = "0x5D8")]
		public static readonly LegacySoundStyle DD2_GoblinHurt;

		// Token: 0x04008336 RID: 33590
		[Token(Token = "0x4008336")]
		[FieldOffset(Offset = "0x5DC")]
		public static readonly LegacySoundStyle DD2_GoblinScream;

		// Token: 0x04008337 RID: 33591
		[Token(Token = "0x4008337")]
		[FieldOffset(Offset = "0x5E0")]
		public static readonly LegacySoundStyle DD2_GoblinBomberDeath;

		// Token: 0x04008338 RID: 33592
		[Token(Token = "0x4008338")]
		[FieldOffset(Offset = "0x5E4")]
		public static readonly LegacySoundStyle DD2_GoblinBomberHurt;

		// Token: 0x04008339 RID: 33593
		[Token(Token = "0x4008339")]
		[FieldOffset(Offset = "0x5E8")]
		public static readonly LegacySoundStyle DD2_GoblinBomberScream;

		// Token: 0x0400833A RID: 33594
		[Token(Token = "0x400833A")]
		[FieldOffset(Offset = "0x5EC")]
		public static readonly LegacySoundStyle DD2_GoblinBomberThrow;

		// Token: 0x0400833B RID: 33595
		[Token(Token = "0x400833B")]
		[FieldOffset(Offset = "0x5F0")]
		public static readonly LegacySoundStyle DD2_JavelinThrowersAttack;

		// Token: 0x0400833C RID: 33596
		[Token(Token = "0x400833C")]
		[FieldOffset(Offset = "0x5F4")]
		public static readonly LegacySoundStyle DD2_JavelinThrowersDeath;

		// Token: 0x0400833D RID: 33597
		[Token(Token = "0x400833D")]
		[FieldOffset(Offset = "0x5F8")]
		public static readonly LegacySoundStyle DD2_JavelinThrowersHurt;

		// Token: 0x0400833E RID: 33598
		[Token(Token = "0x400833E")]
		[FieldOffset(Offset = "0x5FC")]
		public static readonly LegacySoundStyle DD2_JavelinThrowersTaunt;

		// Token: 0x0400833F RID: 33599
		[Token(Token = "0x400833F")]
		[FieldOffset(Offset = "0x600")]
		public static readonly LegacySoundStyle DD2_KoboldDeath;

		// Token: 0x04008340 RID: 33600
		[Token(Token = "0x4008340")]
		[FieldOffset(Offset = "0x604")]
		public static readonly LegacySoundStyle DD2_KoboldExplosion;

		// Token: 0x04008341 RID: 33601
		[Token(Token = "0x4008341")]
		[FieldOffset(Offset = "0x608")]
		public static readonly LegacySoundStyle DD2_KoboldHurt;

		// Token: 0x04008342 RID: 33602
		[Token(Token = "0x4008342")]
		[FieldOffset(Offset = "0x60C")]
		public static readonly LegacySoundStyle DD2_KoboldIgnite;

		// Token: 0x04008343 RID: 33603
		[Token(Token = "0x4008343")]
		[FieldOffset(Offset = "0x610")]
		public static readonly LegacySoundStyle DD2_KoboldIgniteLoop;

		// Token: 0x04008344 RID: 33604
		[Token(Token = "0x4008344")]
		[FieldOffset(Offset = "0x614")]
		public static readonly LegacySoundStyle DD2_KoboldScreamChargeLoop;

		// Token: 0x04008345 RID: 33605
		[Token(Token = "0x4008345")]
		[FieldOffset(Offset = "0x618")]
		public static readonly LegacySoundStyle DD2_KoboldFlyerChargeScream;

		// Token: 0x04008346 RID: 33606
		[Token(Token = "0x4008346")]
		[FieldOffset(Offset = "0x61C")]
		public static readonly LegacySoundStyle DD2_KoboldFlyerDeath;

		// Token: 0x04008347 RID: 33607
		[Token(Token = "0x4008347")]
		[FieldOffset(Offset = "0x620")]
		public static readonly LegacySoundStyle DD2_KoboldFlyerHurt;

		// Token: 0x04008348 RID: 33608
		[Token(Token = "0x4008348")]
		[FieldOffset(Offset = "0x624")]
		public static readonly LegacySoundStyle DD2_LightningBugDeath;

		// Token: 0x04008349 RID: 33609
		[Token(Token = "0x4008349")]
		[FieldOffset(Offset = "0x628")]
		public static readonly LegacySoundStyle DD2_LightningBugHurt;

		// Token: 0x0400834A RID: 33610
		[Token(Token = "0x400834A")]
		[FieldOffset(Offset = "0x62C")]
		public static readonly LegacySoundStyle DD2_LightningBugZap;

		// Token: 0x0400834B RID: 33611
		[Token(Token = "0x400834B")]
		[FieldOffset(Offset = "0x630")]
		public static readonly LegacySoundStyle DD2_OgreAttack;

		// Token: 0x0400834C RID: 33612
		[Token(Token = "0x400834C")]
		[FieldOffset(Offset = "0x634")]
		public static readonly LegacySoundStyle DD2_OgreDeath;

		// Token: 0x0400834D RID: 33613
		[Token(Token = "0x400834D")]
		[FieldOffset(Offset = "0x638")]
		public static readonly LegacySoundStyle DD2_OgreGroundPound;

		// Token: 0x0400834E RID: 33614
		[Token(Token = "0x400834E")]
		[FieldOffset(Offset = "0x63C")]
		public static readonly LegacySoundStyle DD2_OgreHurt;

		// Token: 0x0400834F RID: 33615
		[Token(Token = "0x400834F")]
		[FieldOffset(Offset = "0x640")]
		public static readonly LegacySoundStyle DD2_OgreRoar;

		// Token: 0x04008350 RID: 33616
		[Token(Token = "0x4008350")]
		[FieldOffset(Offset = "0x644")]
		public static readonly LegacySoundStyle DD2_OgreSpit;

		// Token: 0x04008351 RID: 33617
		[Token(Token = "0x4008351")]
		[FieldOffset(Offset = "0x648")]
		public static readonly LegacySoundStyle DD2_SkeletonDeath;

		// Token: 0x04008352 RID: 33618
		[Token(Token = "0x4008352")]
		[FieldOffset(Offset = "0x64C")]
		public static readonly LegacySoundStyle DD2_SkeletonHurt;

		// Token: 0x04008353 RID: 33619
		[Token(Token = "0x4008353")]
		[FieldOffset(Offset = "0x650")]
		public static readonly LegacySoundStyle DD2_SkeletonSummoned;

		// Token: 0x04008354 RID: 33620
		[Token(Token = "0x4008354")]
		[FieldOffset(Offset = "0x654")]
		public static readonly LegacySoundStyle DD2_WitherBeastAuraPulse;

		// Token: 0x04008355 RID: 33621
		[Token(Token = "0x4008355")]
		[FieldOffset(Offset = "0x658")]
		public static readonly LegacySoundStyle DD2_WitherBeastCrystalImpact;

		// Token: 0x04008356 RID: 33622
		[Token(Token = "0x4008356")]
		[FieldOffset(Offset = "0x65C")]
		public static readonly LegacySoundStyle DD2_WitherBeastDeath;

		// Token: 0x04008357 RID: 33623
		[Token(Token = "0x4008357")]
		[FieldOffset(Offset = "0x660")]
		public static readonly LegacySoundStyle DD2_WitherBeastHurt;

		// Token: 0x04008358 RID: 33624
		[Token(Token = "0x4008358")]
		[FieldOffset(Offset = "0x664")]
		public static readonly LegacySoundStyle DD2_WyvernDeath;

		// Token: 0x04008359 RID: 33625
		[Token(Token = "0x4008359")]
		[FieldOffset(Offset = "0x668")]
		public static readonly LegacySoundStyle DD2_WyvernHurt;

		// Token: 0x0400835A RID: 33626
		[Token(Token = "0x400835A")]
		[FieldOffset(Offset = "0x66C")]
		public static readonly LegacySoundStyle DD2_WyvernScream;

		// Token: 0x0400835B RID: 33627
		[Token(Token = "0x400835B")]
		[FieldOffset(Offset = "0x670")]
		public static readonly LegacySoundStyle DD2_WyvernDiveDown;

		// Token: 0x0400835C RID: 33628
		[Token(Token = "0x400835C")]
		[FieldOffset(Offset = "0x674")]
		public static readonly LegacySoundStyle DD2_EtherianPortalDryadTouch;

		// Token: 0x0400835D RID: 33629
		[Token(Token = "0x400835D")]
		[FieldOffset(Offset = "0x678")]
		public static readonly LegacySoundStyle DD2_EtherianPortalIdleLoop;

		// Token: 0x0400835E RID: 33630
		[Token(Token = "0x400835E")]
		[FieldOffset(Offset = "0x67C")]
		public static readonly LegacySoundStyle DD2_EtherianPortalOpen;

		// Token: 0x0400835F RID: 33631
		[Token(Token = "0x400835F")]
		[FieldOffset(Offset = "0x680")]
		public static readonly LegacySoundStyle DD2_EtherianPortalSpawnEnemy;

		// Token: 0x04008360 RID: 33632
		[Token(Token = "0x4008360")]
		[FieldOffset(Offset = "0x684")]
		public static readonly LegacySoundStyle DD2_CrystalCartImpact;

		// Token: 0x04008361 RID: 33633
		[Token(Token = "0x4008361")]
		[FieldOffset(Offset = "0x688")]
		public static readonly LegacySoundStyle DD2_DefeatScene;

		// Token: 0x04008362 RID: 33634
		[Token(Token = "0x4008362")]
		[FieldOffset(Offset = "0x68C")]
		public static readonly LegacySoundStyle DD2_WinScene;

		// Token: 0x04008363 RID: 33635
		[Token(Token = "0x4008363")]
		[FieldOffset(Offset = "0x690")]
		public static readonly LegacySoundStyle DD2_BetsysWrathShot;

		// Token: 0x04008364 RID: 33636
		[Token(Token = "0x4008364")]
		[FieldOffset(Offset = "0x694")]
		public static readonly LegacySoundStyle DD2_BetsysWrathImpact;

		// Token: 0x04008365 RID: 33637
		[Token(Token = "0x4008365")]
		[FieldOffset(Offset = "0x698")]
		public static readonly LegacySoundStyle DD2_BookStaffCast;

		// Token: 0x04008366 RID: 33638
		[Token(Token = "0x4008366")]
		[FieldOffset(Offset = "0x69C")]
		public static readonly LegacySoundStyle DD2_BookStaffTwisterLoop;

		// Token: 0x04008367 RID: 33639
		[Token(Token = "0x4008367")]
		[FieldOffset(Offset = "0x6A0")]
		public static readonly LegacySoundStyle DD2_GhastlyGlaiveImpactGhost;

		// Token: 0x04008368 RID: 33640
		[Token(Token = "0x4008368")]
		[FieldOffset(Offset = "0x6A4")]
		public static readonly LegacySoundStyle DD2_GhastlyGlaivePierce;

		// Token: 0x04008369 RID: 33641
		[Token(Token = "0x4008369")]
		[FieldOffset(Offset = "0x6A8")]
		public static readonly LegacySoundStyle DD2_MonkStaffGroundImpact;

		// Token: 0x0400836A RID: 33642
		[Token(Token = "0x400836A")]
		[FieldOffset(Offset = "0x6AC")]
		public static readonly LegacySoundStyle DD2_MonkStaffGroundMiss;

		// Token: 0x0400836B RID: 33643
		[Token(Token = "0x400836B")]
		[FieldOffset(Offset = "0x6B0")]
		public static readonly LegacySoundStyle DD2_MonkStaffSwing;

		// Token: 0x0400836C RID: 33644
		[Token(Token = "0x400836C")]
		[FieldOffset(Offset = "0x6B4")]
		public static readonly LegacySoundStyle DD2_PhantomPhoenixShot;

		// Token: 0x0400836D RID: 33645
		[Token(Token = "0x400836D")]
		[FieldOffset(Offset = "0x6B8")]
		public static readonly LegacySoundStyle DD2_SonicBoomBladeSlash;

		// Token: 0x0400836E RID: 33646
		[Token(Token = "0x400836E")]
		[FieldOffset(Offset = "0x6BC")]
		public static readonly LegacySoundStyle DD2_SkyDragonsFuryCircle;

		// Token: 0x0400836F RID: 33647
		[Token(Token = "0x400836F")]
		[FieldOffset(Offset = "0x6C0")]
		public static readonly LegacySoundStyle DD2_SkyDragonsFuryShot;

		// Token: 0x04008370 RID: 33648
		[Token(Token = "0x4008370")]
		[FieldOffset(Offset = "0x6C4")]
		public static readonly LegacySoundStyle DD2_SkyDragonsFurySwing;

		// Token: 0x04008371 RID: 33649
		[Token(Token = "0x4008371")]
		[FieldOffset(Offset = "0x6C8")]
		public static readonly LegacySoundStyle PlayerHurt1;

		// Token: 0x04008372 RID: 33650
		[Token(Token = "0x4008372")]
		[FieldOffset(Offset = "0x6CC")]
		public static readonly LegacySoundStyle PlayerHurt2;

		// Token: 0x04008373 RID: 33651
		[Token(Token = "0x4008373")]
		[FieldOffset(Offset = "0x6D0")]
		public static readonly LegacySoundStyle LucyTheAxeTalk;

		// Token: 0x04008374 RID: 33652
		[Token(Token = "0x4008374")]
		[FieldOffset(Offset = "0x6D4")]
		public static readonly LegacySoundStyle DeerclopsHit;

		// Token: 0x04008375 RID: 33653
		[Token(Token = "0x4008375")]
		[FieldOffset(Offset = "0x6D8")]
		public static readonly LegacySoundStyle DeerclopsDeath;

		// Token: 0x04008376 RID: 33654
		[Token(Token = "0x4008376")]
		[FieldOffset(Offset = "0x6DC")]
		public static readonly LegacySoundStyle DeerclopsScream;

		// Token: 0x04008377 RID: 33655
		[Token(Token = "0x4008377")]
		[FieldOffset(Offset = "0x6E0")]
		public static readonly LegacySoundStyle DeerclopsIceAttack;

		// Token: 0x04008378 RID: 33656
		[Token(Token = "0x4008378")]
		[FieldOffset(Offset = "0x6E4")]
		public static readonly LegacySoundStyle DeerclopsRubbleAttack;

		// Token: 0x04008379 RID: 33657
		[Token(Token = "0x4008379")]
		[FieldOffset(Offset = "0x6E8")]
		public static readonly LegacySoundStyle DeerclopsStep;

		// Token: 0x0400837A RID: 33658
		[Token(Token = "0x400837A")]
		[FieldOffset(Offset = "0x6EC")]
		public static readonly LegacySoundStyle ChesterOpen;

		// Token: 0x0400837B RID: 33659
		[Token(Token = "0x400837B")]
		[FieldOffset(Offset = "0x6F0")]
		public static readonly LegacySoundStyle ChesterClose;

		// Token: 0x0400837C RID: 33660
		[Token(Token = "0x400837C")]
		[FieldOffset(Offset = "0x6F4")]
		public static readonly LegacySoundStyle AbigailSummon;

		// Token: 0x0400837D RID: 33661
		[Token(Token = "0x400837D")]
		[FieldOffset(Offset = "0x6F8")]
		public static readonly LegacySoundStyle AbigailCry;

		// Token: 0x0400837E RID: 33662
		[Token(Token = "0x400837E")]
		[FieldOffset(Offset = "0x6FC")]
		public static readonly LegacySoundStyle AbigailAttack;

		// Token: 0x0400837F RID: 33663
		[Token(Token = "0x400837F")]
		[FieldOffset(Offset = "0x700")]
		public static readonly LegacySoundStyle AbigailUpgrade;

		// Token: 0x04008380 RID: 33664
		[Token(Token = "0x4008380")]
		[FieldOffset(Offset = "0x704")]
		public static readonly LegacySoundStyle GlommerBounce;

		// Token: 0x04008381 RID: 33665
		[Token(Token = "0x4008381")]
		[FieldOffset(Offset = "0x708")]
		public static readonly LegacySoundStyle DSTMaleHurt;

		// Token: 0x04008382 RID: 33666
		[Token(Token = "0x4008382")]
		[FieldOffset(Offset = "0x70C")]
		public static readonly LegacySoundStyle DSTFemaleHurt;

		// Token: 0x04008383 RID: 33667
		[Token(Token = "0x4008383")]
		[FieldOffset(Offset = "0x710")]
		public static readonly LegacySoundStyle JimsDrone;

		// Token: 0x04008384 RID: 33668
		[Token(Token = "0x4008384")]
		[FieldOffset(Offset = "0x714")]
		public static readonly LegacySoundStyle RCCar;

		// Token: 0x04008385 RID: 33669
		[Token(Token = "0x4008385")]
		[FieldOffset(Offset = "0x718")]
		public static readonly LegacySoundStyle VampireSizzle;

		// Token: 0x04008386 RID: 33670
		[Token(Token = "0x4008386")]
		[FieldOffset(Offset = "0x71C")]
		public static readonly LegacySoundStyle RainbowBoulder;

		// Token: 0x04008387 RID: 33671
		[Token(Token = "0x4008387")]
		[FieldOffset(Offset = "0x720")]
		public static readonly LegacySoundStyle MenuAccept;

		// Token: 0x04008388 RID: 33672
		[Token(Token = "0x4008388")]
		[FieldOffset(Offset = "0x724")]
		public static readonly LegacySoundStyle Hungry;

		// Token: 0x04008389 RID: 33673
		[Token(Token = "0x4008389")]
		[FieldOffset(Offset = "0x728")]
		public static readonly LegacySoundStyle PalSummon;

		// Token: 0x0400838A RID: 33674
		[Token(Token = "0x400838A")]
		[FieldOffset(Offset = "0x72C")]
		public static readonly LegacySoundStyle PalCattiva;

		// Token: 0x0400838B RID: 33675
		[Token(Token = "0x400838B")]
		[FieldOffset(Offset = "0x730")]
		public static readonly LegacySoundStyle PalCattivaPain;

		// Token: 0x0400838C RID: 33676
		[Token(Token = "0x400838C")]
		[FieldOffset(Offset = "0x734")]
		public static readonly LegacySoundStyle PalCattivaJoy;

		// Token: 0x0400838D RID: 33677
		[Token(Token = "0x400838D")]
		[FieldOffset(Offset = "0x738")]
		public static readonly LegacySoundStyle PalChillet;

		// Token: 0x0400838E RID: 33678
		[Token(Token = "0x400838E")]
		[FieldOffset(Offset = "0x73C")]
		public static readonly LegacySoundStyle PalChilletJoy;

		// Token: 0x0400838F RID: 33679
		[Token(Token = "0x400838F")]
		[FieldOffset(Offset = "0x740")]
		public static readonly LegacySoundStyle PalChilletAttack;

		// Token: 0x04008390 RID: 33680
		[Token(Token = "0x4008390")]
		[FieldOffset(Offset = "0x744")]
		public static readonly LegacySoundStyle PalFoxparks;

		// Token: 0x04008391 RID: 33681
		[Token(Token = "0x4008391")]
		[FieldOffset(Offset = "0x748")]
		public static readonly LegacySoundStyle PalFoxparksPain;

		// Token: 0x04008392 RID: 33682
		[Token(Token = "0x4008392")]
		[FieldOffset(Offset = "0x74C")]
		public static readonly LegacySoundStyle PalFoxparksJoy;

		// Token: 0x04008393 RID: 33683
		[Token(Token = "0x4008393")]
		[FieldOffset(Offset = "0x750")]
		public static readonly LegacySoundStyle PalFoxparksAttack;

		// Token: 0x04008394 RID: 33684
		[Token(Token = "0x4008394")]
		[FieldOffset(Offset = "0x754")]
		public static readonly LegacySoundStyle PalDigtoise;

		// Token: 0x04008395 RID: 33685
		[Token(Token = "0x4008395")]
		[FieldOffset(Offset = "0x758")]
		public static readonly LegacySoundStyle PalDigtoiseJoy;

		// Token: 0x04008396 RID: 33686
		[Token(Token = "0x4008396")]
		[FieldOffset(Offset = "0x75C")]
		public static readonly LegacySoundStyle FoxparksFlame;

		// Token: 0x04008397 RID: 33687
		[Token(Token = "0x4008397")]
		[FieldOffset(Offset = "0x760")]
		public static readonly LegacySoundStyle LeafBlower;

		// Token: 0x04008398 RID: 33688
		[Token(Token = "0x4008398")]
		[FieldOffset(Offset = "0x764")]
		public static readonly LegacySoundStyle DeadCellsBarrelLauncherFire;

		// Token: 0x04008399 RID: 33689
		[Token(Token = "0x4008399")]
		[FieldOffset(Offset = "0x768")]
		public static readonly LegacySoundStyle DeadCellsBarrelLauncherExplode;

		// Token: 0x0400839A RID: 33690
		[Token(Token = "0x400839A")]
		[FieldOffset(Offset = "0x76C")]
		public static readonly LegacySoundStyle DeadCellsMushroomSummon;

		// Token: 0x0400839B RID: 33691
		[Token(Token = "0x400839B")]
		[FieldOffset(Offset = "0x770")]
		public static readonly LegacySoundStyle DeadCellsMushroomLand;

		// Token: 0x0400839C RID: 33692
		[Token(Token = "0x400839C")]
		[FieldOffset(Offset = "0x774")]
		public static readonly LegacySoundStyle DeadCellsMushroomJump;

		// Token: 0x0400839D RID: 33693
		[Token(Token = "0x400839D")]
		[FieldOffset(Offset = "0x778")]
		public static readonly LegacySoundStyle DeadCellsMushroomExplode;

		// Token: 0x0400839E RID: 33694
		[Token(Token = "0x400839E")]
		[FieldOffset(Offset = "0x77C")]
		public static readonly LegacySoundStyle DeadCellsFlintCharge;

		// Token: 0x0400839F RID: 33695
		[Token(Token = "0x400839F")]
		[FieldOffset(Offset = "0x780")]
		public static readonly LegacySoundStyle DeadCellsFlintRelease;

		// Token: 0x040083A0 RID: 33696
		[Token(Token = "0x40083A0")]
		[FieldOffset(Offset = "0x784")]
		public static readonly LegacySoundStyle DeadCellsFlintWave;

		// Token: 0x040083A1 RID: 33697
		[Token(Token = "0x40083A1")]
		[FieldOffset(Offset = "0x788")]
		public static readonly LegacySoundStyle MeteorShower;

		// Token: 0x040083A2 RID: 33698
		[Token(Token = "0x40083A2")]
		[FieldOffset(Offset = "0x78C")]
		public static readonly LegacySoundStyle BestReforge;

		// Token: 0x040083A3 RID: 33699
		[Token(Token = "0x40083A3")]
		[FieldOffset(Offset = "0x790")]
		public static readonly LegacySoundStyle TrashItem;

		// Token: 0x040083A4 RID: 33700
		[Token(Token = "0x40083A4")]
		[FieldOffset(Offset = "0x794")]
		public static readonly LegacySoundStyle InstantThunder;

		// Token: 0x040083A5 RID: 33701
		[Token(Token = "0x40083A5")]
		[FieldOffset(Offset = "0x798")]
		public static readonly LegacySoundStyle SonarPotion;

		// Token: 0x040083A6 RID: 33702
		[Token(Token = "0x40083A6")]
		[FieldOffset(Offset = "0x79C")]
		public static readonly LegacySoundStyle StatueMimicScare;

		// Token: 0x040083A7 RID: 33703
		[Token(Token = "0x40083A7")]
		[FieldOffset(Offset = "0x7A0")]
		public static readonly LegacySoundStyle StatueMimicJump;

		// Token: 0x040083A8 RID: 33704
		[Token(Token = "0x40083A8")]
		[FieldOffset(Offset = "0x7A4")]
		public static readonly LegacySoundStyle StatueMimicLaugh;

		// Token: 0x040083A9 RID: 33705
		[Token(Token = "0x40083A9")]
		public const float playerVoicePitchVariance = 0.4f;

		// Token: 0x040083AA RID: 33706
		[Token(Token = "0x40083AA")]
		[FieldOffset(Offset = "0x7A8")]
		public static readonly LegacySoundStyle DefaultPlayerHurt;

		// Token: 0x040083AB RID: 33707
		[Token(Token = "0x40083AB")]
		[FieldOffset(Offset = "0x7AC")]
		public static readonly LegacySoundStyle BellHurt;

		// Token: 0x040083AC RID: 33708
		[Token(Token = "0x40083AC")]
		[FieldOffset(Offset = "0x7B0")]
		public static readonly LegacySoundStyle ChickenHurt;

		// Token: 0x040083AD RID: 33709
		[Token(Token = "0x40083AD")]
		[FieldOffset(Offset = "0x7B4")]
		public static readonly LegacySoundStyle ChickenHurtRare;

		// Token: 0x040083AE RID: 33710
		[Token(Token = "0x40083AE")]
		[FieldOffset(Offset = "0x7B8")]
		public static readonly LegacySoundStyle FrogHurt;

		// Token: 0x040083AF RID: 33711
		[Token(Token = "0x40083AF")]
		[FieldOffset(Offset = "0x7BC")]
		public static readonly LegacySoundStyle GoatHurt;

		// Token: 0x040083B0 RID: 33712
		[Token(Token = "0x40083B0")]
		[FieldOffset(Offset = "0x7C0")]
		public static readonly LegacySoundStyle RetroHurt;

		// Token: 0x040083B1 RID: 33713
		[Token(Token = "0x40083B1")]
		[FieldOffset(Offset = "0x7C4")]
		public static readonly LegacySoundStyle RetroDeath;

		// Token: 0x040083B2 RID: 33714
		[Token(Token = "0x40083B2")]
		[FieldOffset(Offset = "0x7C8")]
		public static readonly LegacySoundStyle CatHurt;

		// Token: 0x040083B3 RID: 33715
		[Token(Token = "0x40083B3")]
		[FieldOffset(Offset = "0x7CC")]
		public static readonly LegacySoundStyle DogHurt;

		// Token: 0x040083B4 RID: 33716
		[Token(Token = "0x40083B4")]
		[FieldOffset(Offset = "0x7D0")]
		public static readonly LegacySoundStyle TurkeyHurt;

		// Token: 0x040083B5 RID: 33717
		[Token(Token = "0x40083B5")]
		[FieldOffset(Offset = "0x7D4")]
		public static readonly LegacySoundStyle GoblinHurt;

		// Token: 0x040083B6 RID: 33718
		[Token(Token = "0x40083B6")]
		[FieldOffset(Offset = "0x7D8")]
		public static readonly LegacySoundStyle CrowHurt;

		// Token: 0x040083B7 RID: 33719
		[Token(Token = "0x40083B7")]
		[FieldOffset(Offset = "0x7DC")]
		public static readonly LegacySoundStyle BalloonHurt;

		// Token: 0x040083B8 RID: 33720
		[Token(Token = "0x40083B8")]
		[FieldOffset(Offset = "0x7E0")]
		public static readonly LegacySoundStyle BalloonDeath;

		// Token: 0x040083B9 RID: 33721
		[Token(Token = "0x40083B9")]
		[FieldOffset(Offset = "0x7E4")]
		public static readonly LegacySoundStyle UndeadHurt;

		// Token: 0x040083BA RID: 33722
		[Token(Token = "0x40083BA")]
		[FieldOffset(Offset = "0x7E8")]
		public static readonly LegacySoundStyle VampireHurt;

		// Token: 0x040083BB RID: 33723
		[Token(Token = "0x40083BB")]
		[FieldOffset(Offset = "0x7EC")]
		public static readonly LegacySoundStyle FairyHurt;

		// Token: 0x040083BC RID: 33724
		[Token(Token = "0x40083BC")]
		[FieldOffset(Offset = "0x7F0")]
		public static readonly LegacySoundStyle FishSplash;

		// Token: 0x040083BD RID: 33725
		[Token(Token = "0x40083BD")]
		[FieldOffset(Offset = "0x7F4")]
		public static readonly LegacySoundStyle EOWDiggin;

		// Token: 0x040083BE RID: 33726
		[Token(Token = "0x40083BE")]
		[FieldOffset(Offset = "0x7F8")]
		public static readonly LegacySoundStyle BombFuse;

		// Token: 0x040083BF RID: 33727
		[Token(Token = "0x40083BF")]
		[FieldOffset(Offset = "0x7FC")]
		private static List<string> _trackableLegacySoundPathList;

		// Token: 0x040083C0 RID: 33728
		[Token(Token = "0x40083C0")]
		[FieldOffset(Offset = "0x800")]
		public static Dictionary<string, LegacySoundStyle> SoundByName;

		// Token: 0x040083C1 RID: 33729
		[Token(Token = "0x40083C1")]
		[FieldOffset(Offset = "0x804")]
		public static Dictionary<string, ushort> IndexByName;

		// Token: 0x040083C2 RID: 33730
		[Token(Token = "0x40083C2")]
		[FieldOffset(Offset = "0x808")]
		public static Dictionary<ushort, LegacySoundStyle> SoundByIndex;

		// Token: 0x02000713 RID: 1811
		[Token(Token = "0x2000713")]
		private struct SoundStyleDefaults
		{
			// Token: 0x060041F0 RID: 16880 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60041F0")]
			[Address(RVA = "0x1F9264C", Offset = "0x1F9264C", VA = "0x1F9264C")]
			public SoundStyleDefaults(float volume, float pitchVariance, SoundType type = SoundType.Sound)
			{
			}

			// Token: 0x040083C3 RID: 33731
			[Token(Token = "0x40083C3")]
			[FieldOffset(Offset = "0x0")]
			public readonly float PitchVariance;

			// Token: 0x040083C4 RID: 33732
			[Token(Token = "0x40083C4")]
			[FieldOffset(Offset = "0x4")]
			public readonly float Volume;

			// Token: 0x040083C5 RID: 33733
			[Token(Token = "0x40083C5")]
			[FieldOffset(Offset = "0x8")]
			public readonly SoundType Type;
		}

		// Token: 0x02000714 RID: 1812
		[Token(Token = "0x2000714")]
		private sealed class <>c__DisplayClass592_0
		{
			// Token: 0x060041F1 RID: 16881 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60041F1")]
			[Address(RVA = "0x1F88824", Offset = "0x1F88824", VA = "0x1F88824")]
			public <>c__DisplayClass592_0()
			{
			}

			// Token: 0x060041F2 RID: 16882 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60041F2")]
			[Address(RVA = "0x1F92658", Offset = "0x1F92658", VA = "0x1F92658")]
			internal void <FillAccessMap>b__2(FieldInfo field)
			{
			}

			// Token: 0x040083C6 RID: 33734
			[Token(Token = "0x40083C6")]
			[FieldOffset(Offset = "0x8")]
			public Dictionary<string, LegacySoundStyle> ret;

			// Token: 0x040083C7 RID: 33735
			[Token(Token = "0x40083C7")]
			[FieldOffset(Offset = "0xC")]
			public Dictionary<string, ushort> ret2;

			// Token: 0x040083C8 RID: 33736
			[Token(Token = "0x40083C8")]
			[FieldOffset(Offset = "0x10")]
			public ushort nextIndex;

			// Token: 0x040083C9 RID: 33737
			[Token(Token = "0x40083C9")]
			[FieldOffset(Offset = "0x14")]
			public Dictionary<ushort, LegacySoundStyle> ret3;
		}

		// Token: 0x02000715 RID: 1813
		[Token(Token = "0x2000715")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060041F4 RID: 16884 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60041F4")]
			[Address(RVA = "0x1F92904", Offset = "0x1F92904", VA = "0x1F92904")]
			public <>c()
			{
			}

			// Token: 0x060041F5 RID: 16885 RVA: 0x00020220 File Offset: 0x0001E420
			[Token(Token = "0x60041F5")]
			[Address(RVA = "0x1F9290C", Offset = "0x1F9290C", VA = "0x1F9290C")]
			internal bool <FillAccessMap>b__592_0(FieldInfo f)
			{
				return default(bool);
			}

			// Token: 0x060041F6 RID: 16886 RVA: 0x00020238 File Offset: 0x0001E438
			[Token(Token = "0x60041F6")]
			[Address(RVA = "0x1F929C8", Offset = "0x1F929C8", VA = "0x1F929C8")]
			internal int <FillAccessMap>b__592_1(FieldInfo a, FieldInfo b)
			{
				return 0;
			}

			// Token: 0x040083CA RID: 33738
			[Token(Token = "0x40083CA")]
			[FieldOffset(Offset = "0x0")]
			public static readonly SoundID.<>c <>9;

			// Token: 0x040083CB RID: 33739
			[Token(Token = "0x40083CB")]
			[FieldOffset(Offset = "0x4")]
			public static Func<FieldInfo, bool> <>9__592_0;

			// Token: 0x040083CC RID: 33740
			[Token(Token = "0x40083CC")]
			[FieldOffset(Offset = "0x8")]
			public static Comparison<FieldInfo> <>9__592_1;
		}
	}
}
