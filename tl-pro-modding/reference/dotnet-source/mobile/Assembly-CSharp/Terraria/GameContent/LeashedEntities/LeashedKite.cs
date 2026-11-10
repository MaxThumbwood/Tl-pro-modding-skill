using System;
using System.IO;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent.LeashedEntities
{
	// Token: 0x02000A5F RID: 2655
	[Token(Token = "0x2000A5F")]
	public class LeashedKite : LeashedEntity
	{
		// Token: 0x060054F4 RID: 21748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054F4")]
		[Address(RVA = "0x8206E4", Offset = "0x8206E4", VA = "0x8206E4")]
		public void SetDefaults(int projType)
		{
		}

		// Token: 0x060054F5 RID: 21749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054F5")]
		[Address(RVA = "0x8207B0", Offset = "0x8207B0", VA = "0x8207B0", Slot = "9")]
		public override void NetSend(BinaryWriter writer, bool full)
		{
		}

		// Token: 0x060054F6 RID: 21750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054F6")]
		[Address(RVA = "0x820968", Offset = "0x820968", VA = "0x820968", Slot = "10")]
		public override void NetReceive(BinaryReader reader, bool full)
		{
		}

		// Token: 0x060054F7 RID: 21751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054F7")]
		[Address(RVA = "0x820CF8", Offset = "0x820CF8", VA = "0x820CF8")]
		private void FixFirstTimeAppearance()
		{
		}

		// Token: 0x170009D2 RID: 2514
		// (get) Token: 0x060054F8 RID: 21752 RVA: 0x000274B0 File Offset: 0x000256B0
		[Token(Token = "0x170009D2")]
		private Vector2 AnchorWorldPosition
		{
			[Token(Token = "0x60054F8")]
			[Address(RVA = "0x820DA4", Offset = "0x820DA4", VA = "0x820DA4")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x060054F9 RID: 21753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054F9")]
		[Address(RVA = "0x820E38", Offset = "0x820E38", VA = "0x820E38", Slot = "8")]
		public override void Draw()
		{
		}

		// Token: 0x060054FA RID: 21754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054FA")]
		[Address(RVA = "0x821300", Offset = "0x821300", VA = "0x821300", Slot = "7")]
		public override void Update()
		{
		}

		// Token: 0x060054FB RID: 21755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054FB")]
		[Address(RVA = "0x821308", Offset = "0x821308", VA = "0x821308")]
		public void Update(bool fastForward)
		{
		}

		// Token: 0x060054FC RID: 21756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054FC")]
		[Address(RVA = "0x8217C4", Offset = "0x8217C4", VA = "0x8217C4")]
		private void MoveKite(bool fastForward = false)
		{
		}

		// Token: 0x060054FD RID: 21757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054FD")]
		[Address(RVA = "0x8228F0", Offset = "0x8228F0", VA = "0x8228F0", Slot = "5")]
		public override void Spawn(bool newlyAdded)
		{
		}

		// Token: 0x060054FE RID: 21758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054FE")]
		[Address(RVA = "0x821030", Offset = "0x821030", VA = "0x821030")]
		private void CopyToDummy()
		{
		}

		// Token: 0x060054FF RID: 21759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054FF")]
		[Address(RVA = "0x822740", Offset = "0x822740", VA = "0x822740")]
		private void CopyFromDummy()
		{
		}

		// Token: 0x06005500 RID: 21760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005500")]
		[Address(RVA = "0x822C5C", Offset = "0x822C5C", VA = "0x822C5C")]
		public LeashedKite()
		{
		}

		// Token: 0x0400984C RID: 38988
		[Token(Token = "0x400984C")]
		[FieldOffset(Offset = "0x0")]
		public static LeashedKite Prototype;

		// Token: 0x0400984D RID: 38989
		[Token(Token = "0x400984D")]
		[FieldOffset(Offset = "0x4")]
		private static Projectile _dummy;

		// Token: 0x0400984E RID: 38990
		[Token(Token = "0x400984E")]
		[FieldOffset(Offset = "0x38")]
		public int projType;

		// Token: 0x0400984F RID: 38991
		[Token(Token = "0x400984F")]
		[FieldOffset(Offset = "0x3C")]
		public int frame;

		// Token: 0x04009850 RID: 38992
		[Token(Token = "0x4009850")]
		[FieldOffset(Offset = "0x40")]
		public int frameCounter;

		// Token: 0x04009851 RID: 38993
		[Token(Token = "0x4009851")]
		[FieldOffset(Offset = "0x44")]
		public float rotation;

		// Token: 0x04009852 RID: 38994
		[Token(Token = "0x4009852")]
		[FieldOffset(Offset = "0x48")]
		public int spriteDirection;

		// Token: 0x04009853 RID: 38995
		[Token(Token = "0x4009853")]
		[FieldOffset(Offset = "0x4C")]
		public float kiteDistance;

		// Token: 0x04009854 RID: 38996
		[Token(Token = "0x4009854")]
		[FieldOffset(Offset = "0x50")]
		public float windTarget;

		// Token: 0x04009855 RID: 38997
		[Token(Token = "0x4009855")]
		[FieldOffset(Offset = "0x54")]
		public float windCurrent;

		// Token: 0x04009856 RID: 38998
		[Token(Token = "0x4009856")]
		[FieldOffset(Offset = "0x58")]
		public float timeCounter;

		// Token: 0x04009857 RID: 38999
		[Token(Token = "0x4009857")]
		[FieldOffset(Offset = "0x5C")]
		public float cloudAlpha;

		// Token: 0x04009858 RID: 39000
		[Token(Token = "0x4009858")]
		[FieldOffset(Offset = "0x60")]
		public int timeWithoutWind;

		// Token: 0x04009859 RID: 39001
		[Token(Token = "0x4009859")]
		[FieldOffset(Offset = "0x64")]
		public float projectileLocalAI0;

		// Token: 0x0400985A RID: 39002
		[Token(Token = "0x400985A")]
		[FieldOffset(Offset = "0x68")]
		public float projectileLocalAI1;

		// Token: 0x0400985B RID: 39003
		[Token(Token = "0x400985B")]
		[FieldOffset(Offset = "0x6C")]
		public Vector2_DynamicArray_120 oldPos;

		// Token: 0x0400985C RID: 39004
		[Token(Token = "0x400985C")]
		[FieldOffset(Offset = "0x430")]
		public Float_DynamicArray_120 oldRot;

		// Token: 0x0400985D RID: 39005
		[Token(Token = "0x400985D")]
		[FieldOffset(Offset = "0x614")]
		public Int_DynamicArray_120 oldSpriteDirection;

		// Token: 0x0400985E RID: 39006
		[Token(Token = "0x400985E")]
		[FieldOffset(Offset = "0x7F8")]
		public Vector2 netOffset;
	}
}
