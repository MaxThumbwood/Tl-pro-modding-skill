using System;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;
using Terraria.IO;
using Terraria.WorldBuilding;

namespace Terraria.GameContent.Biomes
{
	// Token: 0x02000BA3 RID: 2979
	[Token(Token = "0x2000BA3")]
	public class JunglePass : GenPass
	{
		// Token: 0x06005AD7 RID: 23255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AD7")]
		[Address(RVA = "0x938230", Offset = "0x938230", VA = "0x938230")]
		public JunglePass()
		{
		}

		// Token: 0x06005AD8 RID: 23256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AD8")]
		[Address(RVA = "0x9382C8", Offset = "0x9382C8", VA = "0x9382C8", Slot = "4")]
		protected override void ApplyPass(GenerationProgress progress, GameConfiguration configuration)
		{
		}

		// Token: 0x06005AD9 RID: 23257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AD9")]
		[Address(RVA = "0x938E00", Offset = "0x938E00", VA = "0x938E00")]
		private void PlaceGemsAt(int x, int y, ushort baseGem, int gemVariants)
		{
		}

		// Token: 0x06005ADA RID: 23258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ADA")]
		[Address(RVA = "0x938C10", Offset = "0x938C10", VA = "0x938C10")]
		private void PlaceFirstPassMud(int x, int y, int xSpeedScale)
		{
		}

		// Token: 0x06005ADB RID: 23259 RVA: 0x0002AA08 File Offset: 0x00028C08
		[Token(Token = "0x6005ADB")]
		[Address(RVA = "0x938908", Offset = "0x938908", VA = "0x938908")]
		private Point CreateStartPoint()
		{
			return default(Point);
		}

		// Token: 0x06005ADC RID: 23260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ADC")]
		[Address(RVA = "0x938A08", Offset = "0x938A08", VA = "0x938A08")]
		private void ApplyRandomMovement(ref int x, ref int y, int xRange, int yRange)
		{
		}

		// Token: 0x06005ADD RID: 23261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ADD")]
		[Address(RVA = "0x939068", Offset = "0x939068", VA = "0x939068")]
		private void GenerateTunnelToSurface(int i, int j)
		{
		}

		// Token: 0x06005ADE RID: 23262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ADE")]
		[Address(RVA = "0x93A6A8", Offset = "0x93A6A8", VA = "0x93A6A8")]
		private void GenerateHolesInMudWalls()
		{
		}

		// Token: 0x06005ADF RID: 23263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005ADF")]
		[Address(RVA = "0x93AA00", Offset = "0x93AA00", VA = "0x93AA00")]
		private void GenerateFinishingTouches(GenerationProgress progress, int oldX, int oldY)
		{
		}

		// Token: 0x04009BE8 RID: 39912
		[Token(Token = "0x4009BE8")]
		[FieldOffset(Offset = "0x18")]
		private double _worldScale;
	}
}
