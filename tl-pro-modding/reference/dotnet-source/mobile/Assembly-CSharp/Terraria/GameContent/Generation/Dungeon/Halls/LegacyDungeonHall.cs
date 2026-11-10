using System;
using Il2CppDummyDll;
using ReLogic.Utilities;

namespace Terraria.GameContent.Generation.Dungeon.Halls
{
	// Token: 0x02000B58 RID: 2904
	[Token(Token = "0x2000B58")]
	public class LegacyDungeonHall : DungeonHall
	{
		// Token: 0x060059B0 RID: 22960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059B0")]
		[Address(RVA = "0x8AF628", Offset = "0x8AF628", VA = "0x8AF628")]
		public LegacyDungeonHall(DungeonHallSettings settings)
		{
		}

		// Token: 0x060059B1 RID: 22961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059B1")]
		[Address(RVA = "0x8AF6AC", Offset = "0x8AF6AC", VA = "0x8AF6AC", Slot = "5")]
		public override void CalculatePlatformsAndDoors(DungeonData data)
		{
		}

		// Token: 0x060059B2 RID: 22962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059B2")]
		[Address(RVA = "0x8AF814", Offset = "0x8AF814", VA = "0x8AF814", Slot = "4")]
		public override void CalculateHall(DungeonData data, Vector2D startPoint, Vector2D endPoint)
		{
		}

		// Token: 0x060059B3 RID: 22963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059B3")]
		[Address(RVA = "0x8AF88C", Offset = "0x8AF88C", VA = "0x8AF88C", Slot = "6")]
		public override void GenerateHall(DungeonData data)
		{
		}

		// Token: 0x060059B4 RID: 22964 RVA: 0x0002A048 File Offset: 0x00028248
		[Token(Token = "0x60059B4")]
		[Address(RVA = "0x8ADD00", Offset = "0x8ADD00", VA = "0x8ADD00")]
		public bool GenerateHall(DungeonData data, int x, int y)
		{
			return default(bool);
		}

		// Token: 0x060059B5 RID: 22965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059B5")]
		[Address(RVA = "0x8AF8D8", Offset = "0x8AF8D8", VA = "0x8AF8D8", Slot = "10")]
		public virtual void LegacyHall(DungeonData dungeonData, int i, int j, bool generating = false)
		{
		}

		// Token: 0x04009B3F RID: 39743
		[Token(Token = "0x4009B3F")]
		[FieldOffset(Offset = "0x60")]
		public Vector2D LastHall;

		// Token: 0x04009B40 RID: 39744
		[Token(Token = "0x4009B40")]
		[FieldOffset(Offset = "0x70")]
		public int Strength;

		// Token: 0x04009B41 RID: 39745
		[Token(Token = "0x4009B41")]
		[FieldOffset(Offset = "0x74")]
		public int Steps;

		// Token: 0x04009B42 RID: 39746
		[Token(Token = "0x4009B42")]
		[FieldOffset(Offset = "0x78")]
		protected Vector2D OverrideStartPosition;

		// Token: 0x04009B43 RID: 39747
		[Token(Token = "0x4009B43")]
		[FieldOffset(Offset = "0x88")]
		protected Vector2D OverrideEndPosition;
	}
}
