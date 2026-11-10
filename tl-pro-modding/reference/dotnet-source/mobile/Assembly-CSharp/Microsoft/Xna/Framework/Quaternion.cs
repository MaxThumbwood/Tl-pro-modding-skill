using System;
using Il2CppDummyDll;

namespace Microsoft.Xna.Framework
{
	// Token: 0x02000399 RID: 921
	[Token(Token = "0x2000399")]
	[Serializable]
	public struct Quaternion : FileAPI
	{
		// Token: 0x060016F0 RID: 5872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016F0")]
		[Address(RVA = "0xE15518", Offset = "0xE15518", VA = "0xE15518")]
		public Quaternion(float x, float y, float z, float w)
		{
		}

		// Token: 0x060016F1 RID: 5873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016F1")]
		[Address(RVA = "0xE15524", Offset = "0xE15524", VA = "0xE15524")]
		public Quaternion(Vector3 vectorPart, float scalarPart)
		{
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x060016F2 RID: 5874 RVA: 0x0000A698 File Offset: 0x00008898
		[Token(Token = "0x1700022E")]
		public static Quaternion Identity
		{
			[Token(Token = "0x60016F2")]
			[Address(RVA = "0xE15530", Offset = "0xE15530", VA = "0xE15530")]
			get
			{
				return default(Quaternion);
			}
		}

		// Token: 0x060016F3 RID: 5875 RVA: 0x0000A6B0 File Offset: 0x000088B0
		[Token(Token = "0x60016F3")]
		[Address(RVA = "0xE1559C", Offset = "0xE1559C", VA = "0xE1559C")]
		public static Quaternion Add(Quaternion quaternion1, Quaternion quaternion2)
		{
			return default(Quaternion);
		}

		// Token: 0x060016F4 RID: 5876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016F4")]
		[Address(RVA = "0xE155E0", Offset = "0xE155E0", VA = "0xE155E0")]
		public static void Add(ref Quaternion quaternion1, ref Quaternion quaternion2, out Quaternion result)
		{
		}

		// Token: 0x060016F5 RID: 5877 RVA: 0x0000A6C8 File Offset: 0x000088C8
		[Token(Token = "0x60016F5")]
		[Address(RVA = "0xE155F4", Offset = "0xE155F4", VA = "0xE155F4")]
		public static Quaternion Concatenate(Quaternion value1, Quaternion value2)
		{
			return default(Quaternion);
		}

		// Token: 0x060016F6 RID: 5878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016F6")]
		[Address(RVA = "0xE15668", Offset = "0xE15668", VA = "0xE15668")]
		public void Conjugate()
		{
		}

		// Token: 0x060016F7 RID: 5879 RVA: 0x0000A6E0 File Offset: 0x000088E0
		[Token(Token = "0x60016F7")]
		[Address(RVA = "0xE15690", Offset = "0xE15690", VA = "0xE15690")]
		public static Quaternion Conjugate(Quaternion value)
		{
			return default(Quaternion);
		}

		// Token: 0x060016F8 RID: 5880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016F8")]
		[Address(RVA = "0xE156A8", Offset = "0xE156A8", VA = "0xE156A8")]
		public static void Conjugate(ref Quaternion value, out Quaternion result)
		{
		}

		// Token: 0x060016F9 RID: 5881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016F9")]
		[Address(RVA = "0xE156D8", Offset = "0xE156D8", VA = "0xE156D8")]
		public static void Concatenate(ref Quaternion value1, ref Quaternion value2, out Quaternion result)
		{
		}

		// Token: 0x060016FA RID: 5882 RVA: 0x0000A6F8 File Offset: 0x000088F8
		[Token(Token = "0x60016FA")]
		[Address(RVA = "0xE15764", Offset = "0xE15764", VA = "0xE15764")]
		public static Quaternion CreateFromYawPitchRoll(float yaw, float pitch, float roll)
		{
			return default(Quaternion);
		}

		// Token: 0x060016FB RID: 5883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016FB")]
		[Address(RVA = "0xE158A4", Offset = "0xE158A4", VA = "0xE158A4")]
		public static void CreateFromYawPitchRoll(float yaw, float pitch, float roll, out Quaternion result)
		{
		}

		// Token: 0x060016FC RID: 5884 RVA: 0x0000A710 File Offset: 0x00008910
		[Token(Token = "0x60016FC")]
		[Address(RVA = "0xE159E4", Offset = "0xE159E4", VA = "0xE159E4")]
		public static Quaternion CreateFromAxisAngle(Vector3 axis, float angle)
		{
			return default(Quaternion);
		}

		// Token: 0x060016FD RID: 5885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016FD")]
		[Address(RVA = "0xE15AB4", Offset = "0xE15AB4", VA = "0xE15AB4")]
		public static void CreateFromAxisAngle(ref Vector3 axis, float angle, out Quaternion result)
		{
		}

		// Token: 0x060016FE RID: 5886 RVA: 0x0000A728 File Offset: 0x00008928
		[Token(Token = "0x60016FE")]
		[Address(RVA = "0xE15B80", Offset = "0xE15B80", VA = "0xE15B80")]
		public static Quaternion CreateFromRotationMatrix(Matrix matrix)
		{
			return default(Quaternion);
		}

		// Token: 0x060016FF RID: 5887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60016FF")]
		[Address(RVA = "0xE15E04", Offset = "0xE15E04", VA = "0xE15E04")]
		public static void CreateFromRotationMatrix(ref Matrix matrix, out Quaternion result)
		{
		}

		// Token: 0x06001700 RID: 5888 RVA: 0x0000A740 File Offset: 0x00008940
		[Token(Token = "0x6001700")]
		[Address(RVA = "0xE1606C", Offset = "0xE1606C", VA = "0xE1606C")]
		public static Quaternion Divide(Quaternion quaternion1, Quaternion quaternion2)
		{
			return default(Quaternion);
		}

		// Token: 0x06001701 RID: 5889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001701")]
		[Address(RVA = "0xE16118", Offset = "0xE16118", VA = "0xE16118")]
		public static void Divide(ref Quaternion quaternion1, ref Quaternion quaternion2, out Quaternion result)
		{
		}

		// Token: 0x06001702 RID: 5890 RVA: 0x0000A758 File Offset: 0x00008958
		[Token(Token = "0x6001702")]
		[Address(RVA = "0xE161D0", Offset = "0xE161D0", VA = "0xE161D0")]
		public static float Dot(Quaternion quaternion1, Quaternion quaternion2)
		{
			return 0f;
		}

		// Token: 0x06001703 RID: 5891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001703")]
		[Address(RVA = "0xE16208", Offset = "0xE16208", VA = "0xE16208")]
		public static void Dot(ref Quaternion quaternion1, ref Quaternion quaternion2, out float result)
		{
		}

		// Token: 0x06001704 RID: 5892 RVA: 0x0000A770 File Offset: 0x00008970
		[Token(Token = "0x6001704")]
		[Address(RVA = "0xE16240", Offset = "0xE16240", VA = "0xE16240", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06001705 RID: 5893 RVA: 0x0000A788 File Offset: 0x00008988
		[Token(Token = "0x6001705")]
		[Address(RVA = "0xE163C8", Offset = "0xE163C8", VA = "0xE163C8", Slot = "4")]
		public bool Equals(Quaternion other)
		{
			return default(bool);
		}

		// Token: 0x06001706 RID: 5894 RVA: 0x0000A7A0 File Offset: 0x000089A0
		[Token(Token = "0x6001706")]
		[Address(RVA = "0xE1642C", Offset = "0xE1642C", VA = "0xE1642C", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x06001707 RID: 5895 RVA: 0x0000A7B8 File Offset: 0x000089B8
		[Token(Token = "0x6001707")]
		[Address(RVA = "0xE16474", Offset = "0xE16474", VA = "0xE16474")]
		public static Quaternion Inverse(Quaternion quaternion)
		{
			return default(Quaternion);
		}

		// Token: 0x06001708 RID: 5896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001708")]
		[Address(RVA = "0xE164C0", Offset = "0xE164C0", VA = "0xE164C0")]
		public static void Inverse(ref Quaternion quaternion, out Quaternion result)
		{
		}

		// Token: 0x06001709 RID: 5897 RVA: 0x0000A7D0 File Offset: 0x000089D0
		[Token(Token = "0x6001709")]
		[Address(RVA = "0xE1650C", Offset = "0xE1650C", VA = "0xE1650C")]
		public float Length()
		{
			return 0f;
		}

		// Token: 0x0600170A RID: 5898 RVA: 0x0000A7E8 File Offset: 0x000089E8
		[Token(Token = "0x600170A")]
		[Address(RVA = "0xE16598", Offset = "0xE16598", VA = "0xE16598")]
		public float LengthSquared()
		{
			return 0f;
		}

		// Token: 0x0600170B RID: 5899 RVA: 0x0000A800 File Offset: 0x00008A00
		[Token(Token = "0x600170B")]
		[Address(RVA = "0xE165C0", Offset = "0xE165C0", VA = "0xE165C0")]
		public static Quaternion Lerp(Quaternion quaternion1, Quaternion quaternion2, float amount)
		{
			return default(Quaternion);
		}

		// Token: 0x0600170C RID: 5900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600170C")]
		[Address(RVA = "0xE16718", Offset = "0xE16718", VA = "0xE16718")]
		public static void Lerp(ref Quaternion quaternion1, ref Quaternion quaternion2, float amount, out Quaternion result)
		{
		}

		// Token: 0x0600170D RID: 5901 RVA: 0x0000A818 File Offset: 0x00008A18
		[Token(Token = "0x600170D")]
		[Address(RVA = "0xE16868", Offset = "0xE16868", VA = "0xE16868")]
		public static Quaternion Slerp(Quaternion quaternion1, Quaternion quaternion2, float amount)
		{
			return default(Quaternion);
		}

		// Token: 0x0600170E RID: 5902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600170E")]
		[Address(RVA = "0xE16A3C", Offset = "0xE16A3C", VA = "0xE16A3C")]
		public static void Slerp(ref Quaternion quaternion1, ref Quaternion quaternion2, float amount, out Quaternion result)
		{
		}

		// Token: 0x0600170F RID: 5903 RVA: 0x0000A830 File Offset: 0x00008A30
		[Token(Token = "0x600170F")]
		[Address(RVA = "0xE16BD4", Offset = "0xE16BD4", VA = "0xE16BD4")]
		public static Quaternion Subtract(Quaternion quaternion1, Quaternion quaternion2)
		{
			return default(Quaternion);
		}

		// Token: 0x06001710 RID: 5904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001710")]
		[Address(RVA = "0xE16C18", Offset = "0xE16C18", VA = "0xE16C18")]
		public static void Subtract(ref Quaternion quaternion1, ref Quaternion quaternion2, out Quaternion result)
		{
		}

		// Token: 0x06001711 RID: 5905 RVA: 0x0000A848 File Offset: 0x00008A48
		[Token(Token = "0x6001711")]
		[Address(RVA = "0xE16C2C", Offset = "0xE16C2C", VA = "0xE16C2C")]
		public static Quaternion Multiply(Quaternion quaternion1, Quaternion quaternion2)
		{
			return default(Quaternion);
		}

		// Token: 0x06001712 RID: 5906 RVA: 0x0000A860 File Offset: 0x00008A60
		[Token(Token = "0x6001712")]
		[Address(RVA = "0xE16CAC", Offset = "0xE16CAC", VA = "0xE16CAC")]
		public static Quaternion Multiply(Quaternion quaternion1, float scaleFactor)
		{
			return default(Quaternion);
		}

		// Token: 0x06001713 RID: 5907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001713")]
		[Address(RVA = "0xE16CE4", Offset = "0xE16CE4", VA = "0xE16CE4")]
		public static void Multiply(ref Quaternion quaternion1, float scaleFactor, out Quaternion result)
		{
		}

		// Token: 0x06001714 RID: 5908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001714")]
		[Address(RVA = "0xE16CF8", Offset = "0xE16CF8", VA = "0xE16CF8")]
		public static void Multiply(ref Quaternion quaternion1, ref Quaternion quaternion2, out Quaternion result)
		{
		}

		// Token: 0x06001715 RID: 5909 RVA: 0x0000A878 File Offset: 0x00008A78
		[Token(Token = "0x6001715")]
		[Address(RVA = "0xE16D78", Offset = "0xE16D78", VA = "0xE16D78")]
		public static Quaternion Negate(Quaternion quaternion)
		{
			return default(Quaternion);
		}

		// Token: 0x06001716 RID: 5910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001716")]
		[Address(RVA = "0xE16D9C", Offset = "0xE16D9C", VA = "0xE16D9C")]
		public static void Negate(ref Quaternion quaternion, out Quaternion result)
		{
		}

		// Token: 0x06001717 RID: 5911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001717")]
		[Address(RVA = "0xE16DAC", Offset = "0xE16DAC", VA = "0xE16DAC")]
		public void Normalize()
		{
		}

		// Token: 0x06001718 RID: 5912 RVA: 0x0000A890 File Offset: 0x00008A90
		[Token(Token = "0x6001718")]
		[Address(RVA = "0xE16E40", Offset = "0xE16E40", VA = "0xE16E40")]
		public static Quaternion Normalize(Quaternion quaternion)
		{
			return default(Quaternion);
		}

		// Token: 0x06001719 RID: 5913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001719")]
		[Address(RVA = "0xE16F00", Offset = "0xE16F00", VA = "0xE16F00")]
		public static void Normalize(ref Quaternion quaternion, out Quaternion result)
		{
		}

		// Token: 0x0600171A RID: 5914 RVA: 0x0000A8A8 File Offset: 0x00008AA8
		[Token(Token = "0x600171A")]
		[Address(RVA = "0xE16F98", Offset = "0xE16F98", VA = "0xE16F98")]
		public static Quaternion operator +(Quaternion quaternion1, Quaternion quaternion2)
		{
			return default(Quaternion);
		}

		// Token: 0x0600171B RID: 5915 RVA: 0x0000A8C0 File Offset: 0x00008AC0
		[Token(Token = "0x600171B")]
		[Address(RVA = "0xE16FDC", Offset = "0xE16FDC", VA = "0xE16FDC")]
		public static Quaternion operator /(Quaternion quaternion1, Quaternion quaternion2)
		{
			return default(Quaternion);
		}

		// Token: 0x0600171C RID: 5916 RVA: 0x0000A8D8 File Offset: 0x00008AD8
		[Token(Token = "0x600171C")]
		[Address(RVA = "0xE1635C", Offset = "0xE1635C", VA = "0xE1635C")]
		public static bool operator ==(Quaternion quaternion1, Quaternion quaternion2)
		{
			return default(bool);
		}

		// Token: 0x0600171D RID: 5917 RVA: 0x0000A8F0 File Offset: 0x00008AF0
		[Token(Token = "0x600171D")]
		[Address(RVA = "0xE17088", Offset = "0xE17088", VA = "0xE17088")]
		public static bool operator !=(Quaternion quaternion1, Quaternion quaternion2)
		{
			return default(bool);
		}

		// Token: 0x0600171E RID: 5918 RVA: 0x0000A908 File Offset: 0x00008B08
		[Token(Token = "0x600171E")]
		[Address(RVA = "0xE170F4", Offset = "0xE170F4", VA = "0xE170F4")]
		public static Quaternion operator *(Quaternion quaternion1, Quaternion quaternion2)
		{
			return default(Quaternion);
		}

		// Token: 0x0600171F RID: 5919 RVA: 0x0000A920 File Offset: 0x00008B20
		[Token(Token = "0x600171F")]
		[Address(RVA = "0xE17174", Offset = "0xE17174", VA = "0xE17174")]
		public static Quaternion operator *(Quaternion quaternion1, float scaleFactor)
		{
			return default(Quaternion);
		}

		// Token: 0x06001720 RID: 5920 RVA: 0x0000A938 File Offset: 0x00008B38
		[Token(Token = "0x6001720")]
		[Address(RVA = "0xE171AC", Offset = "0xE171AC", VA = "0xE171AC")]
		public static Quaternion operator -(Quaternion quaternion1, Quaternion quaternion2)
		{
			return default(Quaternion);
		}

		// Token: 0x06001721 RID: 5921 RVA: 0x0000A950 File Offset: 0x00008B50
		[Token(Token = "0x6001721")]
		[Address(RVA = "0xE171F0", Offset = "0xE171F0", VA = "0xE171F0")]
		public static Quaternion operator -(Quaternion quaternion)
		{
			return default(Quaternion);
		}

		// Token: 0x06001722 RID: 5922 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001722")]
		[Address(RVA = "0xE17214", Offset = "0xE17214", VA = "0xE17214", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x04002B07 RID: 11015
		[Token(Token = "0x4002B07")]
		[FieldOffset(Offset = "0x0")]
		public float X;

		// Token: 0x04002B08 RID: 11016
		[Token(Token = "0x4002B08")]
		[FieldOffset(Offset = "0x4")]
		public float Y;

		// Token: 0x04002B09 RID: 11017
		[Token(Token = "0x4002B09")]
		[FieldOffset(Offset = "0x8")]
		public float Z;

		// Token: 0x04002B0A RID: 11018
		[Token(Token = "0x4002B0A")]
		[FieldOffset(Offset = "0xC")]
		public float W;

		// Token: 0x04002B0B RID: 11019
		[Token(Token = "0x4002B0B")]
		[FieldOffset(Offset = "0x0")]
		private static Quaternion identity;
	}
}
