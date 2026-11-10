using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria.Cinematics
{
	// Token: 0x02000912 RID: 2322
	[Token(Token = "0x2000912")]
	public class DSTFilm : Film
	{
		// Token: 0x06004DF1 RID: 19953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DF1")]
		[Address(RVA = "0x72CDD8", Offset = "0x72CDD8", VA = "0x72CDD8")]
		public DSTFilm()
		{
		}

		// Token: 0x06004DF2 RID: 19954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DF2")]
		[Address(RVA = "0x72D42C", Offset = "0x72D42C", VA = "0x72D42C", Slot = "4")]
		public override void OnBegin()
		{
		}

		// Token: 0x06004DF3 RID: 19955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DF3")]
		[Address(RVA = "0x72D658", Offset = "0x72D658", VA = "0x72D658", Slot = "5")]
		public override void OnEnd()
		{
		}

		// Token: 0x06004DF4 RID: 19956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DF4")]
		[Address(RVA = "0x72CE78", Offset = "0x72CE78", VA = "0x72CE78")]
		private void BuildSequence()
		{
		}

		// Token: 0x06004DF5 RID: 19957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DF5")]
		[Address(RVA = "0x72D4A4", Offset = "0x72D4A4", VA = "0x72D4A4")]
		private void PrepareScene()
		{
		}

		// Token: 0x06004DF6 RID: 19958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DF6")]
		[Address(RVA = "0x72D74C", Offset = "0x72D74C", VA = "0x72D74C")]
		private void ClearScene()
		{
		}

		// Token: 0x06004DF7 RID: 19959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DF7")]
		[Address(RVA = "0x72D8A0", Offset = "0x72D8A0", VA = "0x72D8A0")]
		private void EquipDSTShaderItem(FrameEventData evt)
		{
		}

		// Token: 0x06004DF8 RID: 19960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DF8")]
		[Address(RVA = "0x72DA00", Offset = "0x72DA00", VA = "0x72DA00")]
		private void RemoveDSTShaderItem(FrameEventData evt)
		{
		}

		// Token: 0x06004DF9 RID: 19961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DF9")]
		[Address(RVA = "0x72DACC", Offset = "0x72DACC", VA = "0x72DACC")]
		private void CreateDeerclops(FrameEventData evt)
		{
		}

		// Token: 0x06004DFA RID: 19962 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004DFA")]
		[Address(RVA = "0x72DCF8", Offset = "0x72DCF8", VA = "0x72DCF8")]
		private NPC PlaceNPCOnGround(int type, Vector2 position)
		{
			return null;
		}

		// Token: 0x06004DFB RID: 19963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DFB")]
		[Address(RVA = "0x72E008", Offset = "0x72E008", VA = "0x72E008")]
		private void CreateChester(FrameEventData evt)
		{
		}

		// Token: 0x06004DFC RID: 19964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DFC")]
		[Address(RVA = "0x72E2C4", Offset = "0x72E2C4", VA = "0x72E2C4")]
		private void ControlPlayer(FrameEventData evt)
		{
		}

		// Token: 0x06004DFD RID: 19965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DFD")]
		[Address(RVA = "0x72E530", Offset = "0x72E530", VA = "0x72E530")]
		private void StopBeforeCliff(FrameEventData evt)
		{
		}

		// Token: 0x06004DFE RID: 19966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DFE")]
		[Address(RVA = "0x72E5D0", Offset = "0x72E5D0", VA = "0x72E5D0")]
		private void TurnPlayerToTheLeft(FrameEventData evt)
		{
		}

		// Token: 0x06004DFF RID: 19967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004DFF")]
		[Address(RVA = "0x72E740", Offset = "0x72E740", VA = "0x72E740")]
		private void DeerclopsAttack(FrameEventData evt)
		{
		}

		// Token: 0x06004E00 RID: 19968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004E00")]
		[Address(RVA = "0x72DF0C", Offset = "0x72DF0C", VA = "0x72DF0C")]
		private static void FindFloorAt(Vector2 position, out int x, out int y)
		{
		}

		// Token: 0x040092DC RID: 37596
		[Token(Token = "0x40092DC")]
		[FieldOffset(Offset = "0x1C")]
		private NPC _deerclops;

		// Token: 0x040092DD RID: 37597
		[Token(Token = "0x40092DD")]
		[FieldOffset(Offset = "0x20")]
		private Projectile _chester;

		// Token: 0x040092DE RID: 37598
		[Token(Token = "0x40092DE")]
		[FieldOffset(Offset = "0x24")]
		private Vector2 _startPoint;

		// Token: 0x040092DF RID: 37599
		[Token(Token = "0x40092DF")]
		[FieldOffset(Offset = "0x2C")]
		private Item _oldItem;
	}
}
