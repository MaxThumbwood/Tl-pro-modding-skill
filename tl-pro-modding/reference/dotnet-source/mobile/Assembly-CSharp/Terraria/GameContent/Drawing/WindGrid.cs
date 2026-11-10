using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Microsoft.Xna.Framework;

namespace Terraria.GameContent.Drawing
{
	// Token: 0x02000CB5 RID: 3253
	[Token(Token = "0x2000CB5")]
	public class WindGrid
	{
		// Token: 0x060060E6 RID: 24806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060E6")]
		[Address(RVA = "0xAA01E8", Offset = "0xAA01E8", VA = "0xAA01E8")]
		public void SetSize(int targetWidth, int targetHeight)
		{
		}

		// Token: 0x060060E7 RID: 24807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060E7")]
		[Address(RVA = "0xAA0348", Offset = "0xAA0348", VA = "0xAA0348")]
		public void Update()
		{
		}

		// Token: 0x060060E8 RID: 24808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060E8")]
		[Address(RVA = "0xAA057C", Offset = "0xAA057C", VA = "0xAA057C")]
		public void GetWindTime(int tileX, int tileY, int timeThreshold, out int windTimeLeft, out int directionX, out int directionY)
		{
		}

		// Token: 0x060060E9 RID: 24809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060E9")]
		[Address(RVA = "0xAA0284", Offset = "0xAA0284", VA = "0xAA0284")]
		private void ResizeGrid()
		{
		}

		// Token: 0x060060EA RID: 24810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060EA")]
		[Address(RVA = "0xAA061C", Offset = "0xAA061C", VA = "0xAA061C")]
		private void SetWindTime(int tileX, int tileY, int directionX, int directionY)
		{
		}

		// Token: 0x060060EB RID: 24811 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060EB")]
		[Address(RVA = "0xAA03C8", Offset = "0xAA03C8", VA = "0xAA03C8")]
		private void ScanPlayers()
		{
		}

		// Token: 0x060060EC RID: 24812 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060EC")]
		[Address(RVA = "0xAA06E0", Offset = "0xAA06E0", VA = "0xAA06E0")]
		private void ScanPlayer(int i)
		{
		}

		// Token: 0x060060ED RID: 24813 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60060ED")]
		[Address(RVA = "0xAA0C68", Offset = "0xAA0C68", VA = "0xAA0C68")]
		public WindGrid()
		{
		}

		// Token: 0x04009FAB RID: 40875
		[Token(Token = "0x4009FAB")]
		[FieldOffset(Offset = "0x8")]
		private WindGrid.WindCoord[,] _grid;

		// Token: 0x04009FAC RID: 40876
		[Token(Token = "0x4009FAC")]
		[FieldOffset(Offset = "0xC")]
		private int _width;

		// Token: 0x04009FAD RID: 40877
		[Token(Token = "0x4009FAD")]
		[FieldOffset(Offset = "0x10")]
		private int _height;

		// Token: 0x04009FAE RID: 40878
		[Token(Token = "0x4009FAE")]
		[FieldOffset(Offset = "0x14")]
		private int _gameTime;

		// Token: 0x04009FAF RID: 40879
		[Token(Token = "0x4009FAF")]
		[FieldOffset(Offset = "0x0")]
		private static List<Point> points;

		// Token: 0x02000CB6 RID: 3254
		[Token(Token = "0x2000CB6")]
		private struct WindCoord
		{
			// Token: 0x04009FB0 RID: 40880
			[Token(Token = "0x4009FB0")]
			[FieldOffset(Offset = "0x0")]
			public int Time;

			// Token: 0x04009FB1 RID: 40881
			[Token(Token = "0x4009FB1")]
			[FieldOffset(Offset = "0x4")]
			public int DirectionX;

			// Token: 0x04009FB2 RID: 40882
			[Token(Token = "0x4009FB2")]
			[FieldOffset(Offset = "0x8")]
			public int DirectionY;
		}
	}
}
