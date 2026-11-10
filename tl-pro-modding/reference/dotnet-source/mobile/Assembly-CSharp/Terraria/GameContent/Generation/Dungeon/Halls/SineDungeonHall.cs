using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using ReLogic.Utilities;

namespace Terraria.GameContent.Generation.Dungeon.Halls
{
	// Token: 0x02000B5E RID: 2910
	[Token(Token = "0x2000B5E")]
	public class SineDungeonHall : DungeonHall
	{
		// Token: 0x060059C1 RID: 22977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059C1")]
		[Address(RVA = "0x8B6504", Offset = "0x8B6504", VA = "0x8B6504")]
		public SineDungeonHall(DungeonHallSettings settings)
		{
		}

		// Token: 0x060059C2 RID: 22978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059C2")]
		[Address(RVA = "0x8B6608", Offset = "0x8B6608", VA = "0x8B6608", Slot = "5")]
		public override void CalculatePlatformsAndDoors(DungeonData data)
		{
		}

		// Token: 0x060059C3 RID: 22979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059C3")]
		[Address(RVA = "0x8B68F8", Offset = "0x8B68F8", VA = "0x8B68F8", Slot = "4")]
		public override void CalculateHall(DungeonData data, Vector2D startPoint, Vector2D endPoint)
		{
		}

		// Token: 0x060059C4 RID: 22980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059C4")]
		[Address(RVA = "0x8B7660", Offset = "0x8B7660", VA = "0x8B7660", Slot = "6")]
		public override void GenerateHall(DungeonData data)
		{
		}

		// Token: 0x060059C5 RID: 22981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059C5")]
		[Address(RVA = "0x8B6950", Offset = "0x8B6950", VA = "0x8B6950")]
		public void SineHall(DungeonData data, Vector2D startPoint, Vector2D endPoint, bool generating = false)
		{
		}

		// Token: 0x04009B4B RID: 39755
		[Token(Token = "0x4009B4B")]
		[FieldOffset(Offset = "0x5C")]
		public List<Tuple<Vector2D, Vector2D>> PotentialPlatformPoints;
	}
}
