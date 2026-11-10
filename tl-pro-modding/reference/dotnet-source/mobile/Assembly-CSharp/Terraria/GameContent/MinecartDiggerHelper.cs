using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent
{
	// Token: 0x02000938 RID: 2360
	[Token(Token = "0x2000938")]
	public class MinecartDiggerHelper
	{
		// Token: 0x06004EC5 RID: 20165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EC5")]
		[Address(RVA = "0x73A868", Offset = "0x73A868", VA = "0x73A868")]
		public void TryDigging(Player player, Vector2 trackWorldPosition, int digDirectionX, int digDirectionY)
		{
		}

		// Token: 0x06004EC6 RID: 20166 RVA: 0x00024A68 File Offset: 0x00022C68
		[Token(Token = "0x6004EC6")]
		[Address(RVA = "0x73B2B0", Offset = "0x73B2B0", VA = "0x73B2B0")]
		private bool CanConsumeATrackItem(Player player)
		{
			return default(bool);
		}

		// Token: 0x06004EC7 RID: 20167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EC7")]
		[Address(RVA = "0x73B54C", Offset = "0x73B54C", VA = "0x73B54C")]
		private void ConsumeATrackItem(Player player)
		{
		}

		// Token: 0x06004EC8 RID: 20168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004EC8")]
		[Address(RVA = "0x73BA88", Offset = "0x73BA88", VA = "0x73BA88")]
		private Item FindMinecartTrackItem(Player player)
		{
			return null;
		}

		// Token: 0x06004EC9 RID: 20169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004EC9")]
		[Address(RVA = "0x73BB58", Offset = "0x73BB58", VA = "0x73BB58")]
		private void PoundTrack(Point spot)
		{
		}

		// Token: 0x06004ECA RID: 20170 RVA: 0x00024A80 File Offset: 0x00022C80
		[Token(Token = "0x6004ECA")]
		[Address(RVA = "0x73ABF8", Offset = "0x73ABF8", VA = "0x73ABF8")]
		private bool AlreadyLeadsIntoWantedTrack(Point tileCoordsOfFrontWheel, Point tileCoordsWeWantToReach)
		{
			return default(bool);
		}

		// Token: 0x06004ECB RID: 20171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004ECB")]
		[Address(RVA = "0x73BD60", Offset = "0x73BD60", VA = "0x73BD60")]
		private static void GetExpectedDirections(Point startCoords, Point endCoords, out int? expectedStartLeft, out int? expectedStartRight, out int? expectedEndLeft, out int? expectedEndRight)
		{
		}

		// Token: 0x06004ECC RID: 20172 RVA: 0x00024A98 File Offset: 0x00022C98
		[Token(Token = "0x6004ECC")]
		[Address(RVA = "0x73B708", Offset = "0x73B708", VA = "0x73B708")]
		private bool DoTheTracksConnectProperly(Point tileCoordsOfFrontWheel, Point tileCoordsWeWantToReach)
		{
			return default(bool);
		}

		// Token: 0x06004ECD RID: 20173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004ECD")]
		[Address(RVA = "0x73B724", Offset = "0x73B724", VA = "0x73B724")]
		private void CorrectTrackConnections(Point startCoords, Point endCoords)
		{
		}

		// Token: 0x06004ECE RID: 20174 RVA: 0x00024AB0 File Offset: 0x00022CB0
		[Token(Token = "0x6004ECE")]
		[Address(RVA = "0x73B27C", Offset = "0x73B27C", VA = "0x73B27C")]
		private bool HasPickPower(Player player, int x, int y)
		{
			return default(bool);
		}

		// Token: 0x06004ECF RID: 20175 RVA: 0x00024AC8 File Offset: 0x00022CC8
		[Token(Token = "0x6004ECF")]
		[Address(RVA = "0x73AFC8", Offset = "0x73AFC8", VA = "0x73AFC8")]
		private bool CanGetPastTile(int x, int y)
		{
			return default(bool);
		}

		// Token: 0x06004ED0 RID: 20176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004ED0")]
		[Address(RVA = "0x73B5B4", Offset = "0x73B5B4", VA = "0x73B5B4")]
		private void PlaceATrack(int x, int y)
		{
		}

		// Token: 0x06004ED1 RID: 20177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004ED1")]
		[Address(RVA = "0x73B2C4", Offset = "0x73B2C4", VA = "0x73B2C4")]
		private void MineTheTileIfNecessary(int x, int y)
		{
		}

		// Token: 0x06004ED2 RID: 20178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004ED2")]
		[Address(RVA = "0x73BEB0", Offset = "0x73BEB0", VA = "0x73BEB0")]
		public MinecartDiggerHelper()
		{
		}

		// Token: 0x04009340 RID: 37696
		[Token(Token = "0x4009340")]
		[FieldOffset(Offset = "0x0")]
		public static MinecartDiggerHelper Instance;
	}
}
