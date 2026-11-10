using System;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Terraria.IO
{
	// Token: 0x0200066F RID: 1647
	[Token(Token = "0x200066F")]
	public class PlayerFileData : FileData
	{
		// Token: 0x170007F7 RID: 2039
		// (get) Token: 0x06003F96 RID: 16278 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003F97 RID: 16279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007F7")]
		public Player Player
		{
			[Token(Token = "0x6003F96")]
			[Address(RVA = "0x1E866BC", Offset = "0x1E866BC", VA = "0x1E866BC")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003F97")]
			[Address(RVA = "0x1E866C4", Offset = "0x1E866C4", VA = "0x1E866C4")]
			set
			{
			}
		}

		// Token: 0x06003F98 RID: 16280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F98")]
		[Address(RVA = "0x1E866D8", Offset = "0x1E866D8", VA = "0x1E866D8")]
		public void PreparePetProjectiles()
		{
		}

		// Token: 0x170007F8 RID: 2040
		// (get) Token: 0x06003F99 RID: 16281 RVA: 0x0001F3F8 File Offset: 0x0001D5F8
		[Token(Token = "0x170007F8")]
		public DateTime LastPlayed
		{
			[Token(Token = "0x6003F99")]
			[Address(RVA = "0x1E86810", Offset = "0x1E86810", VA = "0x1E86810")]
			get
			{
				return default(DateTime);
			}
		}

		// Token: 0x06003F9A RID: 16282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F9A")]
		[Address(RVA = "0x1E868B4", Offset = "0x1E868B4", VA = "0x1E868B4")]
		public PlayerFileData()
		{
		}

		// Token: 0x06003F9B RID: 16283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F9B")]
		[Address(RVA = "0x1E86994", Offset = "0x1E86994", VA = "0x1E86994")]
		public PlayerFileData(string path, bool cloudSave)
		{
		}

		// Token: 0x06003F9C RID: 16284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003F9C")]
		[Address(RVA = "0x1E86A84", Offset = "0x1E86A84", VA = "0x1E86A84")]
		public static PlayerFileData CreateAndSave(Player player)
		{
			return null;
		}

		// Token: 0x06003F9D RID: 16285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F9D")]
		[Address(RVA = "0x1E86C8C", Offset = "0x1E86C8C", VA = "0x1E86C8C", Slot = "4")]
		public override void SetAsActive()
		{
		}

		// Token: 0x06003F9E RID: 16286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F9E")]
		[Address(RVA = "0x1E86DF4", Offset = "0x1E86DF4", VA = "0x1E86DF4", Slot = "5")]
		public override void MoveToCloud()
		{
		}

		// Token: 0x06003F9F RID: 16287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003F9F")]
		[Address(RVA = "0x1E871BC", Offset = "0x1E871BC", VA = "0x1E871BC", Slot = "6")]
		public override void MoveToLocal()
		{
		}

		// Token: 0x06003FA0 RID: 16288 RVA: 0x0001F410 File Offset: 0x0001D610
		[Token(Token = "0x6003FA0")]
		[Address(RVA = "0x1E87920", Offset = "0x1E87920", VA = "0x1E87920")]
		private bool MapBelongsToPath(string mapPath, string filePath)
		{
			return default(bool);
		}

		// Token: 0x06003FA1 RID: 16289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FA1")]
		[Address(RVA = "0x1E87A34", Offset = "0x1E87A34", VA = "0x1E87A34")]
		public void UpdatePlayTimer()
		{
		}

		// Token: 0x06003FA2 RID: 16290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FA2")]
		[Address(RVA = "0x1E87AE4", Offset = "0x1E87AE4", VA = "0x1E87AE4")]
		public void OnLostFocus()
		{
		}

		// Token: 0x06003FA3 RID: 16291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FA3")]
		[Address(RVA = "0x1E87A64", Offset = "0x1E87A64", VA = "0x1E87A64")]
		public void StartPlayTimer()
		{
		}

		// Token: 0x06003FA4 RID: 16292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FA4")]
		[Address(RVA = "0x1E87AE0", Offset = "0x1E87AE0", VA = "0x1E87AE0")]
		public void PausePlayTimer()
		{
		}

		// Token: 0x06003FA5 RID: 16293 RVA: 0x0001F428 File Offset: 0x0001D628
		[Token(Token = "0x6003FA5")]
		[Address(RVA = "0x1E87C10", Offset = "0x1E87C10", VA = "0x1E87C10")]
		public TimeSpan GetPlayTime()
		{
			return default(TimeSpan);
		}

		// Token: 0x06003FA6 RID: 16294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FA6")]
		[Address(RVA = "0x1E87CF0", Offset = "0x1E87CF0", VA = "0x1E87CF0")]
		public void UpdatePlayTimerAndKeepState()
		{
		}

		// Token: 0x06003FA7 RID: 16295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FA7")]
		[Address(RVA = "0x1E87AE8", Offset = "0x1E87AE8", VA = "0x1E87AE8")]
		public void StopPlayTimer()
		{
		}

		// Token: 0x06003FA8 RID: 16296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FA8")]
		[Address(RVA = "0x1E87E2C", Offset = "0x1E87E2C", VA = "0x1E87E2C")]
		public void SetPlayTime(TimeSpan time)
		{
		}

		// Token: 0x06003FA9 RID: 16297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FA9")]
		[Address(RVA = "0x1E87E3C", Offset = "0x1E87E3C", VA = "0x1E87E3C")]
		public void Rename(string newName)
		{
		}

		// Token: 0x0400497A RID: 18810
		[Token(Token = "0x400497A")]
		[FieldOffset(Offset = "0x20")]
		private Player _player;

		// Token: 0x0400497B RID: 18811
		[Token(Token = "0x400497B")]
		[FieldOffset(Offset = "0x28")]
		private TimeSpan _playTime;

		// Token: 0x0400497C RID: 18812
		[Token(Token = "0x400497C")]
		[FieldOffset(Offset = "0x30")]
		private readonly Stopwatch _timer;

		// Token: 0x0400497D RID: 18813
		[Token(Token = "0x400497D")]
		[FieldOffset(Offset = "0x34")]
		private bool _isTimerActive;

		// Token: 0x0400497E RID: 18814
		[Token(Token = "0x400497E")]
		[FieldOffset(Offset = "0x38")]
		public DateTime SourceFileTime;

		// Token: 0x0400497F RID: 18815
		[Token(Token = "0x400497F")]
		[FieldOffset(Offset = "0x40")]
		public int fileReleaseVersion;

		// Token: 0x04004980 RID: 18816
		[Token(Token = "0x4004980")]
		[FieldOffset(Offset = "0x44")]
		public Projectile UIPetProjectile;

		// Token: 0x02000670 RID: 1648
		[Token(Token = "0x2000670")]
		private sealed class <>c__DisplayClass18_0
		{
			// Token: 0x06003FAA RID: 16298 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003FAA")]
			[Address(RVA = "0x1E87918", Offset = "0x1E87918", VA = "0x1E87918")]
			public <>c__DisplayClass18_0()
			{
			}

			// Token: 0x06003FAB RID: 16299 RVA: 0x0001F440 File Offset: 0x0001D640
			[Token(Token = "0x6003FAB")]
			[Address(RVA = "0x1E87ED8", Offset = "0x1E87ED8", VA = "0x1E87ED8")]
			internal bool <MoveToLocal>b__0(string path)
			{
				return default(bool);
			}

			// Token: 0x04004981 RID: 18817
			[Token(Token = "0x4004981")]
			[FieldOffset(Offset = "0x8")]
			public string mapPath;
		}
	}
}
