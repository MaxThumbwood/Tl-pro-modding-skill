using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;

namespace Terraria.GameContent
{
	// Token: 0x020009D5 RID: 2517
	[Token(Token = "0x20009D5")]
	public class TeleportPylonsSystem : FileAPI
	{
		// Token: 0x170009BF RID: 2495
		// (get) Token: 0x0600524C RID: 21068 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170009BF")]
		public List<TeleportPylonInfo> Pylons
		{
			[Token(Token = "0x600524C")]
			[Address(RVA = "0x7D89B8", Offset = "0x7D89B8", VA = "0x7D89B8")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600524D RID: 21069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600524D")]
		[Address(RVA = "0x7D89C0", Offset = "0x7D89C0", VA = "0x7D89C0")]
		public void Update()
		{
		}

		// Token: 0x0600524E RID: 21070 RVA: 0x00026550 File Offset: 0x00024750
		[Token(Token = "0x600524E")]
		[Address(RVA = "0x7D959C", Offset = "0x7D959C", VA = "0x7D959C")]
		public bool HasPylonOfType(TeleportPylonType pylonType)
		{
			return default(bool);
		}

		// Token: 0x0600524F RID: 21071 RVA: 0x00026568 File Offset: 0x00024768
		[Token(Token = "0x600524F")]
		[Address(RVA = "0x7D96C0", Offset = "0x7D96C0", VA = "0x7D96C0")]
		public bool HasAnyPylon()
		{
			return default(bool);
		}

		// Token: 0x06005250 RID: 21072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005250")]
		[Address(RVA = "0x7D971C", Offset = "0x7D971C", VA = "0x7D971C")]
		public void RequestImmediateUpdate()
		{
		}

		// Token: 0x06005251 RID: 21073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005251")]
		[Address(RVA = "0x7D8A54", Offset = "0x7D8A54", VA = "0x7D8A54")]
		private void UpdatePylonsListAndBroadcastChanges()
		{
		}

		// Token: 0x06005252 RID: 21074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005252")]
		[Address(RVA = "0x7D9798", Offset = "0x7D9798", VA = "0x7D9798")]
		public void AddForClient(TeleportPylonInfo info)
		{
		}

		// Token: 0x06005253 RID: 21075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005253")]
		[Address(RVA = "0x7D98B0", Offset = "0x7D98B0", VA = "0x7D98B0")]
		public void RemoveForClient(TeleportPylonInfo info)
		{
		}

		// Token: 0x06005254 RID: 21076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005254")]
		[Address(RVA = "0x7D99E8", Offset = "0x7D99E8", VA = "0x7D99E8")]
		public void HandleTeleportRequest(TeleportPylonInfo info, int playerIndex)
		{
		}

		// Token: 0x06005255 RID: 21077 RVA: 0x00026580 File Offset: 0x00024780
		[Token(Token = "0x6005255")]
		[Address(RVA = "0x7DA364", Offset = "0x7DA364", VA = "0x7DA364")]
		public static bool IsPlayerNearAPylon(Player player)
		{
			return default(bool);
		}

		// Token: 0x06005256 RID: 21078 RVA: 0x00026598 File Offset: 0x00024798
		[Token(Token = "0x6005256")]
		[Address(RVA = "0x7DA770", Offset = "0x7DA770", VA = "0x7DA770")]
		private bool DoesPylonHaveEnoughNPCsAroundIt(TeleportPylonInfo info, int necessaryNPCCount)
		{
			return default(bool);
		}

		// Token: 0x06005257 RID: 21079 RVA: 0x000265B0 File Offset: 0x000247B0
		[Token(Token = "0x6005257")]
		[Address(RVA = "0x7DADDC", Offset = "0x7DADDC", VA = "0x7DADDC")]
		public static bool DoesPositionHaveEnoughNPCs(int necessaryNPCCount, Point16 centerPoint)
		{
			return default(bool);
		}

		// Token: 0x06005258 RID: 21080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005258")]
		[Address(RVA = "0x7DB100", Offset = "0x7DB100", VA = "0x7DB100")]
		public void RequestTeleportation(TeleportPylonInfo info, Player player)
		{
		}

		// Token: 0x06005259 RID: 21081 RVA: 0x000265C8 File Offset: 0x000247C8
		[Token(Token = "0x6005259")]
		[Address(RVA = "0x7DA788", Offset = "0x7DA788", VA = "0x7DA788")]
		private bool DoesPylonAcceptTeleportation(TeleportPylonInfo info, Player player)
		{
			return default(bool);
		}

		// Token: 0x0600525A RID: 21082 RVA: 0x000265E0 File Offset: 0x000247E0
		[Token(Token = "0x600525A")]
		[Address(RVA = "0x7DA75C", Offset = "0x7DA75C", VA = "0x7DA75C")]
		private int HowManyNPCsDoesPylonNeed(TeleportPylonInfo info, Player player)
		{
			return 0;
		}

		// Token: 0x0600525B RID: 21083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600525B")]
		[Address(RVA = "0x7DB1B4", Offset = "0x7DB1B4", VA = "0x7DB1B4")]
		public void Reset()
		{
		}

		// Token: 0x0600525C RID: 21084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600525C")]
		[Address(RVA = "0x7DB218", Offset = "0x7DB218", VA = "0x7DB218", Slot = "4")]
		public void OnPlayerJoining(int playerIndex)
		{
		}

		// Token: 0x0600525D RID: 21085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600525D")]
		[Address(RVA = "0x7DB45C", Offset = "0x7DB45C", VA = "0x7DB45C")]
		public static void SpawnInWorldDust(int tileStyle, Rectangle dustBox)
		{
		}

		// Token: 0x0600525E RID: 21086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600525E")]
		[Address(RVA = "0x7DB6E8", Offset = "0x7DB6E8", VA = "0x7DB6E8")]
		public TeleportPylonsSystem()
		{
		}

		// Token: 0x0400954D RID: 38221
		[Token(Token = "0x400954D")]
		[FieldOffset(Offset = "0x8")]
		private List<TeleportPylonInfo> _pylons;

		// Token: 0x0400954E RID: 38222
		[Token(Token = "0x400954E")]
		[FieldOffset(Offset = "0xC")]
		private List<TeleportPylonInfo> _pylonsOld;

		// Token: 0x0400954F RID: 38223
		[Token(Token = "0x400954F")]
		[FieldOffset(Offset = "0x10")]
		private int _cooldownForUpdatingPylonsList;

		// Token: 0x04009550 RID: 38224
		[Token(Token = "0x4009550")]
		private const int CooldownTimePerPylonsListUpdate = 2147483647;

		// Token: 0x04009551 RID: 38225
		[Token(Token = "0x4009551")]
		[FieldOffset(Offset = "0x14")]
		private SceneMetrics _sceneMetrics;

		// Token: 0x020009D6 RID: 2518
		[Token(Token = "0x20009D6")]
		private sealed class <>c__DisplayClass8_0
		{
			// Token: 0x0600525F RID: 21087 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600525F")]
			[Address(RVA = "0x7D96B8", Offset = "0x7D96B8", VA = "0x7D96B8")]
			public <>c__DisplayClass8_0()
			{
			}

			// Token: 0x06005260 RID: 21088 RVA: 0x000265F8 File Offset: 0x000247F8
			[Token(Token = "0x6005260")]
			[Address(RVA = "0x7DB7EC", Offset = "0x7DB7EC", VA = "0x7DB7EC")]
			internal bool <HasPylonOfType>b__0(TeleportPylonInfo x)
			{
				return default(bool);
			}

			// Token: 0x04009552 RID: 38226
			[Token(Token = "0x4009552")]
			[FieldOffset(Offset = "0x8")]
			public TeleportPylonType pylonType;
		}

		// Token: 0x020009D7 RID: 2519
		[Token(Token = "0x20009D7")]
		private sealed class <>c__DisplayClass13_0
		{
			// Token: 0x06005261 RID: 21089 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005261")]
			[Address(RVA = "0x7D99E0", Offset = "0x7D99E0", VA = "0x7D99E0")]
			public <>c__DisplayClass13_0()
			{
			}

			// Token: 0x06005262 RID: 21090 RVA: 0x00026610 File Offset: 0x00024810
			[Token(Token = "0x6005262")]
			[Address(RVA = "0x7DB804", Offset = "0x7DB804", VA = "0x7DB804")]
			internal bool <RemoveForClient>b__0(TeleportPylonInfo x)
			{
				return default(bool);
			}

			// Token: 0x04009553 RID: 38227
			[Token(Token = "0x4009553")]
			[FieldOffset(Offset = "0x8")]
			public TeleportPylonInfo info;
		}
	}
}
