using System;
using Il2CppDummyDll;

// Token: 0x02000060 RID: 96
[Token(Token = "0x2000060")]
public static class SimpleProfiler
{
	// Token: 0x060001F5 RID: 501 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001F5")]
	[Address(RVA = "0x4AD408", Offset = "0x4AD408", VA = "0x4AD408")]
	public static void Initialise(Type enumType)
	{
	}

	// Token: 0x060001F6 RID: 502 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001F6")]
	[Address(RVA = "0x4AD69C", Offset = "0x4AD69C", VA = "0x4AD69C")]
	private static void AllocateSampleFrames(int numberFrames)
	{
	}

	// Token: 0x060001F7 RID: 503 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001F7")]
	[Address(RVA = "0x4AD76C", Offset = "0x4AD76C", VA = "0x4AD76C")]
	public static void BeginFrame()
	{
	}

	// Token: 0x060001F8 RID: 504 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001F8")]
	[Address(RVA = "0x4ADA14", Offset = "0x4ADA14", VA = "0x4ADA14")]
	public static void EndFrame()
	{
	}

	// Token: 0x060001F9 RID: 505 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001F9")]
	[Address(RVA = "0x4ADAAC", Offset = "0x4ADAAC", VA = "0x4ADAAC")]
	public static void Draw()
	{
	}

	// Token: 0x060001FA RID: 506 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001FA")]
	[Address(RVA = "0x4ADAB0", Offset = "0x4ADAB0", VA = "0x4ADAB0")]
	public static void BeginSample(int sampleId)
	{
	}

	// Token: 0x060001FB RID: 507 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001FB")]
	[Address(RVA = "0x4ADB94", Offset = "0x4ADB94", VA = "0x4ADB94")]
	public static void EndSample(int sampleId)
	{
	}

	// Token: 0x060001FC RID: 508 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001FC")]
	[Address(RVA = "0x4ADD1C", Offset = "0x4ADD1C", VA = "0x4ADD1C")]
	public static void Dump()
	{
	}

	// Token: 0x060001FD RID: 509 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001FD")]
	[Address(RVA = "0x4ADD20", Offset = "0x4ADD20", VA = "0x4ADD20")]
	private static void DumpFrameData(int frame)
	{
	}

	// Token: 0x060001FE RID: 510 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001FE")]
	[Address(RVA = "0x4AE194", Offset = "0x4AE194", VA = "0x4AE194")]
	public static void UnityProfileBegin(string begin)
	{
	}

	// Token: 0x060001FF RID: 511 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60001FF")]
	[Address(RVA = "0x4AE198", Offset = "0x4AE198", VA = "0x4AE198")]
	public static void UnityProfileEnd(string end)
	{
	}

	// Token: 0x06000200 RID: 512 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000200")]
	[Address(RVA = "0x4AE19C", Offset = "0x4AE19C", VA = "0x4AE19C")]
	public static void OnGUI()
	{
	}

	// Token: 0x04000451 RID: 1105
	[Token(Token = "0x4000451")]
	[FieldOffset(Offset = "0x0")]
	public static bool DisplayStats;

	// Token: 0x04000452 RID: 1106
	[Token(Token = "0x4000452")]
	[FieldOffset(Offset = "0x4")]
	private static int NextFrame;

	// Token: 0x04000453 RID: 1107
	[Token(Token = "0x4000453")]
	[FieldOffset(Offset = "0x8")]
	private static string[] FrameSampleTypes;

	// Token: 0x04000454 RID: 1108
	[Token(Token = "0x4000454")]
	[FieldOffset(Offset = "0xC")]
	private static SimpleProfilerFrameData[] FrameData;

	// Token: 0x04000455 RID: 1109
	[Token(Token = "0x4000455")]
	[FieldOffset(Offset = "0x10")]
	private static SimpleProfilerFrameData CurrentFrameData;

	// Token: 0x04000456 RID: 1110
	[Token(Token = "0x4000456")]
	[FieldOffset(Offset = "0x14")]
	private static SimpleProfilerFrameData LastFrameData;

	// Token: 0x04000457 RID: 1111
	[Token(Token = "0x4000457")]
	[FieldOffset(Offset = "0x18")]
	private static DateTime FrameTimeStart;

	// Token: 0x04000458 RID: 1112
	[Token(Token = "0x4000458")]
	[FieldOffset(Offset = "0x20")]
	private static DateTime FrameTimeEnd;

	// Token: 0x04000459 RID: 1113
	[Token(Token = "0x4000459")]
	[FieldOffset(Offset = "0x28")]
	private static SimpleProfilerSampleFrame AvailableFrames;

	// Token: 0x0400045A RID: 1114
	[Token(Token = "0x400045A")]
	[FieldOffset(Offset = "0x2C")]
	private static SimpleProfilerSampleFrame CurrentFrames;
}
