using System;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;

namespace Terraria.Localization
{
	// Token: 0x02000665 RID: 1637
	[Token(Token = "0x2000665")]
	public class NetworkText
	{
		// Token: 0x06003F63 RID: 16227 RVA: 0x0001F338 File Offset: 0x0001D538
		[Token(Token = "0x6003F63")]
		[Address(RVA = "0x1E82BA4", Offset = "0x1E82BA4", VA = "0x1E82BA4")]
		public bool IsFromKey(string key)
		{
			return default(bool);
		}

		// Token: 0x06003F64 RID: 16228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F64")]
		[Address(RVA = "0x1E82BDC", Offset = "0x1E82BDC", VA = "0x1E82BDC")]
		private NetworkText(string text, NetworkText.Mode mode)
		{
		}

		// Token: 0x06003F65 RID: 16229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F65")]
		[Address(RVA = "0x1E83374", Offset = "0x1E83374", VA = "0x1E83374")]
		private static NetworkText[] ConvertSubstitutionsToNetworkText(object[] substitutions)
		{
			return null;
		}

		// Token: 0x06003F66 RID: 16230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F66")]
		[Address(RVA = "0x1E835B8", Offset = "0x1E835B8", VA = "0x1E835B8")]
		public static NetworkText FromFormattable(string text, object[] substitutions)
		{
			return null;
		}

		// Token: 0x06003F67 RID: 16231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F67")]
		[Address(RVA = "0x1E83544", Offset = "0x1E83544", VA = "0x1E83544")]
		public static NetworkText FromLiteral(string text)
		{
			return null;
		}

		// Token: 0x06003F68 RID: 16232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F68")]
		[Address(RVA = "0x1E82514", Offset = "0x1E82514", VA = "0x1E82514")]
		public static NetworkText FromKey(string key, object[] substitutions)
		{
			return null;
		}

		// Token: 0x06003F69 RID: 16233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F69")]
		[Address(RVA = "0x1E83660", Offset = "0x1E83660", VA = "0x1E83660")]
		public void Serialize(BinaryWriter writer)
		{
		}

		// Token: 0x06003F6A RID: 16234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F6A")]
		[Address(RVA = "0x1E836CC", Offset = "0x1E836CC", VA = "0x1E836CC")]
		private void SerializeSubstitutionList(BinaryWriter writer)
		{
		}

		// Token: 0x06003F6B RID: 16235 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F6B")]
		[Address(RVA = "0x1E837B4", Offset = "0x1E837B4", VA = "0x1E837B4")]
		public static NetworkText Deserialize(BinaryReader reader, bool disableFilter = false)
		{
			return null;
		}

		// Token: 0x06003F6C RID: 16236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F6C")]
		[Address(RVA = "0x1E83A3C", Offset = "0x1E83A3C", VA = "0x1E83A3C")]
		public static NetworkText DeserializeLiteral(BinaryReader reader)
		{
			return null;
		}

		// Token: 0x06003F6D RID: 16237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F6D")]
		[Address(RVA = "0x1E838EC", Offset = "0x1E838EC", VA = "0x1E838EC")]
		private void DeserializeSubstitutionList(BinaryReader reader)
		{
		}

		// Token: 0x06003F6E RID: 16238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F6E")]
		[Address(RVA = "0x1E83BD0", Offset = "0x1E83BD0", VA = "0x1E83BD0")]
		private void SetToEmptyLiteral()
		{
		}

		// Token: 0x06003F6F RID: 16239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F6F")]
		[Address(RVA = "0x1E83C34", Offset = "0x1E83C34", VA = "0x1E83C34")]
		private static NetworkText FilterEmbeddedPlayerName(NetworkText source)
		{
			return null;
		}

		// Token: 0x06003F70 RID: 16240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F70")]
		[Address(RVA = "0x1E83C58", Offset = "0x1E83C58", VA = "0x1E83C58", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06003F71 RID: 16241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F71")]
		[Address(RVA = "0x1E843E8", Offset = "0x1E843E8", VA = "0x1E843E8")]
		private string ToDebugInfoString(string linePrefix = "")
		{
			return null;
		}

		// Token: 0x04004952 RID: 18770
		[Token(Token = "0x4004952")]
		[FieldOffset(Offset = "0x0")]
		public static readonly NetworkText Empty;

		// Token: 0x04004953 RID: 18771
		[Token(Token = "0x4004953")]
		[FieldOffset(Offset = "0x8")]
		private NetworkText[] _substitutions;

		// Token: 0x04004954 RID: 18772
		[Token(Token = "0x4004954")]
		[FieldOffset(Offset = "0xC")]
		private string _text;

		// Token: 0x04004955 RID: 18773
		[Token(Token = "0x4004955")]
		[FieldOffset(Offset = "0x10")]
		private NetworkText.Mode _mode;

		// Token: 0x04004956 RID: 18774
		[Token(Token = "0x4004956")]
		[FieldOffset(Offset = "0x14")]
		private Dictionary<string, int[]> NetworkPlayerKeys;

		// Token: 0x02000666 RID: 1638
		[Token(Token = "0x2000666")]
		public enum Mode : byte
		{
			// Token: 0x04004958 RID: 18776
			[Token(Token = "0x4004958")]
			Literal,
			// Token: 0x04004959 RID: 18777
			[Token(Token = "0x4004959")]
			Formattable,
			// Token: 0x0400495A RID: 18778
			[Token(Token = "0x400495A")]
			LocalizationKey
		}
	}
}
