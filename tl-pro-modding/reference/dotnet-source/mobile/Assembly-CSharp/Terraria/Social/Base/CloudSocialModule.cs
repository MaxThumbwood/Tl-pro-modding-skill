using System;
using System.Collections.Generic;
using System.IO;
using Il2CppDummyDll;
using Terraria.IO;

namespace Terraria.Social.Base
{
	// Token: 0x0200062F RID: 1583
	[Token(Token = "0x200062F")]
	public abstract class CloudSocialModule : FileAPI
	{
		// Token: 0x06003DAD RID: 15789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DAD")]
		[Address(RVA = "0x1E635DC", Offset = "0x1E635DC", VA = "0x1E635DC", Slot = "6")]
		public virtual void Initialize()
		{
		}

		// Token: 0x06003DAE RID: 15790
		[Token(Token = "0x6003DAE")]
		public abstract void Shutdown();

		// Token: 0x06003DAF RID: 15791
		[Token(Token = "0x6003DAF")]
		public abstract IEnumerable<string> GetFiles();

		// Token: 0x06003DB0 RID: 15792
		[Token(Token = "0x6003DB0")]
		public abstract bool Write(string path, byte[] data, int length);

		// Token: 0x06003DB1 RID: 15793
		[Token(Token = "0x6003DB1")]
		public abstract void Read(string path, byte[] buffer, int length);

		// Token: 0x06003DB2 RID: 15794
		[Token(Token = "0x6003DB2")]
		public abstract Stream OpenRead(string file);

		// Token: 0x06003DB3 RID: 15795
		[Token(Token = "0x6003DB3")]
		public abstract bool HasFile(string path);

		// Token: 0x06003DB4 RID: 15796
		[Token(Token = "0x6003DB4")]
		public abstract int GetFileSize(string path);

		// Token: 0x06003DB5 RID: 15797
		[Token(Token = "0x6003DB5")]
		public abstract bool Delete(string path);

		// Token: 0x06003DB6 RID: 15798
		[Token(Token = "0x6003DB6")]
		public abstract bool Forget(string path);

		// Token: 0x06003DB7 RID: 15799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003DB7")]
		[Address(RVA = "0x1E67D8C", Offset = "0x1E67D8C", VA = "0x1E67D8C")]
		public byte[] Read(string path)
		{
			return null;
		}

		// Token: 0x06003DB8 RID: 15800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DB8")]
		[Address(RVA = "0x1E67E3C", Offset = "0x1E67E3C", VA = "0x1E67E3C")]
		public void Read(string path, byte[] buffer)
		{
		}

		// Token: 0x06003DB9 RID: 15801 RVA: 0x0001EA50 File Offset: 0x0001CC50
		[Token(Token = "0x6003DB9")]
		[Address(RVA = "0x1E67E88", Offset = "0x1E67E88", VA = "0x1E67E88")]
		public bool Write(string path, byte[] data)
		{
			return default(bool);
		}

		// Token: 0x06003DBA RID: 15802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DBA")]
		[Address(RVA = "0x1E63F04", Offset = "0x1E63F04", VA = "0x1E63F04")]
		protected CloudSocialModule()
		{
		}

		// Token: 0x06003DBB RID: 15803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DBB")]
		[Address(RVA = "0x1E67ED4", Offset = "0x1E67ED4", VA = "0x1E67ED4")]
		private void <Initialize>b__1_0(Preferences preferences)
		{
		}

		// Token: 0x06003DBC RID: 15804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003DBC")]
		[Address(RVA = "0x1E67F60", Offset = "0x1E67F60", VA = "0x1E67F60")]
		private void <Initialize>b__1_1(Preferences preferences)
		{
		}

		// Token: 0x04004870 RID: 18544
		[Token(Token = "0x4004870")]
		[FieldOffset(Offset = "0x8")]
		public bool EnabledByDefault;
	}
}
