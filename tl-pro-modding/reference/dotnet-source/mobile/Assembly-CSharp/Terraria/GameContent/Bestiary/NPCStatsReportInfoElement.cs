using System;
using Il2CppDummyDll;
using Terraria.UI;

namespace Terraria.GameContent.Bestiary
{
	// Token: 0x02000C20 RID: 3104
	[Token(Token = "0x2000C20")]
	public class NPCStatsReportInfoElement : FileAPI, GUIControllerItem
	{
		// Token: 0x06005CF3 RID: 23795 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CF3")]
		[Address(RVA = "0x99E8F4", Offset = "0x99E8F4", VA = "0x99E8F4")]
		public NPCStatsReportInfoElement(int npcNetId)
		{
		}

		// Token: 0x14000057 RID: 87
		// (add) Token: 0x06005CF4 RID: 23796 RVA: 0x00002053 File Offset: 0x00000253
		// (remove) Token: 0x06005CF5 RID: 23797 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x14000057")]
		public event NPCStatsReportInfoElement.StatAdjustmentStep OnRefreshStats
		{
			[Token(Token = "0x6005CF4")]
			[Address(RVA = "0x9A820C", Offset = "0x9A820C", VA = "0x9A820C")]
			add
			{
			}
			[Token(Token = "0x6005CF5")]
			[Address(RVA = "0x9A82BC", Offset = "0x9A82BC", VA = "0x9A82BC")]
			remove
			{
			}
		}

		// Token: 0x06005CF6 RID: 23798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CF6")]
		[Address(RVA = "0x9A836C", Offset = "0x9A836C", VA = "0x9A836C")]
		public void Refresh()
		{
		}

		// Token: 0x06005CF7 RID: 23799 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CF7")]
		[Address(RVA = "0x9A8374", Offset = "0x9A8374", VA = "0x9A8374", Slot = "5")]
		public void UpdateBeforeSorting()
		{
		}

		// Token: 0x06005CF8 RID: 23800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CF8")]
		[Address(RVA = "0x9A80F4", Offset = "0x9A80F4", VA = "0x9A80F4")]
		private void RefreshStats(NPC instance)
		{
		}

		// Token: 0x06005CF9 RID: 23801 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005CF9")]
		[Address(RVA = "0x9A837C", Offset = "0x9A837C", VA = "0x9A837C", Slot = "4")]
		public UIElement ProvideUIElement(BestiaryUICollectionInfo info)
		{
			return null;
		}

		// Token: 0x06005CFA RID: 23802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CFA")]
		[Address(RVA = "0x9AA364", Offset = "0x9AA364", VA = "0x9AA364")]
		private void ShowStats_Attack(UIElement element)
		{
		}

		// Token: 0x06005CFB RID: 23803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CFB")]
		[Address(RVA = "0x9AA48C", Offset = "0x9AA48C", VA = "0x9AA48C")]
		private void ShowStats_Defense(UIElement element)
		{
		}

		// Token: 0x06005CFC RID: 23804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CFC")]
		[Address(RVA = "0x9AA5B4", Offset = "0x9AA5B4", VA = "0x9AA5B4")]
		private void ShowStats_Knockback(UIElement element)
		{
		}

		// Token: 0x06005CFD RID: 23805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005CFD")]
		[Address(RVA = "0x9AA6DC", Offset = "0x9AA6DC", VA = "0x9AA6DC")]
		private void ShowStats_Life(UIElement element)
		{
		}

		// Token: 0x04009D3D RID: 40253
		[Token(Token = "0x4009D3D")]
		[FieldOffset(Offset = "0x8")]
		public int NpcId;

		// Token: 0x04009D3E RID: 40254
		[Token(Token = "0x4009D3E")]
		[FieldOffset(Offset = "0xC")]
		public int Damage;

		// Token: 0x04009D3F RID: 40255
		[Token(Token = "0x4009D3F")]
		[FieldOffset(Offset = "0x10")]
		public int LifeMax;

		// Token: 0x04009D40 RID: 40256
		[Token(Token = "0x4009D40")]
		[FieldOffset(Offset = "0x14")]
		public float MonetaryValue;

		// Token: 0x04009D41 RID: 40257
		[Token(Token = "0x4009D41")]
		[FieldOffset(Offset = "0x18")]
		public int Defense;

		// Token: 0x04009D42 RID: 40258
		[Token(Token = "0x4009D42")]
		[FieldOffset(Offset = "0x1C")]
		public float KnockbackResist;

		// Token: 0x04009D43 RID: 40259
		[Token(Token = "0x4009D43")]
		[FieldOffset(Offset = "0x20")]
		public NPC _instance;

		// Token: 0x04009D45 RID: 40261
		[Token(Token = "0x4009D45")]
		[FieldOffset(Offset = "0x28")]
		public bool HideStats;

		// Token: 0x02000C21 RID: 3105
		// (Invoke) Token: 0x06005CFF RID: 23807
		[Token(Token = "0x2000C21")]
		public delegate void StatAdjustmentStep(NPCStatsReportInfoElement element);
	}
}
