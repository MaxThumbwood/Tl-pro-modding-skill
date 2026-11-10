using System;
using Il2CppDummyDll;

namespace Terraria.GameContent.Generation.Dungeon.Features
{
	// Token: 0x02000B7D RID: 2941
	[Token(Token = "0x2000B7D")]
	public abstract class DungeonWindowSettings : DungeonFeatureSettings
	{
		// Token: 0x06005A24 RID: 23076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A24")]
		[Address(RVA = "0x8EC9A8", Offset = "0x8EC9A8", VA = "0x8EC9A8")]
		protected DungeonWindowSettings()
		{
		}

		// Token: 0x04009B83 RID: 39811
		[Token(Token = "0x4009B83")]
		[FieldOffset(Offset = "0x8")]
		public DungeonGenerationStyleData Style;

		// Token: 0x04009B84 RID: 39812
		[Token(Token = "0x4009B84")]
		[FieldOffset(Offset = "0xC")]
		public int OverrideGlassPaint;

		// Token: 0x04009B85 RID: 39813
		[Token(Token = "0x4009B85")]
		[FieldOffset(Offset = "0x10")]
		public int OverrideGlassType;

		// Token: 0x04009B86 RID: 39814
		[Token(Token = "0x4009B86")]
		[FieldOffset(Offset = "0x14")]
		public bool Closed;
	}
}
